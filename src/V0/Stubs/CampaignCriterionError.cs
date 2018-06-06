// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/campaign_criterion_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/campaign_criterion_error.proto</summary>
  public static partial class CampaignCriterionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/campaign_criterion_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCriterionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvY2FtcGFpZ25fY3Jp",
            "dGVyaW9uX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5l",
            "cnJvcnMizwMKGkNhbXBhaWduQ3JpdGVyaW9uRXJyb3JFbnVtIrADChZDYW1w",
            "YWlnbkNyaXRlcmlvbkVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEhoKFkNPTkNSRVRFX1RZUEVfUkVRVUlSRUQQAhIZChVJTlZBTElEX1BM",
            "QUNFTUVOVF9VUkwQAxIgChxDQU5OT1RfRVhDTFVERV9DUklURVJJQV9UWVBF",
            "EAQSJwojQ0FOTk9UX1NFVF9TVEFUVVNfRk9SX0NSSVRFUklBX1RZUEUQBRIr",
            "CidDQU5OT1RfU0VUX1NUQVRVU19GT1JfRVhDTFVERURfQ1JJVEVSSUEQBhId",
            "ChlDQU5OT1RfVEFSR0VUX0FORF9FWENMVURFEAcSFwoTVE9PX01BTllfT1BF",
            "UkFUSU9OUxAIEi0KKU9QRVJBVE9SX05PVF9TVVBQT1JURURfRk9SX0NSSVRF",
            "UklPTl9UWVBFEAkSQwo/U0hPUFBJTkdfQ0FNUEFJR05fU0FMRVNfQ09VTlRS",
            "WV9OT1RfU1VQUE9SVEVEX0ZPUl9TQUxFU19DSEFOTkVMEAoSHQoZQ0FOTk9U",
            "X0FERF9FWElTVElOR19GSUVMRBALQtEBCiJjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjAuZXJyb3JzQhtDYW1wYWlnbkNyaXRlcmlvbkVycm9yUHJvdG9Q",
            "AVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YwL2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMC5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MFxFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.CampaignCriterionErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.CampaignCriterionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.CampaignCriterionErrorEnum.Types.CampaignCriterionError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign criterion errors.
  /// </summary>
  public sealed partial class CampaignCriterionErrorEnum : pb::IMessage<CampaignCriterionErrorEnum> {
    private static readonly pb::MessageParser<CampaignCriterionErrorEnum> _parser = new pb::MessageParser<CampaignCriterionErrorEnum>(() => new CampaignCriterionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignCriterionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.CampaignCriterionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionErrorEnum(CampaignCriterionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionErrorEnum Clone() {
      return new CampaignCriterionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignCriterionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignCriterionErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignCriterionErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CampaignCriterionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign criterion errors.
      /// </summary>
      public enum CampaignCriterionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Concrete type of criterion (keyword v.s. placement) is required for
        /// CREATE and UPDATE operations.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 2,
        /// <summary>
        /// Invalid placement URL.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEMENT_URL")] InvalidPlacementUrl = 3,
        /// <summary>
        /// Criteria type can not be excluded for the campaign by the customer. like
        /// AOL account type cannot target site type criteria
        /// </summary>
        [pbr::OriginalName("CANNOT_EXCLUDE_CRITERIA_TYPE")] CannotExcludeCriteriaType = 4,
        /// <summary>
        /// Cannot set the campaign criterion status for this criteria type.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_STATUS_FOR_CRITERIA_TYPE")] CannotSetStatusForCriteriaType = 5,
        /// <summary>
        /// Cannot set the campaign criterion status for an excluded criteria.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_STATUS_FOR_EXCLUDED_CRITERIA")] CannotSetStatusForExcludedCriteria = 6,
        /// <summary>
        /// Cannot target and exclude the same criterion.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_AND_EXCLUDE")] CannotTargetAndExclude = 7,
        /// <summary>
        /// The mutate contained too many operations.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERATIONS")] TooManyOperations = 8,
        /// <summary>
        /// This operator cannot be applied to a criterion of this type.
        /// </summary>
        [pbr::OriginalName("OPERATOR_NOT_SUPPORTED_FOR_CRITERION_TYPE")] OperatorNotSupportedForCriterionType = 9,
        /// <summary>
        /// The Shopping campaign sales country is not supported for
        /// ProductSalesChannel targeting.
        /// </summary>
        [pbr::OriginalName("SHOPPING_CAMPAIGN_SALES_COUNTRY_NOT_SUPPORTED_FOR_SALES_CHANNEL")] ShoppingCampaignSalesCountryNotSupportedForSalesChannel = 10,
        /// <summary>
        /// The existing field can't be updated with CREATE operation. It can be
        /// updated with UPDATE operation only.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_EXISTING_FIELD")] CannotAddExistingField = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code