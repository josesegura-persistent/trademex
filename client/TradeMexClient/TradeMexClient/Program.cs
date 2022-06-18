using Grpc.Net.Client;
using TradeMexClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7019");
var client = new Trader.TraderClient(channel);
var reply = await client.CreateOrderAsync(
    new CreateOrderRequest { InstrumentCode = "TSLA", });
Console.WriteLine("Order accepted with Id: " + reply.OrderId);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();