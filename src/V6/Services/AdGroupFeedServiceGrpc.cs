// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/services/ad_group_feed_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.V6.Services {
  /// <summary>
  /// Service to manage ad group feeds.
  /// </summary>
  public static partial class AdGroupFeedService
  {
    static readonly string __ServiceName = "google.ads.googleads.v6.services.AdGroupFeedService";

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest> __Marshaller_google_ads_googleads_v6_services_GetAdGroupFeedRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed> __Marshaller_google_ads_googleads_v6_resources_AdGroupFeed = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest> __Marshaller_google_ads_googleads_v6_services_MutateAdGroupFeedsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse> __Marshaller_google_ads_googleads_v6_services_MutateAdGroupFeedsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest, global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed> __Method_GetAdGroupFeed = new grpc::Method<global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest, global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdGroupFeed",
        __Marshaller_google_ads_googleads_v6_services_GetAdGroupFeedRequest,
        __Marshaller_google_ads_googleads_v6_resources_AdGroupFeed);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest, global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse> __Method_MutateAdGroupFeeds = new grpc::Method<global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest, global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdGroupFeeds",
        __Marshaller_google_ads_googleads_v6_services_MutateAdGroupFeedsRequest,
        __Marshaller_google_ads_googleads_v6_services_MutateAdGroupFeedsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V6.Services.AdGroupFeedServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdGroupFeedService</summary>
    [grpc::BindServiceMethod(typeof(AdGroupFeedService), "BindService")]
    public abstract partial class AdGroupFeedServiceBase
    {
      /// <summary>
      /// Returns the requested ad group feed in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed> GetAdGroupFeed(global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes ad group feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse> MutateAdGroupFeeds(global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdGroupFeedService</summary>
    public partial class AdGroupFeedServiceClient : grpc::ClientBase<AdGroupFeedServiceClient>
    {
      /// <summary>Creates a new client for AdGroupFeedService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdGroupFeedServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdGroupFeedService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdGroupFeedServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdGroupFeedServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdGroupFeedServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad group feed in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed GetAdGroupFeed(global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupFeed(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group feed in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed GetAdGroupFeed(global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdGroupFeed, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad group feed in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed> GetAdGroupFeedAsync(global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupFeedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group feed in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed> GetAdGroupFeedAsync(global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdGroupFeed, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad group feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse MutateAdGroupFeeds(global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupFeeds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad group feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse MutateAdGroupFeeds(global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdGroupFeeds, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad group feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupFeedsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad group feeds. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdGroupFeeds, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdGroupFeedServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdGroupFeedServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdGroupFeedServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdGroupFeed, serviceImpl.GetAdGroupFeed)
          .AddMethod(__Method_MutateAdGroupFeeds, serviceImpl.MutateAdGroupFeeds).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdGroupFeedServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdGroupFeed, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V6.Services.GetAdGroupFeedRequest, global::Google.Ads.GoogleAds.V6.Resources.AdGroupFeed>(serviceImpl.GetAdGroupFeed));
      serviceBinder.AddMethod(__Method_MutateAdGroupFeeds, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsRequest, global::Google.Ads.GoogleAds.V6.Services.MutateAdGroupFeedsResponse>(serviceImpl.MutateAdGroupFeeds));
    }

  }
}
#endregion