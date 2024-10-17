// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/enums/price_extension_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/enums/price_extension_type.proto</summary>
  public static partial class PriceExtensionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/enums/price_extension_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PriceExtensionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvcHJpY2VfZXh0ZW5z",
            "aW9uX3R5cGUucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5lbnVt",
            "cyLrAQoWUHJpY2VFeHRlbnNpb25UeXBlRW51bSLQAQoSUHJpY2VFeHRlbnNp",
            "b25UeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgoKBkJSQU5E",
            "UxACEgoKBkVWRU5UUxADEg0KCUxPQ0FUSU9OUxAEEhEKDU5FSUdIQk9SSE9P",
            "RFMQBRIWChJQUk9EVUNUX0NBVEVHT1JJRVMQBhIRCg1QUk9EVUNUX1RJRVJT",
            "EAcSDAoIU0VSVklDRVMQCBIWChJTRVJWSUNFX0NBVEVHT1JJRVMQCRIRCg1T",
            "RVJWSUNFX1RJRVJTEApC8QEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTguZW51bXNCF1ByaWNlRXh0ZW5zaW9uVHlwZVByb3RvUAFaQ2dvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MTgvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MTguRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMThcRW51bXPqAiJH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTg6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Enums.PriceExtensionTypeEnum), global::Google.Ads.GoogleAds.V18.Enums.PriceExtensionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Enums.PriceExtensionTypeEnum.Types.PriceExtensionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing types for a price extension.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PriceExtensionTypeEnum : pb::IMessage<PriceExtensionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PriceExtensionTypeEnum> _parser = new pb::MessageParser<PriceExtensionTypeEnum>(() => new PriceExtensionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PriceExtensionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Enums.PriceExtensionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PriceExtensionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PriceExtensionTypeEnum(PriceExtensionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PriceExtensionTypeEnum Clone() {
      return new PriceExtensionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PriceExtensionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PriceExtensionTypeEnum other) {
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
    public void MergeFrom(PriceExtensionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the PriceExtensionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Price extension type.
      /// </summary>
      public enum PriceExtensionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The type for showing a list of brands.
        /// </summary>
        [pbr::OriginalName("BRANDS")] Brands = 2,
        /// <summary>
        /// The type for showing a list of events.
        /// </summary>
        [pbr::OriginalName("EVENTS")] Events = 3,
        /// <summary>
        /// The type for showing locations relevant to your business.
        /// </summary>
        [pbr::OriginalName("LOCATIONS")] Locations = 4,
        /// <summary>
        /// The type for showing sub-regions or districts within a city or region.
        /// </summary>
        [pbr::OriginalName("NEIGHBORHOODS")] Neighborhoods = 5,
        /// <summary>
        /// The type for showing a collection of product categories.
        /// </summary>
        [pbr::OriginalName("PRODUCT_CATEGORIES")] ProductCategories = 6,
        /// <summary>
        /// The type for showing a collection of related product tiers.
        /// </summary>
        [pbr::OriginalName("PRODUCT_TIERS")] ProductTiers = 7,
        /// <summary>
        /// The type for showing a collection of services offered by your business.
        /// </summary>
        [pbr::OriginalName("SERVICES")] Services = 8,
        /// <summary>
        /// The type for showing a collection of service categories.
        /// </summary>
        [pbr::OriginalName("SERVICE_CATEGORIES")] ServiceCategories = 9,
        /// <summary>
        /// The type for showing a collection of related service tiers.
        /// </summary>
        [pbr::OriginalName("SERVICE_TIERS")] ServiceTiers = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
