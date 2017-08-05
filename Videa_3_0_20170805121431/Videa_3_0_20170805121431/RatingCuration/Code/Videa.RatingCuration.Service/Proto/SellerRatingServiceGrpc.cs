// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: SellerRatingService.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Videa.SellerRatingNS.Service.Proto.Types {
  public static partial class SellerRatingService
  {
    static readonly string __ServiceName = "SellerRatingService";

    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest> __Marshaller_RatingDemoDeleteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse> __Marshaller_RatingDemoDeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest> __Marshaller_RatingPeriodDeleteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse> __Marshaller_RatingPeriodDeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest> __Marshaller_SellableInventoryRatingDeleteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse> __Marshaller_SellableInventoryRatingDeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest> __Marshaller_RatingDemoAddUpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse> __Marshaller_RatingDemoAddUpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest> __Marshaller_RatingPeriodAddUpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse> __Marshaller_RatingPeriodAddUpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest> __Marshaller_SellableInventoryRatingAddUpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse> __Marshaller_SellableInventoryRatingAddUpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest> __Marshaller_GetSellerRatingsByInventoryKeysRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse> __Marshaller_GetSellerRatingsByInventoryKeysResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest> __Marshaller_GetSellerRatingsByRatingKeysRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse> __Marshaller_GetSellerRatingsByRatingKeysResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest> __Marshaller_BulkStoreRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse> __Marshaller_BulkStoreResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest, global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse> __Method_RatingDemoDelete = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest, global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RatingDemoDelete",
        __Marshaller_RatingDemoDeleteRequest,
        __Marshaller_RatingDemoDeleteResponse);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest, global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse> __Method_RatingPeriodDelete = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest, global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RatingPeriodDelete",
        __Marshaller_RatingPeriodDeleteRequest,
        __Marshaller_RatingPeriodDeleteResponse);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest, global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse> __Method_SellableInventoryRatingDelete = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest, global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SellableInventoryRatingDelete",
        __Marshaller_SellableInventoryRatingDeleteRequest,
        __Marshaller_SellableInventoryRatingDeleteResponse);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest, global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse> __Method_RatingDemoAddUpdate = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest, global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RatingDemoAddUpdate",
        __Marshaller_RatingDemoAddUpdateRequest,
        __Marshaller_RatingDemoAddUpdateResponse);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest, global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse> __Method_RatingPeriodAddUpdate = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest, global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RatingPeriodAddUpdate",
        __Marshaller_RatingPeriodAddUpdateRequest,
        __Marshaller_RatingPeriodAddUpdateResponse);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest, global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse> __Method_SellableInventoryRatingAddUpdate = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest, global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SellableInventoryRatingAddUpdate",
        __Marshaller_SellableInventoryRatingAddUpdateRequest,
        __Marshaller_SellableInventoryRatingAddUpdateResponse);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest, global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse> __Method_GetSellerRatingsByInventoryKeys = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest, global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSellerRatingsByInventoryKeys",
        __Marshaller_GetSellerRatingsByInventoryKeysRequest,
        __Marshaller_GetSellerRatingsByInventoryKeysResponse);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest, global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse> __Method_GetSellerRatingsByRatingKeys = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest, global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSellerRatingsByRatingKeys",
        __Marshaller_GetSellerRatingsByRatingKeysRequest,
        __Marshaller_GetSellerRatingsByRatingKeysResponse);

    static readonly grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest, global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse> __Method_BulkStore = new grpc::Method<global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest, global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BulkStore",
        __Marshaller_BulkStoreRequest,
        __Marshaller_BulkStoreResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Videa.SellerRatingNS.Service.Proto.Types.SellerRatingServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SellerRatingService</summary>
    public abstract partial class SellerRatingServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse> RatingDemoDelete(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse> RatingPeriodDelete(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse> SellableInventoryRatingDelete(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse> RatingDemoAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse> RatingPeriodAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse> SellableInventoryRatingAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse> GetSellerRatingsByInventoryKeys(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse> GetSellerRatingsByRatingKeys(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse> BulkStore(global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SellerRatingService</summary>
    public partial class SellerRatingServiceClient : grpc::ClientBase<SellerRatingServiceClient>
    {
      /// <summary>Creates a new client for SellerRatingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SellerRatingServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SellerRatingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SellerRatingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SellerRatingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SellerRatingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse RatingDemoDelete(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatingDemoDelete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse RatingDemoDelete(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RatingDemoDelete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse> RatingDemoDeleteAsync(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatingDemoDeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteResponse> RatingDemoDeleteAsync(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RatingDemoDelete, null, options, request);
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse RatingPeriodDelete(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatingPeriodDelete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse RatingPeriodDelete(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RatingPeriodDelete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse> RatingPeriodDeleteAsync(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatingPeriodDeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteResponse> RatingPeriodDeleteAsync(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RatingPeriodDelete, null, options, request);
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse SellableInventoryRatingDelete(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SellableInventoryRatingDelete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse SellableInventoryRatingDelete(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SellableInventoryRatingDelete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse> SellableInventoryRatingDeleteAsync(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SellableInventoryRatingDeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteResponse> SellableInventoryRatingDeleteAsync(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingDeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SellableInventoryRatingDelete, null, options, request);
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse RatingDemoAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatingDemoAddUpdate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse RatingDemoAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RatingDemoAddUpdate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse> RatingDemoAddUpdateAsync(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatingDemoAddUpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateResponse> RatingDemoAddUpdateAsync(global::Videa.SellerRatingNS.Service.Proto.Types.RatingDemoAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RatingDemoAddUpdate, null, options, request);
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse RatingPeriodAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatingPeriodAddUpdate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse RatingPeriodAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RatingPeriodAddUpdate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse> RatingPeriodAddUpdateAsync(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RatingPeriodAddUpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateResponse> RatingPeriodAddUpdateAsync(global::Videa.SellerRatingNS.Service.Proto.Types.RatingPeriodAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RatingPeriodAddUpdate, null, options, request);
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse SellableInventoryRatingAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SellableInventoryRatingAddUpdate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse SellableInventoryRatingAddUpdate(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SellableInventoryRatingAddUpdate, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse> SellableInventoryRatingAddUpdateAsync(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SellableInventoryRatingAddUpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateResponse> SellableInventoryRatingAddUpdateAsync(global::Videa.SellerRatingNS.Service.Proto.Types.SellableInventoryRatingAddUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SellableInventoryRatingAddUpdate, null, options, request);
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse GetSellerRatingsByInventoryKeys(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSellerRatingsByInventoryKeys(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse GetSellerRatingsByInventoryKeys(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSellerRatingsByInventoryKeys, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse> GetSellerRatingsByInventoryKeysAsync(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSellerRatingsByInventoryKeysAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysResponse> GetSellerRatingsByInventoryKeysAsync(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByInventoryKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSellerRatingsByInventoryKeys, null, options, request);
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse GetSellerRatingsByRatingKeys(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSellerRatingsByRatingKeys(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse GetSellerRatingsByRatingKeys(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSellerRatingsByRatingKeys, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse> GetSellerRatingsByRatingKeysAsync(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetSellerRatingsByRatingKeysAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysResponse> GetSellerRatingsByRatingKeysAsync(global::Videa.SellerRatingNS.Service.Proto.Types.GetSellerRatingsByRatingKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSellerRatingsByRatingKeys, null, options, request);
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse BulkStore(global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BulkStore(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse BulkStore(global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BulkStore, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse> BulkStoreAsync(global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BulkStoreAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreResponse> BulkStoreAsync(global::Videa.SellerRatingNS.Service.Proto.Types.BulkStoreRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BulkStore, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SellerRatingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SellerRatingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SellerRatingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RatingDemoDelete, serviceImpl.RatingDemoDelete)
          .AddMethod(__Method_RatingPeriodDelete, serviceImpl.RatingPeriodDelete)
          .AddMethod(__Method_SellableInventoryRatingDelete, serviceImpl.SellableInventoryRatingDelete)
          .AddMethod(__Method_RatingDemoAddUpdate, serviceImpl.RatingDemoAddUpdate)
          .AddMethod(__Method_RatingPeriodAddUpdate, serviceImpl.RatingPeriodAddUpdate)
          .AddMethod(__Method_SellableInventoryRatingAddUpdate, serviceImpl.SellableInventoryRatingAddUpdate)
          .AddMethod(__Method_GetSellerRatingsByInventoryKeys, serviceImpl.GetSellerRatingsByInventoryKeys)
          .AddMethod(__Method_GetSellerRatingsByRatingKeys, serviceImpl.GetSellerRatingsByRatingKeys)
          .AddMethod(__Method_BulkStore, serviceImpl.BulkStore).Build();
    }

  }
}
#endregion
