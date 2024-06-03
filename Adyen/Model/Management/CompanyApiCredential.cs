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
    /// CompanyApiCredential
    /// </summary>
    [DataContract(Name = "CompanyApiCredential")]
    public partial class CompanyApiCredential : IEquatable<CompanyApiCredential>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApiCredential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyApiCredential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApiCredential" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="active">Indicates if the API credential is enabled. Must be set to **true** to use the credential in your integration. (required).</param>
        /// <param name="allowedIpAddresses">List of IP addresses from which your client can make requests.  If the list is empty, we allow requests from any IP. If the list is not empty and we get a request from an IP which is not on the list, you get a security error. (required).</param>
        /// <param name="allowedOrigins">List containing the [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) linked to the API credential..</param>
        /// <param name="associatedMerchantAccounts">List of merchant accounts that the API credential has explicit access to.   If the credential has access to a company, this implies access to all merchant accounts and no merchants for that company will be included..</param>
        /// <param name="clientKey">Public key used for [client-side authentication](https://docs.adyen.com/development-resources/client-side-authentication). The client key is required for Drop-in and Components integrations. (required).</param>
        /// <param name="description">Description of the API credential..</param>
        /// <param name="id">Unique identifier of the API credential. (required).</param>
        /// <param name="roles">List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential. (required).</param>
        /// <param name="username">The name of the [API credential](https://docs.adyen.com/development-resources/api-credentials), for example **ws@Company.TestCompany**. (required).</param>
        public CompanyApiCredential(ApiCredentialLinks links = default(ApiCredentialLinks), bool active = default(bool), List<string> allowedIpAddresses = default(List<string>), List<AllowedOrigin> allowedOrigins = default(List<AllowedOrigin>), List<string> associatedMerchantAccounts = default(List<string>), string clientKey = default(string), string description = default(string), string id = default(string), List<string> roles = default(List<string>), string username = default(string))
        {
            this.Active = active;
            this.AllowedIpAddresses = allowedIpAddresses;
            this.ClientKey = clientKey;
            this.Id = id;
            this.Roles = roles;
            this.Username = username;
            this.Links = links;
            this.AllowedOrigins = allowedOrigins;
            this.AssociatedMerchantAccounts = associatedMerchantAccounts;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public ApiCredentialLinks Links { get; set; }

        /// <summary>
        /// Indicates if the API credential is enabled. Must be set to **true** to use the credential in your integration.
        /// </summary>
        /// <value>Indicates if the API credential is enabled. Must be set to **true** to use the credential in your integration.</value>
        [DataMember(Name = "active", IsRequired = false, EmitDefaultValue = false)]
        public bool Active { get; set; }

        /// <summary>
        /// List of IP addresses from which your client can make requests.  If the list is empty, we allow requests from any IP. If the list is not empty and we get a request from an IP which is not on the list, you get a security error.
        /// </summary>
        /// <value>List of IP addresses from which your client can make requests.  If the list is empty, we allow requests from any IP. If the list is not empty and we get a request from an IP which is not on the list, you get a security error.</value>
        [DataMember(Name = "allowedIpAddresses", IsRequired = false, EmitDefaultValue = false)]
        public List<string> AllowedIpAddresses { get; set; }

        /// <summary>
        /// List containing the [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) linked to the API credential.
        /// </summary>
        /// <value>List containing the [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) linked to the API credential.</value>
        [DataMember(Name = "allowedOrigins", EmitDefaultValue = false)]
        public List<AllowedOrigin> AllowedOrigins { get; set; }

        /// <summary>
        /// List of merchant accounts that the API credential has explicit access to.   If the credential has access to a company, this implies access to all merchant accounts and no merchants for that company will be included.
        /// </summary>
        /// <value>List of merchant accounts that the API credential has explicit access to.   If the credential has access to a company, this implies access to all merchant accounts and no merchants for that company will be included.</value>
        [DataMember(Name = "associatedMerchantAccounts", EmitDefaultValue = false)]
        public List<string> AssociatedMerchantAccounts { get; set; }

        /// <summary>
        /// Public key used for [client-side authentication](https://docs.adyen.com/development-resources/client-side-authentication). The client key is required for Drop-in and Components integrations.
        /// </summary>
        /// <value>Public key used for [client-side authentication](https://docs.adyen.com/development-resources/client-side-authentication). The client key is required for Drop-in and Components integrations.</value>
        [DataMember(Name = "clientKey", IsRequired = false, EmitDefaultValue = false)]
        public string ClientKey { get; set; }

        /// <summary>
        /// Description of the API credential.
        /// </summary>
        /// <value>Description of the API credential.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier of the API credential.
        /// </summary>
        /// <value>Unique identifier of the API credential.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential.
        /// </summary>
        /// <value>List of [roles](https://docs.adyen.com/development-resources/api-credentials#roles-1) for the API credential.</value>
        [DataMember(Name = "roles", IsRequired = false, EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// The name of the [API credential](https://docs.adyen.com/development-resources/api-credentials), for example **ws@Company.TestCompany**.
        /// </summary>
        /// <value>The name of the [API credential](https://docs.adyen.com/development-resources/api-credentials), for example **ws@Company.TestCompany**.</value>
        [DataMember(Name = "username", IsRequired = false, EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyApiCredential {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AllowedIpAddresses: ").Append(AllowedIpAddresses).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  AssociatedMerchantAccounts: ").Append(AssociatedMerchantAccounts).Append("\n");
            sb.Append("  ClientKey: ").Append(ClientKey).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as CompanyApiCredential);
        }

        /// <summary>
        /// Returns true if CompanyApiCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyApiCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyApiCredential input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.AllowedIpAddresses == input.AllowedIpAddresses ||
                    this.AllowedIpAddresses != null &&
                    input.AllowedIpAddresses != null &&
                    this.AllowedIpAddresses.SequenceEqual(input.AllowedIpAddresses)
                ) && 
                (
                    this.AllowedOrigins == input.AllowedOrigins ||
                    this.AllowedOrigins != null &&
                    input.AllowedOrigins != null &&
                    this.AllowedOrigins.SequenceEqual(input.AllowedOrigins)
                ) && 
                (
                    this.AssociatedMerchantAccounts == input.AssociatedMerchantAccounts ||
                    this.AssociatedMerchantAccounts != null &&
                    input.AssociatedMerchantAccounts != null &&
                    this.AssociatedMerchantAccounts.SequenceEqual(input.AssociatedMerchantAccounts)
                ) && 
                (
                    this.ClientKey == input.ClientKey ||
                    (this.ClientKey != null &&
                    this.ClientKey.Equals(input.ClientKey))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.AllowedIpAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedIpAddresses.GetHashCode();
                }
                if (this.AllowedOrigins != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedOrigins.GetHashCode();
                }
                if (this.AssociatedMerchantAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.AssociatedMerchantAccounts.GetHashCode();
                }
                if (this.ClientKey != null)
                {
                    hashCode = (hashCode * 59) + this.ClientKey.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 50.", new [] { "Description" });
            }

            yield break;
        }
    }

}
