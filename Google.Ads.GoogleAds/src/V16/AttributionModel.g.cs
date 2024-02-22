// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/enums/attribution_model.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/enums/attribution_model.proto</summary>
  public static partial class AttributionModelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/enums/attribution_model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AttributionModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZW51bXMvYXR0cmlidXRpb25f",
            "bW9kZWwucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5lbnVtcyLG",
            "AgoUQXR0cmlidXRpb25Nb2RlbEVudW0irQIKEEF0dHJpYnV0aW9uTW9kZWwS",
            "DwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDAoIRVhURVJOQUwQZBIZ",
            "ChVHT09HTEVfQURTX0xBU1RfQ0xJQ0sQZRIpCiVHT09HTEVfU0VBUkNIX0FU",
            "VFJJQlVUSU9OX0ZJUlNUX0NMSUNLEGYSJAogR09PR0xFX1NFQVJDSF9BVFRS",
            "SUJVVElPTl9MSU5FQVIQZxIoCiRHT09HTEVfU0VBUkNIX0FUVFJJQlVUSU9O",
            "X1RJTUVfREVDQVkQaBIsCihHT09HTEVfU0VBUkNIX0FUVFJJQlVUSU9OX1BP",
            "U0lUSU9OX0JBU0VEEGkSKQolR09PR0xFX1NFQVJDSF9BVFRSSUJVVElPTl9E",
            "QVRBX0RSSVZFThBqQu8BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE2",
            "LmVudW1zQhVBdHRyaWJ1dGlvbk1vZGVsUHJvdG9QAVpDZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNi9l",
            "bnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxNi5F",
            "bnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNlxFbnVtc+oCIkdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYxNjo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Enums.AttributionModelEnum), global::Google.Ads.GoogleAds.V16.Enums.AttributionModelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V16.Enums.AttributionModelEnum.Types.AttributionModel) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum representing the attribution model that describes how to
  /// distribute credit for a particular conversion across potentially many prior
  /// interactions.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AttributionModelEnum : pb::IMessage<AttributionModelEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AttributionModelEnum> _parser = new pb::MessageParser<AttributionModelEnum>(() => new AttributionModelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AttributionModelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Enums.AttributionModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AttributionModelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AttributionModelEnum(AttributionModelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AttributionModelEnum Clone() {
      return new AttributionModelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AttributionModelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AttributionModelEnum other) {
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
    public void MergeFrom(AttributionModelEnum other) {
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
    /// <summary>Container for nested types declared in the AttributionModelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The attribution model that describes how to distribute credit for a
      /// particular conversion across potentially many prior interactions.
      /// </summary>
      public enum AttributionModel {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Uses external attribution.
        /// </summary>
        [pbr::OriginalName("EXTERNAL")] External = 100,
        /// <summary>
        /// Attributes all credit for a conversion to its last click.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_LAST_CLICK")] GoogleAdsLastClick = 101,
        /// <summary>
        /// Attributes all credit for a conversion to its first click using Google
        /// Search attribution.
        /// </summary>
        [pbr::OriginalName("GOOGLE_SEARCH_ATTRIBUTION_FIRST_CLICK")] GoogleSearchAttributionFirstClick = 102,
        /// <summary>
        /// Attributes credit for a conversion equally across all of its clicks using
        /// Google Search attribution.
        /// </summary>
        [pbr::OriginalName("GOOGLE_SEARCH_ATTRIBUTION_LINEAR")] GoogleSearchAttributionLinear = 103,
        /// <summary>
        /// Attributes exponentially more credit for a conversion to its more recent
        /// clicks using Google Search attribution (half-life is 1 week).
        /// </summary>
        [pbr::OriginalName("GOOGLE_SEARCH_ATTRIBUTION_TIME_DECAY")] GoogleSearchAttributionTimeDecay = 104,
        /// <summary>
        /// Attributes 40% of the credit for a conversion to its first and last
        /// clicks. Remaining 20% is evenly distributed across all other clicks. This
        /// uses Google Search attribution.
        /// </summary>
        [pbr::OriginalName("GOOGLE_SEARCH_ATTRIBUTION_POSITION_BASED")] GoogleSearchAttributionPositionBased = 105,
        /// <summary>
        /// Flexible model that uses machine learning to determine the appropriate
        /// distribution of credit among clicks using Google Search attribution.
        /// </summary>
        [pbr::OriginalName("GOOGLE_SEARCH_ATTRIBUTION_DATA_DRIVEN")] GoogleSearchAttributionDataDriven = 106,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
