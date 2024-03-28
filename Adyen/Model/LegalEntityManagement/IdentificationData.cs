/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// IdentificationData
    /// </summary>
    [DataContract(Name = "IdentificationData")]
    public partial class IdentificationData : IEquatable<IdentificationData>, IValidatableObject
    {
        /// <summary>
        /// Type of identity data. For **individual**, the &#x60;type&#x60; value is **nationalIdNumber**.
        /// </summary>
        /// <value>Type of identity data. For **individual**, the &#x60;type&#x60; value is **nationalIdNumber**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NationalIdNumber for value: nationalIdNumber
            /// </summary>
            [EnumMember(Value = "nationalIdNumber")]
            NationalIdNumber = 1

        }


        /// <summary>
        /// Type of identity data. For **individual**, the &#x60;type&#x60; value is **nationalIdNumber**.
        /// </summary>
        /// <value>Type of identity data. For **individual**, the &#x60;type&#x60; value is **nationalIdNumber**.</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentificationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IdentificationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentificationData" /> class.
        /// </summary>
        /// <param name="cardNumber">The card number of the document that was issued (AU only)..</param>
        /// <param name="expiryDate">The expiry date of the document, in YYYY-MM-DD format..</param>
        /// <param name="issuerCountry">The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the document was issued. For example, **US**..</param>
        /// <param name="issuerState">The state or province where the document was issued (AU only)..</param>
        /// <param name="nationalIdExempt">Applies only to individuals in the US. Set to **true** if the individual does not have an SSN. To verify their identity, Adyen will require them to upload an ID document..</param>
        /// <param name="number">The number in the document..</param>
        /// <param name="type">Type of identity data. For **individual**, the &#x60;type&#x60; value is **nationalIdNumber**. (required).</param>
        public IdentificationData(string cardNumber = default(string), string expiryDate = default(string), string issuerCountry = default(string), string issuerState = default(string), bool? nationalIdExempt = default(bool?), string number = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Type = type;
            this.CardNumber = cardNumber;
            this.ExpiryDate = expiryDate;
            this.IssuerCountry = issuerCountry;
            this.IssuerState = issuerState;
            this.NationalIdExempt = nationalIdExempt;
            this.Number = number;
        }

        /// <summary>
        /// The card number of the document that was issued (AU only).
        /// </summary>
        /// <value>The card number of the document that was issued (AU only).</value>
        [DataMember(Name = "cardNumber", EmitDefaultValue = false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// The expiry date of the document, in YYYY-MM-DD format.
        /// </summary>
        /// <value>The expiry date of the document, in YYYY-MM-DD format.</value>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the document was issued. For example, **US**.
        /// </summary>
        /// <value>The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the document was issued. For example, **US**.</value>
        [DataMember(Name = "issuerCountry", EmitDefaultValue = false)]
        [Obsolete]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// The state or province where the document was issued (AU only).
        /// </summary>
        /// <value>The state or province where the document was issued (AU only).</value>
        [DataMember(Name = "issuerState", EmitDefaultValue = false)]
        public string IssuerState { get; set; }

        /// <summary>
        /// Applies only to individuals in the US. Set to **true** if the individual does not have an SSN. To verify their identity, Adyen will require them to upload an ID document.
        /// </summary>
        /// <value>Applies only to individuals in the US. Set to **true** if the individual does not have an SSN. To verify their identity, Adyen will require them to upload an ID document.</value>
        [DataMember(Name = "nationalIdExempt", EmitDefaultValue = false)]
        public bool? NationalIdExempt { get; set; }

        /// <summary>
        /// The number in the document.
        /// </summary>
        /// <value>The number in the document.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentificationData {\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  IssuerCountry: ").Append(IssuerCountry).Append("\n");
            sb.Append("  IssuerState: ").Append(IssuerState).Append("\n");
            sb.Append("  NationalIdExempt: ").Append(NationalIdExempt).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as IdentificationData);
        }

        /// <summary>
        /// Returns true if IdentificationData instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentificationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentificationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.IssuerCountry == input.IssuerCountry ||
                    (this.IssuerCountry != null &&
                    this.IssuerCountry.Equals(input.IssuerCountry))
                ) && 
                (
                    this.IssuerState == input.IssuerState ||
                    (this.IssuerState != null &&
                    this.IssuerState.Equals(input.IssuerState))
                ) && 
                (
                    this.NationalIdExempt == input.NationalIdExempt ||
                    this.NationalIdExempt.Equals(input.NationalIdExempt)
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.CardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CardNumber.GetHashCode();
                }
                if (this.ExpiryDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryDate.GetHashCode();
                }
                if (this.IssuerCountry != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerCountry.GetHashCode();
                }
                if (this.IssuerState != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerState.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NationalIdExempt.GetHashCode();
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
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