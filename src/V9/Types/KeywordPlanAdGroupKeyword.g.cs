// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/keyword_plan_ad_group_keyword.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/keyword_plan_ad_group_keyword.proto</summary>
  public static partial class KeywordPlanAdGroupKeywordReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/keyword_plan_ad_group_keyword.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanAdGroupKeywordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMva2V5d29yZF9w",
            "bGFuX2FkX2dyb3VwX2tleXdvcmQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY5LnJlc291cmNlcxo2Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjkvZW51",
            "bXMva2V5d29yZF9tYXRjaF90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItwEChlLZXl3b3JkUGxhbkFk",
            "R3JvdXBLZXl3b3JkElEKDXJlc291cmNlX25hbWUYASABKAlCOuBBBfpBNAoy",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0tleXdvcmRQbGFuQWRHcm91cEtl",
            "eXdvcmQSVAoVa2V5d29yZF9wbGFuX2FkX2dyb3VwGAggASgJQjD6QS0KK2dv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9LZXl3b3JkUGxhbkFkR3JvdXBIAIgB",
            "ARIUCgJpZBgJIAEoA0ID4EEDSAGIAQESEQoEdGV4dBgKIAEoCUgCiAEBElgK",
            "Cm1hdGNoX3R5cGUYBSABKA4yRC5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5l",
            "bnVtcy5LZXl3b3JkTWF0Y2hUeXBlRW51bS5LZXl3b3JkTWF0Y2hUeXBlEhsK",
            "DmNwY19iaWRfbWljcm9zGAsgASgDSAOIAQESGgoIbmVnYXRpdmUYDCABKAhC",
            "A+BBBUgEiAEBOo8B6kGLAQoyZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0tl",
            "eXdvcmRQbGFuQWRHcm91cEtleXdvcmQSVWN1c3RvbWVycy97Y3VzdG9tZXJf",
            "aWR9L2tleXdvcmRQbGFuQWRHcm91cEtleXdvcmRzL3trZXl3b3JkX3BsYW5f",
            "YWRfZ3JvdXBfa2V5d29yZF9pZH1CGAoWX2tleXdvcmRfcGxhbl9hZF9ncm91",
            "cEIFCgNfaWRCBwoFX3RleHRCEQoPX2NwY19iaWRfbWljcm9zQgsKCV9uZWdh",
            "dGl2ZUKLAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnJlc291cmNl",
            "c0IeS2V5d29yZFBsYW5BZEdyb3VwS2V5d29yZFByb3RvUAFaSmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "OS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjkuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjlc",
            "UmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjk6OlJlc291",
            "cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.KeywordPlanAdGroupKeyword), global::Google.Ads.GoogleAds.V9.Resources.KeywordPlanAdGroupKeyword.Parser, new[]{ "ResourceName", "KeywordPlanAdGroup", "Id", "Text", "MatchType", "CpcBidMicros", "Negative" }, new[]{ "KeywordPlanAdGroup", "Id", "Text", "CpcBidMicros", "Negative" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Keyword Plan ad group keyword.
  /// Max number of keyword plan keywords per plan: 10000.
  /// </summary>
  public sealed partial class KeywordPlanAdGroupKeyword : pb::IMessage<KeywordPlanAdGroupKeyword>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordPlanAdGroupKeyword> _parser = new pb::MessageParser<KeywordPlanAdGroupKeyword>(() => new KeywordPlanAdGroupKeyword());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeywordPlanAdGroupKeyword> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.KeywordPlanAdGroupKeywordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanAdGroupKeyword() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanAdGroupKeyword(KeywordPlanAdGroupKeyword other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      keywordPlanAdGroup_ = other.keywordPlanAdGroup_;
      id_ = other.id_;
      text_ = other.text_;
      matchType_ = other.matchType_;
      cpcBidMicros_ = other.cpcBidMicros_;
      negative_ = other.negative_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanAdGroupKeyword Clone() {
      return new KeywordPlanAdGroupKeyword(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the Keyword Plan ad group keyword.
    /// KeywordPlanAdGroupKeyword resource names have the form:
    ///
    /// `customers/{customer_id}/keywordPlanAdGroupKeywords/{kp_ad_group_keyword_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "keyword_plan_ad_group" field.</summary>
    public const int KeywordPlanAdGroupFieldNumber = 8;
    private string keywordPlanAdGroup_;
    /// <summary>
    /// The Keyword Plan ad group to which this keyword belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string KeywordPlanAdGroup {
      get { return keywordPlanAdGroup_ ?? ""; }
      set {
        keywordPlanAdGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "keyword_plan_ad_group" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasKeywordPlanAdGroup {
      get { return keywordPlanAdGroup_ != null; }
    }
    /// <summary>Clears the value of the "keyword_plan_ad_group" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearKeywordPlanAdGroup() {
      keywordPlanAdGroup_ = null;
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 9;
    private long id_;
    /// <summary>
    /// Output only. The ID of the Keyword Plan keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 10;
    private string text_;
    /// <summary>
    /// The keyword text.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Text {
      get { return text_ ?? ""; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "text" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasText {
      get { return text_ != null; }
    }
    /// <summary>Clears the value of the "text" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearText() {
      text_ = null;
    }

    /// <summary>Field number for the "match_type" field.</summary>
    public const int MatchTypeFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType matchType_ = global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified;
    /// <summary>
    /// The keyword match type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType MatchType {
      get { return matchType_; }
      set {
        matchType_ = value;
      }
    }

    /// <summary>Field number for the "cpc_bid_micros" field.</summary>
    public const int CpcBidMicrosFieldNumber = 11;
    private long cpcBidMicros_;
    /// <summary>
    /// A keyword level max cpc bid in micros (e.g. $1 = 1mm). The currency is the
    /// same as the account currency code. This will override any CPC bid set at
    /// the keyword plan ad group level.
    /// Not applicable for negative keywords. (negative = true)
    /// This field is Optional.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CpcBidMicros {
      get { if ((_hasBits0 & 2) != 0) { return cpcBidMicros_; } else { return 0L; } }
      set {
        _hasBits0 |= 2;
        cpcBidMicros_ = value;
      }
    }
    /// <summary>Gets whether the "cpc_bid_micros" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCpcBidMicros {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "cpc_bid_micros" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCpcBidMicros() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "negative" field.</summary>
    public const int NegativeFieldNumber = 12;
    private bool negative_;
    /// <summary>
    /// Immutable. If true, the keyword is negative.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Negative {
      get { if ((_hasBits0 & 4) != 0) { return negative_; } else { return false; } }
      set {
        _hasBits0 |= 4;
        negative_ = value;
      }
    }
    /// <summary>Gets whether the "negative" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasNegative {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "negative" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearNegative() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanAdGroupKeyword);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeywordPlanAdGroupKeyword other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (KeywordPlanAdGroup != other.KeywordPlanAdGroup) return false;
      if (Id != other.Id) return false;
      if (Text != other.Text) return false;
      if (MatchType != other.MatchType) return false;
      if (CpcBidMicros != other.CpcBidMicros) return false;
      if (Negative != other.Negative) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasKeywordPlanAdGroup) hash ^= KeywordPlanAdGroup.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasText) hash ^= Text.GetHashCode();
      if (MatchType != global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) hash ^= MatchType.GetHashCode();
      if (HasCpcBidMicros) hash ^= CpcBidMicros.GetHashCode();
      if (HasNegative) hash ^= Negative.GetHashCode();
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
      if (MatchType != global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MatchType);
      }
      if (HasKeywordPlanAdGroup) {
        output.WriteRawTag(66);
        output.WriteString(KeywordPlanAdGroup);
      }
      if (HasId) {
        output.WriteRawTag(72);
        output.WriteInt64(Id);
      }
      if (HasText) {
        output.WriteRawTag(82);
        output.WriteString(Text);
      }
      if (HasCpcBidMicros) {
        output.WriteRawTag(88);
        output.WriteInt64(CpcBidMicros);
      }
      if (HasNegative) {
        output.WriteRawTag(96);
        output.WriteBool(Negative);
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
      if (MatchType != global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MatchType);
      }
      if (HasKeywordPlanAdGroup) {
        output.WriteRawTag(66);
        output.WriteString(KeywordPlanAdGroup);
      }
      if (HasId) {
        output.WriteRawTag(72);
        output.WriteInt64(Id);
      }
      if (HasText) {
        output.WriteRawTag(82);
        output.WriteString(Text);
      }
      if (HasCpcBidMicros) {
        output.WriteRawTag(88);
        output.WriteInt64(CpcBidMicros);
      }
      if (HasNegative) {
        output.WriteRawTag(96);
        output.WriteBool(Negative);
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
      if (HasKeywordPlanAdGroup) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KeywordPlanAdGroup);
      }
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasText) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (MatchType != global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (HasCpcBidMicros) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CpcBidMicros);
      }
      if (HasNegative) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KeywordPlanAdGroupKeyword other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasKeywordPlanAdGroup) {
        KeywordPlanAdGroup = other.KeywordPlanAdGroup;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasText) {
        Text = other.Text;
      }
      if (other.MatchType != global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) {
        MatchType = other.MatchType;
      }
      if (other.HasCpcBidMicros) {
        CpcBidMicros = other.CpcBidMicros;
      }
      if (other.HasNegative) {
        Negative = other.Negative;
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
          case 40: {
            MatchType = (global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType) input.ReadEnum();
            break;
          }
          case 66: {
            KeywordPlanAdGroup = input.ReadString();
            break;
          }
          case 72: {
            Id = input.ReadInt64();
            break;
          }
          case 82: {
            Text = input.ReadString();
            break;
          }
          case 88: {
            CpcBidMicros = input.ReadInt64();
            break;
          }
          case 96: {
            Negative = input.ReadBool();
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
          case 40: {
            MatchType = (global::Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType) input.ReadEnum();
            break;
          }
          case 66: {
            KeywordPlanAdGroup = input.ReadString();
            break;
          }
          case 72: {
            Id = input.ReadInt64();
            break;
          }
          case 82: {
            Text = input.ReadString();
            break;
          }
          case 88: {
            CpcBidMicros = input.ReadInt64();
            break;
          }
          case 96: {
            Negative = input.ReadBool();
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