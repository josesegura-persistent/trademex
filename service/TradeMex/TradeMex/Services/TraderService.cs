using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace TradeMex.Services;

public class TraderService : Trader.TraderBase
{
    private readonly ILogger<TraderService> _logger;
    public TraderService(ILogger<TraderService> logger)
    {
        _logger = logger;
    }

    public override Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Order received for instrument: {InstrumentCode}", request.InstrumentCode);
        return Task.FromResult(new CreateOrderResponse
        {
            ResponseType = ResponseType.Accepted,
            Order = new Order
            {
                Id = Guid.NewGuid().ToString(),
                Price = request.Price,
                CreationTime = Timestamp.FromDateTime(DateTime.UtcNow),
                Status = OrderStatus.Active,
                Instrument = request.InstrumentCode,
                Type = request.OrderType
            }
        });
    }
    
    public override Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Cancel Order with Id: {OrderId}", request.OrderId);
        return Task.FromResult(new CancelOrderResponse
        {
            OrderId = Guid.NewGuid().ToString(),
            ResponseType = ResponseType.Accepted
        });
    }
    
    public override Task<UpdateOrderResponse> UpdateOrder(UpdateOrderRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Update Order with Id: {OrderId}", request.OrderId);
        return Task.FromResult(new UpdateOrderResponse
        {
            OrderId = Guid.NewGuid().ToString(),
            ResponseType = ResponseType.Accepted
        });
    }
    
}

public class OrderBookService : OrderBook.OrderBookBase
{
    private readonly ILogger<OrderBookService> _logger;

    public OrderBookService(ILogger<OrderBookService> logger)
    {
        _logger = logger;
    }
}