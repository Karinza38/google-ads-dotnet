// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/enums/hotel_asset_suggestion_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/enums/hotel_asset_suggestion_status.proto</summary>
  public static partial class HotelAssetSuggestionStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/enums/hotel_asset_suggestion_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotelAssetSuggestionStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvaG90ZWxfYXNzZXRf",
            "c3VnZ2VzdGlvbl9zdGF0dXMucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxOC5lbnVtcyKUAQoeSG90ZWxBc3NldFN1Z2dlc3Rpb25TdGF0dXNFbnVt",
            "InIKGkhvdGVsQXNzZXRTdWdnZXN0aW9uU3RhdHVzEg8KC1VOU1BFQ0lGSUVE",
            "EAASCwoHVU5LTk9XThABEgsKB1NVQ0NFU1MQAhITCg9IT1RFTF9OT1RfRk9V",
            "TkQQAxIUChBJTlZBTElEX1BMQUNFX0lEEARC+QEKImNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTguZW51bXNCH0hvdGVsQXNzZXRTdWdnZXN0aW9uU3Rh",
            "dHVzUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxOC9lbnVtcztlbnVtc6ICA0dBQaoCHkdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYxOC5FbnVtc8oCHkdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFYxOFxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYx",
            "ODo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Enums.HotelAssetSuggestionStatusEnum), global::Google.Ads.GoogleAds.V18.Enums.HotelAssetSuggestionStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Enums.HotelAssetSuggestionStatusEnum.Types.HotelAssetSuggestionStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible statuses of a hotel asset suggestion.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HotelAssetSuggestionStatusEnum : pb::IMessage<HotelAssetSuggestionStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HotelAssetSuggestionStatusEnum> _parser = new pb::MessageParser<HotelAssetSuggestionStatusEnum>(() => new HotelAssetSuggestionStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HotelAssetSuggestionStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Enums.HotelAssetSuggestionStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelAssetSuggestionStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelAssetSuggestionStatusEnum(HotelAssetSuggestionStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelAssetSuggestionStatusEnum Clone() {
      return new HotelAssetSuggestionStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HotelAssetSuggestionStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HotelAssetSuggestionStatusEnum other) {
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
    public void MergeFrom(HotelAssetSuggestionStatusEnum other) {
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
    /// <summary>Container for nested types declared in the HotelAssetSuggestionStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible statuses of a hotel asset suggestion.
      /// </summary>
      public enum HotelAssetSuggestionStatus {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The hotel asset suggestion was successfully retrieved.
        /// </summary>
        [pbr::OriginalName("SUCCESS")] Success = 2,
        /// <summary>
        /// A hotel look up returns nothing.
        /// </summary>
        [pbr::OriginalName("HOTEL_NOT_FOUND")] HotelNotFound = 3,
        /// <summary>
        /// A Google Places ID is invalid and cannot be decoded.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACE_ID")] InvalidPlaceId = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
