/*
* Classic Platforms - Notifications
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsWebhooks
{
    /// <summary>
    /// PersonalDocumentData
    /// </summary>
    [DataContract(Name = "PersonalDocumentData")]
    public partial class PersonalDocumentData : IEquatable<PersonalDocumentData>, IValidatableObject
    {
        /// <summary>
        /// The type of the document. Possible values: **ID**, **DRIVINGLICENSE**, **PASSPORT**, **SOCIALSECURITY**, **VISA**.  To delete an existing entry for a document &#x60;type&#x60;, send only the &#x60;type&#x60; field in your request. 
        /// </summary>
        /// <value>The type of the document. Possible values: **ID**, **DRIVINGLICENSE**, **PASSPORT**, **SOCIALSECURITY**, **VISA**.  To delete an existing entry for a document &#x60;type&#x60;, send only the &#x60;type&#x60; field in your request. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DRIVINGLICENSE for value: DRIVINGLICENSE
            /// </summary>
            [EnumMember(Value = "DRIVINGLICENSE")]
            DRIVINGLICENSE = 1,

            /// <summary>
            /// Enum ID for value: ID
            /// </summary>
            [EnumMember(Value = "ID")]
            ID = 2,

            /// <summary>
            /// Enum PASSPORT for value: PASSPORT
            /// </summary>
            [EnumMember(Value = "PASSPORT")]
            PASSPORT = 3,

            /// <summary>
            /// Enum SOCIALSECURITY for value: SOCIALSECURITY
            /// </summary>
            [EnumMember(Value = "SOCIALSECURITY")]
            SOCIALSECURITY = 4,

            /// <summary>
            /// Enum VISA for value: VISA
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISA = 5

        }


        /// <summary>
        /// The type of the document. Possible values: **ID**, **DRIVINGLICENSE**, **PASSPORT**, **SOCIALSECURITY**, **VISA**.  To delete an existing entry for a document &#x60;type&#x60;, send only the &#x60;type&#x60; field in your request. 
        /// </summary>
        /// <value>The type of the document. Possible values: **ID**, **DRIVINGLICENSE**, **PASSPORT**, **SOCIALSECURITY**, **VISA**.  To delete an existing entry for a document &#x60;type&#x60;, send only the &#x60;type&#x60; field in your request. </value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalDocumentData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PersonalDocumentData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalDocumentData" /> class.
        /// </summary>
        /// <param name="expirationDate">The expiry date of the document,   in ISO-8601 YYYY-MM-DD format. For example, **2000-01-31**..</param>
        /// <param name="issuerCountry">The country where the document was issued, in the two-character  [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **NL**..</param>
        /// <param name="issuerState">The state where the document was issued (if applicable)..</param>
        /// <param name="number">The number in the document..</param>
        /// <param name="type">The type of the document. Possible values: **ID**, **DRIVINGLICENSE**, **PASSPORT**, **SOCIALSECURITY**, **VISA**.  To delete an existing entry for a document &#x60;type&#x60;, send only the &#x60;type&#x60; field in your request.  (required).</param>
        public PersonalDocumentData(string expirationDate = default(string), string issuerCountry = default(string), string issuerState = default(string), string number = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Type = type;
            this.ExpirationDate = expirationDate;
            this.IssuerCountry = issuerCountry;
            this.IssuerState = issuerState;
            this.Number = number;
        }

        /// <summary>
        /// The expiry date of the document,   in ISO-8601 YYYY-MM-DD format. For example, **2000-01-31**.
        /// </summary>
        /// <value>The expiry date of the document,   in ISO-8601 YYYY-MM-DD format. For example, **2000-01-31**.</value>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// The country where the document was issued, in the two-character  [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **NL**.
        /// </summary>
        /// <value>The country where the document was issued, in the two-character  [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. For example, **NL**.</value>
        [DataMember(Name = "issuerCountry", EmitDefaultValue = false)]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// The state where the document was issued (if applicable).
        /// </summary>
        /// <value>The state where the document was issued (if applicable).</value>
        [DataMember(Name = "issuerState", EmitDefaultValue = false)]
        public string IssuerState { get; set; }

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
            sb.Append("class PersonalDocumentData {\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IssuerCountry: ").Append(IssuerCountry).Append("\n");
            sb.Append("  IssuerState: ").Append(IssuerState).Append("\n");
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
            return this.Equals(input as PersonalDocumentData);
        }

        /// <summary>
        /// Returns true if PersonalDocumentData instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonalDocumentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalDocumentData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
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
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
                }
                if (this.IssuerCountry != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerCountry.GetHashCode();
                }
                if (this.IssuerState != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerState.GetHashCode();
                }
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
            // IssuerCountry (string) maxLength
            if (this.IssuerCountry != null && this.IssuerCountry.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerCountry, length must be less than 2.", new [] { "IssuerCountry" });
            }

            // IssuerCountry (string) minLength
            if (this.IssuerCountry != null && this.IssuerCountry.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerCountry, length must be greater than 2.", new [] { "IssuerCountry" });
            }

            yield break;
        }
    }

}