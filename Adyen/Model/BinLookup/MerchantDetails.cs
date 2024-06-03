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
    /// MerchantDetails
    /// </summary>
    [DataContract(Name = "MerchantDetails")]
    public partial class MerchantDetails : IEquatable<MerchantDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantDetails" /> class.
        /// </summary>
        /// <param name="countryCode">2-letter ISO 3166 country code of the card acceptor location. &gt; This parameter is required for the merchants who don&#39;t use Adyen as the payment authorisation gateway..</param>
        /// <param name="enrolledIn3DSecure">If true, indicates that the merchant is enrolled in 3D Secure for the card network..</param>
        /// <param name="mcc">The merchant category code (MCC) is a four-digit number which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.  The list of MCCs can be found [here](https://en.wikipedia.org/wiki/Merchant_category_code)..</param>
        public MerchantDetails(string countryCode = default(string), bool enrolledIn3DSecure = default(bool), string mcc = default(string))
        {
            this.CountryCode = countryCode;
            this.EnrolledIn3DSecure = enrolledIn3DSecure;
            this.Mcc = mcc;
        }

        /// <summary>
        /// 2-letter ISO 3166 country code of the card acceptor location. &gt; This parameter is required for the merchants who don&#39;t use Adyen as the payment authorisation gateway.
        /// </summary>
        /// <value>2-letter ISO 3166 country code of the card acceptor location. &gt; This parameter is required for the merchants who don&#39;t use Adyen as the payment authorisation gateway.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// If true, indicates that the merchant is enrolled in 3D Secure for the card network.
        /// </summary>
        /// <value>If true, indicates that the merchant is enrolled in 3D Secure for the card network.</value>
        [DataMember(Name = "enrolledIn3DSecure", EmitDefaultValue = false)]
        public bool EnrolledIn3DSecure { get; set; }

        /// <summary>
        /// The merchant category code (MCC) is a four-digit number which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.  The list of MCCs can be found [here](https://en.wikipedia.org/wiki/Merchant_category_code).
        /// </summary>
        /// <value>The merchant category code (MCC) is a four-digit number which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.  The list of MCCs can be found [here](https://en.wikipedia.org/wiki/Merchant_category_code).</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public string Mcc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantDetails {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  EnrolledIn3DSecure: ").Append(EnrolledIn3DSecure).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
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
            return this.Equals(input as MerchantDetails);
        }

        /// <summary>
        /// Returns true if MerchantDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.EnrolledIn3DSecure == input.EnrolledIn3DSecure ||
                    this.EnrolledIn3DSecure.Equals(input.EnrolledIn3DSecure)
                ) && 
                (
                    this.Mcc == input.Mcc ||
                    (this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc))
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
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnrolledIn3DSecure.GetHashCode();
                if (this.Mcc != null)
                {
                    hashCode = (hashCode * 59) + this.Mcc.GetHashCode();
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
            // CountryCode (string) maxLength
            if (this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // CountryCode (string) minLength
            if (this.CountryCode != null && this.CountryCode.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be greater than 2.", new [] { "CountryCode" });
            }

            yield break;
        }
    }

}
