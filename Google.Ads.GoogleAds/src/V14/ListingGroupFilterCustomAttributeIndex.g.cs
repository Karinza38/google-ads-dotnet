// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/enums/listing_group_filter_custom_attribute_index.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/enums/listing_group_filter_custom_attribute_index.proto</summary>
  public static partial class ListingGroupFilterCustomAttributeIndexReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/enums/listing_group_filter_custom_attribute_index.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListingGroupFilterCustomAttributeIndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvbGlzdGluZ19ncm91",
            "cF9maWx0ZXJfY3VzdG9tX2F0dHJpYnV0ZV9pbmRleC5wcm90bxIeZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE0LmVudW1zIrEBCipMaXN0aW5nR3JvdXBGaWx0",
            "ZXJDdXN0b21BdHRyaWJ1dGVJbmRleEVudW0iggEKJkxpc3RpbmdHcm91cEZp",
            "bHRlckN1c3RvbUF0dHJpYnV0ZUluZGV4Eg8KC1VOU1BFQ0lGSUVEEAASCwoH",
            "VU5LTk9XThABEgoKBklOREVYMBACEgoKBklOREVYMRADEgoKBklOREVYMhAE",
            "EgoKBklOREVYMxAFEgoKBklOREVYNBAGQoUCCiJjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjE0LmVudW1zQitMaXN0aW5nR3JvdXBGaWx0ZXJDdXN0b21B",
            "dHRyaWJ1dGVJbmRleFByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTQvZW51bXM7ZW51bXOi",
            "AgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTQuRW51bXPKAh5Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWMTRcRW51bXPqAiJHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTQ6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Enums.ListingGroupFilterCustomAttributeIndexEnum), global::Google.Ads.GoogleAds.V14.Enums.ListingGroupFilterCustomAttributeIndexEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Enums.ListingGroupFilterCustomAttributeIndexEnum.Types.ListingGroupFilterCustomAttributeIndex) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the indexes of custom attribute used in
  /// ListingGroupFilterDimension.
  /// </summary>
  public sealed partial class ListingGroupFilterCustomAttributeIndexEnum : pb::IMessage<ListingGroupFilterCustomAttributeIndexEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListingGroupFilterCustomAttributeIndexEnum> _parser = new pb::MessageParser<ListingGroupFilterCustomAttributeIndexEnum>(() => new ListingGroupFilterCustomAttributeIndexEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListingGroupFilterCustomAttributeIndexEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Enums.ListingGroupFilterCustomAttributeIndexReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterCustomAttributeIndexEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterCustomAttributeIndexEnum(ListingGroupFilterCustomAttributeIndexEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterCustomAttributeIndexEnum Clone() {
      return new ListingGroupFilterCustomAttributeIndexEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListingGroupFilterCustomAttributeIndexEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListingGroupFilterCustomAttributeIndexEnum other) {
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
    public void MergeFrom(ListingGroupFilterCustomAttributeIndexEnum other) {
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
    /// <summary>Container for nested types declared in the ListingGroupFilterCustomAttributeIndexEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The index of customer attributes.
      /// </summary>
      public enum ListingGroupFilterCustomAttributeIndex {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// First listing group filter custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX0")] Index0 = 2,
        /// <summary>
        /// Second listing group filter custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX1")] Index1 = 3,
        /// <summary>
        /// Third listing group filter custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX2")] Index2 = 4,
        /// <summary>
        /// Fourth listing group filter custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX3")] Index3 = 5,
        /// <summary>
        /// Fifth listing group filter custom attribute.
        /// </summary>
        [pbr::OriginalName("INDEX4")] Index4 = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code