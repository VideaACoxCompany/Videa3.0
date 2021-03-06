// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RateCardConfirmation.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Videa.RateCardConfirmation.Service.Proto.Types {

  /// <summary>Holder for reflection information generated from RateCardConfirmation.proto</summary>
  public static partial class RateCardConfirmationReflection {

    #region Descriptor
    /// <summary>File descriptor for RateCardConfirmation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RateCardConfirmationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSYXRlQ2FyZENvbmZpcm1hdGlvbi5wcm90bxofZ29vZ2xlL3Byb3RvYnVm",
            "L3RpbWVzdGFtcC5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9uLnBy",
            "b3RvIhgKFkNvbmZpcm1SYXRlQ2FyZFJlcXVlc3QiGQoXQ29uZmlybVJhdGVD",
            "YXJkUmVzcG9uc2UyZQobUmF0ZUNhcmRDb25maXJtYXRpb25TZXJ2aWNlEkYK",
            "D0NvbmZpcm1SYXRlQ2FyZBIXLkNvbmZpcm1SYXRlQ2FyZFJlcXVlc3QaGC5D",
            "b25maXJtUmF0ZUNhcmRSZXNwb25zZSIAQjGqAi5WaWRlYS5SYXRlQ2FyZENv",
            "bmZpcm1hdGlvbi5TZXJ2aWNlLlByb3RvLlR5cGVzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Videa.RateCardConfirmation.Service.Proto.Types.ConfirmRateCardRequest), global::Videa.RateCardConfirmation.Service.Proto.Types.ConfirmRateCardRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Videa.RateCardConfirmation.Service.Proto.Types.ConfirmRateCardResponse), global::Videa.RateCardConfirmation.Service.Proto.Types.ConfirmRateCardResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ConfirmRateCardRequest : pb::IMessage<ConfirmRateCardRequest> {
    private static readonly pb::MessageParser<ConfirmRateCardRequest> _parser = new pb::MessageParser<ConfirmRateCardRequest>(() => new ConfirmRateCardRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConfirmRateCardRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Videa.RateCardConfirmation.Service.Proto.Types.RateCardConfirmationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfirmRateCardRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfirmRateCardRequest(ConfirmRateCardRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfirmRateCardRequest Clone() {
      return new ConfirmRateCardRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConfirmRateCardRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConfirmRateCardRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConfirmRateCardRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class ConfirmRateCardResponse : pb::IMessage<ConfirmRateCardResponse> {
    private static readonly pb::MessageParser<ConfirmRateCardResponse> _parser = new pb::MessageParser<ConfirmRateCardResponse>(() => new ConfirmRateCardResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConfirmRateCardResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Videa.RateCardConfirmation.Service.Proto.Types.RateCardConfirmationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfirmRateCardResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfirmRateCardResponse(ConfirmRateCardResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfirmRateCardResponse Clone() {
      return new ConfirmRateCardResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConfirmRateCardResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConfirmRateCardResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConfirmRateCardResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
