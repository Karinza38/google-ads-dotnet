// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/services/product_link_invitation_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V18.Services {
  /// <summary>
  /// This service allows management of product link invitations from Google Ads
  /// accounts to other accounts.
  /// </summary>
  public static partial class ProductLinkInvitationService
  {
    static readonly string __ServiceName = "google.ads.googleads.v18.services.ProductLinkInvitationService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest> __Marshaller_google_ads_googleads_v18_services_CreateProductLinkInvitationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse> __Marshaller_google_ads_googleads_v18_services_CreateProductLinkInvitationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest> __Marshaller_google_ads_googleads_v18_services_UpdateProductLinkInvitationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse> __Marshaller_google_ads_googleads_v18_services_UpdateProductLinkInvitationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest> __Marshaller_google_ads_googleads_v18_services_RemoveProductLinkInvitationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse> __Marshaller_google_ads_googleads_v18_services_RemoveProductLinkInvitationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse> __Method_CreateProductLinkInvitation = new grpc::Method<global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateProductLinkInvitation",
        __Marshaller_google_ads_googleads_v18_services_CreateProductLinkInvitationRequest,
        __Marshaller_google_ads_googleads_v18_services_CreateProductLinkInvitationResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse> __Method_UpdateProductLinkInvitation = new grpc::Method<global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProductLinkInvitation",
        __Marshaller_google_ads_googleads_v18_services_UpdateProductLinkInvitationRequest,
        __Marshaller_google_ads_googleads_v18_services_UpdateProductLinkInvitationResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse> __Method_RemoveProductLinkInvitation = new grpc::Method<global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveProductLinkInvitation",
        __Marshaller_google_ads_googleads_v18_services_RemoveProductLinkInvitationRequest,
        __Marshaller_google_ads_googleads_v18_services_RemoveProductLinkInvitationResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V18.Services.ProductLinkInvitationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductLinkInvitationService</summary>
    [grpc::BindServiceMethod(typeof(ProductLinkInvitationService), "BindService")]
    public abstract partial class ProductLinkInvitationServiceBase
    {
      /// <summary>
      /// Creates a product link invitation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse> CreateProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Update a product link invitation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse> UpdateProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Remove a product link invitation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse> RemoveProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProductLinkInvitationService</summary>
    public partial class ProductLinkInvitationServiceClient : grpc::ClientBase<ProductLinkInvitationServiceClient>
    {
      /// <summary>Creates a new client for ProductLinkInvitationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductLinkInvitationServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductLinkInvitationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductLinkInvitationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductLinkInvitationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductLinkInvitationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse CreateProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProductLinkInvitation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse CreateProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateProductLinkInvitation, null, options, request);
      }
      /// <summary>
      /// Creates a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse> CreateProductLinkInvitationAsync(global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProductLinkInvitationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse> CreateProductLinkInvitationAsync(global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateProductLinkInvitation, null, options, request);
      }
      /// <summary>
      /// Update a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse UpdateProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProductLinkInvitation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse UpdateProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateProductLinkInvitation, null, options, request);
      }
      /// <summary>
      /// Update a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProductLinkInvitationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateProductLinkInvitation, null, options, request);
      }
      /// <summary>
      /// Remove a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse RemoveProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveProductLinkInvitation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Remove a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse RemoveProductLinkInvitation(global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveProductLinkInvitation, null, options, request);
      }
      /// <summary>
      /// Remove a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveProductLinkInvitationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Remove a product link invitation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveProductLinkInvitation, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProductLinkInvitationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductLinkInvitationServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductLinkInvitationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateProductLinkInvitation, serviceImpl.CreateProductLinkInvitation)
          .AddMethod(__Method_UpdateProductLinkInvitation, serviceImpl.UpdateProductLinkInvitation)
          .AddMethod(__Method_RemoveProductLinkInvitation, serviceImpl.RemoveProductLinkInvitation).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductLinkInvitationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateProductLinkInvitation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.CreateProductLinkInvitationResponse>(serviceImpl.CreateProductLinkInvitation));
      serviceBinder.AddMethod(__Method_UpdateProductLinkInvitation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.UpdateProductLinkInvitationResponse>(serviceImpl.UpdateProductLinkInvitation));
      serviceBinder.AddMethod(__Method_RemoveProductLinkInvitation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationRequest, global::Google.Ads.GoogleAds.V18.Services.RemoveProductLinkInvitationResponse>(serviceImpl.RemoveProductLinkInvitation));
    }

  }
}
#endregion
