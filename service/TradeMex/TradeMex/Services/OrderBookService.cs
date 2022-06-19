using Google.Protobuf.Collections;
using Grpc.Core;

namespace TradeMex.Services;

public class OrderBookService : OrderBook.OrderBookBase
{
    private readonly ILogger<OrderBookService> _logger;
    private readonly OrdersBook _ordersBook;

    public OrderBookService(ILogger<OrderBookService> logger, OrdersBook ordersBook)
    {
        _logger = logger;
        _ordersBook = ordersBook;
    }
    
    public override async Task GetOrderBookSnapshot(GetOrderBookSnapshotRequest request, IServerStreamWriter<Order> responseStream, ServerCallContext context)
    {
        _logger.LogInformation("Return all orders in OrderBook");
        var responses = _ordersBook.Orders.Values;
        foreach (var response in responses)
        {
            await responseStream.WriteAsync(response);
        }
    }
}