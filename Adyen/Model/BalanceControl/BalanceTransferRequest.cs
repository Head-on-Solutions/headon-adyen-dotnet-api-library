/*
* Adyen Balance Control API
*
*
* The version of the OpenAPI document: 1
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

namespace HeadOn.Classic.Adyen.Model.BalanceControl
{
    /// <summary>
    /// BalanceTransferRequest
    /// </summary>
    [DataContract(Name = "BalanceTransferRequest")]
    public partial class BalanceTransferRequest : IEquatable<BalanceTransferRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of balance transfer. Possible values: **tax**, **fee**, **terminalSale**, **credit**, **debit**, and **adjustment**.
        /// </summary>
        /// <value>The type of balance transfer. Possible values: **tax**, **fee**, **terminalSale**, **credit**, **debit**, and **adjustment**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Tax for value: tax
            /// </summary>
            [EnumMember(Value = "tax")]
            Tax = 1,

            /// <summary>
            /// Enum Fee for value: fee
            /// </summary>
            [EnumMember(Value = "fee")]
            Fee = 2,

            /// <summary>
            /// Enum TerminalSale for value: terminalSale
            /// </summary>
            [EnumMember(Value = "terminalSale")]
            TerminalSale = 3,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 4,

            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 5,

            /// <summary>
            /// Enum Adjustment for value: adjustment
            /// </summary>
            [EnumMember(Value = "adjustment")]
            Adjustment = 6

        }


        /// <summary>
        /// The type of balance transfer. Possible values: **tax**, **fee**, **terminalSale**, **credit**, **debit**, and **adjustment**.
        /// </summary>
        /// <value>The type of balance transfer. Possible values: **tax**, **fee**, **terminalSale**, **credit**, **debit**, and **adjustment**.</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceTransferRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceTransferRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceTransferRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="description">A human-readable description for the transfer. You can use alphanumeric characters and hyphens. We recommend sending a maximum of 140 characters, otherwise the description may be truncated..</param>
        /// <param name="fromMerchant">The unique identifier of the source merchant account from which funds are deducted. (required).</param>
        /// <param name="reference">A reference for the balance transfer. If you don&#39;t provide this in the request, Adyen generates a unique reference. Maximum length: 80 characters..</param>
        /// <param name="toMerchant">The unique identifier of the destination merchant account from which funds are transferred. (required).</param>
        /// <param name="type">The type of balance transfer. Possible values: **tax**, **fee**, **terminalSale**, **credit**, **debit**, and **adjustment**. (required).</param>
        public BalanceTransferRequest(Amount amount = default(Amount), string description = default(string), string fromMerchant = default(string), string reference = default(string), string toMerchant = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Amount = amount;
            this.FromMerchant = fromMerchant;
            this.ToMerchant = toMerchant;
            this.Type = type;
            this.Description = description;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// A human-readable description for the transfer. You can use alphanumeric characters and hyphens. We recommend sending a maximum of 140 characters, otherwise the description may be truncated.
        /// </summary>
        /// <value>A human-readable description for the transfer. You can use alphanumeric characters and hyphens. We recommend sending a maximum of 140 characters, otherwise the description may be truncated.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the source merchant account from which funds are deducted.
        /// </summary>
        /// <value>The unique identifier of the source merchant account from which funds are deducted.</value>
        [DataMember(Name = "fromMerchant", IsRequired = false, EmitDefaultValue = false)]
        public string FromMerchant { get; set; }

        /// <summary>
        /// A reference for the balance transfer. If you don&#39;t provide this in the request, Adyen generates a unique reference. Maximum length: 80 characters.
        /// </summary>
        /// <value>A reference for the balance transfer. If you don&#39;t provide this in the request, Adyen generates a unique reference. Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The unique identifier of the destination merchant account from which funds are transferred.
        /// </summary>
        /// <value>The unique identifier of the destination merchant account from which funds are transferred.</value>
        [DataMember(Name = "toMerchant", IsRequired = false, EmitDefaultValue = false)]
        public string ToMerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceTransferRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FromMerchant: ").Append(FromMerchant).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ToMerchant: ").Append(ToMerchant).Append("\n");
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
            return this.Equals(input as BalanceTransferRequest);
        }

        /// <summary>
        /// Returns true if BalanceTransferRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceTransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceTransferRequest input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FromMerchant == input.FromMerchant ||
                    (this.FromMerchant != null &&
                    this.FromMerchant.Equals(input.FromMerchant))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ToMerchant == input.ToMerchant ||
                    (this.ToMerchant != null &&
                    this.ToMerchant.Equals(input.ToMerchant))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FromMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.FromMerchant.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.ToMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.ToMerchant.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 140)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 140.", new [] { "Description" });
            }

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 80.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
