using System.Collections.Concurrent;

namespace TradeMex;

public class OrdersBook
{
    public ConcurrentDictionary<Guid, Order> Orders { get; } = new();
}