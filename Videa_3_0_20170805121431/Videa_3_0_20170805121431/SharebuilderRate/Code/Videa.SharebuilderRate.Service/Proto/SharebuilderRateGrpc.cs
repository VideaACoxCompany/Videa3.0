// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: SharebuilderRate.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Videa.SharebuilderRateNS.Service.Proto.Types {
  public static partial class SharebuilderRateService
  {
    static readonly string __ServiceName = "SharebuilderRateService";

    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest> __Marshaller_RateTierDeleteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse> __Marshaller_RateTierDeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest> __Marshaller_RatePeriodDeleteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse> __Marshaller_RatePeriodDeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest> __Marshaller_SellableInventoryRateDeleteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse> __Marshaller_SellableInventoryRateDeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest> __Marshaller_RateTierAddUpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse> __Marshaller_RateTierAddUpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest> __Marshaller_RatePeriodAddUpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse> __Marshaller_RatePeriodAddUpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest> __Marshaller_SellableInventoryRateAddUpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse> __Marshaller_SellableInventoryRateAddUpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest> __Marshaller_GetSharebuilderRatesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse> __Marshaller_GetSharebuilderRatesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest> __Marshaller_BulkStoreRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse> __Marshaller_BulkStoreResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse> __Method_RateTierDelete = new grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RateTierDelete",
        __Marshaller_RateTierDeleteRequest,
        __Marshaller_RateTierDeleteResponse);

    static readonly grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse> __Method_RatePeriodDelete = new grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RatePeriodDelete",
        __Marshaller_RatePeriodDeleteRequest,
        __Marshaller_RatePeriodDeleteResponse);

    static readonly grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse> __Method_SellableInventoryRateDelete = new grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SellableInventoryRateDelete",
        __Marshaller_SellableInventoryRateDeleteRequest,
        __Marshaller_SellableInventoryRateDeleteResponse);

    static readonly grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse> __Method_RateTierAddUpdate = new grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RateTierAddUpdate",
        __Marshaller_RateTierAddUpdateRequest,
        __Marshaller_RateTierAddUpdateResponse);

    static readonly grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse> __Method_RatePeriodAddUpdate = new grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RatePeriodAddUpdate",
        __Marshaller_RatePeriodAddUpdateRequest,
        __Marshaller_RatePeriodAddUpdateResponse);

    static readonly grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse> __Method_SellableInventoryRateAddUpdate = new grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SellableInventoryRateAddUpdate",
        __Marshaller_SellableInventoryRateAddUpdateRequest,
        __Marshaller_SellableInventoryRateAddUpdateResponse);

    static readonly grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse> __Method_GetSharebuilderRates = new grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSharebuilderRates",
        __Marshaller_GetSharebuilderRatesRequest,
        __Marshaller_GetSharebuilderRatesResponse);

    static readonly grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse> __Method_BulkStore = new grpc::Method<global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest, global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BulkStore",
        __Marshaller_BulkStoreRequest,
        __Marshaller_BulkStoreResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Videa.SharebuilderRateNS.Service.Proto.Types.SharebuilderRateReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SharebuilderRateService</summary>
    public abstract partial class SharebuilderRateServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse> RateTierDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse> RatePeriodDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse> SellableInventoryRateDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse> RateTierAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse> RatePeriodAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse> SellableInventoryRateAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse> GetSharebuilderRates(global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse> BulkStore(global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SharebuilderRateService</summary>
    public partial class SharebuilderRateServiceClient : grpc::ClientBase<SharebuilderRateServiceClient>
    {
      /// <summary>Creates a new client for SharebuilderRateService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SharebuilderRateServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SharebuilderRateService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SharebuilderRateServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SharebuilderRateServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SharebuilderRateServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse RateTierDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RateTierDelete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse RateTierDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RateTierDelete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse> RateTierDeleteAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RateTierDeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteResponse> RateTierDeleteAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RateTierDelete, null, options, request);
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse RatePeriodDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatePeriodDelete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse RatePeriodDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RatePeriodDelete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse> RatePeriodDeleteAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatePeriodDeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteResponse> RatePeriodDeleteAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RatePeriodDelete, null, options, request);
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse SellableInventoryRateDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SellableInventoryRateDelete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse SellableInventoryRateDelete(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SellableInventoryRateDelete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse> SellableInventoryRateDeleteAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SellableInventoryRateDeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteResponse> SellableInventoryRateDeleteAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SellableInventoryRateDelete, null, options, request);
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse RateTierAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RateTierAddUpdate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse RateTierAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RateTierAddUpdate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse> RateTierAddUpdateAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RateTierAddUpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateResponse> RateTierAddUpdateAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.RateTierAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RateTierAddUpdate, null, options, request);
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse RatePeriodAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatePeriodAddUpdate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse RatePeriodAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RatePeriodAddUpdate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse> RatePeriodAddUpdateAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatePeriodAddUpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateResponse> RatePeriodAddUpdateAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.RatePeriodAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RatePeriodAddUpdate, null, options, request);
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse SellableInventoryRateAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SellableInventoryRateAddUpdate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse SellableInventoryRateAddUpdate(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SellableInventoryRateAddUpdate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse> SellableInventoryRateAddUpdateAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SellableInventoryRateAddUpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateResponse> SellableInventoryRateAddUpdateAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.SellableInventoryRateAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SellableInventoryRateAddUpdate, null, options, request);
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse GetSharebuilderRates(global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSharebuilderRates(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse GetSharebuilderRates(global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSharebuilderRates, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse> GetSharebuilderRatesAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSharebuilderRatesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesResponse> GetSharebuilderRatesAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.GetSharebuilderRatesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSharebuilderRates, null, options, request);
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse BulkStore(global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BulkStore(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse BulkStore(global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BulkStore, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse> BulkStoreAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BulkStoreAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreResponse> BulkStoreAsync(global::Videa.SharebuilderRateNS.Service.Proto.Types.BulkStoreRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BulkStore, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SharebuilderRateServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SharebuilderRateServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SharebuilderRateServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RateTierDelete, serviceImpl.RateTierDelete)
          .AddMethod(__Method_RatePeriodDelete, serviceImpl.RatePeriodDelete)
          .AddMethod(__Method_SellableInventoryRateDelete, serviceImpl.SellableInventoryRateDelete)
          .AddMethod(__Method_RateTierAddUpdate, serviceImpl.RateTierAddUpdate)
          .AddMethod(__Method_RatePeriodAddUpdate, serviceImpl.RatePeriodAddUpdate)
          .AddMethod(__Method_SellableInventoryRateAddUpdate, serviceImpl.SellableInventoryRateAddUpdate)
          .AddMethod(__Method_GetSharebuilderRates, serviceImpl.GetSharebuilderRates)
          .AddMethod(__Method_BulkStore, serviceImpl.BulkStore).Build();
    }

  }
}
#endregion
