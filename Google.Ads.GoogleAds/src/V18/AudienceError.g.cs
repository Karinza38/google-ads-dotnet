// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/errors/audience_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/errors/audience_error.proto</summary>
  public static partial class AudienceErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/errors/audience_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AudienceErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZXJyb3JzL2F1ZGllbmNlX2Vy",
            "cm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTguZXJyb3JzIvcC",
            "ChFBdWRpZW5jZUVycm9yRW51bSLhAgoNQXVkaWVuY2VFcnJvchIPCgtVTlNQ",
            "RUNJRklFRBAAEgsKB1VOS05PV04QARIXChNOQU1FX0FMUkVBRFlfSU5fVVNF",
            "EAISFQoRRElNRU5TSU9OX0lOVkFMSUQQAxIeChpBVURJRU5DRV9TRUdNRU5U",
            "X05PVF9GT1VORBAEEicKI0FVRElFTkNFX1NFR01FTlRfVFlQRV9OT1RfU1VQ",
            "UE9SVEVEEAUSHgoaRFVQTElDQVRFX0FVRElFTkNFX1NFR01FTlQQBhIVChFU",
            "T09fTUFOWV9TRUdNRU5UUxAHEiQKIFRPT19NQU5ZX0RJTUVOU0lPTlNfT0Zf",
            "U0FNRV9UWVBFEAgSCgoGSU5fVVNFEAkSGgoWTUlTU0lOR19BU1NFVF9HUk9V",
            "UF9JRBAKEjQKMENBTk5PVF9DSEFOR0VfRlJPTV9DVVNUT01FUl9UT19BU1NF",
            "VF9HUk9VUF9TQ09QRRALQvIBCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djE4LmVycm9yc0ISQXVkaWVuY2VFcnJvclByb3RvUAFaRWdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTgv",
            "ZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "OC5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMThcRXJyb3Jz6gIj",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE4OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Errors.AudienceErrorEnum), global::Google.Ads.GoogleAds.V18.Errors.AudienceErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Errors.AudienceErrorEnum.Types.AudienceError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible audience errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AudienceErrorEnum : pb::IMessage<AudienceErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AudienceErrorEnum> _parser = new pb::MessageParser<AudienceErrorEnum>(() => new AudienceErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AudienceErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Errors.AudienceErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudienceErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudienceErrorEnum(AudienceErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudienceErrorEnum Clone() {
      return new AudienceErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AudienceErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AudienceErrorEnum other) {
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
    public void MergeFrom(AudienceErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AudienceErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible audience errors.
      /// </summary>
      public enum AudienceError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An audience with this name already exists.
        /// </summary>
        [pbr::OriginalName("NAME_ALREADY_IN_USE")] NameAlreadyInUse = 2,
        /// <summary>
        /// A dimension within the audience definition is not valid.
        /// </summary>
        [pbr::OriginalName("DIMENSION_INVALID")] DimensionInvalid = 3,
        /// <summary>
        /// One of the audience segment added is not found.
        /// </summary>
        [pbr::OriginalName("AUDIENCE_SEGMENT_NOT_FOUND")] AudienceSegmentNotFound = 4,
        /// <summary>
        /// One of the audience segment type is not supported.
        /// </summary>
        [pbr::OriginalName("AUDIENCE_SEGMENT_TYPE_NOT_SUPPORTED")] AudienceSegmentTypeNotSupported = 5,
        /// <summary>
        /// The same segment already exists in this audience.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_AUDIENCE_SEGMENT")] DuplicateAudienceSegment = 6,
        /// <summary>
        /// Audience can't have more than allowed number segments.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_SEGMENTS")] TooManySegments = 7,
        /// <summary>
        /// Audience can't have multiple dimensions of same type.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_DIMENSIONS_OF_SAME_TYPE")] TooManyDimensionsOfSameType = 8,
        /// <summary>
        /// The audience cannot be removed, because it is currently used in an
        /// ad group criterion or asset group signal in an (enabled or paused)
        /// ad group or campaign.
        /// </summary>
        [pbr::OriginalName("IN_USE")] InUse = 9,
        /// <summary>
        /// Asset Group scoped audience requires an asset group ID.
        /// </summary>
        [pbr::OriginalName("MISSING_ASSET_GROUP_ID")] MissingAssetGroupId = 10,
        /// <summary>
        /// Audience scope may not be changed from Customer to AssetGroup.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_FROM_CUSTOMER_TO_ASSET_GROUP_SCOPE")] CannotChangeFromCustomerToAssetGroupScope = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
