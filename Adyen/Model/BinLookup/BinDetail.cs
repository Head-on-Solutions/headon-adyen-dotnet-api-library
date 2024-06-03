/*
* Adyen BinLookup API
*
*
* The version of the OpenAPI document: 54
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

namespace HeadOn.Classic.Adyen.Model.BinLookup
{
    /// <summary>
    /// BinDetail
    /// </summary>
    [DataContract(Name = "BinDetail")]
    public partial class BinDetail : IEquatable<BinDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinDetail" /> class.
        /// </summary>
        /// <param name="issuerCountry">The country where the card was issued..</param>
        public BinDetail(string issuerCountry = default(string))
        {
            this.IssuerCountry = issuerCountry;
        }

        /// <summary>
        /// The country where the card was issued.
        /// </summary>
        /// <value>The country where the card was issued.</value>
        [DataMember(Name = "issuerCountry", EmitDefaultValue = false)]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BinDetail {\n");
            sb.Append("  IssuerCountry: ").Append(IssuerCountry).Append("\n");
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
            return this.Equals(input as BinDetail);
        }

        /// <summary>
        /// Returns true if BinDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BinDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IssuerCountry == input.IssuerCountry ||
                    (this.IssuerCountry != null &&
                    this.IssuerCountry.Equals(input.IssuerCountry))
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
                if (this.IssuerCountry != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerCountry.GetHashCode();
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
