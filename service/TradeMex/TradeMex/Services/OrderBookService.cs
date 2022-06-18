namespace TradeMex.Services;

public class OrderBookService : OrderBook.OrderBookBase
{
    private readonly ILogger<OrderBookService> _logger;

    public OrderBookService(ILogger<OrderBookService> logger)
    {
        _logger = logger;
    }
}