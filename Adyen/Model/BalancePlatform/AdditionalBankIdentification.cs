/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace HeadOn.Classic.Adyen.Model.BalancePlatform
{
    /// <summary>
    /// AdditionalBankIdentification
    /// </summary>
    [DataContract(Name = "AdditionalBankIdentification")]
    public partial class AdditionalBankIdentification : IEquatable<AdditionalBankIdentification>, IValidatableObject
    {
        /// <summary>
        /// The type of additional bank identification, depending on the country.  Possible values:   * **gbSortCode**: The 6-digit [UK sort code](https://en.wikipedia.org/wiki/Sort_code), without separators or spaces  * **usRoutingNumber**: The 9-digit [routing number](https://en.wikipedia.org/wiki/ABA_routing_transit_number), without separators or spaces.
        /// </summary>
        /// <value>The type of additional bank identification, depending on the country.  Possible values:   * **gbSortCode**: The 6-digit [UK sort code](https://en.wikipedia.org/wiki/Sort_code), without separators or spaces  * **usRoutingNumber**: The 9-digit [routing number](https://en.wikipedia.org/wiki/ABA_routing_transit_number), without separators or spaces.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum GbSortCode for value: gbSortCode
            /// </summary>
            [EnumMember(Value = "gbSortCode")]
            GbSortCode = 1,

            /// <summary>
            /// Enum UsRoutingNumber for value: usRoutingNumber
            /// </summary>
            [EnumMember(Value = "usRoutingNumber")]
            UsRoutingNumber = 2

        }


        /// <summary>
        /// The type of additional bank identification, depending on the country.  Possible values:   * **gbSortCode**: The 6-digit [UK sort code](https://en.wikipedia.org/wiki/Sort_code), without separators or spaces  * **usRoutingNumber**: The 9-digit [routing number](https://en.wikipedia.org/wiki/ABA_routing_transit_number), without separators or spaces.
        /// </summary>
        /// <value>The type of additional bank identification, depending on the country.  Possible values:   * **gbSortCode**: The 6-digit [UK sort code](https://en.wikipedia.org/wiki/Sort_code), without separators or spaces  * **usRoutingNumber**: The 9-digit [routing number](https://en.wikipedia.org/wiki/ABA_routing_transit_number), without separators or spaces.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalBankIdentification" /> class.
        /// </summary>
        /// <param name="code">The value of the additional bank identification..</param>
        /// <param name="type">The type of additional bank identification, depending on the country.  Possible values:   * **gbSortCode**: The 6-digit [UK sort code](https://en.wikipedia.org/wiki/Sort_code), without separators or spaces  * **usRoutingNumber**: The 9-digit [routing number](https://en.wikipedia.org/wiki/ABA_routing_transit_number), without separators or spaces..</param>
        public AdditionalBankIdentification(string code = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Code = code;
            this.Type = type;
        }

        /// <summary>
        /// The value of the additional bank identification.
        /// </summary>
        /// <value>The value of the additional bank identification.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalBankIdentification {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as AdditionalBankIdentification);
        }

        /// <summary>
        /// Returns true if AdditionalBankIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalBankIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalBankIdentification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
