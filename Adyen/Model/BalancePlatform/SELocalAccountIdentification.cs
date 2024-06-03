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
    /// SELocalAccountIdentification
    /// </summary>
    [DataContract(Name = "SELocalAccountIdentification")]
    public partial class SELocalAccountIdentification : IEquatable<SELocalAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// **seLocal**
        /// </summary>
        /// <value>**seLocal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SeLocal for value: seLocal
            /// </summary>
            [EnumMember(Value = "seLocal")]
            SeLocal = 1

        }


        /// <summary>
        /// **seLocal**
        /// </summary>
        /// <value>**seLocal**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SELocalAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SELocalAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SELocalAccountIdentification" /> class.
        /// </summary>
        /// <param name="accountNumber">The 7- to 10-digit bank account number ([Bankkontonummer](https://sv.wikipedia.org/wiki/Bankkonto)), without the clearing number, separators, or whitespace. (required).</param>
        /// <param name="clearingNumber">The 4- to 5-digit clearing number ([Clearingnummer](https://sv.wikipedia.org/wiki/Clearingnummer)), without separators or whitespace. (required).</param>
        /// <param name="type">**seLocal** (required) (default to TypeEnum.SeLocal).</param>
        public SELocalAccountIdentification(string accountNumber = default(string), string clearingNumber = default(string), TypeEnum type = TypeEnum.SeLocal)
        {
            this.AccountNumber = accountNumber;
            this.ClearingNumber = clearingNumber;
            this.Type = type;
        }

        /// <summary>
        /// The 7- to 10-digit bank account number ([Bankkontonummer](https://sv.wikipedia.org/wiki/Bankkonto)), without the clearing number, separators, or whitespace.
        /// </summary>
        /// <value>The 7- to 10-digit bank account number ([Bankkontonummer](https://sv.wikipedia.org/wiki/Bankkonto)), without the clearing number, separators, or whitespace.</value>
        [DataMember(Name = "accountNumber", IsRequired = false, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The 4- to 5-digit clearing number ([Clearingnummer](https://sv.wikipedia.org/wiki/Clearingnummer)), without separators or whitespace.
        /// </summary>
        /// <value>The 4- to 5-digit clearing number ([Clearingnummer](https://sv.wikipedia.org/wiki/Clearingnummer)), without separators or whitespace.</value>
        [DataMember(Name = "clearingNumber", IsRequired = false, EmitDefaultValue = false)]
        public string ClearingNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SELocalAccountIdentification {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ClearingNumber: ").Append(ClearingNumber).Append("\n");
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
            return this.Equals(input as SELocalAccountIdentification);
        }

        /// <summary>
        /// Returns true if SELocalAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of SELocalAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SELocalAccountIdentification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.ClearingNumber == input.ClearingNumber ||
                    (this.ClearingNumber != null &&
                    this.ClearingNumber.Equals(input.ClearingNumber))
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.ClearingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ClearingNumber.GetHashCode();
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
            // AccountNumber (string) maxLength
            if (this.AccountNumber != null && this.AccountNumber.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 10.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 7.", new [] { "AccountNumber" });
            }

            // ClearingNumber (string) maxLength
            if (this.ClearingNumber != null && this.ClearingNumber.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClearingNumber, length must be less than 5.", new [] { "ClearingNumber" });
            }

            // ClearingNumber (string) minLength
            if (this.ClearingNumber != null && this.ClearingNumber.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClearingNumber, length must be greater than 4.", new [] { "ClearingNumber" });
            }

            yield break;
        }
    }

}
