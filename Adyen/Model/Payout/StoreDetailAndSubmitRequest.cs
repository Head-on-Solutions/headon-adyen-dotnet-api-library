/*
* Adyen Payout API
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

namespace Adyen.Model.Payout
{
    /// <summary>
    /// StoreDetailAndSubmitRequest
    /// </summary>
    [DataContract(Name = "StoreDetailAndSubmitRequest")]
    public partial class StoreDetailAndSubmitRequest : IEquatable<StoreDetailAndSubmitRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of the entity the payout is processed for.
        /// </summary>
        /// <value>The type of the entity the payout is processed for.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Enum NaturalPerson for value: NaturalPerson
            /// </summary>
            [EnumMember(Value = "NaturalPerson")]
            NaturalPerson = 1,

            /// <summary>
            /// Enum Company for value: Company
            /// </summary>
            [EnumMember(Value = "Company")]
            Company = 2

        }


        /// <summary>
        /// The type of the entity the payout is processed for.
        /// </summary>
        /// <value>The type of the entity the payout is processed for.</value>
        [DataMember(Name = "entityType", IsRequired = false, EmitDefaultValue = false)]
        public EntityTypeEnum EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetailAndSubmitRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoreDetailAndSubmitRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDetailAndSubmitRequest" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be required for a particular request..</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="bank">bank.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="card">card.</param>
        /// <param name="dateOfBirth">The date of birth. Format: [ISO-8601](https://www.w3.org/TR/NOTE-datetime); example: YYYY-MM-DD For Paysafecard it must be the same as used when registering the Paysafecard account. &gt; This field is mandatory for natural persons. (required).</param>
        /// <param name="entityType">The type of the entity the payout is processed for. (required).</param>
        /// <param name="fraudOffset">An integer value that is added to the normal fraud score. The value can be either positive or negative..</param>
        /// <param name="merchantAccount">The merchant account identifier, with which you want to process the transaction. (required).</param>
        /// <param name="nationality">The shopper&#39;s nationality.  A valid value is an ISO 2-character country code (e.g. &#39;NL&#39;). (required).</param>
        /// <param name="recurring">recurring (required).</param>
        /// <param name="reference">The merchant reference for this payment. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement. (required).</param>
        /// <param name="selectedBrand">The name of the brand to make a payout to.  For Paysafecard it must be set to &#x60;paysafecard&#x60;..</param>
        /// <param name="shopperEmail">The shopper&#39;s email address. (required).</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">The shopper&#39;s reference for the payment transaction. (required).</param>
        /// <param name="shopperStatement">The description of this payout. This description is shown on the bank statement of the shopper (if this is supported by the chosen payment method)..</param>
        /// <param name="socialSecurityNumber">The shopper&#39;s social security number..</param>
        /// <param name="telephoneNumber">The shopper&#39;s phone number..</param>
        public StoreDetailAndSubmitRequest(Dictionary<string, string> additionalData = default(Dictionary<string, string>), Amount amount = default(Amount), BankAccount bank = default(BankAccount), Address billingAddress = default(Address), Card card = default(Card), DateTime dateOfBirth = default(DateTime), EntityTypeEnum entityType = default(EntityTypeEnum), int? fraudOffset = default(int?), string merchantAccount = default(string), string nationality = default(string), Recurring recurring = default(Recurring), string reference = default(string), string selectedBrand = default(string), string shopperEmail = default(string), Name shopperName = default(Name), string shopperReference = default(string), string shopperStatement = default(string), string socialSecurityNumber = default(string), string telephoneNumber = default(string))
        {
            this.Amount = amount;
            this.DateOfBirth = dateOfBirth;
            this.EntityType = entityType;
            this.MerchantAccount = merchantAccount;
            this.Nationality = nationality;
            this.Recurring = recurring;
            this.Reference = reference;
            this.ShopperEmail = shopperEmail;
            this.ShopperReference = shopperReference;
            this.AdditionalData = additionalData;
            this.Bank = bank;
            this.BillingAddress = billingAddress;
            this.Card = card;
            this.FraudOffset = fraudOffset;
            this.SelectedBrand = selectedBrand;
            this.ShopperName = shopperName;
            this.ShopperStatement = shopperStatement;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.TelephoneNumber = telephoneNumber;
        }

        /// <summary>
        /// This field contains additional data, which may be required for a particular request.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular request.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public BankAccount Bank { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; }

        /// <summary>
        /// The date of birth. Format: [ISO-8601](https://www.w3.org/TR/NOTE-datetime); example: YYYY-MM-DD For Paysafecard it must be the same as used when registering the Paysafecard account. &gt; This field is mandatory for natural persons.
        /// </summary>
        /// <value>The date of birth. Format: [ISO-8601](https://www.w3.org/TR/NOTE-datetime); example: YYYY-MM-DD For Paysafecard it must be the same as used when registering the Paysafecard account. &gt; This field is mandatory for natural persons.</value>
        [DataMember(Name = "dateOfBirth", IsRequired = false, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
        [DataMember(Name = "fraudOffset", EmitDefaultValue = false)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The shopper&#39;s nationality.  A valid value is an ISO 2-character country code (e.g. &#39;NL&#39;).
        /// </summary>
        /// <value>The shopper&#39;s nationality.  A valid value is an ISO 2-character country code (e.g. &#39;NL&#39;).</value>
        [DataMember(Name = "nationality", IsRequired = false, EmitDefaultValue = false)]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring", IsRequired = false, EmitDefaultValue = false)]
        public Recurring Recurring { get; set; }

        /// <summary>
        /// The merchant reference for this payment. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement.
        /// </summary>
        /// <value>The merchant reference for this payment. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement.</value>
        [DataMember(Name = "reference", IsRequired = false, EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The name of the brand to make a payout to.  For Paysafecard it must be set to &#x60;paysafecard&#x60;.
        /// </summary>
        /// <value>The name of the brand to make a payout to.  For Paysafecard it must be set to &#x60;paysafecard&#x60;.</value>
        [DataMember(Name = "selectedBrand", EmitDefaultValue = false)]
        public string SelectedBrand { get; set; }

        /// <summary>
        /// The shopper&#39;s email address.
        /// </summary>
        /// <value>The shopper&#39;s email address.</value>
        [DataMember(Name = "shopperEmail", IsRequired = false, EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public Name ShopperName { get; set; }

        /// <summary>
        /// The shopper&#39;s reference for the payment transaction.
        /// </summary>
        /// <value>The shopper&#39;s reference for the payment transaction.</value>
        [DataMember(Name = "shopperReference", IsRequired = false, EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The description of this payout. This description is shown on the bank statement of the shopper (if this is supported by the chosen payment method).
        /// </summary>
        /// <value>The description of this payout. This description is shown on the bank statement of the shopper (if this is supported by the chosen payment method).</value>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper&#39;s social security number.
        /// </summary>
        /// <value>The shopper&#39;s social security number.</value>
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// The shopper&#39;s phone number.
        /// </summary>
        /// <value>The shopper&#39;s phone number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StoreDetailAndSubmitRequest {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SelectedBrand: ").Append(SelectedBrand).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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
            return this.Equals(input as StoreDetailAndSubmitRequest);
        }

        /// <summary>
        /// Returns true if StoreDetailAndSubmitRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreDetailAndSubmitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreDetailAndSubmitRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Bank == input.Bank ||
                    (this.Bank != null &&
                    this.Bank.Equals(input.Bank))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    this.EntityType.Equals(input.EntityType)
                ) && 
                (
                    this.FraudOffset == input.FraudOffset ||
                    this.FraudOffset.Equals(input.FraudOffset)
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SelectedBrand == input.SelectedBrand ||
                    (this.SelectedBrand != null &&
                    this.SelectedBrand.Equals(input.SelectedBrand))
                ) && 
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.ShopperName == input.ShopperName ||
                    (this.ShopperName != null &&
                    this.ShopperName.Equals(input.ShopperName))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) && 
                (
                    this.ShopperStatement == input.ShopperStatement ||
                    (this.ShopperStatement != null &&
                    this.ShopperStatement.Equals(input.ShopperStatement))
                ) && 
                (
                    this.SocialSecurityNumber == input.SocialSecurityNumber ||
                    (this.SocialSecurityNumber != null &&
                    this.SocialSecurityNumber.Equals(input.SocialSecurityNumber))
                ) && 
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
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
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Bank != null)
                {
                    hashCode = (hashCode * 59) + this.Bank.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                }
                if (this.Card != null)
                {
                    hashCode = (hashCode * 59) + this.Card.GetHashCode();
                }
                if (this.DateOfBirth != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfBirth.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                hashCode = (hashCode * 59) + this.FraudOffset.GetHashCode();
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.Nationality != null)
                {
                    hashCode = (hashCode * 59) + this.Nationality.GetHashCode();
                }
                if (this.Recurring != null)
                {
                    hashCode = (hashCode * 59) + this.Recurring.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.SelectedBrand != null)
                {
                    hashCode = (hashCode * 59) + this.SelectedBrand.GetHashCode();
                }
                if (this.ShopperEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperEmail.GetHashCode();
                }
                if (this.ShopperName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperName.GetHashCode();
                }
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
                }
                if (this.ShopperStatement != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperStatement.GetHashCode();
                }
                if (this.SocialSecurityNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SocialSecurityNumber.GetHashCode();
                }
                if (this.TelephoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TelephoneNumber.GetHashCode();
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
            // Nationality (string) maxLength
            if (this.Nationality != null && this.Nationality.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nationality, length must be less than 2.", new [] { "Nationality" });
            }

            yield break;
        }
    }

}
