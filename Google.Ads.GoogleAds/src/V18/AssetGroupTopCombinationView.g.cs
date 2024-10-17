// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/resources/asset_group_top_combination_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/resources/asset_group_top_combination_view.proto</summary>
  public static partial class AssetGroupTopCombinationViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/resources/asset_group_top_combination_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupTopCombinationViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvcmVzb3VyY2VzL2Fzc2V0X2dy",
            "b3VwX3RvcF9jb21iaW5hdGlvbl92aWV3LnByb3RvEiJnb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTgucmVzb3VyY2VzGjFnb29nbGUvYWRzL2dvb2dsZWFkcy92",
            "MTgvY29tbW9uL2Fzc2V0X3VzYWdlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIoYD",
            "ChxBc3NldEdyb3VwVG9wQ29tYmluYXRpb25WaWV3ElQKDXJlc291cmNlX25h",
            "bWUYASABKAlCPeBBA/pBNwo1Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0Fz",
            "c2V0R3JvdXBUb3BDb21iaW5hdGlvblZpZXcSbQocYXNzZXRfZ3JvdXBfdG9w",
            "X2NvbWJpbmF0aW9ucxgCIAMoCzJCLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "OC5yZXNvdXJjZXMuQXNzZXRHcm91cEFzc2V0Q29tYmluYXRpb25EYXRhQgPg",
            "QQM6oAHqQZwBCjVnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXRHcm91",
            "cFRvcENvbWJpbmF0aW9uVmlldxJjY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0v",
            "YXNzZXRHcm91cFRvcENvbWJpbmF0aW9uVmlld3Mve2Fzc2V0X2dyb3VwX2lk",
            "fX57YXNzZXRfY29tYmluYXRpb25fY2F0ZWdvcnl9InsKHkFzc2V0R3JvdXBB",
            "c3NldENvbWJpbmF0aW9uRGF0YRJZCh9hc3NldF9jb21iaW5hdGlvbl9zZXJ2",
            "ZWRfYXNzZXRzGAEgAygLMisuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE4LmNv",
            "bW1vbi5Bc3NldFVzYWdlQgPgQQNCkwIKJmNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTgucmVzb3VyY2VzQiFBc3NldEdyb3VwVG9wQ29tYmluYXRpb25W",
            "aWV3UHJvdG9QAVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxOC9yZXNvdXJjZXM7cmVzb3VyY2VzogID",
            "R0FBqgIiR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE4LlJlc291cmNlc8oCIkdv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFYxOFxSZXNvdXJjZXPqAiZHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWMTg6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V18.Common.AssetUsageReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Resources.AssetGroupTopCombinationView), global::Google.Ads.GoogleAds.V18.Resources.AssetGroupTopCombinationView.Parser, new[]{ "ResourceName", "AssetGroupTopCombinations" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAssetCombinationData), global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAssetCombinationData.Parser, new[]{ "AssetCombinationServedAssets" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A view on the usage of ad group ad asset combination.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AssetGroupTopCombinationView : pb::IMessage<AssetGroupTopCombinationView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroupTopCombinationView> _parser = new pb::MessageParser<AssetGroupTopCombinationView>(() => new AssetGroupTopCombinationView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroupTopCombinationView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Resources.AssetGroupTopCombinationViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupTopCombinationView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupTopCombinationView(AssetGroupTopCombinationView other) : this() {
      resourceName_ = other.resourceName_;
      assetGroupTopCombinations_ = other.assetGroupTopCombinations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupTopCombinationView Clone() {
      return new AssetGroupTopCombinationView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the asset group top combination view.
    /// AssetGroup Top Combination view resource names have the form:
    /// `"customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_group_top_combinations" field.</summary>
    public const int AssetGroupTopCombinationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAssetCombinationData> _repeated_assetGroupTopCombinations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAssetCombinationData.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAssetCombinationData> assetGroupTopCombinations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAssetCombinationData>();
    /// <summary>
    /// Output only. The top combinations of assets that served together.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAssetCombinationData> AssetGroupTopCombinations {
      get { return assetGroupTopCombinations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroupTopCombinationView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroupTopCombinationView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if(!assetGroupTopCombinations_.Equals(other.assetGroupTopCombinations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      hash ^= assetGroupTopCombinations_.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      assetGroupTopCombinations_.WriteTo(output, _repeated_assetGroupTopCombinations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      assetGroupTopCombinations_.WriteTo(ref output, _repeated_assetGroupTopCombinations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      size += assetGroupTopCombinations_.CalculateSize(_repeated_assetGroupTopCombinations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetGroupTopCombinationView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      assetGroupTopCombinations_.Add(other.assetGroupTopCombinations_);
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            assetGroupTopCombinations_.AddEntriesFrom(input, _repeated_assetGroupTopCombinations_codec);
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            assetGroupTopCombinations_.AddEntriesFrom(ref input, _repeated_assetGroupTopCombinations_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Asset group asset combination data
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AssetGroupAssetCombinationData : pb::IMessage<AssetGroupAssetCombinationData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroupAssetCombinationData> _parser = new pb::MessageParser<AssetGroupAssetCombinationData>(() => new AssetGroupAssetCombinationData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroupAssetCombinationData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Resources.AssetGroupTopCombinationViewReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupAssetCombinationData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupAssetCombinationData(AssetGroupAssetCombinationData other) : this() {
      assetCombinationServedAssets_ = other.assetCombinationServedAssets_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupAssetCombinationData Clone() {
      return new AssetGroupAssetCombinationData(this);
    }

    /// <summary>Field number for the "asset_combination_served_assets" field.</summary>
    public const int AssetCombinationServedAssetsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V18.Common.AssetUsage> _repeated_assetCombinationServedAssets_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V18.Common.AssetUsage.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.AssetUsage> assetCombinationServedAssets_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.AssetUsage>();
    /// <summary>
    /// Output only. Served assets.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.AssetUsage> AssetCombinationServedAssets {
      get { return assetCombinationServedAssets_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroupAssetCombinationData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroupAssetCombinationData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!assetCombinationServedAssets_.Equals(other.assetCombinationServedAssets_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= assetCombinationServedAssets_.GetHashCode();
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
      assetCombinationServedAssets_.WriteTo(output, _repeated_assetCombinationServedAssets_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      assetCombinationServedAssets_.WriteTo(ref output, _repeated_assetCombinationServedAssets_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += assetCombinationServedAssets_.CalculateSize(_repeated_assetCombinationServedAssets_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetGroupAssetCombinationData other) {
      if (other == null) {
        return;
      }
      assetCombinationServedAssets_.Add(other.assetCombinationServedAssets_);
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
          case 10: {
            assetCombinationServedAssets_.AddEntriesFrom(input, _repeated_assetCombinationServedAssets_codec);
            break;
          }
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
          case 10: {
            assetCombinationServedAssets_.AddEntriesFrom(ref input, _repeated_assetCombinationServedAssets_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
