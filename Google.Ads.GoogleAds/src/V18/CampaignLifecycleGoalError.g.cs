// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/errors/campaign_lifecycle_goal_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/errors/campaign_lifecycle_goal_error.proto</summary>
  public static partial class CampaignLifecycleGoalErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/errors/campaign_lifecycle_goal_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignLifecycleGoalErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZXJyb3JzL2NhbXBhaWduX2xp",
            "ZmVjeWNsZV9nb2FsX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTguZXJyb3JzIrUECh5DYW1wYWlnbkxpZmVjeWNsZUdvYWxFcnJvckVu",
            "dW0ikgQKGkNhbXBhaWduTGlmZWN5Y2xlR29hbEVycm9yEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEhQKEENBTVBBSUdOX01JU1NJTkcQAhIUChBJ",
            "TlZBTElEX0NBTVBBSUdOEAMSMgouQ1VTVE9NRVJfQUNRVUlTSVRJT05fSU5W",
            "QUxJRF9PUFRJTUlaQVRJT05fTU9ERRAEEiEKHUlOQ09NUEFUSUJMRV9CSURE",
            "SU5HX1NUUkFURUdZEAUSGQoVTUlTU0lOR19QVVJDSEFTRV9HT0FMEAYSNAow",
            "Q1VTVE9NRVJfQUNRVUlTSVRJT05fSU5WQUxJRF9ISUdIX0xJRkVUSU1FX1ZB",
            "TFVFEAcSMgouQ1VTVE9NRVJfQUNRVUlTSVRJT05fVU5TVVBQT1JURURfQ0FN",
            "UEFJR05fVFlQRRAIEiYKIkNVU1RPTUVSX0FDUVVJU0lUSU9OX0lOVkFMSURf",
            "VkFMVUUQCRImCiJDVVNUT01FUl9BQ1FVSVNJVElPTl9WQUxVRV9NSVNTSU5H",
            "EAoSPQo5Q1VTVE9NRVJfQUNRVUlTSVRJT05fTUlTU0lOR19FWElTVElOR19D",
            "VVNUT01FUl9ERUZJTklUSU9OEAsSPwo7Q1VTVE9NRVJfQUNRVUlTSVRJT05f",
            "TUlTU0lOR19ISUdIX1ZBTFVFX0NVU1RPTUVSX0RFRklOSVRJT04QDEL/AQoj",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5lcnJvcnNCH0NhbXBhaWdu",
            "TGlmZWN5Y2xlR29hbEVycm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxOC9lcnJvcnM7",
            "ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE4LkVycm9y",
            "c8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxOFxFcnJvcnPqAiNHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWMTg6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Errors.CampaignLifecycleGoalErrorEnum), global::Google.Ads.GoogleAds.V18.Errors.CampaignLifecycleGoalErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Errors.CampaignLifecycleGoalErrorEnum.Types.CampaignLifecycleGoalError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign lifecycle goal errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CampaignLifecycleGoalErrorEnum : pb::IMessage<CampaignLifecycleGoalErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignLifecycleGoalErrorEnum> _parser = new pb::MessageParser<CampaignLifecycleGoalErrorEnum>(() => new CampaignLifecycleGoalErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignLifecycleGoalErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Errors.CampaignLifecycleGoalErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignLifecycleGoalErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignLifecycleGoalErrorEnum(CampaignLifecycleGoalErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignLifecycleGoalErrorEnum Clone() {
      return new CampaignLifecycleGoalErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignLifecycleGoalErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignLifecycleGoalErrorEnum other) {
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
    public void MergeFrom(CampaignLifecycleGoalErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignLifecycleGoalErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign lifecycle goal errors.
      /// </summary>
      public enum CampaignLifecycleGoalError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Campaign is not specified.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_MISSING")] CampaignMissing = 2,
        /// <summary>
        /// Cannot find the specified campaign.
        /// </summary>
        [pbr::OriginalName("INVALID_CAMPAIGN")] InvalidCampaign = 3,
        /// <summary>
        /// Optimization mode is unspecified or invalid.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ACQUISITION_INVALID_OPTIMIZATION_MODE")] CustomerAcquisitionInvalidOptimizationMode = 4,
        /// <summary>
        /// The configured lifecycle goal setting is not compatible with the bidding
        /// strategy the campaign is using. Specifically, BID_HIGHER_FOR_NEW_CUSTOMER
        /// requires conversion-value based bidding strategy type such as
        /// MAXIMIZE_CONVERSION_VALUE.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_BIDDING_STRATEGY")] IncompatibleBiddingStrategy = 5,
        /// <summary>
        /// Lifecycle goals require the campaign to optimize towards purchase
        /// conversion goal.
        /// </summary>
        [pbr::OriginalName("MISSING_PURCHASE_GOAL")] MissingPurchaseGoal = 6,
        /// <summary>
        /// CampaignLifecycleGoal.customer_acquisition_goal_settings.value_settings.high_lifetime_value
        /// is invalid or not allowed, such as when the specified value is smaller
        /// than 0.01, when the optimization mode is not BID_HIGHER_FOR_NEW_CUSTOMER,
        /// or when
        /// CampaignLifecycleGoal.customer_acquisition_goal_settings.value_settings.high_lifetime_value
        /// is specified smaller than/without
        /// CampaignLifecycleGoal.customer_acquisition_goal_settings.value_settings.value.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ACQUISITION_INVALID_HIGH_LIFETIME_VALUE")] CustomerAcquisitionInvalidHighLifetimeValue = 7,
        /// <summary>
        /// Customer acquisition goal is not supported on this campaign type.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ACQUISITION_UNSUPPORTED_CAMPAIGN_TYPE")] CustomerAcquisitionUnsupportedCampaignType = 8,
        /// <summary>
        /// CampaignLifecycleGoal.customer_acquisition_goal_settings.value_settings.value
        /// is invalid or not allowed, such as when the specified value is smaller
        /// than 0.01, or when the optimization mode is not
        /// BID_HIGHER_FOR_NEW_CUSTOMER.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ACQUISITION_INVALID_VALUE")] CustomerAcquisitionInvalidValue = 9,
        /// <summary>
        /// To use BID_HIGHER_FOR_NEW_CUSTOMER mode, either
        /// CampaignLifecycleGoal.customer_acquisition_goal_settings.value_settings.value
        /// or CustomerLifecycleGoal.customer_acquisition_goal_value_settings.value
        /// must have been specified. If a manager account is managing your account's
        /// conversion tracking, then only the CustomerLifecycleGoal of that manager
        /// account is used.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ACQUISITION_VALUE_MISSING")] CustomerAcquisitionValueMissing = 10,
        /// <summary>
        /// In order for a campaign to adopt the customer acquisition goal,
        /// CustomerLifecycleGoal.lifecycle_goal_customer_definition_settings.existing_user_lists
        /// must include active and accessible userlist with more than 1000 members
        /// in the Search/Youtube network. If a manager account is managing your
        /// account's conversion tracking, then only the CustomerLifecycleGoal of
        /// that manager account is used. Also make sure that the manager account
        /// shares audience segments with sub-accounts with continuous audience
        /// sharing.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ACQUISITION_MISSING_EXISTING_CUSTOMER_DEFINITION")] CustomerAcquisitionMissingExistingCustomerDefinition = 11,
        /// <summary>
        /// In order for a campaign to adopt the customer acquisition goal with high
        /// lifetime value optimization,
        /// CustomerLifecycleGoal.lifecycle_goal_customer_definition_settings.high_lifetime_value_user_lists
        /// must include active and accessible userlist with more than 1000 members
        /// in the Search/Youtube network. If a manager account is managing your
        /// account's conversion tracking, then only the CustomerLifecycleGoal of
        /// that manager account is used. Also make sure that the manager account
        /// shares audience segments with sub-accounts using continuous audience
        /// sharing.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ACQUISITION_MISSING_HIGH_VALUE_CUSTOMER_DEFINITION")] CustomerAcquisitionMissingHighValueCustomerDefinition = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
