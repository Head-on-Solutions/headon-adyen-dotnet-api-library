/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace HeadOn.Classic.Adyen.Model.Management
{
    /// <summary>
    /// ApiCredentialLinks
    /// </summary>
    [DataContract(Name = "ApiCredentialLinks")]
    public partial class ApiCredentialLinks : IEquatable<ApiCredentialLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCredentialLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiCredentialLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCredentialLinks" /> class.
        /// </summary>
        /// <param name="allowedOrigins">allowedOrigins.</param>
        /// <param name="company">company.</param>
        /// <param name="generateApiKey">generateApiKey.</param>
        /// <param name="generateClientKey">generateClientKey.</param>
        /// <param name="merchant">merchant.</param>
        /// <param name="self">self (required).</param>
        public ApiCredentialLinks(LinksElement allowedOrigins = default(LinksElement), LinksElement company = default(LinksElement), LinksElement generateApiKey = default(LinksElement), LinksElement generateClientKey = default(LinksElement), LinksElement merchant = default(LinksElement), LinksElement self = default(LinksElement))
        {
            this.Self = self;
            this.AllowedOrigins = allowedOrigins;
            this.Company = company;
            this.GenerateApiKey = generateApiKey;
            this.GenerateClientKey = generateClientKey;
            this.Merchant = merchant;
        }

        /// <summary>
        /// Gets or Sets AllowedOrigins
        /// </summary>
        [DataMember(Name = "allowedOrigins", EmitDefaultValue = false)]
        public LinksElement AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public LinksElement Company { get; set; }

        /// <summary>
        /// Gets or Sets GenerateApiKey
        /// </summary>
        [DataMember(Name = "generateApiKey", EmitDefaultValue = false)]
        public LinksElement GenerateApiKey { get; set; }

        /// <summary>
        /// Gets or Sets GenerateClientKey
        /// </summary>
        [DataMember(Name = "generateClientKey", EmitDefaultValue = false)]
        public LinksElement GenerateClientKey { get; set; }

        /// <summary>
        /// Gets or Sets Merchant
        /// </summary>
        [DataMember(Name = "merchant", EmitDefaultValue = false)]
        public LinksElement Merchant { get; set; }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", IsRequired = false, EmitDefaultValue = false)]
        public LinksElement Self { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiCredentialLinks {\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  GenerateApiKey: ").Append(GenerateApiKey).Append("\n");
            sb.Append("  GenerateClientKey: ").Append(GenerateClientKey).Append("\n");
            sb.Append("  Merchant: ").Append(Merchant).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return this.Equals(input as ApiCredentialLinks);
        }

        /// <summary>
        /// Returns true if ApiCredentialLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiCredentialLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiCredentialLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowedOrigins == input.AllowedOrigins ||
                    (this.AllowedOrigins != null &&
                    this.AllowedOrigins.Equals(input.AllowedOrigins))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.GenerateApiKey == input.GenerateApiKey ||
                    (this.GenerateApiKey != null &&
                    this.GenerateApiKey.Equals(input.GenerateApiKey))
                ) && 
                (
                    this.GenerateClientKey == input.GenerateClientKey ||
                    (this.GenerateClientKey != null &&
                    this.GenerateClientKey.Equals(input.GenerateClientKey))
                ) && 
                (
                    this.Merchant == input.Merchant ||
                    (this.Merchant != null &&
                    this.Merchant.Equals(input.Merchant))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
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
                if (this.AllowedOrigins != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedOrigins.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.GenerateApiKey != null)
                {
                    hashCode = (hashCode * 59) + this.GenerateApiKey.GetHashCode();
                }
                if (this.GenerateClientKey != null)
                {
                    hashCode = (hashCode * 59) + this.GenerateClientKey.GetHashCode();
                }
                if (this.Merchant != null)
                {
                    hashCode = (hashCode * 59) + this.Merchant.GetHashCode();
                }
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
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
