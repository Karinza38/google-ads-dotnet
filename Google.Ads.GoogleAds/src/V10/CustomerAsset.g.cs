// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/customer_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/customer_asset.proto</summary>
  public static partial class CustomerAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/customer_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL2N1c3RvbWVy",
            "X2Fzc2V0LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTAucmVzb3Vy",
            "Y2VzGjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvYXNzZXRfZmll",
            "bGRfdHlwZS5wcm90bxo2Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEwL2VudW1z",
            "L2Fzc2V0X2xpbmtfc3RhdHVzLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2Jl",
            "aGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIrEDCg1D",
            "dXN0b21lckFzc2V0EkUKDXJlc291cmNlX25hbWUYASABKAlCLuBBBfpBKAom",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyQXNzZXQSOAoFYXNz",
            "ZXQYAiABKAlCKeBBAuBBBfpBIAoeZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "L0Fzc2V0El0KCmZpZWxkX3R5cGUYAyABKA4yQS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTAuZW51bXMuQXNzZXRGaWVsZFR5cGVFbnVtLkFzc2V0RmllbGRU",
            "eXBlQgbgQQLgQQUSUwoGc3RhdHVzGAQgASgOMkMuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEwLmVudW1zLkFzc2V0TGlua1N0YXR1c0VudW0uQXNzZXRMaW5r",
            "U3RhdHVzOmvqQWgKJmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21l",
            "ckFzc2V0Ej5jdXN0b21lcnMve2N1c3RvbWVyX2lkfS9jdXN0b21lckFzc2V0",
            "cy97YXNzZXRfaWR9fntmaWVsZF90eXBlfUKEAgomY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxMC5yZXNvdXJjZXNCEkN1c3RvbWVyQXNzZXRQcm90b1AB",
            "Wktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjEwL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMTAuUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjEwXFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYxMDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.CustomerAsset), global::Google.Ads.GoogleAds.V10.Resources.CustomerAsset.Parser, new[]{ "ResourceName", "Asset", "FieldType", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between a customer and an asset.
  /// </summary>
  public sealed partial class CustomerAsset : pb::IMessage<CustomerAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerAsset> _parser = new pb::MessageParser<CustomerAsset>(() => new CustomerAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.CustomerAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAsset(CustomerAsset other) : this() {
      resourceName_ = other.resourceName_;
      asset_ = other.asset_;
      fieldType_ = other.fieldType_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerAsset Clone() {
      return new CustomerAsset(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer asset.
    /// CustomerAsset resource names have the form:
    ///
    /// `customers/{customer_id}/customerAssets/{asset_id}~{field_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 2;
    private string asset_ = "";
    /// <summary>
    /// Required. Immutable. The asset which is linked to the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "field_type" field.</summary>
    public const int FieldTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType fieldType_ = global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified;
    /// <summary>
    /// Required. Immutable. Role that the asset takes for the customer link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType FieldType {
      get { return fieldType_; }
      set {
        fieldType_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus status_ = global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified;
    /// <summary>
    /// Status of the customer asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Asset != other.Asset) return false;
      if (FieldType != other.FieldType) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Asset.Length != 0) hash ^= Asset.GetHashCode();
      if (FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) hash ^= FieldType.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (Asset.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
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
      if (Asset.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
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
      if (Asset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerAsset other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Asset.Length != 0) {
        Asset = other.Asset;
      }
      if (other.FieldType != global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        FieldType = other.FieldType;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        Status = other.Status;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            Asset = input.ReadString();
            break;
          }
          case 24: {
            FieldType = (global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
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
            Asset = input.ReadString();
            break;
          }
          case 24: {
            FieldType = (global::Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V10.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
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