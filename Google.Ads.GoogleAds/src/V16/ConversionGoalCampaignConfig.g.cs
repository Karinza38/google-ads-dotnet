// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/resources/conversion_goal_campaign_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/resources/conversion_goal_campaign_config.proto</summary>
  public static partial class ConversionGoalCampaignConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/resources/conversion_goal_campaign_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionGoalCampaignConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvcmVzb3VyY2VzL2NvbnZlcnNp",
            "b25fZ29hbF9jYW1wYWlnbl9jb25maWcucHJvdG8SImdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxNi5yZXNvdXJjZXMaNmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Yx",
            "Ni9lbnVtcy9nb2FsX2NvbmZpZ19sZXZlbC5wcm90bxofZ29vZ2xlL2FwaS9m",
            "aWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90",
            "byLmAwocQ29udmVyc2lvbkdvYWxDYW1wYWlnbkNvbmZpZxJUCg1yZXNvdXJj",
            "ZV9uYW1lGAEgASgJQj3gQQX6QTcKNWdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9Db252ZXJzaW9uR29hbENhbXBhaWduQ29uZmlnEjsKCGNhbXBhaWduGAIg",
            "ASgJQingQQX6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWln",
            "bhJeChFnb2FsX2NvbmZpZ19sZXZlbBgDIAEoDjJDLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxNi5lbnVtcy5Hb2FsQ29uZmlnTGV2ZWxFbnVtLkdvYWxDb25m",
            "aWdMZXZlbBJSChZjdXN0b21fY29udmVyc2lvbl9nb2FsGAQgASgJQjL6QS8K",
            "LWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21Db252ZXJzaW9uR29h",
            "bDp/6kF8CjVnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ29udmVyc2lvbkdv",
            "YWxDYW1wYWlnbkNvbmZpZxJDY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0vY29u",
            "dmVyc2lvbkdvYWxDYW1wYWlnbkNvbmZpZ3Mve2NhbXBhaWduX2lkfUKTAgom",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5yZXNvdXJjZXNCIUNvbnZl",
            "cnNpb25Hb2FsQ2FtcGFpZ25Db25maWdQcm90b1ABWktnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE2L3Jl",
            "c291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WMTYuUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE2XFJl",
            "c291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNjo6UmVzb3Vy",
            "Y2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Resources.ConversionGoalCampaignConfig), global::Google.Ads.GoogleAds.V16.Resources.ConversionGoalCampaignConfig.Parser, new[]{ "ResourceName", "Campaign", "GoalConfigLevel", "CustomConversionGoal" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Conversion goal settings for a Campaign.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ConversionGoalCampaignConfig : pb::IMessage<ConversionGoalCampaignConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionGoalCampaignConfig> _parser = new pb::MessageParser<ConversionGoalCampaignConfig>(() => new ConversionGoalCampaignConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionGoalCampaignConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Resources.ConversionGoalCampaignConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionGoalCampaignConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionGoalCampaignConfig(ConversionGoalCampaignConfig other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      goalConfigLevel_ = other.goalConfigLevel_;
      customConversionGoal_ = other.customConversionGoal_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionGoalCampaignConfig Clone() {
      return new ConversionGoalCampaignConfig(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the conversion goal campaign config.
    /// Conversion goal campaign config resource names have the form:
    ///
    /// `customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}`
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
    public const int CampaignFieldNumber = 2;
    private string campaign_ = "";
    /// <summary>
    /// Immutable. The campaign with which this conversion goal campaign config is
    /// associated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "goal_config_level" field.</summary>
    public const int GoalConfigLevelFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel goalConfigLevel_ = global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel.Unspecified;
    /// <summary>
    /// The level of goal config the campaign is using.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel GoalConfigLevel {
      get { return goalConfigLevel_; }
      set {
        goalConfigLevel_ = value;
      }
    }

    /// <summary>Field number for the "custom_conversion_goal" field.</summary>
    public const int CustomConversionGoalFieldNumber = 4;
    private string customConversionGoal_ = "";
    /// <summary>
    /// The custom conversion goal the campaign is using for optimization.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomConversionGoal {
      get { return customConversionGoal_; }
      set {
        customConversionGoal_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionGoalCampaignConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionGoalCampaignConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (GoalConfigLevel != other.GoalConfigLevel) return false;
      if (CustomConversionGoal != other.CustomConversionGoal) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (GoalConfigLevel != global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel.Unspecified) hash ^= GoalConfigLevel.GetHashCode();
      if (CustomConversionGoal.Length != 0) hash ^= CustomConversionGoal.GetHashCode();
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
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (GoalConfigLevel != global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) GoalConfigLevel);
      }
      if (CustomConversionGoal.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CustomConversionGoal);
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
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (GoalConfigLevel != global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) GoalConfigLevel);
      }
      if (CustomConversionGoal.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CustomConversionGoal);
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
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (GoalConfigLevel != global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GoalConfigLevel);
      }
      if (CustomConversionGoal.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomConversionGoal);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConversionGoalCampaignConfig other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.GoalConfigLevel != global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel.Unspecified) {
        GoalConfigLevel = other.GoalConfigLevel;
      }
      if (other.CustomConversionGoal.Length != 0) {
        CustomConversionGoal = other.CustomConversionGoal;
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
            Campaign = input.ReadString();
            break;
          }
          case 24: {
            GoalConfigLevel = (global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel) input.ReadEnum();
            break;
          }
          case 34: {
            CustomConversionGoal = input.ReadString();
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
            Campaign = input.ReadString();
            break;
          }
          case 24: {
            GoalConfigLevel = (global::Google.Ads.GoogleAds.V16.Enums.GoalConfigLevelEnum.Types.GoalConfigLevel) input.ReadEnum();
            break;
          }
          case 34: {
            CustomConversionGoal = input.ReadString();
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
