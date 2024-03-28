#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout.Action
{
    /// <summary>
    /// CheckoutQrCodeAction
    /// </summary>
    [DataContract]
    public partial class CheckoutQrCodeAction : IEquatable<CheckoutQrCodeAction>, IValidatableObject , IPaymentResponseAction
    {
        /// <summary>
        /// **qrCode**
        /// </summary>
        /// <value>**qrCode**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public String Type { get; set; } = "qrCode";

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutQrCodeAction" /> class.
        /// </summary>
        /// <param name="expiresAt">Expiry time of the QR code..</param>
        /// <param name="paymentData">A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="qrCodeData">The contents of the QR code as a UTF8 string..</param>
        /// <param name="type">**qrCode** (required).</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutQrCodeAction(string expiresAt = default(string), string paymentData = default(string),
            string paymentMethodType = default(string), string qrCodeData = default(string),
           string url = default(string))
        {
            this.ExpiresAt = expiresAt;
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.QrCodeData = qrCodeData;
            this.Url = url;
        }

        /// <summary>
        /// Expiry time of the QR code.
        /// </summary>
        /// <value>Expiry time of the QR code.</value>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment.
        /// </summary>
        /// <value>A value that must be submitted to the &#x60;/payments/details&#x60; endpoint to verify this payment.</value>
        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        /// <value>Specifies the payment method.</value>
        [DataMember(Name = "paymentMethodType", EmitDefaultValue = false)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// The contents of the QR code as a UTF8 string.
        /// </summary>
        /// <value>The contents of the QR code as a UTF8 string.</value>
        [DataMember(Name = "qrCodeData", EmitDefaultValue = false)]
        public string QrCodeData { get; set; }


        /// <summary>
        /// Specifies the URL to redirect to.
        /// </summary>
        /// <value>Specifies the URL to redirect to.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutQrCodeAction {\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  QrCodeData: ").Append(QrCodeData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckoutQrCodeAction);
        }

        /// <summary>
        /// Returns true if CheckoutQrCodeAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutQrCodeAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutQrCodeAction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                     this.ExpiresAt.Equals(input.ExpiresAt))
                ) &&
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                     this.PaymentData.Equals(input.PaymentData))
                ) &&
                (
                    this.PaymentMethodType == input.PaymentMethodType ||
                    (this.PaymentMethodType != null &&
                     this.PaymentMethodType.Equals(input.PaymentMethodType))
                ) &&
                (
                    this.QrCodeData == input.QrCodeData ||
                    (this.QrCodeData != null &&
                     this.QrCodeData.Equals(input.QrCodeData))
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                     this.Type.Equals(input.Type))
                ) &&
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                     this.Url.Equals(input.Url))
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
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                if (this.PaymentMethodType != null)
                    hashCode = hashCode * 59 + this.PaymentMethodType.GetHashCode();
                if (this.QrCodeData != null)
                    hashCode = hashCode * 59 + this.QrCodeData.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}