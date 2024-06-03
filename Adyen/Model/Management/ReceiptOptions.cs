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
    /// ReceiptOptions
    /// </summary>
    [DataContract(Name = "ReceiptOptions")]
    public partial class ReceiptOptions : IEquatable<ReceiptOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptOptions" /> class.
        /// </summary>
        /// <param name="logo">The receipt logo converted to a Base64-encoded string. The image must be a .bmp file of &lt; 256 KB, dimensions 240 (H) x 384 (W) px..</param>
        /// <param name="qrCodeData">Data to print on the receipt as a QR code. This can include static text and the following variables:  - &#x60;${merchantreference}&#x60;: the merchant reference of the transaction. - &#x60;${pspreference}&#x60;: the PSP reference of the transaction.   For example, **http://www.example.com/order/${pspreference}/${merchantreference}**..</param>
        public ReceiptOptions(string logo = default(string), string qrCodeData = default(string))
        {
            this.Logo = logo;
            this.QrCodeData = qrCodeData;
        }

        /// <summary>
        /// The receipt logo converted to a Base64-encoded string. The image must be a .bmp file of &lt; 256 KB, dimensions 240 (H) x 384 (W) px.
        /// </summary>
        /// <value>The receipt logo converted to a Base64-encoded string. The image must be a .bmp file of &lt; 256 KB, dimensions 240 (H) x 384 (W) px.</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// Data to print on the receipt as a QR code. This can include static text and the following variables:  - &#x60;${merchantreference}&#x60;: the merchant reference of the transaction. - &#x60;${pspreference}&#x60;: the PSP reference of the transaction.   For example, **http://www.example.com/order/${pspreference}/${merchantreference}**.
        /// </summary>
        /// <value>Data to print on the receipt as a QR code. This can include static text and the following variables:  - &#x60;${merchantreference}&#x60;: the merchant reference of the transaction. - &#x60;${pspreference}&#x60;: the PSP reference of the transaction.   For example, **http://www.example.com/order/${pspreference}/${merchantreference}**.</value>
        [DataMember(Name = "qrCodeData", EmitDefaultValue = false)]
        public string QrCodeData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceiptOptions {\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  QrCodeData: ").Append(QrCodeData).Append("\n");
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
            return this.Equals(input as ReceiptOptions);
        }

        /// <summary>
        /// Returns true if ReceiptOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiptOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiptOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.QrCodeData == input.QrCodeData ||
                    (this.QrCodeData != null &&
                    this.QrCodeData.Equals(input.QrCodeData))
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
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.QrCodeData != null)
                {
                    hashCode = (hashCode * 59) + this.QrCodeData.GetHashCode();
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
            // Logo (string) maxLength
            if (this.Logo != null && this.Logo.Length > 350000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Logo, length must be less than 350000.", new [] { "Logo" });
            }

            yield break;
        }
    }

}
