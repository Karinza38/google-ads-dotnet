// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/resources/android_privacy_shared_key_google_ad_group.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/resources/android_privacy_shared_key_google_ad_group.proto</summary>
  public static partial class AndroidPrivacySharedKeyGoogleAdGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/resources/android_privacy_shared_key_google_ad_group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AndroidPrivacySharedKeyGoogleAdGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvcmVzb3VyY2VzL2FuZHJvaWRf",
            "cHJpdmFjeV9zaGFyZWRfa2V5X2dvb2dsZV9hZF9ncm91cC5wcm90bxIiZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjE2LnJlc291cmNlcxpFZ29vZ2xlL2Fkcy9n",
            "b29nbGVhZHMvdjE2L2VudW1zL2FuZHJvaWRfcHJpdmFjeV9pbnRlcmFjdGlv",
            "bl90eXBlLnByb3RvGkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZW51bXMv",
            "YW5kcm9pZF9wcml2YWN5X25ldHdvcmtfdHlwZS5wcm90bxofZ29vZ2xlL2Fw",
            "aS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5w",
            "cm90byKmBgokQW5kcm9pZFByaXZhY3lTaGFyZWRLZXlHb29nbGVBZEdyb3Vw",
            "ElwKDXJlc291cmNlX25hbWUYASABKAlCReBBA/pBPwo9Z29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tL0FuZHJvaWRQcml2YWN5U2hhcmVkS2V5R29vZ2xlQWRH",
            "cm91cBIYCgtjYW1wYWlnbl9pZBgCIAEoA0ID4EEDEo4BCiBhbmRyb2lkX3By",
            "aXZhY3lfaW50ZXJhY3Rpb25fdHlwZRgDIAEoDjJfLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxNi5lbnVtcy5BbmRyb2lkUHJpdmFjeUludGVyYWN0aW9uVHlw",
            "ZUVudW0uQW5kcm9pZFByaXZhY3lJbnRlcmFjdGlvblR5cGVCA+BBAxItCiBh",
            "bmRyb2lkX3ByaXZhY3lfaW50ZXJhY3Rpb25fZGF0ZRgEIAEoCUID4EEDEoIB",
            "ChxhbmRyb2lkX3ByaXZhY3lfbmV0d29ya190eXBlGAUgASgOMlcuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE2LmVudW1zLkFuZHJvaWRQcml2YWN5TmV0d29y",
            "a1R5cGVFbnVtLkFuZHJvaWRQcml2YWN5TmV0d29ya1R5cGVCA+BBAxIYCgth",
            "ZF9ncm91cF9pZBgGIAEoA0ID4EEDEiAKE3NoYXJlZF9hZF9ncm91cF9rZXkY",
            "ByABKAlCA+BBAzqEAupBgAIKPWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9B",
            "bmRyb2lkUHJpdmFjeVNoYXJlZEtleUdvb2dsZUFkR3JvdXASvgFjdXN0b21l",
            "cnMve2N1c3RvbWVyX2lkfS9hbmRyb2lkUHJpdmFjeVNoYXJlZEtleUdvb2ds",
            "ZUFkR3JvdXBzL3tjYW1wYWlnbl9pZH1+e2FkX2dyb3VwX2lkfX57YW5kcm9p",
            "ZF9wcml2YWN5X2ludGVyYWN0aW9uX3R5cGV9fnthbmRyb2lkX3ByaXZhY3lf",
            "bmV0d29ya190eXBlfX57YW5kcm9pZF9wcml2YWN5X2ludGVyYWN0aW9uX2Rh",
            "dGV9QpsCCiZjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE2LnJlc291cmNl",
            "c0IpQW5kcm9pZFByaXZhY3lTaGFyZWRLZXlHb29nbGVBZEdyb3VwUHJvdG9Q",
            "AVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YxNi9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjE2LlJlc291cmNlc8oCIkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxNlxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWMTY6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Resources.AndroidPrivacySharedKeyGoogleAdGroup), global::Google.Ads.GoogleAds.V16.Resources.AndroidPrivacySharedKeyGoogleAdGroup.Parser, new[]{ "ResourceName", "CampaignId", "AndroidPrivacyInteractionType", "AndroidPrivacyInteractionDate", "AndroidPrivacyNetworkType", "AdGroupId", "SharedAdGroupKey" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An Android privacy shared key view for Google ad group key.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AndroidPrivacySharedKeyGoogleAdGroup : pb::IMessage<AndroidPrivacySharedKeyGoogleAdGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AndroidPrivacySharedKeyGoogleAdGroup> _parser = new pb::MessageParser<AndroidPrivacySharedKeyGoogleAdGroup>(() => new AndroidPrivacySharedKeyGoogleAdGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AndroidPrivacySharedKeyGoogleAdGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Resources.AndroidPrivacySharedKeyGoogleAdGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AndroidPrivacySharedKeyGoogleAdGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AndroidPrivacySharedKeyGoogleAdGroup(AndroidPrivacySharedKeyGoogleAdGroup other) : this() {
      resourceName_ = other.resourceName_;
      campaignId_ = other.campaignId_;
      androidPrivacyInteractionType_ = other.androidPrivacyInteractionType_;
      androidPrivacyInteractionDate_ = other.androidPrivacyInteractionDate_;
      androidPrivacyNetworkType_ = other.androidPrivacyNetworkType_;
      adGroupId_ = other.adGroupId_;
      sharedAdGroupKey_ = other.sharedAdGroupKey_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AndroidPrivacySharedKeyGoogleAdGroup Clone() {
      return new AndroidPrivacySharedKeyGoogleAdGroup(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the Android privacy shared key.
    /// Android privacy shared key resource names have the form:
    ///
    /// `customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date(yyyy-mm-dd)}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign_id" field.</summary>
    public const int CampaignIdFieldNumber = 2;
    private long campaignId_;
    /// <summary>
    /// Output only. The campaign ID used in the share key encoding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CampaignId {
      get { return campaignId_; }
      set {
        campaignId_ = value;
      }
    }

    /// <summary>Field number for the "android_privacy_interaction_type" field.</summary>
    public const int AndroidPrivacyInteractionTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType androidPrivacyInteractionType_ = global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified;
    /// <summary>
    /// Output only. The interaction type enum used in the share key encoding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType AndroidPrivacyInteractionType {
      get { return androidPrivacyInteractionType_; }
      set {
        androidPrivacyInteractionType_ = value;
      }
    }

    /// <summary>Field number for the "android_privacy_interaction_date" field.</summary>
    public const int AndroidPrivacyInteractionDateFieldNumber = 4;
    private string androidPrivacyInteractionDate_ = "";
    /// <summary>
    /// Output only. The interaction date used in the shared key encoding in the
    /// format of "YYYY-MM-DD" in UTC timezone.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AndroidPrivacyInteractionDate {
      get { return androidPrivacyInteractionDate_; }
      set {
        androidPrivacyInteractionDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "android_privacy_network_type" field.</summary>
    public const int AndroidPrivacyNetworkTypeFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType androidPrivacyNetworkType_ = global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified;
    /// <summary>
    /// Output only. The network type enum used in the share key encoding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType AndroidPrivacyNetworkType {
      get { return androidPrivacyNetworkType_; }
      set {
        androidPrivacyNetworkType_ = value;
      }
    }

    /// <summary>Field number for the "ad_group_id" field.</summary>
    public const int AdGroupIdFieldNumber = 6;
    private long adGroupId_;
    /// <summary>
    /// Output only. The ad group ID used in the share key encoding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long AdGroupId {
      get { return adGroupId_; }
      set {
        adGroupId_ = value;
      }
    }

    /// <summary>Field number for the "shared_ad_group_key" field.</summary>
    public const int SharedAdGroupKeyFieldNumber = 7;
    private string sharedAdGroupKey_ = "";
    /// <summary>
    /// Output only. 128 bit hex string of the encoded shared ad group key,
    /// including a '0x' prefix. This key can be used to do a bitwise OR operator
    /// with the aggregate conversion key to create a full aggregation key to
    /// retrieve the Aggregate API Report in Android Privacy Sandbox.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SharedAdGroupKey {
      get { return sharedAdGroupKey_; }
      set {
        sharedAdGroupKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AndroidPrivacySharedKeyGoogleAdGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AndroidPrivacySharedKeyGoogleAdGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CampaignId != other.CampaignId) return false;
      if (AndroidPrivacyInteractionType != other.AndroidPrivacyInteractionType) return false;
      if (AndroidPrivacyInteractionDate != other.AndroidPrivacyInteractionDate) return false;
      if (AndroidPrivacyNetworkType != other.AndroidPrivacyNetworkType) return false;
      if (AdGroupId != other.AdGroupId) return false;
      if (SharedAdGroupKey != other.SharedAdGroupKey) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (CampaignId != 0L) hash ^= CampaignId.GetHashCode();
      if (AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) hash ^= AndroidPrivacyInteractionType.GetHashCode();
      if (AndroidPrivacyInteractionDate.Length != 0) hash ^= AndroidPrivacyInteractionDate.GetHashCode();
      if (AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) hash ^= AndroidPrivacyNetworkType.GetHashCode();
      if (AdGroupId != 0L) hash ^= AdGroupId.GetHashCode();
      if (SharedAdGroupKey.Length != 0) hash ^= SharedAdGroupKey.GetHashCode();
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
      if (CampaignId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CampaignId);
      }
      if (AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AndroidPrivacyInteractionType);
      }
      if (AndroidPrivacyInteractionDate.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AndroidPrivacyInteractionDate);
      }
      if (AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) AndroidPrivacyNetworkType);
      }
      if (AdGroupId != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(AdGroupId);
      }
      if (SharedAdGroupKey.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(SharedAdGroupKey);
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
      if (CampaignId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CampaignId);
      }
      if (AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AndroidPrivacyInteractionType);
      }
      if (AndroidPrivacyInteractionDate.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AndroidPrivacyInteractionDate);
      }
      if (AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) AndroidPrivacyNetworkType);
      }
      if (AdGroupId != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(AdGroupId);
      }
      if (SharedAdGroupKey.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(SharedAdGroupKey);
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
      if (CampaignId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CampaignId);
      }
      if (AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AndroidPrivacyInteractionType);
      }
      if (AndroidPrivacyInteractionDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AndroidPrivacyInteractionDate);
      }
      if (AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AndroidPrivacyNetworkType);
      }
      if (AdGroupId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AdGroupId);
      }
      if (SharedAdGroupKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SharedAdGroupKey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AndroidPrivacySharedKeyGoogleAdGroup other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.CampaignId != 0L) {
        CampaignId = other.CampaignId;
      }
      if (other.AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) {
        AndroidPrivacyInteractionType = other.AndroidPrivacyInteractionType;
      }
      if (other.AndroidPrivacyInteractionDate.Length != 0) {
        AndroidPrivacyInteractionDate = other.AndroidPrivacyInteractionDate;
      }
      if (other.AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) {
        AndroidPrivacyNetworkType = other.AndroidPrivacyNetworkType;
      }
      if (other.AdGroupId != 0L) {
        AdGroupId = other.AdGroupId;
      }
      if (other.SharedAdGroupKey.Length != 0) {
        SharedAdGroupKey = other.SharedAdGroupKey;
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
          case 16: {
            CampaignId = input.ReadInt64();
            break;
          }
          case 24: {
            AndroidPrivacyInteractionType = (global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType) input.ReadEnum();
            break;
          }
          case 34: {
            AndroidPrivacyInteractionDate = input.ReadString();
            break;
          }
          case 40: {
            AndroidPrivacyNetworkType = (global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType) input.ReadEnum();
            break;
          }
          case 48: {
            AdGroupId = input.ReadInt64();
            break;
          }
          case 58: {
            SharedAdGroupKey = input.ReadString();
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
          case 16: {
            CampaignId = input.ReadInt64();
            break;
          }
          case 24: {
            AndroidPrivacyInteractionType = (global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType) input.ReadEnum();
            break;
          }
          case 34: {
            AndroidPrivacyInteractionDate = input.ReadString();
            break;
          }
          case 40: {
            AndroidPrivacyNetworkType = (global::Google.Ads.GoogleAds.V16.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType) input.ReadEnum();
            break;
          }
          case 48: {
            AdGroupId = input.ReadInt64();
            break;
          }
          case 58: {
            SharedAdGroupKey = input.ReadString();
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
