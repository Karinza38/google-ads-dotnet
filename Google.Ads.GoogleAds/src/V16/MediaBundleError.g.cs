// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v16/errors/media_bundle_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V16.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v16/errors/media_bundle_error.proto</summary>
  public static partial class MediaBundleErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v16/errors/media_bundle_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MediaBundleErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTYvZXJyb3JzL21lZGlhX2J1bmRs",
            "ZV9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE2LmVycm9y",
            "cyK4BQoUTWVkaWFCdW5kbGVFcnJvckVudW0inwUKEE1lZGlhQnVuZGxlRXJy",
            "b3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDwoLQkFEX1JFUVVF",
            "U1QQAxIiCh5ET1VCTEVDTElDS19CVU5ETEVfTk9UX0FMTE9XRUQQBBIcChhF",
            "WFRFUk5BTF9VUkxfTk9UX0FMTE9XRUQQBRISCg5GSUxFX1RPT19MQVJHRRAG",
            "Ei4KKkdPT0dMRV9XRUJfREVTSUdORVJfWklQX0ZJTEVfTk9UX1BVQkxJU0hF",
            "RBAHEhEKDUlOVkFMSURfSU5QVVQQCBIYChRJTlZBTElEX01FRElBX0JVTkRM",
            "RRAJEh4KGklOVkFMSURfTUVESUFfQlVORExFX0VOVFJZEAoSFQoRSU5WQUxJ",
            "RF9NSU1FX1RZUEUQCxIQCgxJTlZBTElEX1BBVEgQDBIZChVJTlZBTElEX1VS",
            "TF9SRUZFUkVOQ0UQDRIYChRNRURJQV9EQVRBX1RPT19MQVJHRRAOEiYKIk1J",
            "U1NJTkdfUFJJTUFSWV9NRURJQV9CVU5ETEVfRU5UUlkQDxIQCgxTRVJWRVJf",
            "RVJST1IQEBIRCg1TVE9SQUdFX0VSUk9SEBESHQoZU1dJRkZZX0JVTkRMRV9O",
            "T1RfQUxMT1dFRBASEhIKDlRPT19NQU5ZX0ZJTEVTEBMSEwoPVU5FWFBFQ1RF",
            "RF9TSVpFEBQSLworVU5TVVBQT1JURURfR09PR0xFX1dFQl9ERVNJR05FUl9F",
            "TlZJUk9OTUVOVBAVEh0KGVVOU1VQUE9SVEVEX0hUTUw1X0ZFQVRVUkUQFhIp",
            "CiVVUkxfSU5fTUVESUFfQlVORExFX05PVF9TU0xfQ09NUExJQU5UEBcSGwoX",
            "Q1VTVE9NX0VYSVRfTk9UX0FMTE9XRUQQGEL1AQojY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxNi5lcnJvcnNCFU1lZGlhQnVuZGxlRXJyb3JQcm90b1AB",
            "WkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjE2L2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMTYuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjE2XEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNjo6RXJy",
            "b3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V16.Errors.MediaBundleErrorEnum), global::Google.Ads.GoogleAds.V16.Errors.MediaBundleErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V16.Errors.MediaBundleErrorEnum.Types.MediaBundleError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible media bundle errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MediaBundleErrorEnum : pb::IMessage<MediaBundleErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MediaBundleErrorEnum> _parser = new pb::MessageParser<MediaBundleErrorEnum>(() => new MediaBundleErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MediaBundleErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V16.Errors.MediaBundleErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MediaBundleErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MediaBundleErrorEnum(MediaBundleErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MediaBundleErrorEnum Clone() {
      return new MediaBundleErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MediaBundleErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MediaBundleErrorEnum other) {
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
    public void MergeFrom(MediaBundleErrorEnum other) {
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
    /// <summary>Container for nested types declared in the MediaBundleErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible media bundle errors.
      /// </summary>
      public enum MediaBundleError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// There was a problem with the request.
        /// </summary>
        [pbr::OriginalName("BAD_REQUEST")] BadRequest = 3,
        /// <summary>
        /// HTML5 ads using DoubleClick Studio created ZIP files are not supported.
        /// </summary>
        [pbr::OriginalName("DOUBLECLICK_BUNDLE_NOT_ALLOWED")] DoubleclickBundleNotAllowed = 4,
        /// <summary>
        /// Cannot reference URL external to the media bundle.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_URL_NOT_ALLOWED")] ExternalUrlNotAllowed = 5,
        /// <summary>
        /// Media bundle file is too large.
        /// </summary>
        [pbr::OriginalName("FILE_TOO_LARGE")] FileTooLarge = 6,
        /// <summary>
        /// ZIP file from Google Web Designer is not published.
        /// </summary>
        [pbr::OriginalName("GOOGLE_WEB_DESIGNER_ZIP_FILE_NOT_PUBLISHED")] GoogleWebDesignerZipFileNotPublished = 7,
        /// <summary>
        /// Input was invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_INPUT")] InvalidInput = 8,
        /// <summary>
        /// There was a problem with the media bundle.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_BUNDLE")] InvalidMediaBundle = 9,
        /// <summary>
        /// There was a problem with one or more of the media bundle entries.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_BUNDLE_ENTRY")] InvalidMediaBundleEntry = 10,
        /// <summary>
        /// The media bundle contains a file with an unknown mime type
        /// </summary>
        [pbr::OriginalName("INVALID_MIME_TYPE")] InvalidMimeType = 11,
        /// <summary>
        /// The media bundle contain an invalid asset path.
        /// </summary>
        [pbr::OriginalName("INVALID_PATH")] InvalidPath = 12,
        /// <summary>
        /// HTML5 ad is trying to reference an asset not in .ZIP file
        /// </summary>
        [pbr::OriginalName("INVALID_URL_REFERENCE")] InvalidUrlReference = 13,
        /// <summary>
        /// Media data is too large.
        /// </summary>
        [pbr::OriginalName("MEDIA_DATA_TOO_LARGE")] MediaDataTooLarge = 14,
        /// <summary>
        /// The media bundle contains no primary entry.
        /// </summary>
        [pbr::OriginalName("MISSING_PRIMARY_MEDIA_BUNDLE_ENTRY")] MissingPrimaryMediaBundleEntry = 15,
        /// <summary>
        /// There was an error on the server.
        /// </summary>
        [pbr::OriginalName("SERVER_ERROR")] ServerError = 16,
        /// <summary>
        /// The image could not be stored.
        /// </summary>
        [pbr::OriginalName("STORAGE_ERROR")] StorageError = 17,
        /// <summary>
        /// Media bundle created with the Swiffy tool is not allowed.
        /// </summary>
        [pbr::OriginalName("SWIFFY_BUNDLE_NOT_ALLOWED")] SwiffyBundleNotAllowed = 18,
        /// <summary>
        /// The media bundle contains too many files.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_FILES")] TooManyFiles = 19,
        /// <summary>
        /// The media bundle is not of legal dimensions.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_SIZE")] UnexpectedSize = 20,
        /// <summary>
        /// Google Web Designer not created for "Google Ads" environment.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_GOOGLE_WEB_DESIGNER_ENVIRONMENT")] UnsupportedGoogleWebDesignerEnvironment = 21,
        /// <summary>
        /// Unsupported HTML5 feature in HTML5 asset.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_HTML5_FEATURE")] UnsupportedHtml5Feature = 22,
        /// <summary>
        /// URL in HTML5 entry is not ssl compliant.
        /// </summary>
        [pbr::OriginalName("URL_IN_MEDIA_BUNDLE_NOT_SSL_COMPLIANT")] UrlInMediaBundleNotSslCompliant = 23,
        /// <summary>
        /// Custom exits not allowed in HTML5 entry.
        /// </summary>
        [pbr::OriginalName("CUSTOM_EXIT_NOT_ALLOWED")] CustomExitNotAllowed = 24,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
