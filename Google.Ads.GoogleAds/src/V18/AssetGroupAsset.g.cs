// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/resources/asset_group_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/resources/asset_group_asset.proto</summary>
  public static partial class AssetGroupAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/resources/asset_group_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvcmVzb3VyY2VzL2Fzc2V0X2dy",
            "b3VwX2Fzc2V0LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTgucmVz",
            "b3VyY2VzGjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvY29tbW9uL2Fzc2V0",
            "X3BvbGljeS5wcm90bxo0Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE4L2NvbW1v",
            "bi9wb2xpY3lfc3VtbWFyeS5wcm90bxo1Z29vZ2xlL2Fkcy9nb29nbGVhZHMv",
            "djE4L2VudW1zL2Fzc2V0X2ZpZWxkX3R5cGUucHJvdG8aPmdvb2dsZS9hZHMv",
            "Z29vZ2xlYWRzL3YxOC9lbnVtcy9hc3NldF9saW5rX3ByaW1hcnlfc3RhdHVz",
            "LnByb3RvGkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvYXNzZXRf",
            "bGlua19wcmltYXJ5X3N0YXR1c19yZWFzb24ucHJvdG8aNmdvb2dsZS9hZHMv",
            "Z29vZ2xlYWRzL3YxOC9lbnVtcy9hc3NldF9saW5rX3N0YXR1cy5wcm90bxo8",
            "Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE4L2VudW1zL2Fzc2V0X3BlcmZvcm1h",
            "bmNlX2xhYmVsLnByb3RvGjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51",
            "bXMvYXNzZXRfc291cmNlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2",
            "aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIuwICg9Bc3Nl",
            "dEdyb3VwQXNzZXQSRwoNcmVzb3VyY2VfbmFtZRgBIAEoCUIw4EEF+kEqCihn",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXRHcm91cEFzc2V0EkAKC2Fz",
            "c2V0X2dyb3VwGAIgASgJQivgQQX6QSUKI2dvb2dsZWFkcy5nb29nbGVhcGlz",
            "LmNvbS9Bc3NldEdyb3VwEjUKBWFzc2V0GAMgASgJQibgQQX6QSAKHmdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9Bc3NldBJVCgpmaWVsZF90eXBlGAQgASgO",
            "MkEuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE4LmVudW1zLkFzc2V0RmllbGRU",
            "eXBlRW51bS5Bc3NldEZpZWxkVHlwZRJTCgZzdGF0dXMYBSABKA4yQy5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MTguZW51bXMuQXNzZXRMaW5rU3RhdHVzRW51",
            "bS5Bc3NldExpbmtTdGF0dXMSbgoOcHJpbWFyeV9zdGF0dXMYCCABKA4yUS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTguZW51bXMuQXNzZXRMaW5rUHJpbWFy",
            "eVN0YXR1c0VudW0uQXNzZXRMaW5rUHJpbWFyeVN0YXR1c0ID4EEDEoIBChZw",
            "cmltYXJ5X3N0YXR1c19yZWFzb25zGAkgAygOMl0uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjE4LmVudW1zLkFzc2V0TGlua1ByaW1hcnlTdGF0dXNSZWFzb25F",
            "bnVtLkFzc2V0TGlua1ByaW1hcnlTdGF0dXNSZWFzb25CA+BBAxJjChZwcmlt",
            "YXJ5X3N0YXR1c19kZXRhaWxzGAogAygLMj4uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjE4LmNvbW1vbi5Bc3NldExpbmtQcmltYXJ5U3RhdHVzRGV0YWlsc0ID",
            "4EEDEm8KEXBlcmZvcm1hbmNlX2xhYmVsGAYgASgOMk8uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjE4LmVudW1zLkFzc2V0UGVyZm9ybWFuY2VMYWJlbEVudW0u",
            "QXNzZXRQZXJmb3JtYW5jZUxhYmVsQgPgQQMSSwoOcG9saWN5X3N1bW1hcnkY",
            "ByABKAsyLi5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTguY29tbW9uLlBvbGlj",
            "eVN1bW1hcnlCA+BBAxJQCgZzb3VyY2UYCyABKA4yOy5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTguZW51bXMuQXNzZXRTb3VyY2VFbnVtLkFzc2V0U291cmNl",
            "QgPgQQM6gAHqQX0KKGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Bc3NldEdy",
            "b3VwQXNzZXQSUWN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2Fzc2V0R3JvdXBB",
            "c3NldHMve2Fzc2V0X2dyb3VwX2lkfX57YXNzZXRfaWR9fntmaWVsZF90eXBl",
            "fUKGAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5yZXNvdXJjZXNC",
            "FEFzc2V0R3JvdXBBc3NldFByb3RvUAFaS2dvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTgvcmVzb3VyY2Vz",
            "O3Jlc291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxOC5S",
            "ZXNvdXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMThcUmVzb3VyY2Vz",
            "6gImR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE4OjpSZXNvdXJjZXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V18.Common.AssetPolicyReflection.Descriptor, global::Google.Ads.GoogleAds.V18.Common.PolicySummaryReflection.Descriptor, global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusReasonReflection.Descriptor, global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelReflection.Descriptor, global::Google.Ads.GoogleAds.V18.Enums.AssetSourceReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAsset), global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAsset.Parser, new[]{ "ResourceName", "AssetGroup", "Asset", "FieldType", "Status", "PrimaryStatus", "PrimaryStatusReasons", "PrimaryStatusDetails", "PerformanceLabel", "PolicySummary", "Source" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// AssetGroupAsset is the link between an asset and an asset group.
  /// Adding an AssetGroupAsset links an asset with an asset group.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AssetGroupAsset : pb::IMessage<AssetGroupAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroupAsset> _parser = new pb::MessageParser<AssetGroupAsset>(() => new AssetGroupAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroupAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Resources.AssetGroupAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupAsset(AssetGroupAsset other) : this() {
      resourceName_ = other.resourceName_;
      assetGroup_ = other.assetGroup_;
      asset_ = other.asset_;
      fieldType_ = other.fieldType_;
      status_ = other.status_;
      primaryStatus_ = other.primaryStatus_;
      primaryStatusReasons_ = other.primaryStatusReasons_.Clone();
      primaryStatusDetails_ = other.primaryStatusDetails_.Clone();
      performanceLabel_ = other.performanceLabel_;
      policySummary_ = other.policySummary_ != null ? other.policySummary_.Clone() : null;
      source_ = other.source_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupAsset Clone() {
      return new AssetGroupAsset(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the asset group asset.
    /// Asset group asset resource name have the form:
    ///
    /// `customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_group" field.</summary>
    public const int AssetGroupFieldNumber = 2;
    private string assetGroup_ = "";
    /// <summary>
    /// Immutable. The asset group which this asset group asset is linking.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AssetGroup {
      get { return assetGroup_; }
      set {
        assetGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 3;
    private string asset_ = "";
    /// <summary>
    /// Immutable. The asset which this asset group asset is linking.
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
    public const int FieldTypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType fieldType_ = global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified;
    /// <summary>
    /// The description of the placement of the asset within the asset group. For
    /// example: HEADLINE, YOUTUBE_VIDEO etc
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType FieldType {
      get { return fieldType_; }
      set {
        fieldType_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus status_ = global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified;
    /// <summary>
    /// The status of the link between an asset and asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "primary_status" field.</summary>
    public const int PrimaryStatusFieldNumber = 8;
    private global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus primaryStatus_ = global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified;
    /// <summary>
    /// Output only. Provides the PrimaryStatus of this asset link.
    /// Primary status is meant essentially to differentiate between the plain
    /// "status" field, which has advertiser set values of enabled, paused, or
    /// removed.  The primary status takes into account other signals (for assets
    /// its mainly policy and quality approvals) to come up with a more
    /// comprehensive status to indicate its serving state.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus PrimaryStatus {
      get { return primaryStatus_; }
      set {
        primaryStatus_ = value;
      }
    }

    /// <summary>Field number for the "primary_status_reasons" field.</summary>
    public const int PrimaryStatusReasonsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason> _repeated_primaryStatusReasons_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason> primaryStatusReasons_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason>();
    /// <summary>
    /// Output only. Provides a list of reasons for why an asset is not serving or
    /// not serving at full capacity.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason> PrimaryStatusReasons {
      get { return primaryStatusReasons_; }
    }

    /// <summary>Field number for the "primary_status_details" field.</summary>
    public const int PrimaryStatusDetailsFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V18.Common.AssetLinkPrimaryStatusDetails> _repeated_primaryStatusDetails_codec
        = pb::FieldCodec.ForMessage(82, global::Google.Ads.GoogleAds.V18.Common.AssetLinkPrimaryStatusDetails.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.AssetLinkPrimaryStatusDetails> primaryStatusDetails_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.AssetLinkPrimaryStatusDetails>();
    /// <summary>
    /// Output only. Provides the details of the primary status and its associated
    /// reasons.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V18.Common.AssetLinkPrimaryStatusDetails> PrimaryStatusDetails {
      get { return primaryStatusDetails_; }
    }

    /// <summary>Field number for the "performance_label" field.</summary>
    public const int PerformanceLabelFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel performanceLabel_ = global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified;
    /// <summary>
    /// Output only. The performance of this asset group asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel PerformanceLabel {
      get { return performanceLabel_; }
      set {
        performanceLabel_ = value;
      }
    }

    /// <summary>Field number for the "policy_summary" field.</summary>
    public const int PolicySummaryFieldNumber = 7;
    private global::Google.Ads.GoogleAds.V18.Common.PolicySummary policySummary_;
    /// <summary>
    /// Output only. The policy information for this asset group asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V18.Common.PolicySummary PolicySummary {
      get { return policySummary_; }
      set {
        policySummary_ = value;
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 11;
    private global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource source_ = global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource.Unspecified;
    /// <summary>
    /// Output only. Source of the asset group asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroupAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroupAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AssetGroup != other.AssetGroup) return false;
      if (Asset != other.Asset) return false;
      if (FieldType != other.FieldType) return false;
      if (Status != other.Status) return false;
      if (PrimaryStatus != other.PrimaryStatus) return false;
      if(!primaryStatusReasons_.Equals(other.primaryStatusReasons_)) return false;
      if(!primaryStatusDetails_.Equals(other.primaryStatusDetails_)) return false;
      if (PerformanceLabel != other.PerformanceLabel) return false;
      if (!object.Equals(PolicySummary, other.PolicySummary)) return false;
      if (Source != other.Source) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (AssetGroup.Length != 0) hash ^= AssetGroup.GetHashCode();
      if (Asset.Length != 0) hash ^= Asset.GetHashCode();
      if (FieldType != global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) hash ^= FieldType.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) hash ^= PrimaryStatus.GetHashCode();
      hash ^= primaryStatusReasons_.GetHashCode();
      hash ^= primaryStatusDetails_.GetHashCode();
      if (PerformanceLabel != global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) hash ^= PerformanceLabel.GetHashCode();
      if (policySummary_ != null) hash ^= PolicySummary.GetHashCode();
      if (Source != global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) hash ^= Source.GetHashCode();
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
      if (AssetGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetGroup);
      }
      if (Asset.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (PerformanceLabel != global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) PerformanceLabel);
      }
      if (policySummary_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(PolicySummary);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) PrimaryStatus);
      }
      primaryStatusReasons_.WriteTo(output, _repeated_primaryStatusReasons_codec);
      primaryStatusDetails_.WriteTo(output, _repeated_primaryStatusDetails_codec);
      if (Source != global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Source);
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
      if (AssetGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetGroup);
      }
      if (Asset.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (PerformanceLabel != global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) PerformanceLabel);
      }
      if (policySummary_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(PolicySummary);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) PrimaryStatus);
      }
      primaryStatusReasons_.WriteTo(ref output, _repeated_primaryStatusReasons_codec);
      primaryStatusDetails_.WriteTo(ref output, _repeated_primaryStatusDetails_codec);
      if (Source != global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Source);
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
      if (AssetGroup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetGroup);
      }
      if (Asset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PrimaryStatus);
      }
      size += primaryStatusReasons_.CalculateSize(_repeated_primaryStatusReasons_codec);
      size += primaryStatusDetails_.CalculateSize(_repeated_primaryStatusDetails_codec);
      if (PerformanceLabel != global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PerformanceLabel);
      }
      if (policySummary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PolicySummary);
      }
      if (Source != global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Source);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetGroupAsset other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AssetGroup.Length != 0) {
        AssetGroup = other.AssetGroup;
      }
      if (other.Asset.Length != 0) {
        Asset = other.Asset;
      }
      if (other.FieldType != global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        FieldType = other.FieldType;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.PrimaryStatus != global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) {
        PrimaryStatus = other.PrimaryStatus;
      }
      primaryStatusReasons_.Add(other.primaryStatusReasons_);
      primaryStatusDetails_.Add(other.primaryStatusDetails_);
      if (other.PerformanceLabel != global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Unspecified) {
        PerformanceLabel = other.PerformanceLabel;
      }
      if (other.policySummary_ != null) {
        if (policySummary_ == null) {
          PolicySummary = new global::Google.Ads.GoogleAds.V18.Common.PolicySummary();
        }
        PolicySummary.MergeFrom(other.PolicySummary);
      }
      if (other.Source != global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        Source = other.Source;
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
            AssetGroup = input.ReadString();
            break;
          }
          case 26: {
            Asset = input.ReadString();
            break;
          }
          case 32: {
            FieldType = (global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
            break;
          }
          case 48: {
            PerformanceLabel = (global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel) input.ReadEnum();
            break;
          }
          case 58: {
            if (policySummary_ == null) {
              PolicySummary = new global::Google.Ads.GoogleAds.V18.Common.PolicySummary();
            }
            input.ReadMessage(PolicySummary);
            break;
          }
          case 64: {
            PrimaryStatus = (global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus) input.ReadEnum();
            break;
          }
          case 74:
          case 72: {
            primaryStatusReasons_.AddEntriesFrom(input, _repeated_primaryStatusReasons_codec);
            break;
          }
          case 82: {
            primaryStatusDetails_.AddEntriesFrom(input, _repeated_primaryStatusDetails_codec);
            break;
          }
          case 88: {
            Source = (global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource) input.ReadEnum();
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
            AssetGroup = input.ReadString();
            break;
          }
          case 26: {
            Asset = input.ReadString();
            break;
          }
          case 32: {
            FieldType = (global::Google.Ads.GoogleAds.V18.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V18.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
            break;
          }
          case 48: {
            PerformanceLabel = (global::Google.Ads.GoogleAds.V18.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel) input.ReadEnum();
            break;
          }
          case 58: {
            if (policySummary_ == null) {
              PolicySummary = new global::Google.Ads.GoogleAds.V18.Common.PolicySummary();
            }
            input.ReadMessage(PolicySummary);
            break;
          }
          case 64: {
            PrimaryStatus = (global::Google.Ads.GoogleAds.V18.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus) input.ReadEnum();
            break;
          }
          case 74:
          case 72: {
            primaryStatusReasons_.AddEntriesFrom(ref input, _repeated_primaryStatusReasons_codec);
            break;
          }
          case 82: {
            primaryStatusDetails_.AddEntriesFrom(ref input, _repeated_primaryStatusDetails_codec);
            break;
          }
          case 88: {
            Source = (global::Google.Ads.GoogleAds.V18.Enums.AssetSourceEnum.Types.AssetSource) input.ReadEnum();
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
