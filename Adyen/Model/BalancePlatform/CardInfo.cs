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
    /// CardInfo
    /// </summary>
    [DataContract(Name = "CardInfo")]
    public partial class CardInfo : IEquatable<CardInfo>, IValidatableObject
    {
        /// <summary>
        /// The form factor of the card. Possible values: **virtual**, **physical**.
        /// </summary>
        /// <value>The form factor of the card. Possible values: **virtual**, **physical**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormFactorEnum
        {
            /// <summary>
            /// Enum Physical for value: physical
            /// </summary>
            [EnumMember(Value = "physical")]
            Physical = 1,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 2,

            /// <summary>
            /// Enum Virtual for value: virtual
            /// </summary>
            [EnumMember(Value = "virtual")]
            Virtual = 3

        }


        /// <summary>
        /// The form factor of the card. Possible values: **virtual**, **physical**.
        /// </summary>
        /// <value>The form factor of the card. Possible values: **virtual**, **physical**.</value>
        [DataMember(Name = "formFactor", IsRequired = false, EmitDefaultValue = false)]
        public FormFactorEnum FormFactor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardInfo" /> class.
        /// </summary>
        /// <param name="authentication">authentication.</param>
        /// <param name="brand">The brand of the physical or the virtual card. Possible values: **visa**, **mc**. (required).</param>
        /// <param name="brandVariant">The brand variant of the physical or the virtual card. &gt;Contact your Adyen Implementation Manager to get the values that are relevant to your integration. Examples: **visadebit**, **mcprepaid**. (required).</param>
        /// <param name="cardholderName">The name of the cardholder.  Maximum length: 26 characters. (required).</param>
        /// <param name="configuration">configuration.</param>
        /// <param name="deliveryContact">deliveryContact.</param>
        /// <param name="formFactor">The form factor of the card. Possible values: **virtual**, **physical**. (required).</param>
        public CardInfo(Authentication authentication = default(Authentication), string brand = default(string), string brandVariant = default(string), string cardholderName = default(string), CardConfiguration configuration = default(CardConfiguration), DeliveryContact deliveryContact = default(DeliveryContact), FormFactorEnum formFactor = default(FormFactorEnum))
        {
            this.Brand = brand;
            this.BrandVariant = brandVariant;
            this.CardholderName = cardholderName;
            this.FormFactor = formFactor;
            this.Authentication = authentication;
            this._Configuration = configuration;
            this.DeliveryContact = deliveryContact;
        }

        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name = "authentication", EmitDefaultValue = false)]
        public Authentication Authentication { get; set; }

        /// <summary>
        /// The brand of the physical or the virtual card. Possible values: **visa**, **mc**.
        /// </summary>
        /// <value>The brand of the physical or the virtual card. Possible values: **visa**, **mc**.</value>
        [DataMember(Name = "brand", IsRequired = false, EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The brand variant of the physical or the virtual card. &gt;Contact your Adyen Implementation Manager to get the values that are relevant to your integration. Examples: **visadebit**, **mcprepaid**.
        /// </summary>
        /// <value>The brand variant of the physical or the virtual card. &gt;Contact your Adyen Implementation Manager to get the values that are relevant to your integration. Examples: **visadebit**, **mcprepaid**.</value>
        [DataMember(Name = "brandVariant", IsRequired = false, EmitDefaultValue = false)]
        public string BrandVariant { get; set; }

        /// <summary>
        /// The name of the cardholder.  Maximum length: 26 characters.
        /// </summary>
        /// <value>The name of the cardholder.  Maximum length: 26 characters.</value>
        [DataMember(Name = "cardholderName", IsRequired = false, EmitDefaultValue = false)]
        public string CardholderName { get; set; }

        /// <summary>
        /// Gets or Sets _Configuration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public CardConfiguration _Configuration { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryContact
        /// </summary>
        [DataMember(Name = "deliveryContact", EmitDefaultValue = false)]
        public DeliveryContact DeliveryContact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardInfo {\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  BrandVariant: ").Append(BrandVariant).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            sb.Append("  _Configuration: ").Append(_Configuration).Append("\n");
            sb.Append("  DeliveryContact: ").Append(DeliveryContact).Append("\n");
            sb.Append("  FormFactor: ").Append(FormFactor).Append("\n");
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
            return this.Equals(input as CardInfo);
        }

        /// <summary>
        /// Returns true if CardInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CardInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.BrandVariant == input.BrandVariant ||
                    (this.BrandVariant != null &&
                    this.BrandVariant.Equals(input.BrandVariant))
                ) && 
                (
                    this.CardholderName == input.CardholderName ||
                    (this.CardholderName != null &&
                    this.CardholderName.Equals(input.CardholderName))
                ) && 
                (
                    this._Configuration == input._Configuration ||
                    (this._Configuration != null &&
                    this._Configuration.Equals(input._Configuration))
                ) && 
                (
                    this.DeliveryContact == input.DeliveryContact ||
                    (this.DeliveryContact != null &&
                    this.DeliveryContact.Equals(input.DeliveryContact))
                ) && 
                (
                    this.FormFactor == input.FormFactor ||
                    this.FormFactor.Equals(input.FormFactor)
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
                if (this.Authentication != null)
                {
                    hashCode = (hashCode * 59) + this.Authentication.GetHashCode();
                }
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.BrandVariant != null)
                {
                    hashCode = (hashCode * 59) + this.BrandVariant.GetHashCode();
                }
                if (this.CardholderName != null)
                {
                    hashCode = (hashCode * 59) + this.CardholderName.GetHashCode();
                }
                if (this._Configuration != null)
                {
                    hashCode = (hashCode * 59) + this._Configuration.GetHashCode();
                }
                if (this.DeliveryContact != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryContact.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FormFactor.GetHashCode();
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
            // CardholderName (string) maxLength
            if (this.CardholderName != null && this.CardholderName.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardholderName, length must be less than 26.", new [] { "CardholderName" });
            }

            yield break;
        }
    }

}
