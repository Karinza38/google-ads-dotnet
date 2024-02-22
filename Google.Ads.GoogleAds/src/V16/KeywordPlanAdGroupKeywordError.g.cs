// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/errors/keyword_plan_ad_group_keyword_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/errors/keyword_plan_ad_group_keyword_error.proto</summary>
  public static partial class KeywordPlanAdGroupKeywordErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/errors/keyword_plan_ad_group_keyword_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanAdGroupKeywordErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZXJyb3JzL2tleXdvcmRfcGxh",
            "bl9hZF9ncm91cF9rZXl3b3JkX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTYuZXJyb3JzItQCCiJLZXl3b3JkUGxhbkFkR3JvdXBLZXl3",
            "b3JkRXJyb3JFbnVtIq0CCh5LZXl3b3JkUGxhbkFkR3JvdXBLZXl3b3JkRXJy",
            "b3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESHgoaSU5WQUxJRF9L",
            "RVlXT1JEX01BVENIX1RZUEUQAhIVChFEVVBMSUNBVEVfS0VZV09SRBADEhkK",
            "FUtFWVdPUkRfVEVYVF9UT09fTE9ORxAEEh0KGUtFWVdPUkRfSEFTX0lOVkFM",
            "SURfQ0hBUlMQBRIeChpLRVlXT1JEX0hBU19UT09fTUFOWV9XT1JEUxAGEhgK",
            "FElOVkFMSURfS0VZV09SRF9URVhUEAcSIAocTkVHQVRJVkVfS0VZV09SRF9I",
            "QVNfQ1BDX0JJRBAIEiAKHE5FV19CTU1fS0VZV09SRFNfTk9UX0FMTE9XRUQQ",
            "CUKDAgojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNi5lcnJvcnNCI0tl",
            "eXdvcmRQbGFuQWRHcm91cEtleXdvcmRFcnJvclByb3RvUAFaRWdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MTYvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYxNi5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTZcRXJyb3Jz",
            "6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE2OjpFcnJvcnNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Errors.KeywordPlanAdGroupKeywordErrorEnum), global::Google.Ads.GoogleAds.V16.Errors.KeywordPlanAdGroupKeywordErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V16.Errors.KeywordPlanAdGroupKeywordErrorEnum.Types.KeywordPlanAdGroupKeywordError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible errors from applying an ad group
  /// keyword or a campaign keyword from a keyword plan.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KeywordPlanAdGroupKeywordErrorEnum : pb::IMessage<KeywordPlanAdGroupKeywordErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordPlanAdGroupKeywordErrorEnum> _parser = new pb::MessageParser<KeywordPlanAdGroupKeywordErrorEnum>(() => new KeywordPlanAdGroupKeywordErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeywordPlanAdGroupKeywordErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Errors.KeywordPlanAdGroupKeywordErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanAdGroupKeywordErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanAdGroupKeywordErrorEnum(KeywordPlanAdGroupKeywordErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanAdGroupKeywordErrorEnum Clone() {
      return new KeywordPlanAdGroupKeywordErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanAdGroupKeywordErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeywordPlanAdGroupKeywordErrorEnum other) {
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
    public void MergeFrom(KeywordPlanAdGroupKeywordErrorEnum other) {
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
    /// <summary>Container for nested types declared in the KeywordPlanAdGroupKeywordErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible errors from applying a keyword plan ad group
      /// keyword or keyword plan campaign keyword.
      /// </summary>
      public enum KeywordPlanAdGroupKeywordError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A keyword or negative keyword has invalid match type.
        /// </summary>
        [pbr::OriginalName("INVALID_KEYWORD_MATCH_TYPE")] InvalidKeywordMatchType = 2,
        /// <summary>
        /// A keyword or negative keyword with same text and match type already
        /// exists.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_KEYWORD")] DuplicateKeyword = 3,
        /// <summary>
        /// Keyword or negative keyword text exceeds the allowed limit.
        /// </summary>
        [pbr::OriginalName("KEYWORD_TEXT_TOO_LONG")] KeywordTextTooLong = 4,
        /// <summary>
        /// Keyword or negative keyword text has invalid characters or symbols.
        /// </summary>
        [pbr::OriginalName("KEYWORD_HAS_INVALID_CHARS")] KeywordHasInvalidChars = 5,
        /// <summary>
        /// Keyword or negative keyword text has too many words.
        /// </summary>
        [pbr::OriginalName("KEYWORD_HAS_TOO_MANY_WORDS")] KeywordHasTooManyWords = 6,
        /// <summary>
        /// Keyword or negative keyword has invalid text.
        /// </summary>
        [pbr::OriginalName("INVALID_KEYWORD_TEXT")] InvalidKeywordText = 7,
        /// <summary>
        /// Cpc Bid set for negative keyword.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_KEYWORD_HAS_CPC_BID")] NegativeKeywordHasCpcBid = 8,
        /// <summary>
        /// New broad match modifier (BMM) KpAdGroupKeywords are not allowed.
        /// </summary>
        [pbr::OriginalName("NEW_BMM_KEYWORDS_NOT_ALLOWED")] NewBmmKeywordsNotAllowed = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
