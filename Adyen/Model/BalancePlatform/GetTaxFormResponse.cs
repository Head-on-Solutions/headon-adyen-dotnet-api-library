/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// GetTaxFormResponse
    /// </summary>
    [DataContract(Name = "GetTaxFormResponse")]
    public partial class GetTaxFormResponse : IEquatable<GetTaxFormResponse>, IValidatableObject
    {
        /// <summary>
        /// The content type of the tax form.  Possible values: *  **application/pdf**  
        /// </summary>
        /// <value>The content type of the tax form.  Possible values: *  **application/pdf**  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContentTypeEnum
        {
            /// <summary>
            /// Enum ApplicationPdf for value: application/pdf
            /// </summary>
            [EnumMember(Value = "application/pdf")]
            ApplicationPdf = 1

        }


        /// <summary>
        /// The content type of the tax form.  Possible values: *  **application/pdf**  
        /// </summary>
        /// <value>The content type of the tax form.  Possible values: *  **application/pdf**  </value>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public ContentTypeEnum? ContentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaxFormResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTaxFormResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaxFormResponse" /> class.
        /// </summary>
        /// <param name="content">The content of the tax form in Base64 format. (required).</param>
        /// <param name="contentType">The content type of the tax form.  Possible values: *  **application/pdf**  .</param>
        public GetTaxFormResponse(byte[] content = default(byte[]), ContentTypeEnum? contentType = default(ContentTypeEnum?))
        {
            this.Content = content;
            this.ContentType = contentType;
        }

        /// <summary>
        /// The content of the tax form in Base64 format.
        /// </summary>
        /// <value>The content of the tax form in Base64 format.</value>
        [DataMember(Name = "content", IsRequired = false, EmitDefaultValue = false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTaxFormResponse {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
            return this.Equals(input as GetTaxFormResponse);
        }

        /// <summary>
        /// Returns true if GetTaxFormResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTaxFormResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTaxFormResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    this.ContentType.Equals(input.ContentType)
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
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