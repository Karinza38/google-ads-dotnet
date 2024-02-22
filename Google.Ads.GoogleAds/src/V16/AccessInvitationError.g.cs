// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/errors/access_invitation_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/errors/access_invitation_error.proto</summary>
  public static partial class AccessInvitationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/errors/access_invitation_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccessInvitationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZXJyb3JzL2FjY2Vzc19pbnZp",
            "dGF0aW9uX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTYu",
            "ZXJyb3JzIvMCChlBY2Nlc3NJbnZpdGF0aW9uRXJyb3JFbnVtItUCChVBY2Nl",
            "c3NJbnZpdGF0aW9uRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESGQoVSU5WQUxJRF9FTUFJTF9BRERSRVNTEAISJAogRU1BSUxfQUREUkVT",
            "U19BTFJFQURZX0hBU19BQ0NFU1MQAxIdChlJTlZBTElEX0lOVklUQVRJT05f",
            "U1RBVFVTEAQSJwojR09PR0xFX0NPTlNVTUVSX0FDQ09VTlRfTk9UX0FMTE9X",
            "RUQQBRIZChVJTlZBTElEX0lOVklUQVRJT05fSUQQBhIwCixFTUFJTF9BRERS",
            "RVNTX0FMUkVBRFlfSEFTX1BFTkRJTkdfSU5WSVRBVElPThAHEiYKIlBFTkRJ",
            "TkdfSU5WSVRBVElPTlNfTElNSVRfRVhDRUVERUQQCBIgChxFTUFJTF9ET01B",
            "SU5fUE9MSUNZX1ZJT0xBVEVEEAlC+gEKI2NvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTYuZXJyb3JzQhpBY2Nlc3NJbnZpdGF0aW9uRXJyb3JQcm90b1AB",
            "WkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjE2L2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMTYuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjE2XEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNjo6RXJy",
            "b3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Errors.AccessInvitationErrorEnum), global::Google.Ads.GoogleAds.V16.Errors.AccessInvitationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V16.Errors.AccessInvitationErrorEnum.Types.AccessInvitationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible AccessInvitation errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AccessInvitationErrorEnum : pb::IMessage<AccessInvitationErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccessInvitationErrorEnum> _parser = new pb::MessageParser<AccessInvitationErrorEnum>(() => new AccessInvitationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccessInvitationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Errors.AccessInvitationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccessInvitationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccessInvitationErrorEnum(AccessInvitationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccessInvitationErrorEnum Clone() {
      return new AccessInvitationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccessInvitationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccessInvitationErrorEnum other) {
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
    public void MergeFrom(AccessInvitationErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AccessInvitationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible AccessInvitation errors.
      /// </summary>
      public enum AccessInvitationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The email address is invalid for sending an invitation.
        /// </summary>
        [pbr::OriginalName("INVALID_EMAIL_ADDRESS")] InvalidEmailAddress = 2,
        /// <summary>
        /// Email address already has access to this customer.
        /// </summary>
        [pbr::OriginalName("EMAIL_ADDRESS_ALREADY_HAS_ACCESS")] EmailAddressAlreadyHasAccess = 3,
        /// <summary>
        /// Invalid invitation status for the operation.
        /// </summary>
        [pbr::OriginalName("INVALID_INVITATION_STATUS")] InvalidInvitationStatus = 4,
        /// <summary>
        /// Email address cannot be like abc+foo@google.com.
        /// </summary>
        [pbr::OriginalName("GOOGLE_CONSUMER_ACCOUNT_NOT_ALLOWED")] GoogleConsumerAccountNotAllowed = 5,
        /// <summary>
        /// Invalid invitation ID.
        /// </summary>
        [pbr::OriginalName("INVALID_INVITATION_ID")] InvalidInvitationId = 6,
        /// <summary>
        /// Email address already has a pending invitation.
        /// </summary>
        [pbr::OriginalName("EMAIL_ADDRESS_ALREADY_HAS_PENDING_INVITATION")] EmailAddressAlreadyHasPendingInvitation = 7,
        /// <summary>
        /// Pending invitation limit exceeded for the customer.
        /// </summary>
        [pbr::OriginalName("PENDING_INVITATIONS_LIMIT_EXCEEDED")] PendingInvitationsLimitExceeded = 8,
        /// <summary>
        /// Email address doesn't conform to the email domain policy. See
        /// https://support.google.com/google-ads/answer/2375456
        /// </summary>
        [pbr::OriginalName("EMAIL_DOMAIN_POLICY_VIOLATED")] EmailDomainPolicyViolated = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
