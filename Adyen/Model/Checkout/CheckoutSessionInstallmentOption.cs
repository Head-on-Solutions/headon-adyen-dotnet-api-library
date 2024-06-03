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
    /// CheckoutSessionInstallmentOption
    /// </summary>
    [DataContract(Name = "CheckoutSessionInstallmentOption")]
    public partial class CheckoutSessionInstallmentOption : IEquatable<CheckoutSessionInstallmentOption>, IValidatableObject
    {
        /// <summary>
        /// Defines Plans
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlansEnum
        {
            /// <summary>
            /// Enum Regular for value: regular
            /// </summary>
            [EnumMember(Value = "regular")]
            Regular = 1,

            /// <summary>
            /// Enum Revolving for value: revolving
            /// </summary>
            [EnumMember(Value = "revolving")]
            Revolving = 2

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSessionInstallmentOption" /> class.
        /// </summary>
        /// <param name="plans">Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**.</param>
        /// <param name="preselectedValue">Preselected number of installments offered for this payment method..</param>
        /// <param name="values">An array of the number of installments that the shopper can choose from. For example, **[2,3,5]**. This cannot be specified simultaneously with &#x60;maxValue&#x60;..</param>
        public CheckoutSessionInstallmentOption(List<PlansEnum> plans = default(List<PlansEnum>), int? preselectedValue = default(int?), List<int> values = default(List<int>))
        {
            this.Plans = plans;
            this.PreselectedValue = preselectedValue;
            this.Values = values;
        }

        /// <summary>
        /// Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**
        /// </summary>
        /// <value>Defines the type of installment plan. If not set, defaults to **regular**.  Possible values: * **regular** * **revolving**</value>
        [DataMember(Name = "plans", EmitDefaultValue = false)]
        public List<CheckoutSessionInstallmentOption.PlansEnum> Plans { get; set; }

        /// <summary>
        /// Preselected number of installments offered for this payment method.
        /// </summary>
        /// <value>Preselected number of installments offered for this payment method.</value>
        [DataMember(Name = "preselectedValue", EmitDefaultValue = false)]
        public int? PreselectedValue { get; set; }

        /// <summary>
        /// An array of the number of installments that the shopper can choose from. For example, **[2,3,5]**. This cannot be specified simultaneously with &#x60;maxValue&#x60;.
        /// </summary>
        /// <value>An array of the number of installments that the shopper can choose from. For example, **[2,3,5]**. This cannot be specified simultaneously with &#x60;maxValue&#x60;.</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<int> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutSessionInstallmentOption {\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
            sb.Append("  PreselectedValue: ").Append(PreselectedValue).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as CheckoutSessionInstallmentOption);
        }

        /// <summary>
        /// Returns true if CheckoutSessionInstallmentOption instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutSessionInstallmentOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutSessionInstallmentOption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Plans == input.Plans ||
                    this.Plans != null &&
                    input.Plans != null &&
                    this.Plans.SequenceEqual(input.Plans)
                ) && 
                (
                    this.PreselectedValue == input.PreselectedValue ||
                    this.PreselectedValue.Equals(input.PreselectedValue)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Plans != null)
                {
                    hashCode = (hashCode * 59) + this.Plans.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PreselectedValue.GetHashCode();
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
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
