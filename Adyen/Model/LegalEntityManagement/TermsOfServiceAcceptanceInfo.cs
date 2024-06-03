/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
* 
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HeadOn.Classic.Adyen.ApiSerialization.OpenAPIDateConverter;

namespace HeadOn.Classic.Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// TermsOfServiceAcceptanceInfo
    /// </summary>
    [DataContract(Name = "TermsOfServiceAcceptanceInfo")]
    public partial class TermsOfServiceAcceptanceInfo : IEquatable<TermsOfServiceAcceptanceInfo>, IValidatableObject
    {
        /// <summary>
        /// The type of Terms of Service.
        /// </summary>
        /// <value>The type of Terms of Service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AdyenAccount for value: adyenAccount
            /// </summary>
            [EnumMember(Value = "adyenAccount")]
            AdyenAccount = 1,

            /// <summary>
            /// Enum AdyenCapital for value: adyenCapital
            /// </summary>
            [EnumMember(Value = "adyenCapital")]
            AdyenCapital = 2,

            /// <summary>
            /// Enum AdyenCard for value: adyenCard
            /// </summary>
            [EnumMember(Value = "adyenCard")]
            AdyenCard = 3,

            /// <summary>
            /// Enum AdyenForPlatformsAdvanced for value: adyenForPlatformsAdvanced
            /// </summary>
            [EnumMember(Value = "adyenForPlatformsAdvanced")]
            AdyenForPlatformsAdvanced = 4,

            /// <summary>
            /// Enum AdyenForPlatformsManage for value: adyenForPlatformsManage
            /// </summary>
            [EnumMember(Value = "adyenForPlatformsManage")]
            AdyenForPlatformsManage = 5,

            /// <summary>
            /// Enum AdyenFranchisee for value: adyenFranchisee
            /// </summary>
            [EnumMember(Value = "adyenFranchisee")]
            AdyenFranchisee = 6,

            /// <summary>
            /// Enum AdyenIssuing for value: adyenIssuing
            /// </summary>
            [EnumMember(Value = "adyenIssuing")]
            AdyenIssuing = 7

        }


        /// <summary>
        /// The type of Terms of Service.
        /// </summary>
        /// <value>The type of Terms of Service.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsOfServiceAcceptanceInfo" /> class.
        /// </summary>
        /// <param name="acceptedBy">The unique identifier of the user that accepted the Terms of Service..</param>
        /// <param name="acceptedFor">The unique identifier of the legal entity for which the Terms of Service are accepted..</param>
        /// <param name="createdAt">The date when the Terms of Service were accepted..</param>
        /// <param name="id">An Adyen-generated reference for the accepted Terms of Service..</param>
        /// <param name="type">The type of Terms of Service..</param>
        public TermsOfServiceAcceptanceInfo(string acceptedBy = default(string), string acceptedFor = default(string), DateTime createdAt = default(DateTime), string id = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.AcceptedBy = acceptedBy;
            this.AcceptedFor = acceptedFor;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// The unique identifier of the user that accepted the Terms of Service.
        /// </summary>
        /// <value>The unique identifier of the user that accepted the Terms of Service.</value>
        [DataMember(Name = "acceptedBy", EmitDefaultValue = false)]
        public string AcceptedBy { get; set; }

        /// <summary>
        /// The unique identifier of the legal entity for which the Terms of Service are accepted.
        /// </summary>
        /// <value>The unique identifier of the legal entity for which the Terms of Service are accepted.</value>
        [DataMember(Name = "acceptedFor", EmitDefaultValue = false)]
        public string AcceptedFor { get; set; }

        /// <summary>
        /// The date when the Terms of Service were accepted.
        /// </summary>
        /// <value>The date when the Terms of Service were accepted.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// An Adyen-generated reference for the accepted Terms of Service.
        /// </summary>
        /// <value>An Adyen-generated reference for the accepted Terms of Service.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TermsOfServiceAcceptanceInfo {\n");
            sb.Append("  AcceptedBy: ").Append(AcceptedBy).Append("\n");
            sb.Append("  AcceptedFor: ").Append(AcceptedFor).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TermsOfServiceAcceptanceInfo);
        }

        /// <summary>
        /// Returns true if TermsOfServiceAcceptanceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TermsOfServiceAcceptanceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermsOfServiceAcceptanceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptedBy == input.AcceptedBy ||
                    (this.AcceptedBy != null &&
                    this.AcceptedBy.Equals(input.AcceptedBy))
                ) && 
                (
                    this.AcceptedFor == input.AcceptedFor ||
                    (this.AcceptedFor != null &&
                    this.AcceptedFor.Equals(input.AcceptedFor))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AcceptedBy != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptedBy.GetHashCode();
                }
                if (this.AcceptedFor != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptedFor.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
