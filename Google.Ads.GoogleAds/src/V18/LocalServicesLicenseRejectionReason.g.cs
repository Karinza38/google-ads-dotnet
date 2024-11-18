// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/enums/local_services_license_rejection_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/enums/local_services_license_rejection_reason.proto</summary>
  public static partial class LocalServicesLicenseRejectionReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/enums/local_services_license_rejection_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocalServicesLicenseRejectionReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvbG9jYWxfc2Vydmlj",
            "ZXNfbGljZW5zZV9yZWplY3Rpb25fcmVhc29uLnByb3RvEh5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTguZW51bXMi8wEKJ0xvY2FsU2VydmljZXNMaWNlbnNl",
            "UmVqZWN0aW9uUmVhc29uRW51bSLHAQojTG9jYWxTZXJ2aWNlc0xpY2Vuc2VS",
            "ZWplY3Rpb25SZWFzb24SDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAES",
            "GgoWQlVTSU5FU1NfTkFNRV9NSVNNQVRDSBACEhAKDFVOQVVUSE9SSVpFRBAD",
            "EgsKB0VYUElSRUQQBBIQCgxQT09SX1FVQUxJVFkQBRIQCgxVTlZFUklGSUFC",
            "TEUQBhIYChRXUk9OR19ET0NVTUVOVF9PUl9JRBAHEgkKBU9USEVSEAhCggIK",
            "ImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTguZW51bXNCKExvY2FsU2Vy",
            "dmljZXNMaWNlbnNlUmVqZWN0aW9uUmVhc29uUHJvdG9QAVpDZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "OC9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "OC5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxOFxFbnVtc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxODo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Enums.LocalServicesLicenseRejectionReasonEnum), global::Google.Ads.GoogleAds.V18.Enums.LocalServicesLicenseRejectionReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Enums.LocalServicesLicenseRejectionReasonEnum.Types.LocalServicesLicenseRejectionReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the rejection reason of a local services
  /// license verification artifact.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LocalServicesLicenseRejectionReasonEnum : pb::IMessage<LocalServicesLicenseRejectionReasonEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocalServicesLicenseRejectionReasonEnum> _parser = new pb::MessageParser<LocalServicesLicenseRejectionReasonEnum>(() => new LocalServicesLicenseRejectionReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocalServicesLicenseRejectionReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Enums.LocalServicesLicenseRejectionReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLicenseRejectionReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLicenseRejectionReasonEnum(LocalServicesLicenseRejectionReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLicenseRejectionReasonEnum Clone() {
      return new LocalServicesLicenseRejectionReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocalServicesLicenseRejectionReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocalServicesLicenseRejectionReasonEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LocalServicesLicenseRejectionReasonEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LocalServicesLicenseRejectionReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enums describing possible rejection reasons of a local services license
      /// verification artifact.
      /// </summary>
      public enum LocalServicesLicenseRejectionReason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Business name doesn't match business name for the Local Services Ad.
        /// </summary>
        [pbr::OriginalName("BUSINESS_NAME_MISMATCH")] BusinessNameMismatch = 2,
        /// <summary>
        /// License is unauthorized or been revoked.
        /// </summary>
        [pbr::OriginalName("UNAUTHORIZED")] Unauthorized = 3,
        /// <summary>
        /// License is expired.
        /// </summary>
        [pbr::OriginalName("EXPIRED")] Expired = 4,
        /// <summary>
        /// License is poor quality - blurry images, illegible, etc...
        /// </summary>
        [pbr::OriginalName("POOR_QUALITY")] PoorQuality = 5,
        /// <summary>
        /// License cannot be verified due to a not legitimate image.
        /// </summary>
        [pbr::OriginalName("UNVERIFIABLE")] Unverifiable = 6,
        /// <summary>
        /// License is not the requested document type or contains an invalid ID.
        /// </summary>
        [pbr::OriginalName("WRONG_DOCUMENT_OR_ID")] WrongDocumentOrId = 7,
        /// <summary>
        /// License has another flaw not listed explicitly.
        /// </summary>
        [pbr::OriginalName("OTHER")] Other = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code