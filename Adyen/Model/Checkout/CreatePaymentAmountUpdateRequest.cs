/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace HeadOn.Classic.Adyen.Model.Checkout
{
    /// <summary>
    /// CreatePaymentAmountUpdateRequest
    /// </summary>
    [DataContract(Name = "CreatePaymentAmountUpdateRequest")]
    public partial class CreatePaymentAmountUpdateRequest : IEquatable<CreatePaymentAmountUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**  * **installment**
        /// </summary>
        /// <value>The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**  * **installment**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IndustryUsageEnum
        {
            /// <summary>
            /// Enum DelayedCharge for value: delayedCharge
            /// </summary>
            [EnumMember(Value = "delayedCharge")]
            DelayedCharge = 1,

            /// <summary>
            /// Enum Installment for value: installment
            /// </summary>
            [EnumMember(Value = "installment")]
            Installment = 2,

            /// <summary>
            /// Enum NoShow for value: noShow
            /// </summary>
            [EnumMember(Value = "noShow")]
            NoShow = 3

        }


        /// <summary>
        /// The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**  * **installment**
        /// </summary>
        /// <value>The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**  * **installment**</value>
        [DataMember(Name = "industryUsage", EmitDefaultValue = false)]
        public IndustryUsageEnum? IndustryUsage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentAmountUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePaymentAmountUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentAmountUpdateRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="industryUsage">The reason for the amount update. Possible values:  * **delayedCharge**  * **noShow**  * **installment**.</param>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="reference">Your reference for the amount update request. Maximum length: 80 characters..</param>
        /// <param name="splits">An array of objects specifying how the amount should be split between accounts when using HeadOn.Classic.Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information)..</param>
        public CreatePaymentAmountUpdateRequest(Amount amount = default(Amount), IndustryUsageEnum? industryUsage = default(IndustryUsageEnum?), string merchantAccount = default(string), string reference = default(string), List<Split> splits = default(List<Split>))
        {
            this.Amount = amount;
            this.MerchantAccount = merchantAccount;
            this.IndustryUsage = industryUsage;
            this.Reference = reference;
            this.Splits = splits;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        /// <value>The merchant account that is used to process the payment.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Your reference for the amount update request. Maximum length: 80 characters.
        /// </summary>
        /// <value>Your reference for the amount update request. Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// An array of objects specifying how the amount should be split between accounts when using HeadOn.Classic.Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information).
        /// </summary>
        /// <value>An array of objects specifying how the amount should be split between accounts when using HeadOn.Classic.Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information).</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePaymentAmountUpdateRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  IndustryUsage: ").Append(IndustryUsage).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
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
            return this.Equals(input as CreatePaymentAmountUpdateRequest);
        }

        /// <summary>
        /// Returns true if CreatePaymentAmountUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePaymentAmountUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePaymentAmountUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.IndustryUsage == input.IndustryUsage ||
                    this.IndustryUsage.Equals(input.IndustryUsage)
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Splits == input.Splits ||
                    this.Splits != null &&
                    input.Splits != null &&
                    this.Splits.SequenceEqual(input.Splits)
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IndustryUsage.GetHashCode();
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Splits != null)
                {
                    hashCode = (hashCode * 59) + this.Splits.GetHashCode();
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
