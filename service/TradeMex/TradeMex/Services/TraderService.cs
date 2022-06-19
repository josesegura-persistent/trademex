using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace TradeMex.Services;

public class TraderService : Trader.TraderBase
{
    private readonly ILogger<TraderService> _logger;
    private readonly OrdersBook _ordersBook;

    public TraderService(ILogger<TraderService> logger, OrdersBook ordersBook)
    {
        _logger = logger;
        _ordersBook = ordersBook;
    }

    public override Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Order received for instrument: {InstrumentCode}", request.Stock);

        var orderId = Guid.NewGuid();
        var order = new Order
        {
            Id = orderId.ToString(),
            Price = request.Price,
            CreationTime = Timestamp.FromDateTime(DateTime.UtcNow),
            Status = OrderStatus.Active,
            Stock = request.Stock,
            Type = request.OrderType
        };

        var result = _ordersBook.Orders.TryAdd(orderId, order);

        if (!result)
        {
            return Task.FromResult(
                new CreateOrderResponse
                {
                    ResponseType = ResponseType.Rejected
                }
            );
        }

        _logger.LogInformation("Order successfully created {Order}", order);
        return Task.FromResult(new CreateOrderResponse
        {
            ResponseType = ResponseType.Accepted,
            Order = order
        });
    }

    public override Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Cancel Order with Id: {OrderId}", request.OrderId);

        var result = _ordersBook.Orders.TryGetValue(Guid.Parse(request.OrderId), out var order);

        if (result && order is not null)
        {
            order.Status = OrderStatus.Canceled;
            order.CancellationTime = Timestamp.FromDateTime(DateTime.UtcNow);
            order.Type = order.Type;
            return Task.FromResult(new CancelOrderResponse
            {
                OrderId = order.Id,
                ResponseType = result ? ResponseType.Accepted : ResponseType.Rejected,
                CancellationTime = order.CancellationTime
            });
        }

        return Task.FromResult(new CancelOrderResponse
        {
            ResponseType = ResponseType.Rejected,
        });
    }

    public override Task<UpdateOrderResponse> UpdateOrder(UpdateOrderRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Update Order with Id: {OrderId}", request.OrderId);

        var result = _ordersBook.Orders.TryGetValue(Guid.Parse(request.OrderId), out var order);

        if (result && order is not null)
        {
            order.Price = request.Price;
            order.UpdateTime = Timestamp.FromDateTime(DateTime.UtcNow);
            order.Type = order.Type;
            return Task.FromResult(new UpdateOrderResponse
            {
                OrderId = order.Id,
                ResponseType = ResponseType.Accepted,
                UpdateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                Price = order.Price
            });
        }

        return Task.FromResult(new UpdateOrderResponse
        {
            ResponseType = ResponseType.Rejected
        });
    }
}