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
    /// ThreeDSAvailabilityRequest
    /// </summary>
    [DataContract(Name = "ThreeDSAvailabilityRequest")]
    public partial class ThreeDSAvailabilityRequest : IEquatable<ThreeDSAvailabilityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSAvailabilityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThreeDSAvailabilityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSAvailabilityRequest" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be required for a particular request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value..</param>
        /// <param name="brands">List of brands..</param>
        /// <param name="cardNumber">Card number or BIN..</param>
        /// <param name="merchantAccount">The merchant account identifier. (required).</param>
        /// <param name="recurringDetailReference">A recurring detail reference corresponding to a card..</param>
        /// <param name="shopperReference">The shopper&#39;s reference to uniquely identify this shopper (e.g. user ID or account ID)..</param>
        public ThreeDSAvailabilityRequest(Dictionary<string, string> additionalData = default(Dictionary<string, string>), List<string> brands = default(List<string>), string cardNumber = default(string), string merchantAccount = default(string), string recurringDetailReference = default(string), string shopperReference = default(string))
        {
            this.MerchantAccount = merchantAccount;
            this.AdditionalData = additionalData;
            this.Brands = brands;
            this.CardNumber = cardNumber;
            this.RecurringDetailReference = recurringDetailReference;
            this.ShopperReference = shopperReference;
        }

        /// <summary>
        /// This field contains additional data, which may be required for a particular request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// List of brands.
        /// </summary>
        /// <value>List of brands.</value>
        [DataMember(Name = "brands", EmitDefaultValue = false)]
        public List<string> Brands { get; set; }

        /// <summary>
        /// Card number or BIN.
        /// </summary>
        /// <value>Card number or BIN.</value>
        [DataMember(Name = "cardNumber", EmitDefaultValue = false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// The merchant account identifier.
        /// </summary>
        /// <value>The merchant account identifier.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// A recurring detail reference corresponding to a card.
        /// </summary>
        /// <value>A recurring detail reference corresponding to a card.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// The shopper&#39;s reference to uniquely identify this shopper (e.g. user ID or account ID).
        /// </summary>
        /// <value>The shopper&#39;s reference to uniquely identify this shopper (e.g. user ID or account ID).</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThreeDSAvailabilityRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
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
            return this.Equals(input as ThreeDSAvailabilityRequest);
        }

        /// <summary>
        /// Returns true if ThreeDSAvailabilityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSAvailabilityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSAvailabilityRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) && 
                (
                    this.Brands == input.Brands ||
                    this.Brands != null &&
                    input.Brands != null &&
                    this.Brands.SequenceEqual(input.Brands)
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
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
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
                }
                if (this.Brands != null)
                {
                    hashCode = (hashCode * 59) + this.Brands.GetHashCode();
                }
                if (this.CardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CardNumber.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
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
