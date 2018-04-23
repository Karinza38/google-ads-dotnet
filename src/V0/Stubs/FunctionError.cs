// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/function_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/function_error.proto</summary>
  public static partial class FunctionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/function_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FunctionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvZnVuY3Rpb25fZXJy",
            "b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVycm9ycyLBBAoR",
            "RnVuY3Rpb25FcnJvckVudW0iqwQKDUZ1bmN0aW9uRXJyb3ISDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESGwoXSU5WQUxJRF9GVU5DVElPTl9GT1JN",
            "QVQQAhIWChJEQVRBX1RZUEVfTUlTTUFUQ0gQAxIgChxJTlZBTElEX0NPTkpV",
            "TkNUSU9OX09QRVJBTkRTEAQSHgoaSU5WQUxJRF9OVU1CRVJfT0ZfT1BFUkFO",
            "RFMQBRIYChRJTlZBTElEX09QRVJBTkRfVFlQRRAGEhQKEElOVkFMSURfT1BF",
            "UkFUT1IQBxIgChxJTlZBTElEX1JFUVVFU1RfQ09OVEVYVF9UWVBFEAgSKQol",
            "SU5WQUxJRF9GVU5DVElPTl9GT1JfQ0FMTF9QTEFDRUhPTERFUhAJEiQKIElO",
            "VkFMSURfRlVOQ1RJT05fRk9SX1BMQUNFSE9MREVSEAoSEwoPSU5WQUxJRF9P",
            "UEVSQU5EEAsSIgoeTUlTU0lOR19DT05TVEFOVF9PUEVSQU5EX1ZBTFVFEAwS",
            "IgoeSU5WQUxJRF9DT05TVEFOVF9PUEVSQU5EX1ZBTFVFEA0SEwoPSU5WQUxJ",
            "RF9ORVNUSU5HEA4SIwofTVVMVElQTEVfRkVFRF9JRFNfTk9UX1NVUFBPUlRF",
            "RBAPEi8KK0lOVkFMSURfRlVOQ1RJT05fRk9SX0ZFRURfV0lUSF9GSVhFRF9T",
            "Q0hFTUEQEBIaChZJTlZBTElEX0FUVFJJQlVURV9OQU1FEBFCyAEKImNvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnNCEkZ1bmN0aW9uRXJyb3JQ",
            "cm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjAvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYwLkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYwXEVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.FunctionErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.FunctionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.FunctionErrorEnum.Types.FunctionError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible function errors.
  /// </summary>
  public sealed partial class FunctionErrorEnum : pb::IMessage<FunctionErrorEnum> {
    private static readonly pb::MessageParser<FunctionErrorEnum> _parser = new pb::MessageParser<FunctionErrorEnum>(() => new FunctionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FunctionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.FunctionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionErrorEnum(FunctionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FunctionErrorEnum Clone() {
      return new FunctionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FunctionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FunctionErrorEnum other) {
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
    public void MergeFrom(FunctionErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FunctionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible function errors.
      /// </summary>
      public enum FunctionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The format of the function is not recognized as a supported function
        /// format.
        /// </summary>
        [pbr::OriginalName("INVALID_FUNCTION_FORMAT")] InvalidFunctionFormat = 2,
        /// <summary>
        /// Operand data types do not match.
        /// </summary>
        [pbr::OriginalName("DATA_TYPE_MISMATCH")] DataTypeMismatch = 3,
        /// <summary>
        /// The operands cannot be used together in a conjunction.
        /// </summary>
        [pbr::OriginalName("INVALID_CONJUNCTION_OPERANDS")] InvalidConjunctionOperands = 4,
        /// <summary>
        /// Invalid numer of Operands.
        /// </summary>
        [pbr::OriginalName("INVALID_NUMBER_OF_OPERANDS")] InvalidNumberOfOperands = 5,
        /// <summary>
        /// Operand Type not supported.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERAND_TYPE")] InvalidOperandType = 6,
        /// <summary>
        /// Operator not supported.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERATOR")] InvalidOperator = 7,
        /// <summary>
        /// Request context type not supported.
        /// </summary>
        [pbr::OriginalName("INVALID_REQUEST_CONTEXT_TYPE")] InvalidRequestContextType = 8,
        /// <summary>
        /// The matching function is not allowed for call placeholders
        /// </summary>
        [pbr::OriginalName("INVALID_FUNCTION_FOR_CALL_PLACEHOLDER")] InvalidFunctionForCallPlaceholder = 9,
        /// <summary>
        /// The matching function is not allowed for the specified placeholder
        /// </summary>
        [pbr::OriginalName("INVALID_FUNCTION_FOR_PLACEHOLDER")] InvalidFunctionForPlaceholder = 10,
        /// <summary>
        /// Invalid operand.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERAND")] InvalidOperand = 11,
        /// <summary>
        /// Missing value for the constant operand.
        /// </summary>
        [pbr::OriginalName("MISSING_CONSTANT_OPERAND_VALUE")] MissingConstantOperandValue = 12,
        /// <summary>
        /// The value of the constant operand is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_CONSTANT_OPERAND_VALUE")] InvalidConstantOperandValue = 13,
        /// <summary>
        /// Invalid function nesting.
        /// </summary>
        [pbr::OriginalName("INVALID_NESTING")] InvalidNesting = 14,
        /// <summary>
        /// The Feed ID was different from another Feed ID in the same function.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_FEED_IDS_NOT_SUPPORTED")] MultipleFeedIdsNotSupported = 15,
        /// <summary>
        /// The matching function is invalid for use with a feed with a fixed schema.
        /// </summary>
        [pbr::OriginalName("INVALID_FUNCTION_FOR_FEED_WITH_FIXED_SCHEMA")] InvalidFunctionForFeedWithFixedSchema = 16,
        /// <summary>
        /// Invalid attribute name.
        /// </summary>
        [pbr::OriginalName("INVALID_ATTRIBUTE_NAME")] InvalidAttributeName = 17,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
