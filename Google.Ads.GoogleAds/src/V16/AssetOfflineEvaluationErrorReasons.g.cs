// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/enums/asset_offline_evaluation_error_reasons.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/enums/asset_offline_evaluation_error_reasons.proto</summary>
  public static partial class AssetOfflineEvaluationErrorReasonsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/enums/asset_offline_evaluation_error_reasons.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetOfflineEvaluationErrorReasonsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cktnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZW51bXMvYXNzZXRfb2ZmbGlu",
            "ZV9ldmFsdWF0aW9uX2Vycm9yX3JlYXNvbnMucHJvdG8SHmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxNi5lbnVtcyKlAwomQXNzZXRPZmZsaW5lRXZhbHVhdGlv",
            "bkVycm9yUmVhc29uc0VudW0i+gIKIkFzc2V0T2ZmbGluZUV2YWx1YXRpb25F",
            "cnJvclJlYXNvbnMSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESLgoq",
            "UFJJQ0VfQVNTRVRfREVTQ1JJUFRJT05fUkVQRUFUU19ST1dfSEVBREVSEAIS",
            "IgoeUFJJQ0VfQVNTRVRfUkVQRVRJVElWRV9IRUFERVJTEAMSMwovUFJJQ0Vf",
            "QVNTRVRfSEVBREVSX0lOQ09NUEFUSUJMRV9XSVRIX1BSSUNFX1RZUEUQBBI5",
            "CjVQUklDRV9BU1NFVF9ERVNDUklQVElPTl9JTkNPTVBBVElCTEVfV0lUSF9J",
            "VEVNX0hFQURFUhAFEi8KK1BSSUNFX0FTU0VUX0RFU0NSSVBUSU9OX0hBU19Q",
            "UklDRV9RVUFMSUZJRVIQBhIkCiBQUklDRV9BU1NFVF9VTlNVUFBPUlRFRF9M",
            "QU5HVUFHRRAHEhsKF1BSSUNFX0FTU0VUX09USEVSX0VSUk9SEAhCgQIKImNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTYuZW51bXNCJ0Fzc2V0T2ZmbGlu",
            "ZUV2YWx1YXRpb25FcnJvclJlYXNvbnNQcm90b1ABWkNnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE2L2Vu",
            "dW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE2LkVu",
            "dW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE2XEVudW1z6gIiR29vZ2xl",
            "OjpBZHM6Okdvb2dsZUFkczo6VjE2OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Enums.AssetOfflineEvaluationErrorReasonsEnum), global::Google.Ads.GoogleAds.V16.Enums.AssetOfflineEvaluationErrorReasonsEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V16.Enums.AssetOfflineEvaluationErrorReasonsEnum.Types.AssetOfflineEvaluationErrorReasons) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Provides the quality evaluation disapproval reason of an asset.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AssetOfflineEvaluationErrorReasonsEnum : pb::IMessage<AssetOfflineEvaluationErrorReasonsEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetOfflineEvaluationErrorReasonsEnum> _parser = new pb::MessageParser<AssetOfflineEvaluationErrorReasonsEnum>(() => new AssetOfflineEvaluationErrorReasonsEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetOfflineEvaluationErrorReasonsEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Enums.AssetOfflineEvaluationErrorReasonsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetOfflineEvaluationErrorReasonsEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetOfflineEvaluationErrorReasonsEnum(AssetOfflineEvaluationErrorReasonsEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetOfflineEvaluationErrorReasonsEnum Clone() {
      return new AssetOfflineEvaluationErrorReasonsEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetOfflineEvaluationErrorReasonsEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetOfflineEvaluationErrorReasonsEnum other) {
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
    public void MergeFrom(AssetOfflineEvaluationErrorReasonsEnum other) {
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
    /// <summary>Container for nested types declared in the AssetOfflineEvaluationErrorReasonsEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the quality evaluation disapproval reason of an asset.
      /// </summary>
      public enum AssetOfflineEvaluationErrorReasons {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// One or more descriptions repeats its corresponding row header.
        /// </summary>
        [pbr::OriginalName("PRICE_ASSET_DESCRIPTION_REPEATS_ROW_HEADER")] PriceAssetDescriptionRepeatsRowHeader = 2,
        /// <summary>
        /// Price asset contains repetitive headers.
        /// </summary>
        [pbr::OriginalName("PRICE_ASSET_REPETITIVE_HEADERS")] PriceAssetRepetitiveHeaders = 3,
        /// <summary>
        /// Price item header is not relevant to the price type.
        /// </summary>
        [pbr::OriginalName("PRICE_ASSET_HEADER_INCOMPATIBLE_WITH_PRICE_TYPE")] PriceAssetHeaderIncompatibleWithPriceType = 4,
        /// <summary>
        /// Price item description is not relevant to the item header.
        /// </summary>
        [pbr::OriginalName("PRICE_ASSET_DESCRIPTION_INCOMPATIBLE_WITH_ITEM_HEADER")] PriceAssetDescriptionIncompatibleWithItemHeader = 5,
        /// <summary>
        /// Price asset has a price qualifier in a description.
        /// </summary>
        [pbr::OriginalName("PRICE_ASSET_DESCRIPTION_HAS_PRICE_QUALIFIER")] PriceAssetDescriptionHasPriceQualifier = 6,
        /// <summary>
        /// Unsupported language for price assets
        /// </summary>
        [pbr::OriginalName("PRICE_ASSET_UNSUPPORTED_LANGUAGE")] PriceAssetUnsupportedLanguage = 7,
        /// <summary>
        /// Human raters identified an issue with the price asset that isn't captured
        /// by other error reasons. The primary purpose of this value is to represent
        /// legacy FeedItem disapprovals that are no longer produced.
        /// </summary>
        [pbr::OriginalName("PRICE_ASSET_OTHER_ERROR")] PriceAssetOtherError = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
