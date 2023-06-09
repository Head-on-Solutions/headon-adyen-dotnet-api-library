/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Payment
{
    /// <summary>
    /// ResponseAdditionalDataCard
    /// </summary>
    [DataContract(Name = "ResponseAdditionalDataCard")]
    public partial class ResponseAdditionalDataCard : IEquatable<ResponseAdditionalDataCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataCard" /> class.
        /// </summary>
        /// <param name="cardBin">The first six digits of the card number.  This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with a six-digit BIN.  Example: 521234.</param>
        /// <param name="cardHolderName">The cardholder name passed in the payment request..</param>
        /// <param name="cardIssuingBank">The bank or the financial institution granting lines of credit through card association branded payment cards. This information can be included when available..</param>
        /// <param name="cardIssuingCountry">The country where the card was issued.  Example: US.</param>
        /// <param name="cardIssuingCurrency">The currency in which the card is issued, if this information is available. Provided as the currency code or currency number from the ISO-4217 standard.   Example: USD.</param>
        /// <param name="cardPaymentMethod">The card payment method used for the transaction.  Example: amex.</param>
        /// <param name="cardSummary">The last four digits of a card number.  &gt; Returned only in case of a card payment..</param>
        /// <param name="issuerBin">The first eight digits of the card number. Only returned if the card number is 16 digits or more.  This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with an eight-digit BIN.  Example: 52123423.</param>
        public ResponseAdditionalDataCard(string cardBin = default(string), string cardHolderName = default(string), string cardIssuingBank = default(string), string cardIssuingCountry = default(string), string cardIssuingCurrency = default(string), string cardPaymentMethod = default(string), string cardSummary = default(string), string issuerBin = default(string))
        {
            this.CardBin = cardBin;
            this.CardHolderName = cardHolderName;
            this.CardIssuingBank = cardIssuingBank;
            this.CardIssuingCountry = cardIssuingCountry;
            this.CardIssuingCurrency = cardIssuingCurrency;
            this.CardPaymentMethod = cardPaymentMethod;
            this.CardSummary = cardSummary;
            this.IssuerBin = issuerBin;
        }

        /// <summary>
        /// The first six digits of the card number.  This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with a six-digit BIN.  Example: 521234
        /// </summary>
        /// <value>The first six digits of the card number.  This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with a six-digit BIN.  Example: 521234</value>
        [DataMember(Name = "cardBin", EmitDefaultValue = false)]
        public string CardBin { get; set; }

        /// <summary>
        /// The cardholder name passed in the payment request.
        /// </summary>
        /// <value>The cardholder name passed in the payment request.</value>
        [DataMember(Name = "cardHolderName", EmitDefaultValue = false)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// The bank or the financial institution granting lines of credit through card association branded payment cards. This information can be included when available.
        /// </summary>
        /// <value>The bank or the financial institution granting lines of credit through card association branded payment cards. This information can be included when available.</value>
        [DataMember(Name = "cardIssuingBank", EmitDefaultValue = false)]
        public string CardIssuingBank { get; set; }

        /// <summary>
        /// The country where the card was issued.  Example: US
        /// </summary>
        /// <value>The country where the card was issued.  Example: US</value>
        [DataMember(Name = "cardIssuingCountry", EmitDefaultValue = false)]
        public string CardIssuingCountry { get; set; }

        /// <summary>
        /// The currency in which the card is issued, if this information is available. Provided as the currency code or currency number from the ISO-4217 standard.   Example: USD
        /// </summary>
        /// <value>The currency in which the card is issued, if this information is available. Provided as the currency code or currency number from the ISO-4217 standard.   Example: USD</value>
        [DataMember(Name = "cardIssuingCurrency", EmitDefaultValue = false)]
        public string CardIssuingCurrency { get; set; }

        /// <summary>
        /// The card payment method used for the transaction.  Example: amex
        /// </summary>
        /// <value>The card payment method used for the transaction.  Example: amex</value>
        [DataMember(Name = "cardPaymentMethod", EmitDefaultValue = false)]
        public string CardPaymentMethod { get; set; }

        /// <summary>
        /// The last four digits of a card number.  &gt; Returned only in case of a card payment.
        /// </summary>
        /// <value>The last four digits of a card number.  &gt; Returned only in case of a card payment.</value>
        [DataMember(Name = "cardSummary", EmitDefaultValue = false)]
        public string CardSummary { get; set; }

        /// <summary>
        /// The first eight digits of the card number. Only returned if the card number is 16 digits or more.  This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with an eight-digit BIN.  Example: 52123423
        /// </summary>
        /// <value>The first eight digits of the card number. Only returned if the card number is 16 digits or more.  This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with an eight-digit BIN.  Example: 52123423</value>
        [DataMember(Name = "issuerBin", EmitDefaultValue = false)]
        public string IssuerBin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataCard {\n");
            sb.Append("  CardBin: ").Append(CardBin).Append("\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  CardIssuingBank: ").Append(CardIssuingBank).Append("\n");
            sb.Append("  CardIssuingCountry: ").Append(CardIssuingCountry).Append("\n");
            sb.Append("  CardIssuingCurrency: ").Append(CardIssuingCurrency).Append("\n");
            sb.Append("  CardPaymentMethod: ").Append(CardPaymentMethod).Append("\n");
            sb.Append("  CardSummary: ").Append(CardSummary).Append("\n");
            sb.Append("  IssuerBin: ").Append(IssuerBin).Append("\n");
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
            return this.Equals(input as ResponseAdditionalDataCard);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataCard instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataCard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardBin == input.CardBin ||
                    (this.CardBin != null &&
                    this.CardBin.Equals(input.CardBin))
                ) && 
                (
                    this.CardHolderName == input.CardHolderName ||
                    (this.CardHolderName != null &&
                    this.CardHolderName.Equals(input.CardHolderName))
                ) && 
                (
                    this.CardIssuingBank == input.CardIssuingBank ||
                    (this.CardIssuingBank != null &&
                    this.CardIssuingBank.Equals(input.CardIssuingBank))
                ) && 
                (
                    this.CardIssuingCountry == input.CardIssuingCountry ||
                    (this.CardIssuingCountry != null &&
                    this.CardIssuingCountry.Equals(input.CardIssuingCountry))
                ) && 
                (
                    this.CardIssuingCurrency == input.CardIssuingCurrency ||
                    (this.CardIssuingCurrency != null &&
                    this.CardIssuingCurrency.Equals(input.CardIssuingCurrency))
                ) && 
                (
                    this.CardPaymentMethod == input.CardPaymentMethod ||
                    (this.CardPaymentMethod != null &&
                    this.CardPaymentMethod.Equals(input.CardPaymentMethod))
                ) && 
                (
                    this.CardSummary == input.CardSummary ||
                    (this.CardSummary != null &&
                    this.CardSummary.Equals(input.CardSummary))
                ) && 
                (
                    this.IssuerBin == input.IssuerBin ||
                    (this.IssuerBin != null &&
                    this.IssuerBin.Equals(input.IssuerBin))
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
                if (this.CardBin != null)
                {
                    hashCode = (hashCode * 59) + this.CardBin.GetHashCode();
                }
                if (this.CardHolderName != null)
                {
                    hashCode = (hashCode * 59) + this.CardHolderName.GetHashCode();
                }
                if (this.CardIssuingBank != null)
                {
                    hashCode = (hashCode * 59) + this.CardIssuingBank.GetHashCode();
                }
                if (this.CardIssuingCountry != null)
                {
                    hashCode = (hashCode * 59) + this.CardIssuingCountry.GetHashCode();
                }
                if (this.CardIssuingCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.CardIssuingCurrency.GetHashCode();
                }
                if (this.CardPaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.CardPaymentMethod.GetHashCode();
                }
                if (this.CardSummary != null)
                {
                    hashCode = (hashCode * 59) + this.CardSummary.GetHashCode();
                }
                if (this.IssuerBin != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerBin.GetHashCode();
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
