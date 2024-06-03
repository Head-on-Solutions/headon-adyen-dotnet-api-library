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
using OpenAPIDateConverter = HeadOn.Classic.Adyen.ApiSerialization.OpenAPIDateConverter;

namespace HeadOn.Classic.Adyen.Model.Payment
{
    /// <summary>
    /// DonationRequest
    /// </summary>
    [DataContract(Name = "DonationRequest")]
    public partial class DonationRequest : IEquatable<DonationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DonationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationRequest" /> class.
        /// </summary>
        /// <param name="donationAccount">The Adyen account name of the charity. (required).</param>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="modificationAmount">modificationAmount (required).</param>
        /// <param name="originalReference">The original pspReference of the payment to modify. This reference is returned in: * authorisation response * authorisation notification  .</param>
        /// <param name="platformChargebackLogic">platformChargebackLogic.</param>
        /// <param name="reference">Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters..</param>
        public DonationRequest(string donationAccount = default(string), string merchantAccount = default(string), Amount modificationAmount = default(Amount), string originalReference = default(string), PlatformChargebackLogic platformChargebackLogic = default(PlatformChargebackLogic), string reference = default(string))
        {
            this.DonationAccount = donationAccount;
            this.MerchantAccount = merchantAccount;
            this.ModificationAmount = modificationAmount;
            this.OriginalReference = originalReference;
            this.PlatformChargebackLogic = platformChargebackLogic;
            this.Reference = reference;
        }

        /// <summary>
        /// The Adyen account name of the charity.
        /// </summary>
        /// <value>The Adyen account name of the charity.</value>
        [DataMember(Name = "donationAccount", IsRequired = false, EmitDefaultValue = false)]
        public string DonationAccount { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        /// <value>The merchant account that is used to process the payment.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets ModificationAmount
        /// </summary>
        [DataMember(Name = "modificationAmount", IsRequired = false, EmitDefaultValue = false)]
        public Amount ModificationAmount { get; set; }

        /// <summary>
        /// The original pspReference of the payment to modify. This reference is returned in: * authorisation response * authorisation notification  
        /// </summary>
        /// <value>The original pspReference of the payment to modify. This reference is returned in: * authorisation response * authorisation notification  </value>
        [DataMember(Name = "originalReference", EmitDefaultValue = false)]
        public string OriginalReference { get; set; }

        /// <summary>
        /// Gets or Sets PlatformChargebackLogic
        /// </summary>
        [DataMember(Name = "platformChargebackLogic", EmitDefaultValue = false)]
        public PlatformChargebackLogic PlatformChargebackLogic { get; set; }

        /// <summary>
        /// Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters.
        /// </summary>
        /// <value>Your reference for the payment modification. This reference is visible in Customer Area and in reports. Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DonationRequest {\n");
            sb.Append("  DonationAccount: ").Append(DonationAccount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  ModificationAmount: ").Append(ModificationAmount).Append("\n");
            sb.Append("  OriginalReference: ").Append(OriginalReference).Append("\n");
            sb.Append("  PlatformChargebackLogic: ").Append(PlatformChargebackLogic).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as DonationRequest);
        }

        /// <summary>
        /// Returns true if DonationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DonationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DonationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DonationAccount == input.DonationAccount ||
                    (this.DonationAccount != null &&
                    this.DonationAccount.Equals(input.DonationAccount))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.ModificationAmount == input.ModificationAmount ||
                    (this.ModificationAmount != null &&
                    this.ModificationAmount.Equals(input.ModificationAmount))
                ) && 
                (
                    this.OriginalReference == input.OriginalReference ||
                    (this.OriginalReference != null &&
                    this.OriginalReference.Equals(input.OriginalReference))
                ) && 
                (
                    this.PlatformChargebackLogic == input.PlatformChargebackLogic ||
                    (this.PlatformChargebackLogic != null &&
                    this.PlatformChargebackLogic.Equals(input.PlatformChargebackLogic))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.DonationAccount != null)
                {
                    hashCode = (hashCode * 59) + this.DonationAccount.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.ModificationAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ModificationAmount.GetHashCode();
                }
                if (this.OriginalReference != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalReference.GetHashCode();
                }
                if (this.PlatformChargebackLogic != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformChargebackLogic.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
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
