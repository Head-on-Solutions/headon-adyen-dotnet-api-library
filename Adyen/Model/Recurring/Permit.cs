/*
* Adyen Recurring API
*
*
* The version of the OpenAPI document: 68
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

namespace HeadOn.Classic.Adyen.Model.Recurring
{
    /// <summary>
    /// Permit
    /// </summary>
    [DataContract(Name = "Permit")]
    public partial class Permit : IEquatable<Permit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permit" /> class.
        /// </summary>
        /// <param name="partnerId">Partner ID (when using the permit-per-partner token sharing model)..</param>
        /// <param name="profileReference">The profile to apply to this permit (when using the shared permits model)..</param>
        /// <param name="restriction">restriction.</param>
        /// <param name="resultKey">The key to link permit requests to permit results..</param>
        /// <param name="validTillDate">The expiry date for this permit..</param>
        public Permit(string partnerId = default(string), string profileReference = default(string), PermitRestriction restriction = default(PermitRestriction), string resultKey = default(string), DateTime validTillDate = default(DateTime))
        {
            this.PartnerId = partnerId;
            this.ProfileReference = profileReference;
            this.Restriction = restriction;
            this.ResultKey = resultKey;
            this.ValidTillDate = validTillDate;
        }

        /// <summary>
        /// Partner ID (when using the permit-per-partner token sharing model).
        /// </summary>
        /// <value>Partner ID (when using the permit-per-partner token sharing model).</value>
        [DataMember(Name = "partnerId", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// The profile to apply to this permit (when using the shared permits model).
        /// </summary>
        /// <value>The profile to apply to this permit (when using the shared permits model).</value>
        [DataMember(Name = "profileReference", EmitDefaultValue = false)]
        public string ProfileReference { get; set; }

        /// <summary>
        /// Gets or Sets Restriction
        /// </summary>
        [DataMember(Name = "restriction", EmitDefaultValue = false)]
        public PermitRestriction Restriction { get; set; }

        /// <summary>
        /// The key to link permit requests to permit results.
        /// </summary>
        /// <value>The key to link permit requests to permit results.</value>
        [DataMember(Name = "resultKey", EmitDefaultValue = false)]
        public string ResultKey { get; set; }

        /// <summary>
        /// The expiry date for this permit.
        /// </summary>
        /// <value>The expiry date for this permit.</value>
        [DataMember(Name = "validTillDate", EmitDefaultValue = false)]
        public DateTime ValidTillDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Permit {\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  ProfileReference: ").Append(ProfileReference).Append("\n");
            sb.Append("  Restriction: ").Append(Restriction).Append("\n");
            sb.Append("  ResultKey: ").Append(ResultKey).Append("\n");
            sb.Append("  ValidTillDate: ").Append(ValidTillDate).Append("\n");
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
            return this.Equals(input as Permit);
        }

        /// <summary>
        /// Returns true if Permit instances are equal
        /// </summary>
        /// <param name="input">Instance of Permit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permit input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.ProfileReference == input.ProfileReference ||
                    (this.ProfileReference != null &&
                    this.ProfileReference.Equals(input.ProfileReference))
                ) && 
                (
                    this.Restriction == input.Restriction ||
                    (this.Restriction != null &&
                    this.Restriction.Equals(input.Restriction))
                ) && 
                (
                    this.ResultKey == input.ResultKey ||
                    (this.ResultKey != null &&
                    this.ResultKey.Equals(input.ResultKey))
                ) && 
                (
                    this.ValidTillDate == input.ValidTillDate ||
                    (this.ValidTillDate != null &&
                    this.ValidTillDate.Equals(input.ValidTillDate))
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
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.ProfileReference != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileReference.GetHashCode();
                }
                if (this.Restriction != null)
                {
                    hashCode = (hashCode * 59) + this.Restriction.GetHashCode();
                }
                if (this.ResultKey != null)
                {
                    hashCode = (hashCode * 59) + this.ResultKey.GetHashCode();
                }
                if (this.ValidTillDate != null)
                {
                    hashCode = (hashCode * 59) + this.ValidTillDate.GetHashCode();
                }
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
