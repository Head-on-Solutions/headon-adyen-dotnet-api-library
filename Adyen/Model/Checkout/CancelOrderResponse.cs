/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CancelOrderResponse
    /// </summary>
    [DataContract(Name = "CancelOrderResponse")]
    public partial class CancelOrderResponse : IEquatable<CancelOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of the cancellation request.  Possible values:  * **Received** – Indicates the cancellation has successfully been received by Adyen, and will be processed.
        /// </summary>
        /// <value>The result of the cancellation request.  Possible values:  * **Received** – Indicates the cancellation has successfully been received by Adyen, and will be processed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")]
            Received = 1

        }


        /// <summary>
        /// The result of the cancellation request.  Possible values:  * **Received** – Indicates the cancellation has successfully been received by Adyen, and will be processed.
        /// </summary>
        /// <value>The result of the cancellation request.  Possible values:  * **Received** – Indicates the cancellation has successfully been received by Adyen, and will be processed.</value>
        [DataMember(Name = "resultCode", IsRequired = false, EmitDefaultValue = false)]
        public ResultCodeEnum ResultCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancelOrderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderResponse" /> class.
        /// </summary>
        /// <param name="pspReference">A unique reference of the cancellation request. (required).</param>
        /// <param name="resultCode">The result of the cancellation request.  Possible values:  * **Received** – Indicates the cancellation has successfully been received by Adyen, and will be processed. (required).</param>
        public CancelOrderResponse(string pspReference = default(string), ResultCodeEnum resultCode = default(ResultCodeEnum))
        {
            this.PspReference = pspReference;
            this.ResultCode = resultCode;
        }

        /// <summary>
        /// A unique reference of the cancellation request.
        /// </summary>
        /// <value>A unique reference of the cancellation request.</value>
        [DataMember(Name = "pspReference", IsRequired = false, EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancelOrderResponse {\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return this.Equals(input as CancelOrderResponse);
        }

        /// <summary>
        /// Returns true if CancelOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelOrderResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode.Equals(input.ResultCode)
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
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
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