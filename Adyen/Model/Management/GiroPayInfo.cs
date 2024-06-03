/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
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

namespace HeadOn.Classic.Adyen.Model.Management
{
    /// <summary>
    /// GiroPayInfo
    /// </summary>
    [DataContract(Name = "GiroPayInfo")]
    public partial class GiroPayInfo : IEquatable<GiroPayInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GiroPayInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GiroPayInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GiroPayInfo" /> class.
        /// </summary>
        /// <param name="supportEmail">The email address of merchant support. (required).</param>
        public GiroPayInfo(string supportEmail = default(string))
        {
            this.SupportEmail = supportEmail;
        }

        /// <summary>
        /// The email address of merchant support.
        /// </summary>
        /// <value>The email address of merchant support.</value>
        [DataMember(Name = "supportEmail", IsRequired = false, EmitDefaultValue = false)]
        public string SupportEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GiroPayInfo {\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
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
            return this.Equals(input as GiroPayInfo);
        }

        /// <summary>
        /// Returns true if GiroPayInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GiroPayInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GiroPayInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SupportEmail == input.SupportEmail ||
                    (this.SupportEmail != null &&
                    this.SupportEmail.Equals(input.SupportEmail))
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
                if (this.SupportEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SupportEmail.GetHashCode();
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
