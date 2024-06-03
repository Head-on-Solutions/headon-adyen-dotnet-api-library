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
    /// CreateAllowedOriginRequest
    /// </summary>
    [DataContract(Name = "CreateAllowedOriginRequest")]
    public partial class CreateAllowedOriginRequest : IEquatable<CreateAllowedOriginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAllowedOriginRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAllowedOriginRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAllowedOriginRequest" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="domain">Domain of the allowed origin. (required).</param>
        /// <param name="id">Unique identifier of the allowed origin..</param>
        public CreateAllowedOriginRequest(Links links = default(Links), string domain = default(string), string id = default(string))
        {
            this.Domain = domain;
            this.Links = links;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public Links Links { get; set; }

        /// <summary>
        /// Domain of the allowed origin.
        /// </summary>
        /// <value>Domain of the allowed origin.</value>
        [DataMember(Name = "domain", IsRequired = false, EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Unique identifier of the allowed origin.
        /// </summary>
        /// <value>Unique identifier of the allowed origin.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAllowedOriginRequest {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CreateAllowedOriginRequest);
        }

        /// <summary>
        /// Returns true if CreateAllowedOriginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAllowedOriginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAllowedOriginRequest input)
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
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
