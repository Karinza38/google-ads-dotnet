// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/errors/authentication_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/errors/authentication_error.proto</summary>
  public static partial class AuthenticationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/errors/authentication_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthenticationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZXJyb3JzL2F1dGhlbnRpY2F0",
            "aW9uX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTYuZXJy",
            "b3JzIt4FChdBdXRoZW50aWNhdGlvbkVycm9yRW51bSLCBQoTQXV0aGVudGlj",
            "YXRpb25FcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIYChRB",
            "VVRIRU5USUNBVElPTl9FUlJPUhACEh4KGkNMSUVOVF9DVVNUT01FUl9JRF9J",
            "TlZBTElEEAUSFgoSQ1VTVE9NRVJfTk9UX0ZPVU5EEAgSGgoWR09PR0xFX0FD",
            "Q09VTlRfREVMRVRFRBAJEiEKHUdPT0dMRV9BQ0NPVU5UX0NPT0tJRV9JTlZB",
            "TElEEAoSKAokR09PR0xFX0FDQ09VTlRfQVVUSEVOVElDQVRJT05fRkFJTEVE",
            "EBkSLQopR09PR0xFX0FDQ09VTlRfVVNFUl9BTkRfQURTX1VTRVJfTUlTTUFU",
            "Q0gQDBIZChVMT0dJTl9DT09LSUVfUkVRVUlSRUQQDRIQCgxOT1RfQURTX1VT",
            "RVIQDhIXChNPQVVUSF9UT0tFTl9JTlZBTElEEA8SFwoTT0FVVEhfVE9LRU5f",
            "RVhQSVJFRBAQEhgKFE9BVVRIX1RPS0VOX0RJU0FCTEVEEBESFwoTT0FVVEhf",
            "VE9LRU5fUkVWT0tFRBASEh4KGk9BVVRIX1RPS0VOX0hFQURFUl9JTlZBTElE",
            "EBMSGAoUTE9HSU5fQ09PS0lFX0lOVkFMSUQQFBITCg9VU0VSX0lEX0lOVkFM",
            "SUQQFhImCiJUV09fU1RFUF9WRVJJRklDQVRJT05fTk9UX0VOUk9MTEVEEBcS",
            "JAogQURWQU5DRURfUFJPVEVDVElPTl9OT1RfRU5ST0xMRUQQGBIfChtPUkdB",
            "TklaQVRJT05fTk9UX1JFQ09HTklaRUQQGhIdChlPUkdBTklaQVRJT05fTk9U",
            "X0FQUFJPVkVEEBsSNAowT1JHQU5JWkFUSU9OX05PVF9BU1NPQ0lBVEVEX1dJ",
            "VEhfREVWRUxPUEVSX1RPS0VOEBxC+AEKI2NvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTYuZXJyb3JzQhhBdXRoZW50aWNhdGlvbkVycm9yUHJvdG9QAVpF",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3YxNi9lcnJvcnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjE2LkVycm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYx",
            "NlxFcnJvcnPqAiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTY6OkVycm9y",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Errors.AuthenticationErrorEnum), global::Google.Ads.GoogleAds.V16.Errors.AuthenticationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V16.Errors.AuthenticationErrorEnum.Types.AuthenticationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible authentication errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AuthenticationErrorEnum : pb::IMessage<AuthenticationErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AuthenticationErrorEnum> _parser = new pb::MessageParser<AuthenticationErrorEnum>(() => new AuthenticationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AuthenticationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Errors.AuthenticationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthenticationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthenticationErrorEnum(AuthenticationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthenticationErrorEnum Clone() {
      return new AuthenticationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AuthenticationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AuthenticationErrorEnum other) {
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
    public void MergeFrom(AuthenticationErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AuthenticationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible authentication errors.
      /// </summary>
      public enum AuthenticationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Authentication of the request failed.
        /// </summary>
        [pbr::OriginalName("AUTHENTICATION_ERROR")] AuthenticationError = 2,
        /// <summary>
        /// Client customer ID is not a number.
        /// </summary>
        [pbr::OriginalName("CLIENT_CUSTOMER_ID_INVALID")] ClientCustomerIdInvalid = 5,
        /// <summary>
        /// No customer found for the provided customer ID.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_FOUND")] CustomerNotFound = 8,
        /// <summary>
        /// Client's Google account is deleted.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ACCOUNT_DELETED")] GoogleAccountDeleted = 9,
        /// <summary>
        /// Google account login token in the cookie is invalid.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ACCOUNT_COOKIE_INVALID")] GoogleAccountCookieInvalid = 10,
        /// <summary>
        /// A problem occurred during Google account authentication.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ACCOUNT_AUTHENTICATION_FAILED")] GoogleAccountAuthenticationFailed = 25,
        /// <summary>
        /// The user in the Google account login token does not match the user ID in
        /// the cookie.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ACCOUNT_USER_AND_ADS_USER_MISMATCH")] GoogleAccountUserAndAdsUserMismatch = 12,
        /// <summary>
        /// Login cookie is required for authentication.
        /// </summary>
        [pbr::OriginalName("LOGIN_COOKIE_REQUIRED")] LoginCookieRequired = 13,
        /// <summary>
        /// The Google account that generated the OAuth access
        /// token is not associated with a Google Ads account. Create a new
        /// account, or add the Google account to an existing Google Ads account.
        /// </summary>
        [pbr::OriginalName("NOT_ADS_USER")] NotAdsUser = 14,
        /// <summary>
        /// OAuth token in the header is not valid.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_INVALID")] OauthTokenInvalid = 15,
        /// <summary>
        /// OAuth token in the header has expired.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_EXPIRED")] OauthTokenExpired = 16,
        /// <summary>
        /// OAuth token in the header has been disabled.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_DISABLED")] OauthTokenDisabled = 17,
        /// <summary>
        /// OAuth token in the header has been revoked.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_REVOKED")] OauthTokenRevoked = 18,
        /// <summary>
        /// OAuth token HTTP header is malformed.
        /// </summary>
        [pbr::OriginalName("OAUTH_TOKEN_HEADER_INVALID")] OauthTokenHeaderInvalid = 19,
        /// <summary>
        /// Login cookie is not valid.
        /// </summary>
        [pbr::OriginalName("LOGIN_COOKIE_INVALID")] LoginCookieInvalid = 20,
        /// <summary>
        /// User ID in the header is not a valid ID.
        /// </summary>
        [pbr::OriginalName("USER_ID_INVALID")] UserIdInvalid = 22,
        /// <summary>
        /// An account administrator changed this account's authentication settings.
        /// To access this Google Ads account, enable 2-Step Verification in your
        /// Google account at https://www.google.com/landing/2step.
        /// </summary>
        [pbr::OriginalName("TWO_STEP_VERIFICATION_NOT_ENROLLED")] TwoStepVerificationNotEnrolled = 23,
        /// <summary>
        /// An account administrator changed this account's authentication settings.
        /// To access this Google Ads account, enable Advanced Protection in your
        /// Google account at https://landing.google.com/advancedprotection.
        /// </summary>
        [pbr::OriginalName("ADVANCED_PROTECTION_NOT_ENROLLED")] AdvancedProtectionNotEnrolled = 24,
        /// <summary>
        /// The Cloud organization associated with the project is not recognized.
        /// </summary>
        [pbr::OriginalName("ORGANIZATION_NOT_RECOGNIZED")] OrganizationNotRecognized = 26,
        /// <summary>
        /// The Cloud organization associated with the project is not approved for
        /// prod access.
        /// </summary>
        [pbr::OriginalName("ORGANIZATION_NOT_APPROVED")] OrganizationNotApproved = 27,
        /// <summary>
        /// The Cloud organization associated with the project is not associated with
        /// the developer token.
        /// </summary>
        [pbr::OriginalName("ORGANIZATION_NOT_ASSOCIATED_WITH_DEVELOPER_TOKEN")] OrganizationNotAssociatedWithDeveloperToken = 28,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
