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
    /// Store
    /// </summary>
    [DataContract(Name = "Store")]
    public partial class Store : IEquatable<Store>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Store() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="description">The description of the store..</param>
        /// <param name="inStoreTerminals">The list of terminals assigned to the store..</param>
        /// <param name="merchantAccountCode">The code of the merchant account..</param>
        /// <param name="status">The status of the store:  - &#x60;PreActive&#x60;: the store has been created, but not yet activated.   - &#x60;Active&#x60;: the store has been activated. This means you can process payments for this store.   - &#x60;Inactive&#x60;: the store is currently not active.   - &#x60;InactiveWithModifications&#x60;: the store is currently not active, but payment modifications such as refunds are possible.   - &#x60;Closed&#x60;: the store has been closed. .</param>
        /// <param name="store">The code of the store. (required).</param>
        public Store(Address address = default(Address), string description = default(string), List<string> inStoreTerminals = default(List<string>), string merchantAccountCode = default(string), string status = default(string), string store = default(string))
        {
            this._Store = store;
            this.Address = address;
            this.Description = description;
            this.InStoreTerminals = inStoreTerminals;
            this.MerchantAccountCode = merchantAccountCode;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// The description of the store.
        /// </summary>
        /// <value>The description of the store.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The list of terminals assigned to the store.
        /// </summary>
        /// <value>The list of terminals assigned to the store.</value>
        [DataMember(Name = "inStoreTerminals", EmitDefaultValue = false)]
        public List<string> InStoreTerminals { get; set; }

        /// <summary>
        /// The code of the merchant account.
        /// </summary>
        /// <value>The code of the merchant account.</value>
        [DataMember(Name = "merchantAccountCode", EmitDefaultValue = false)]
        public string MerchantAccountCode { get; set; }

        /// <summary>
        /// The status of the store:  - &#x60;PreActive&#x60;: the store has been created, but not yet activated.   - &#x60;Active&#x60;: the store has been activated. This means you can process payments for this store.   - &#x60;Inactive&#x60;: the store is currently not active.   - &#x60;InactiveWithModifications&#x60;: the store is currently not active, but payment modifications such as refunds are possible.   - &#x60;Closed&#x60;: the store has been closed. 
        /// </summary>
        /// <value>The status of the store:  - &#x60;PreActive&#x60;: the store has been created, but not yet activated.   - &#x60;Active&#x60;: the store has been activated. This means you can process payments for this store.   - &#x60;Inactive&#x60;: the store is currently not active.   - &#x60;InactiveWithModifications&#x60;: the store is currently not active, but payment modifications such as refunds are possible.   - &#x60;Closed&#x60;: the store has been closed. </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The code of the store.
        /// </summary>
        /// <value>The code of the store.</value>
        [DataMember(Name = "store", IsRequired = false, EmitDefaultValue = false)]
        public string _Store { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Store {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InStoreTerminals: ").Append(InStoreTerminals).Append("\n");
            sb.Append("  MerchantAccountCode: ").Append(MerchantAccountCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  _Store: ").Append(_Store).Append("\n");
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
            return this.Equals(input as Store);
        }

        /// <summary>
        /// Returns true if Store instances are equal
        /// </summary>
        /// <param name="input">Instance of Store to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Store input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.InStoreTerminals == input.InStoreTerminals ||
                    this.InStoreTerminals != null &&
                    input.InStoreTerminals != null &&
                    this.InStoreTerminals.SequenceEqual(input.InStoreTerminals)
                ) && 
                (
                    this.MerchantAccountCode == input.MerchantAccountCode ||
                    (this.MerchantAccountCode != null &&
                    this.MerchantAccountCode.Equals(input.MerchantAccountCode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this._Store == input._Store ||
                    (this._Store != null &&
                    this._Store.Equals(input._Store))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.InStoreTerminals != null)
                {
                    hashCode = (hashCode * 59) + this.InStoreTerminals.GetHashCode();
                }
                if (this.MerchantAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccountCode.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this._Store != null)
                {
                    hashCode = (hashCode * 59) + this._Store.GetHashCode();
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
