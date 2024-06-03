/*
* POS Terminal Management API
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

namespace HeadOn.Classic.Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// GetTerminalsUnderAccountRequest
    /// </summary>
    [DataContract(Name = "GetTerminalsUnderAccountRequest")]
    public partial class GetTerminalsUnderAccountRequest : IEquatable<GetTerminalsUnderAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTerminalsUnderAccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTerminalsUnderAccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTerminalsUnderAccountRequest" /> class.
        /// </summary>
        /// <param name="companyAccount">Your company account. If you only specify this parameter, the response includes all terminals at all account levels. (required).</param>
        /// <param name="merchantAccount">The merchant account. This is required if you are retrieving the terminals assigned to a store.If you don&#39;t specify a &#x60;store&#x60; the response includes the terminals assigned to the specified merchant account and the terminals assigned to the stores under this merchant account..</param>
        /// <param name="store">The store code of the store. With this parameter, the response only includes the terminals assigned to the specified store..</param>
        public GetTerminalsUnderAccountRequest(string companyAccount = default(string), string merchantAccount = default(string), string store = default(string))
        {
            this.CompanyAccount = companyAccount;
            this.MerchantAccount = merchantAccount;
            this.Store = store;
        }

        /// <summary>
        /// Your company account. If you only specify this parameter, the response includes all terminals at all account levels.
        /// </summary>
        /// <value>Your company account. If you only specify this parameter, the response includes all terminals at all account levels.</value>
        [DataMember(Name = "companyAccount", IsRequired = false, EmitDefaultValue = false)]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// The merchant account. This is required if you are retrieving the terminals assigned to a store.If you don&#39;t specify a &#x60;store&#x60; the response includes the terminals assigned to the specified merchant account and the terminals assigned to the stores under this merchant account.
        /// </summary>
        /// <value>The merchant account. This is required if you are retrieving the terminals assigned to a store.If you don&#39;t specify a &#x60;store&#x60; the response includes the terminals assigned to the specified merchant account and the terminals assigned to the stores under this merchant account.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The store code of the store. With this parameter, the response only includes the terminals assigned to the specified store.
        /// </summary>
        /// <value>The store code of the store. With this parameter, the response only includes the terminals assigned to the specified store.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        public string Store { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTerminalsUnderAccountRequest {\n");
            sb.Append("  CompanyAccount: ").Append(CompanyAccount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
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
            return this.Equals(input as GetTerminalsUnderAccountRequest);
        }

        /// <summary>
        /// Returns true if GetTerminalsUnderAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTerminalsUnderAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTerminalsUnderAccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyAccount == input.CompanyAccount ||
                    (this.CompanyAccount != null &&
                    this.CompanyAccount.Equals(input.CompanyAccount))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
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
                if (this.CompanyAccount != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyAccount.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.Store != null)
                {
                    hashCode = (hashCode * 59) + this.Store.GetHashCode();
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
