// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/resources/campaign_shared_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/resources/campaign_shared_set.proto</summary>
  public static partial class CampaignSharedSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/resources/campaign_shared_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignSharedSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvcmVzb3VyY2VzL2NhbXBhaWdu",
            "X3NoYXJlZF9zZXQucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5y",
            "ZXNvdXJjZXMaP2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxNi9lbnVtcy9jYW1w",
            "YWlnbl9zaGFyZWRfc2V0X3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVs",
            "ZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byLm",
            "AwoRQ2FtcGFpZ25TaGFyZWRTZXQSSQoNcmVzb3VyY2VfbmFtZRgBIAEoCUIy",
            "4EEF+kEsCipnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFpZ25TaGFy",
            "ZWRTZXQSQAoIY2FtcGFpZ24YBSABKAlCKeBBBfpBIwohZ29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tL0NhbXBhaWduSACIAQESQwoKc2hhcmVkX3NldBgGIAEo",
            "CUIq4EEF+kEkCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vU2hhcmVkU2V0",
            "SAGIAQESaAoGc3RhdHVzGAIgASgOMlMuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djE2LmVudW1zLkNhbXBhaWduU2hhcmVkU2V0U3RhdHVzRW51bS5DYW1wYWln",
            "blNoYXJlZFNldFN0YXR1c0ID4EEDOnnqQXYKKmdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9DYW1wYWlnblNoYXJlZFNldBJIY3VzdG9tZXJzL3tjdXN0b21l",
            "cl9pZH0vY2FtcGFpZ25TaGFyZWRTZXRzL3tjYW1wYWlnbl9pZH1+e3NoYXJl",
            "ZF9zZXRfaWR9QgsKCV9jYW1wYWlnbkINCgtfc2hhcmVkX3NldEKIAgomY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5yZXNvdXJjZXNCFkNhbXBhaWdu",
            "U2hhcmVkU2V0UHJvdG9QAVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNi9yZXNvdXJjZXM7cmVzb3Vy",
            "Y2VzogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE2LlJlc291cmNl",
            "c8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNlxSZXNvdXJjZXPqAiZHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWMTY6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Resources.CampaignSharedSet), global::Google.Ads.GoogleAds.V16.Resources.CampaignSharedSet.Parser, new[]{ "ResourceName", "Campaign", "SharedSet", "Status" }, new[]{ "Campaign", "SharedSet" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CampaignSharedSets are used for managing the shared sets associated with a
  /// campaign.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CampaignSharedSet : pb::IMessage<CampaignSharedSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignSharedSet> _parser = new pb::MessageParser<CampaignSharedSet>(() => new CampaignSharedSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignSharedSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Resources.CampaignSharedSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSharedSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSharedSet(CampaignSharedSet other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      sharedSet_ = other.sharedSet_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSharedSet Clone() {
      return new CampaignSharedSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign shared set.
    /// Campaign shared set resource names have the form:
    ///
    /// `customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 5;
    private readonly static string CampaignDefaultValue = "";

    private string campaign_;
    /// <summary>
    /// Immutable. The campaign to which the campaign shared set belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_ ?? CampaignDefaultValue; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCampaign {
      get { return campaign_ != null; }
    }
    /// <summary>Clears the value of the "campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCampaign() {
      campaign_ = null;
    }

    /// <summary>Field number for the "shared_set" field.</summary>
    public const int SharedSetFieldNumber = 6;
    private readonly static string SharedSetDefaultValue = "";

    private string sharedSet_;
    /// <summary>
    /// Immutable. The shared set associated with the campaign. This may be a
    /// negative keyword shared set of another customer. This customer should be a
    /// manager of the other customer, otherwise the campaign shared set will exist
    /// but have no serving effect. Only negative keyword shared sets can be
    /// associated with Shopping campaigns. Only negative placement shared sets can
    /// be associated with Display mobile app campaigns.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SharedSet {
      get { return sharedSet_ ?? SharedSetDefaultValue; }
      set {
        sharedSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "shared_set" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSharedSet {
      get { return sharedSet_ != null; }
    }
    /// <summary>Clears the value of the "shared_set" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSharedSet() {
      sharedSet_ = null;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus status_ = global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified;
    /// <summary>
    /// Output only. The status of this campaign shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignSharedSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignSharedSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (SharedSet != other.SharedSet) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      if (HasSharedSet) hash ^= SharedSet.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (Status != global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (HasCampaign) {
        output.WriteRawTag(42);
        output.WriteString(Campaign);
      }
      if (HasSharedSet) {
        output.WriteRawTag(50);
        output.WriteString(SharedSet);
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
      if (Status != global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (HasCampaign) {
        output.WriteRawTag(42);
        output.WriteString(Campaign);
      }
      if (HasSharedSet) {
        output.WriteRawTag(50);
        output.WriteString(SharedSet);
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
      if (HasCampaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (HasSharedSet) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SharedSet);
      }
      if (Status != global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignSharedSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      if (other.HasSharedSet) {
        SharedSet = other.SharedSet;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) {
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
          case 16: {
            Status = (global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus) input.ReadEnum();
            break;
          }
          case 42: {
            Campaign = input.ReadString();
            break;
          }
          case 50: {
            SharedSet = input.ReadString();
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
            Status = (global::Google.Ads.GoogleAds.V16.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus) input.ReadEnum();
            break;
          }
          case 42: {
            Campaign = input.ReadString();
            break;
          }
          case 50: {
            SharedSet = input.ReadString();
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
