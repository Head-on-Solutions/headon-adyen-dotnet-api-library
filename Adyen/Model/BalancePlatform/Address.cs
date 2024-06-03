/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace HeadOn.Classic.Adyen.Model.BalancePlatform
{
    /// <summary>
    /// Address
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="city">The name of the city. Maximum length: 3000 characters. (required).</param>
        /// <param name="country">The two-character ISO-3166-1 alpha-2 country code. For example, **US**. &gt; If you don&#39;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;. (required).</param>
        /// <param name="houseNumberOrName">The number or name of the house. Maximum length: 3000 characters. (required).</param>
        /// <param name="postalCode">A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries. (required).</param>
        /// <param name="stateOrProvince">The two-character ISO 3166-2 state or province code. For example, **CA** in the US or **ON** in Canada. &gt; Required for the US and Canada..</param>
        /// <param name="street">The name of the street. Maximum length: 3000 characters. &gt; The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;. (required).</param>
        public Address(string city = default(string), string country = default(string), string houseNumberOrName = default(string), string postalCode = default(string), string stateOrProvince = default(string), string street = default(string))
        {
            this.City = city;
            this.Country = country;
            this.HouseNumberOrName = houseNumberOrName;
            this.PostalCode = postalCode;
            this.Street = street;
            this.StateOrProvince = stateOrProvince;
        }

        /// <summary>
        /// The name of the city. Maximum length: 3000 characters.
        /// </summary>
        /// <value>The name of the city. Maximum length: 3000 characters.</value>
        [DataMember(Name = "city", IsRequired = false, EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The two-character ISO-3166-1 alpha-2 country code. For example, **US**. &gt; If you don&#39;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;.
        /// </summary>
        /// <value>The two-character ISO-3166-1 alpha-2 country code. For example, **US**. &gt; If you don&#39;t know the country or are not collecting the country from the shopper, provide &#x60;country&#x60; as &#x60;ZZ&#x60;.</value>
        [DataMember(Name = "country", IsRequired = false, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The number or name of the house. Maximum length: 3000 characters.
        /// </summary>
        /// <value>The number or name of the house. Maximum length: 3000 characters.</value>
        [DataMember(Name = "houseNumberOrName", IsRequired = false, EmitDefaultValue = false)]
        public string HouseNumberOrName { get; set; }

        /// <summary>
        /// A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries.
        /// </summary>
        /// <value>A maximum of five digits for an address in the US, or a maximum of ten characters for an address in all other countries.</value>
        [DataMember(Name = "postalCode", IsRequired = false, EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two-character ISO 3166-2 state or province code. For example, **CA** in the US or **ON** in Canada. &gt; Required for the US and Canada.
        /// </summary>
        /// <value>The two-character ISO 3166-2 state or province code. For example, **CA** in the US or **ON** in Canada. &gt; Required for the US and Canada.</value>
        [DataMember(Name = "stateOrProvince", EmitDefaultValue = false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// The name of the street. Maximum length: 3000 characters. &gt; The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;.
        /// </summary>
        /// <value>The name of the street. Maximum length: 3000 characters. &gt; The house number should not be included in this field; it should be separately provided via &#x60;houseNumberOrName&#x60;.</value>
        [DataMember(Name = "street", IsRequired = false, EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  HouseNumberOrName: ").Append(HouseNumberOrName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.HouseNumberOrName == input.HouseNumberOrName ||
                    (this.HouseNumberOrName != null &&
                    this.HouseNumberOrName.Equals(input.HouseNumberOrName))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.StateOrProvince == input.StateOrProvince ||
                    (this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(input.StateOrProvince))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.HouseNumberOrName != null)
                {
                    hashCode = (hashCode * 59) + this.HouseNumberOrName.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.StateOrProvince != null)
                {
                    hashCode = (hashCode * 59) + this.StateOrProvince.GetHashCode();
                }
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
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
            // City (string) maxLength
            if (this.City != null && this.City.Length > 3000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 3000.", new [] { "City" });
            }

            // HouseNumberOrName (string) maxLength
            if (this.HouseNumberOrName != null && this.HouseNumberOrName.Length > 3000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNumberOrName, length must be less than 3000.", new [] { "HouseNumberOrName" });
            }

            // Street (string) maxLength
            if (this.Street != null && this.Street.Length > 3000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Street, length must be less than 3000.", new [] { "Street" });
            }

            yield break;
        }
    }

}
