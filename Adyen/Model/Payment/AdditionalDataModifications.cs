/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Payment
{
    /// <summary>
    /// AdditionalDataModifications
    /// </summary>
    [DataContract(Name = "AdditionalDataModifications")]
    public partial class AdditionalDataModifications : IEquatable<AdditionalDataModifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataModifications" /> class.
        /// </summary>
        /// <param name="installmentPaymentDataSelectedInstallmentOption">This is the installment option selected by the shopper. It is required only if specified by the user..</param>
        public AdditionalDataModifications(string installmentPaymentDataSelectedInstallmentOption = default(string))
        {
            this.InstallmentPaymentDataSelectedInstallmentOption = installmentPaymentDataSelectedInstallmentOption;
        }

        /// <summary>
        /// This is the installment option selected by the shopper. It is required only if specified by the user.
        /// </summary>
        /// <value>This is the installment option selected by the shopper. It is required only if specified by the user.</value>
        [DataMember(Name = "installmentPaymentData.selectedInstallmentOption", EmitDefaultValue = false)]
        public string InstallmentPaymentDataSelectedInstallmentOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataModifications {\n");
            sb.Append("  InstallmentPaymentDataSelectedInstallmentOption: ").Append(InstallmentPaymentDataSelectedInstallmentOption).Append("\n");
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
            return this.Equals(input as AdditionalDataModifications);
        }

        /// <summary>
        /// Returns true if AdditionalDataModifications instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataModifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataModifications input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstallmentPaymentDataSelectedInstallmentOption == input.InstallmentPaymentDataSelectedInstallmentOption ||
                    (this.InstallmentPaymentDataSelectedInstallmentOption != null &&
                    this.InstallmentPaymentDataSelectedInstallmentOption.Equals(input.InstallmentPaymentDataSelectedInstallmentOption))
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
                if (this.InstallmentPaymentDataSelectedInstallmentOption != null)
                {
                    hashCode = (hashCode * 59) + this.InstallmentPaymentDataSelectedInstallmentOption.GetHashCode();
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
