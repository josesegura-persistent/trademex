using Grpc.Core;
using Grpc.Net.Client;
using TradeMexClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7019");
var client = new Trader.TraderClient(channel);
var bookClient = new OrderBook.OrderBookClient(channel);

var ordersToSend = new Dictionary<string, Order>
{
    {"TESLA", new Order{ Price = new DecimalValue(83, 25000), Type = OrderType.Buy}},
    {"WALMART", new Order{ Price = new DecimalValue(27, 83000), Type = OrderType.Sell}},
    {"PERSISTENT", new Order{ Price = new DecimalValue(98, 71000), Type = OrderType.Buy}},
    {"MICROSOFT", new Order{ Price = new DecimalValue(292, 52000),Type = OrderType.Sell}}
};

Console.WriteLine("\nInitializing Trade Mex Client:\n");
Console.WriteLine("\nSend orders to stock exchange:\n");
var orderIdList = new List<string>();

foreach (var order in ordersToSend)
{
    var reply = await client.CreateOrderAsync(
     new CreateOrderRequest
     {
         Stock = order.Key,
         Price = order.Value.Price,
         OrderType = order.Value.Type
     });
    
    Console.WriteLine($"Order for {reply.Order.Stock} and price {reply.Order.Price.ToDecimal()} accepted with Id: {reply.Order.Id}");
    orderIdList.Add(reply.Order.Id);
}

var cancelRequest = await client.CancelOrderAsync(new CancelOrderRequest
    {
        OrderId = orderIdList[0]
    }
);

Console.WriteLine($"\nOrder with Id {cancelRequest.OrderId} Canceled At: {cancelRequest.CancellationTime}");

var updateRequest = await client.UpdateOrderAsync(new UpdateOrderRequest
    {
        OrderId = orderIdList[2],
        Price = new DecimalValue(42, 900000)
    }
);

Console.WriteLine($"\nOrder with Id {updateRequest.OrderId} has new price {updateRequest.Price.ToDecimal()} Updated At: {updateRequest.UpdateTime}");

Console.WriteLine("\nGet all orders in Order Book: \n");
using var orderBook = bookClient.GetOrderBookSnapshot(new GetOrderBookSnapshotRequest());
while (await orderBook.ResponseStream.MoveNext())
{
    Console.WriteLine($"Order: {orderBook.ResponseStream.Current}");
}

Console.WriteLine("\nPress any key to exit...");

Console.ReadKey();