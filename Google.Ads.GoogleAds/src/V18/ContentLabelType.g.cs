// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/enums/content_label_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/enums/content_label_type.proto</summary>
  public static partial class ContentLabelTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/enums/content_label_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContentLabelTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvY29udGVudF9sYWJl",
            "bF90eXBlLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTguZW51bXMi",
            "/wUKFENvbnRlbnRMYWJlbFR5cGVFbnVtIuYFChBDb250ZW50TGFiZWxUeXBl",
            "Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhcKE1NFWFVBTExZX1NV",
            "R0dFU1RJVkUQAhISCg5CRUxPV19USEVfRk9MRBADEhEKDVBBUktFRF9ET01B",
            "SU4QBBIMCghKVVZFTklMRRAGEg0KCVBST0ZBTklUWRAHEgsKB1RSQUdFRFkQ",
            "CBIJCgVWSURFTxAJEhUKEVZJREVPX1JBVElOR19EVl9HEAoSFgoSVklERU9f",
            "UkFUSU5HX0RWX1BHEAsSFQoRVklERU9fUkFUSU5HX0RWX1QQDBIWChJWSURF",
            "T19SQVRJTkdfRFZfTUEQDRIXChNWSURFT19OT1RfWUVUX1JBVEVEEA4SEgoO",
            "RU1CRURERURfVklERU8QDxIYChRMSVZFX1NUUkVBTUlOR19WSURFTxAQEhEK",
            "DVNPQ0lBTF9JU1NVRVMQERIqCiZCUkFORF9TVUlUQUJJTElUWV9DT05URU5U",
            "X0ZPUl9GQU1JTElFUxASEiQKIEJSQU5EX1NVSVRBQklMSVRZX0dBTUVTX0ZJ",
            "R0hUSU5HEBMSIgoeQlJBTkRfU1VJVEFCSUxJVFlfR0FNRVNfTUFUVVJFEBQS",
            "JgoiQlJBTkRfU1VJVEFCSUxJVFlfSEVBTFRIX1NFTlNJVElWRRAVEjAKLEJS",
            "QU5EX1NVSVRBQklMSVRZX0hFQUxUSF9TT1VSQ0VfVU5ERVRFUk1JTkVEEBYS",
            "IQodQlJBTkRfU1VJVEFCSUxJVFlfTkVXU19SRUNFTlQQFxIkCiBCUkFORF9T",
            "VUlUQUJJTElUWV9ORVdTX1NFTlNJVElWRRAYEi4KKkJSQU5EX1NVSVRBQklM",
            "SVRZX05FV1NfU09VUkNFX05PVF9GRUFUVVJFRBAZEh4KGkJSQU5EX1NVSVRB",
            "QklMSVRZX1BPTElUSUNTEBoSHgoaQlJBTkRfU1VJVEFCSUxJVFlfUkVMSUdJ",
            "T04QG0LvAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5lbnVtc0IV",
            "Q29udGVudExhYmVsVHlwZVByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTgvZW51bXM7ZW51",
            "bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTguRW51bXPKAh5H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMThcRW51bXPqAiJHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMTg6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Enums.ContentLabelTypeEnum), global::Google.Ads.GoogleAds.V18.Enums.ContentLabelTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Enums.ContentLabelTypeEnum.Types.ContentLabelType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing content label types in ContentLabel.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ContentLabelTypeEnum : pb::IMessage<ContentLabelTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ContentLabelTypeEnum> _parser = new pb::MessageParser<ContentLabelTypeEnum>(() => new ContentLabelTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ContentLabelTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Enums.ContentLabelTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentLabelTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentLabelTypeEnum(ContentLabelTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentLabelTypeEnum Clone() {
      return new ContentLabelTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ContentLabelTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ContentLabelTypeEnum other) {
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
    public void MergeFrom(ContentLabelTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ContentLabelTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum listing the content label types supported by ContentLabel criterion.
      /// </summary>
      public enum ContentLabelType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Sexually suggestive content.
        /// </summary>
        [pbr::OriginalName("SEXUALLY_SUGGESTIVE")] SexuallySuggestive = 2,
        /// <summary>
        /// Below the fold placement.
        /// </summary>
        [pbr::OriginalName("BELOW_THE_FOLD")] BelowTheFold = 3,
        /// <summary>
        /// Parked domain.
        /// </summary>
        [pbr::OriginalName("PARKED_DOMAIN")] ParkedDomain = 4,
        /// <summary>
        /// Juvenile, gross &amp; bizarre content.
        /// </summary>
        [pbr::OriginalName("JUVENILE")] Juvenile = 6,
        /// <summary>
        /// Profanity &amp; rough language.
        /// </summary>
        [pbr::OriginalName("PROFANITY")] Profanity = 7,
        /// <summary>
        /// Death &amp; tragedy.
        /// </summary>
        [pbr::OriginalName("TRAGEDY")] Tragedy = 8,
        /// <summary>
        /// Video.
        /// </summary>
        [pbr::OriginalName("VIDEO")] Video = 9,
        /// <summary>
        /// Content rating: G.
        /// </summary>
        [pbr::OriginalName("VIDEO_RATING_DV_G")] VideoRatingDvG = 10,
        /// <summary>
        /// Content rating: PG.
        /// </summary>
        [pbr::OriginalName("VIDEO_RATING_DV_PG")] VideoRatingDvPg = 11,
        /// <summary>
        /// Content rating: T.
        /// </summary>
        [pbr::OriginalName("VIDEO_RATING_DV_T")] VideoRatingDvT = 12,
        /// <summary>
        /// Content rating: MA.
        /// </summary>
        [pbr::OriginalName("VIDEO_RATING_DV_MA")] VideoRatingDvMa = 13,
        /// <summary>
        /// Content rating: not yet rated.
        /// </summary>
        [pbr::OriginalName("VIDEO_NOT_YET_RATED")] VideoNotYetRated = 14,
        /// <summary>
        /// Embedded video.
        /// </summary>
        [pbr::OriginalName("EMBEDDED_VIDEO")] EmbeddedVideo = 15,
        /// <summary>
        /// Live streaming video.
        /// </summary>
        [pbr::OriginalName("LIVE_STREAMING_VIDEO")] LiveStreamingVideo = 16,
        /// <summary>
        /// Sensitive social issues.
        /// </summary>
        [pbr::OriginalName("SOCIAL_ISSUES")] SocialIssues = 17,
        /// <summary>
        /// Content that's suitable for families to view together, including Made for
        /// Kids videos on YouTube.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_CONTENT_FOR_FAMILIES")] BrandSuitabilityContentForFamilies = 18,
        /// <summary>
        /// Video games that simulate hand-to-hand fighting or combat with the use of
        /// modern or medieval weapons.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_GAMES_FIGHTING")] BrandSuitabilityGamesFighting = 19,
        /// <summary>
        /// Video games that feature mature content, such as violence, inappropriate
        /// language, or sexual suggestiveness.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_GAMES_MATURE")] BrandSuitabilityGamesMature = 20,
        /// <summary>
        /// Health content that people might find sensitive or upsetting, such as
        /// medical procedures or images and descriptions of various medical
        /// conditions.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_HEALTH_SENSITIVE")] BrandSuitabilityHealthSensitive = 21,
        /// <summary>
        /// Health content from sources that may provide accurate information but
        /// aren't as commonly cited as other, more well-known sources.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_HEALTH_SOURCE_UNDETERMINED")] BrandSuitabilityHealthSourceUndetermined = 22,
        /// <summary>
        /// News content that's been recently announced, regardless of the themes or
        /// people being reported on.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_NEWS_RECENT")] BrandSuitabilityNewsRecent = 23,
        /// <summary>
        /// News content that people might find sensitive or upsetting, such as
        /// crimes, accidents, and natural incidents, or commentary on potentially
        /// controversial social and political issues.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_NEWS_SENSITIVE")] BrandSuitabilityNewsSensitive = 24,
        /// <summary>
        /// News content from sources that aren't featured on Google News or YouTube
        /// News.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_NEWS_SOURCE_NOT_FEATURED")] BrandSuitabilityNewsSourceNotFeatured = 25,
        /// <summary>
        /// Political content, such as political statements made by well-known
        /// politicians, political elections, or events widely perceived to be
        /// political in nature.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_POLITICS")] BrandSuitabilityPolitics = 26,
        /// <summary>
        /// Content with religious themes, such as religious teachings or customs,
        /// holy sites or places of worship, well-known religious figures or people
        /// dressed in religious attire, or religious opinions on social and
        /// political issues.
        /// </summary>
        [pbr::OriginalName("BRAND_SUITABILITY_RELIGION")] BrandSuitabilityReligion = 27,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
