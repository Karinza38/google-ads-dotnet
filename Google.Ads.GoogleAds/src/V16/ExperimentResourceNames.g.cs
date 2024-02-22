// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gagvr = Google.Ads.GoogleAds.V16.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V16.Resources
{
    /// <summary>Resource name for the <c>Experiment</c> resource.</summary>
    public sealed partial class ExperimentName : gax::IResourceName, sys::IEquatable<ExperimentName>
    {
        /// <summary>The possible contents of <see cref="ExperimentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/experiments/{trial_id}</c>.</summary>
            CustomerTrial = 1,
        }

        private static gax::PathTemplate s_customerTrial = new gax::PathTemplate("customers/{customer_id}/experiments/{trial_id}");

        /// <summary>Creates a <see cref="ExperimentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExperimentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExperimentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExperimentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExperimentName"/> with the pattern <c>customers/{customer_id}/experiments/{trial_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExperimentName"/> constructed from the provided ids.</returns>
        public static ExperimentName FromCustomerTrial(string customerId, string trialId) =>
            new ExperimentName(ResourceNameType.CustomerTrial, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), trialId: gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExperimentName"/> with pattern
        /// <c>customers/{customer_id}/experiments/{trial_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExperimentName"/> with pattern
        /// <c>customers/{customer_id}/experiments/{trial_id}</c>.
        /// </returns>
        public static string Format(string customerId, string trialId) => FormatCustomerTrial(customerId, trialId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExperimentName"/> with pattern
        /// <c>customers/{customer_id}/experiments/{trial_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExperimentName"/> with pattern
        /// <c>customers/{customer_id}/experiments/{trial_id}</c>.
        /// </returns>
        public static string FormatCustomerTrial(string customerId, string trialId) =>
            s_customerTrial.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExperimentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/experiments/{trial_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="experimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExperimentName"/> if successful.</returns>
        public static ExperimentName Parse(string experimentName) => Parse(experimentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExperimentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/experiments/{trial_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="experimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExperimentName"/> if successful.</returns>
        public static ExperimentName Parse(string experimentName, bool allowUnparsed) =>
            TryParse(experimentName, allowUnparsed, out ExperimentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExperimentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/experiments/{trial_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="experimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExperimentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string experimentName, out ExperimentName result) =>
            TryParse(experimentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExperimentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/experiments/{trial_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="experimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExperimentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string experimentName, bool allowUnparsed, out ExperimentName result)
        {
            gax::GaxPreconditions.CheckNotNull(experimentName, nameof(experimentName));
            gax::TemplatedResourceName resourceName;
            if (s_customerTrial.TryParseName(experimentName, out resourceName))
            {
                result = FromCustomerTrial(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(experimentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExperimentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string trialId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            TrialId = trialId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExperimentName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/experiments/{trial_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        public ExperimentName(string customerId, string trialId) : this(ResourceNameType.CustomerTrial, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), trialId: gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>Trial</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TrialId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerTrial: return s_customerTrial.Expand(CustomerId, TrialId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExperimentName);

        /// <inheritdoc/>
        public bool Equals(ExperimentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExperimentName a, ExperimentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExperimentName a, ExperimentName b) => !(a == b);
    }

    public partial class Experiment
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ResourceNameAsExperimentName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::ExperimentName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::ExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
