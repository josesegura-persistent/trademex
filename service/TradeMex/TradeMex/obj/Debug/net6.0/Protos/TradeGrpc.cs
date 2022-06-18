// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/trade.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TradeMex {
  public static partial class Trader
  {
    static readonly string __ServiceName = "trademex.Trader";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TradeMex.CreateOrderRequest> __Marshaller_trademex_CreateOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TradeMex.CreateOrderRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TradeMex.CreateOrderResponse> __Marshaller_trademex_CreateOrderResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TradeMex.CreateOrderResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TradeMex.CancelOrderRequest> __Marshaller_trademex_CancelOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TradeMex.CancelOrderRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TradeMex.CancelOrderResponse> __Marshaller_trademex_CancelOrderResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TradeMex.CancelOrderResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TradeMex.UpdateOrderRequest> __Marshaller_trademex_UpdateOrderRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TradeMex.UpdateOrderRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TradeMex.UpdateOrderResponse> __Marshaller_trademex_UpdateOrderResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TradeMex.UpdateOrderResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TradeMex.CreateOrderRequest, global::TradeMex.CreateOrderResponse> __Method_CreateOrder = new grpc::Method<global::TradeMex.CreateOrderRequest, global::TradeMex.CreateOrderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateOrder",
        __Marshaller_trademex_CreateOrderRequest,
        __Marshaller_trademex_CreateOrderResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TradeMex.CancelOrderRequest, global::TradeMex.CancelOrderResponse> __Method_CancelOrder = new grpc::Method<global::TradeMex.CancelOrderRequest, global::TradeMex.CancelOrderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CancelOrder",
        __Marshaller_trademex_CancelOrderRequest,
        __Marshaller_trademex_CancelOrderResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TradeMex.UpdateOrderRequest, global::TradeMex.UpdateOrderResponse> __Method_UpdateOrder = new grpc::Method<global::TradeMex.UpdateOrderRequest, global::TradeMex.UpdateOrderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateOrder",
        __Marshaller_trademex_UpdateOrderRequest,
        __Marshaller_trademex_UpdateOrderResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TradeMex.TradeReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Trader</summary>
    [grpc::BindServiceMethod(typeof(Trader), "BindService")]
    public abstract partial class TraderBase
    {
      /// <summary>
      /// Creates new order in the Book
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::TradeMex.CreateOrderResponse> CreateOrder(global::TradeMex.CreateOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Cancel order in the Book
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::TradeMex.CancelOrderResponse> CancelOrder(global::TradeMex.CancelOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Update order in the Book
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::TradeMex.UpdateOrderResponse> UpdateOrder(global::TradeMex.UpdateOrderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(TraderBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateOrder, serviceImpl.CreateOrder)
          .AddMethod(__Method_CancelOrder, serviceImpl.CancelOrder)
          .AddMethod(__Method_UpdateOrder, serviceImpl.UpdateOrder).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TraderBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TradeMex.CreateOrderRequest, global::TradeMex.CreateOrderResponse>(serviceImpl.CreateOrder));
      serviceBinder.AddMethod(__Method_CancelOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TradeMex.CancelOrderRequest, global::TradeMex.CancelOrderResponse>(serviceImpl.CancelOrder));
      serviceBinder.AddMethod(__Method_UpdateOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TradeMex.UpdateOrderRequest, global::TradeMex.UpdateOrderResponse>(serviceImpl.UpdateOrder));
    }

  }
}
#endregion
