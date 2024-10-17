// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/enums/sk_ad_network_attribution_credit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/enums/sk_ad_network_attribution_credit.proto</summary>
  public static partial class SkAdNetworkAttributionCreditReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/enums/sk_ad_network_attribution_credit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SkAdNetworkAttributionCreditReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvc2tfYWRfbmV0d29y",
            "a19hdHRyaWJ1dGlvbl9jcmVkaXQucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxOC5lbnVtcyKLAQogU2tBZE5ldHdvcmtBdHRyaWJ1dGlvbkNyZWRp",
            "dEVudW0iZwocU2tBZE5ldHdvcmtBdHRyaWJ1dGlvbkNyZWRpdBIPCgtVTlNQ",
            "RUNJRklFRBAAEgsKB1VOS05PV04QARIPCgtVTkFWQUlMQUJMRRACEgcKA1dP",
            "ThADEg8KC0NPTlRSSUJVVEVEEARC+wEKImNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTguZW51bXNCIVNrQWROZXR3b3JrQXR0cmlidXRpb25DcmVkaXRQ",
            "cm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjE4L2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xl",
            "LkFkcy5Hb29nbGVBZHMuVjE4LkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjE4XEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE4OjpF",
            "bnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Enums.SkAdNetworkAttributionCreditEnum), global::Google.Ads.GoogleAds.V18.Enums.SkAdNetworkAttributionCreditEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Enums.SkAdNetworkAttributionCreditEnum.Types.SkAdNetworkAttributionCredit) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of SkAdNetwork attribution credits.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SkAdNetworkAttributionCreditEnum : pb::IMessage<SkAdNetworkAttributionCreditEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SkAdNetworkAttributionCreditEnum> _parser = new pb::MessageParser<SkAdNetworkAttributionCreditEnum>(() => new SkAdNetworkAttributionCreditEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SkAdNetworkAttributionCreditEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Enums.SkAdNetworkAttributionCreditReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkAttributionCreditEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkAttributionCreditEnum(SkAdNetworkAttributionCreditEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkAttributionCreditEnum Clone() {
      return new SkAdNetworkAttributionCreditEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SkAdNetworkAttributionCreditEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SkAdNetworkAttributionCreditEnum other) {
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
    public void MergeFrom(SkAdNetworkAttributionCreditEnum other) {
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
    /// <summary>Container for nested types declared in the SkAdNetworkAttributionCreditEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumerates SkAdNetwork attribution credits.
      /// </summary>
      public enum SkAdNetworkAttributionCredit {
        /// <summary>
        /// Default value. This value is equivalent to null.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this API version. The true enum value cannot be
        /// returned in this API version or is not supported yet.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The value was not present in the postback or we do not have this data for
        /// other reasons.
        /// </summary>
        [pbr::OriginalName("UNAVAILABLE")] Unavailable = 2,
        /// <summary>
        /// Google was the ad network that won ad attribution.
        /// </summary>
        [pbr::OriginalName("WON")] Won = 3,
        /// <summary>
        /// Google qualified for attribution, but didn't win.
        /// </summary>
        [pbr::OriginalName("CONTRIBUTED")] Contributed = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
