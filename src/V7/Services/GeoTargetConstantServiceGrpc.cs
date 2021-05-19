// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/services/geo_target_constant_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
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
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V7.Services {
  /// <summary>
  /// Service to fetch geo target constants.
  /// </summary>
  public static partial class GeoTargetConstantService
  {
    static readonly string __ServiceName = "google.ads.googleads.v7.services.GeoTargetConstantService";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest> __Marshaller_google_ads_googleads_v7_services_GetGeoTargetConstantRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant> __Marshaller_google_ads_googleads_v7_resources_GeoTargetConstant = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest> __Marshaller_google_ads_googleads_v7_services_SuggestGeoTargetConstantsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse> __Marshaller_google_ads_googleads_v7_services_SuggestGeoTargetConstantsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest, global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant> __Method_GetGeoTargetConstant = new grpc::Method<global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest, global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGeoTargetConstant",
        __Marshaller_google_ads_googleads_v7_services_GetGeoTargetConstantRequest,
        __Marshaller_google_ads_googleads_v7_resources_GeoTargetConstant);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest, global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse> __Method_SuggestGeoTargetConstants = new grpc::Method<global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest, global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SuggestGeoTargetConstants",
        __Marshaller_google_ads_googleads_v7_services_SuggestGeoTargetConstantsRequest,
        __Marshaller_google_ads_googleads_v7_services_SuggestGeoTargetConstantsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V7.Services.GeoTargetConstantServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GeoTargetConstantService</summary>
    [grpc::BindServiceMethod(typeof(GeoTargetConstantService), "BindService")]
    public abstract partial class GeoTargetConstantServiceBase
    {
      /// <summary>
      /// Returns the requested geo target constant in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant> GetGeoTargetConstant(global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns GeoTargetConstant suggestions by location name or by resource name.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [GeoTargetConstantSuggestionError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstants(global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GeoTargetConstantService</summary>
    public partial class GeoTargetConstantServiceClient : grpc::ClientBase<GeoTargetConstantServiceClient>
    {
      /// <summary>Creates a new client for GeoTargetConstantService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GeoTargetConstantServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GeoTargetConstantService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GeoTargetConstantServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GeoTargetConstantServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GeoTargetConstantServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested geo target constant in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant GetGeoTargetConstant(global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGeoTargetConstant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested geo target constant in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant GetGeoTargetConstant(global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetGeoTargetConstant, null, options, request);
      }
      /// <summary>
      /// Returns the requested geo target constant in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant> GetGeoTargetConstantAsync(global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGeoTargetConstantAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested geo target constant in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant> GetGeoTargetConstantAsync(global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetGeoTargetConstant, null, options, request);
      }
      /// <summary>
      /// Returns GeoTargetConstant suggestions by location name or by resource name.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [GeoTargetConstantSuggestionError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SuggestGeoTargetConstants(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns GeoTargetConstant suggestions by location name or by resource name.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [GeoTargetConstantSuggestionError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SuggestGeoTargetConstants, null, options, request);
      }
      /// <summary>
      /// Returns GeoTargetConstant suggestions by location name or by resource name.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [GeoTargetConstantSuggestionError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SuggestGeoTargetConstantsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns GeoTargetConstant suggestions by location name or by resource name.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [GeoTargetConstantSuggestionError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SuggestGeoTargetConstants, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GeoTargetConstantServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GeoTargetConstantServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GeoTargetConstantServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetGeoTargetConstant, serviceImpl.GetGeoTargetConstant)
          .AddMethod(__Method_SuggestGeoTargetConstants, serviceImpl.SuggestGeoTargetConstants).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GeoTargetConstantServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetGeoTargetConstant, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V7.Services.GetGeoTargetConstantRequest, global::Google.Ads.GoogleAds.V7.Resources.GeoTargetConstant>(serviceImpl.GetGeoTargetConstant));
      serviceBinder.AddMethod(__Method_SuggestGeoTargetConstants, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsRequest, global::Google.Ads.GoogleAds.V7.Services.SuggestGeoTargetConstantsResponse>(serviceImpl.SuggestGeoTargetConstants));
    }

  }
}
#endregion