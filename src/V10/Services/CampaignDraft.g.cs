// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/campaign_draft.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/campaign_draft.proto</summary>
  public static partial class CampaignDraftReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/campaign_draft.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignDraftReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL2NhbXBhaWdu",
            "X2RyYWZ0LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTAucmVzb3Vy",
            "Y2VzGjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvY2FtcGFpZ25f",
            "ZHJhZnRfc3RhdHVzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnBy",
            "b3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvIq4FCg1DYW1wYWlnbkRyYWZ0EkUKDXJlc291",
            "cmNlX25hbWUYASABKAlCLuBBBfpBKAomZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0NhbXBhaWduRHJhZnQSGgoIZHJhZnRfaWQYCSABKANCA+BBA0gAiAEB",
            "EkUKDWJhc2VfY2FtcGFpZ24YCiABKAlCKeBBBfpBIwohZ29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tL0NhbXBhaWduSAGIAQESEQoEbmFtZRgLIAEoCUgCiAEB",
            "EkYKDmRyYWZ0X2NhbXBhaWduGAwgASgJQingQQP6QSMKIWdvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9DYW1wYWlnbkgDiAEBEmAKBnN0YXR1cxgGIAEoDjJL",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5lbnVtcy5DYW1wYWlnbkRyYWZ0",
            "U3RhdHVzRW51bS5DYW1wYWlnbkRyYWZ0U3RhdHVzQgPgQQMSKAoWaGFzX2V4",
            "cGVyaW1lbnRfcnVubmluZxgNIAEoCEID4EEDSASIAQESKAoWbG9uZ19ydW5u",
            "aW5nX29wZXJhdGlvbhgOIAEoCUID4EEDSAWIAQE6cepBbgomZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL0NhbXBhaWduRHJhZnQSRGN1c3RvbWVycy97Y3Vz",
            "dG9tZXJfaWR9L2NhbXBhaWduRHJhZnRzL3tiYXNlX2NhbXBhaWduX2lkfX57",
            "ZHJhZnRfaWR9QgsKCV9kcmFmdF9pZEIQCg5fYmFzZV9jYW1wYWlnbkIHCgVf",
            "bmFtZUIRCg9fZHJhZnRfY2FtcGFpZ25CGQoXX2hhc19leHBlcmltZW50X3J1",
            "bm5pbmdCGQoXX2xvbmdfcnVubmluZ19vcGVyYXRpb25ChAIKJmNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MTAucmVzb3VyY2VzQhJDYW1wYWlnbkRyYWZ0",
            "UHJvdG9QAVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3YxMC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FB",
            "qgIiR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEwLlJlc291cmNlc8oCIkdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYxMFxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMTA6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.CampaignDraft), global::Google.Ads.GoogleAds.V10.Resources.CampaignDraft.Parser, new[]{ "ResourceName", "DraftId", "BaseCampaign", "Name", "DraftCampaign", "Status", "HasExperimentRunning", "LongRunningOperation" }, new[]{ "DraftId", "BaseCampaign", "Name", "DraftCampaign", "HasExperimentRunning", "LongRunningOperation" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A campaign draft.
  /// </summary>
  public sealed partial class CampaignDraft : pb::IMessage<CampaignDraft>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignDraft> _parser = new pb::MessageParser<CampaignDraft>(() => new CampaignDraft());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignDraft> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.CampaignDraftReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignDraft() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignDraft(CampaignDraft other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      draftId_ = other.draftId_;
      baseCampaign_ = other.baseCampaign_;
      name_ = other.name_;
      draftCampaign_ = other.draftCampaign_;
      status_ = other.status_;
      hasExperimentRunning_ = other.hasExperimentRunning_;
      longRunningOperation_ = other.longRunningOperation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignDraft Clone() {
      return new CampaignDraft(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign draft.
    /// Campaign draft resource names have the form:
    ///
    /// `customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "draft_id" field.</summary>
    public const int DraftIdFieldNumber = 9;
    private long draftId_;
    /// <summary>
    /// Output only. The ID of the draft.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long DraftId {
      get { if ((_hasBits0 & 1) != 0) { return draftId_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        draftId_ = value;
      }
    }
    /// <summary>Gets whether the "draft_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDraftId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "draft_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDraftId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "base_campaign" field.</summary>
    public const int BaseCampaignFieldNumber = 10;
    private string baseCampaign_;
    /// <summary>
    /// Immutable. The base campaign to which the draft belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BaseCampaign {
      get { return baseCampaign_ ?? ""; }
      set {
        baseCampaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "base_campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBaseCampaign {
      get { return baseCampaign_ != null; }
    }
    /// <summary>Clears the value of the "base_campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBaseCampaign() {
      baseCampaign_ = null;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 11;
    private string name_;
    /// <summary>
    /// The name of the campaign draft.
    ///
    /// This field is required and should not be empty when creating new
    /// campaign drafts.
    ///
    /// It must not contain any null (code point 0x0), NL line feed
    /// (code point 0xA) or carriage return (code point 0xD) characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "draft_campaign" field.</summary>
    public const int DraftCampaignFieldNumber = 12;
    private string draftCampaign_;
    /// <summary>
    /// Output only. Resource name of the Campaign that results from overlaying the draft
    /// changes onto the base campaign.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DraftCampaign {
      get { return draftCampaign_ ?? ""; }
      set {
        draftCampaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "draft_campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDraftCampaign {
      get { return draftCampaign_ != null; }
    }
    /// <summary>Clears the value of the "draft_campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDraftCampaign() {
      draftCampaign_ = null;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus status_ = global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the campaign draft. This field is read-only.
    ///
    /// When a new campaign draft is added, the status defaults to PROPOSED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "has_experiment_running" field.</summary>
    public const int HasExperimentRunningFieldNumber = 13;
    private bool hasExperimentRunning_;
    /// <summary>
    /// Output only. Whether there is an experiment based on this draft currently serving.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasExperimentRunning {
      get { if ((_hasBits0 & 2) != 0) { return hasExperimentRunning_; } else { return false; } }
      set {
        _hasBits0 |= 2;
        hasExperimentRunning_ = value;
      }
    }
    /// <summary>Gets whether the "has_experiment_running" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHasExperimentRunning {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "has_experiment_running" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHasExperimentRunning() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "long_running_operation" field.</summary>
    public const int LongRunningOperationFieldNumber = 14;
    private string longRunningOperation_;
    /// <summary>
    /// Output only. The resource name of the long-running operation that can be used to poll
    /// for completion of draft promotion. This is only set if the draft promotion
    /// is in progress or finished.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LongRunningOperation {
      get { return longRunningOperation_ ?? ""; }
      set {
        longRunningOperation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "long_running_operation" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLongRunningOperation {
      get { return longRunningOperation_ != null; }
    }
    /// <summary>Clears the value of the "long_running_operation" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLongRunningOperation() {
      longRunningOperation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignDraft);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignDraft other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (DraftId != other.DraftId) return false;
      if (BaseCampaign != other.BaseCampaign) return false;
      if (Name != other.Name) return false;
      if (DraftCampaign != other.DraftCampaign) return false;
      if (Status != other.Status) return false;
      if (HasExperimentRunning != other.HasExperimentRunning) return false;
      if (LongRunningOperation != other.LongRunningOperation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasDraftId) hash ^= DraftId.GetHashCode();
      if (HasBaseCampaign) hash ^= BaseCampaign.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (HasDraftCampaign) hash ^= DraftCampaign.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus.Unspecified) hash ^= Status.GetHashCode();
      if (HasHasExperimentRunning) hash ^= HasExperimentRunning.GetHashCode();
      if (HasLongRunningOperation) hash ^= LongRunningOperation.GetHashCode();
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
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (HasDraftId) {
        output.WriteRawTag(72);
        output.WriteInt64(DraftId);
      }
      if (HasBaseCampaign) {
        output.WriteRawTag(82);
        output.WriteString(BaseCampaign);
      }
      if (HasName) {
        output.WriteRawTag(90);
        output.WriteString(Name);
      }
      if (HasDraftCampaign) {
        output.WriteRawTag(98);
        output.WriteString(DraftCampaign);
      }
      if (HasHasExperimentRunning) {
        output.WriteRawTag(104);
        output.WriteBool(HasExperimentRunning);
      }
      if (HasLongRunningOperation) {
        output.WriteRawTag(114);
        output.WriteString(LongRunningOperation);
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
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (HasDraftId) {
        output.WriteRawTag(72);
        output.WriteInt64(DraftId);
      }
      if (HasBaseCampaign) {
        output.WriteRawTag(82);
        output.WriteString(BaseCampaign);
      }
      if (HasName) {
        output.WriteRawTag(90);
        output.WriteString(Name);
      }
      if (HasDraftCampaign) {
        output.WriteRawTag(98);
        output.WriteString(DraftCampaign);
      }
      if (HasHasExperimentRunning) {
        output.WriteRawTag(104);
        output.WriteBool(HasExperimentRunning);
      }
      if (HasLongRunningOperation) {
        output.WriteRawTag(114);
        output.WriteString(LongRunningOperation);
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
      if (HasDraftId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DraftId);
      }
      if (HasBaseCampaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BaseCampaign);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasDraftCampaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DraftCampaign);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (HasHasExperimentRunning) {
        size += 1 + 1;
      }
      if (HasLongRunningOperation) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LongRunningOperation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignDraft other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasDraftId) {
        DraftId = other.DraftId;
      }
      if (other.HasBaseCampaign) {
        BaseCampaign = other.BaseCampaign;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasDraftCampaign) {
        DraftCampaign = other.DraftCampaign;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.HasHasExperimentRunning) {
        HasExperimentRunning = other.HasExperimentRunning;
      }
      if (other.HasLongRunningOperation) {
        LongRunningOperation = other.LongRunningOperation;
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
          case 48: {
            Status = (global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus) input.ReadEnum();
            break;
          }
          case 72: {
            DraftId = input.ReadInt64();
            break;
          }
          case 82: {
            BaseCampaign = input.ReadString();
            break;
          }
          case 90: {
            Name = input.ReadString();
            break;
          }
          case 98: {
            DraftCampaign = input.ReadString();
            break;
          }
          case 104: {
            HasExperimentRunning = input.ReadBool();
            break;
          }
          case 114: {
            LongRunningOperation = input.ReadString();
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
          case 48: {
            Status = (global::Google.Ads.GoogleAds.V10.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus) input.ReadEnum();
            break;
          }
          case 72: {
            DraftId = input.ReadInt64();
            break;
          }
          case 82: {
            BaseCampaign = input.ReadString();
            break;
          }
          case 90: {
            Name = input.ReadString();
            break;
          }
          case 98: {
            DraftCampaign = input.ReadString();
            break;
          }
          case 104: {
            HasExperimentRunning = input.ReadBool();
            break;
          }
          case 114: {
            LongRunningOperation = input.ReadString();
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