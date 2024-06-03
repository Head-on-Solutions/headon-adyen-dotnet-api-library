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
    /// TerminalProduct
    /// </summary>
    [DataContract(Name = "TerminalProduct")]
    public partial class TerminalProduct : IEquatable<TerminalProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalProduct" /> class.
        /// </summary>
        /// <param name="description">Information about items included and integration options..</param>
        /// <param name="id">The unique identifier of the product..</param>
        /// <param name="itemsIncluded">A list of parts included in the terminal package..</param>
        /// <param name="name">The descriptive name of the product..</param>
        /// <param name="price">price.</param>
        public TerminalProduct(string description = default(string), string id = default(string), List<string> itemsIncluded = default(List<string>), string name = default(string), TerminalProductPrice price = default(TerminalProductPrice))
        {
            this.Description = description;
            this.Id = id;
            this.ItemsIncluded = itemsIncluded;
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// Information about items included and integration options.
        /// </summary>
        /// <value>Information about items included and integration options.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the product.
        /// </summary>
        /// <value>The unique identifier of the product.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A list of parts included in the terminal package.
        /// </summary>
        /// <value>A list of parts included in the terminal package.</value>
        [DataMember(Name = "itemsIncluded", EmitDefaultValue = false)]
        public List<string> ItemsIncluded { get; set; }

        /// <summary>
        /// The descriptive name of the product.
        /// </summary>
        /// <value>The descriptive name of the product.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public TerminalProductPrice Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalProduct {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ItemsIncluded: ").Append(ItemsIncluded).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(input as TerminalProduct);
        }

        /// <summary>
        /// Returns true if TerminalProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalProduct input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.ItemsIncluded == input.ItemsIncluded ||
                    this.ItemsIncluded != null &&
                    input.ItemsIncluded != null &&
                    this.ItemsIncluded.SequenceEqual(input.ItemsIncluded)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ItemsIncluded != null)
                {
                    hashCode = (hashCode * 59) + this.ItemsIncluded.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
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
