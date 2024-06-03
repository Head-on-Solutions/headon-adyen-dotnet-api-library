/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace HeadOn.Classic.Adyen.Model.Checkout
{
    /// <summary>
    /// AdditionalDataRisk
    /// </summary>
    [DataContract(Name = "AdditionalDataRisk")]
    public partial class AdditionalDataRisk : IEquatable<AdditionalDataRisk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRisk" /> class.
        /// </summary>
        /// <param name="riskdataCustomFieldName">The data for your custom risk field. For more information, refer to [Create custom risk fields](https://docs.adyen.com/risk-management/configure-custom-risk-rules#step-1-create-custom-risk-fields)..</param>
        /// <param name="riskdataBasketItemItemNrAmountPerItem">The price of item in the basket, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes)..</param>
        /// <param name="riskdataBasketItemItemNrBrand">Brand of the item..</param>
        /// <param name="riskdataBasketItemItemNrCategory">Category of the item..</param>
        /// <param name="riskdataBasketItemItemNrColor">Color of the item..</param>
        /// <param name="riskdataBasketItemItemNrCurrency">The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217)..</param>
        /// <param name="riskdataBasketItemItemNrItemID">ID of the item..</param>
        /// <param name="riskdataBasketItemItemNrManufacturer">Manufacturer of the item..</param>
        /// <param name="riskdataBasketItemItemNrProductTitle">A text description of the product the invoice line refers to..</param>
        /// <param name="riskdataBasketItemItemNrQuantity">Quantity of the item purchased..</param>
        /// <param name="riskdataBasketItemItemNrReceiverEmail">Email associated with the given product in the basket (usually in electronic gift cards)..</param>
        /// <param name="riskdataBasketItemItemNrSize">Size of the item..</param>
        /// <param name="riskdataBasketItemItemNrSku">[Stock keeping unit](https://en.wikipedia.org/wiki/Stock_keeping_unit)..</param>
        /// <param name="riskdataBasketItemItemNrUpc">[Universal Product Code](https://en.wikipedia.org/wiki/Universal_Product_Code)..</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionCode">Code of the promotion..</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionDiscountAmount">The discount amount of the promotion, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes)..</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionDiscountCurrency">The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217)..</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionDiscountPercentage">Promotion&#39;s percentage discount. It is represented in percentage value and there is no need to include the &#39;%&#39; sign.  e.g. for a promotion discount of 30%, the value of the field should be 30..</param>
        /// <param name="riskdataPromotionsPromotionItemNrPromotionName">Name of the promotion..</param>
        /// <param name="riskdataRiskProfileReference">Reference number of the risk profile that you want to apply to the payment. If not provided or left blank, the merchant-level account&#39;s default risk profile will be applied to the payment. For more information, see [dynamically assign a risk profile to a payment](https://docs.adyen.com/risk-management/create-and-use-risk-profiles#dynamically-assign-a-risk-profile-to-a-payment)..</param>
        /// <param name="riskdataSkipRisk">If this parameter is provided with the value **true**, risk checks for the payment request are skipped and the transaction will not get a risk score..</param>
        public AdditionalDataRisk(string riskdataCustomFieldName = default(string), string riskdataBasketItemItemNrAmountPerItem = default(string), string riskdataBasketItemItemNrBrand = default(string), string riskdataBasketItemItemNrCategory = default(string), string riskdataBasketItemItemNrColor = default(string), string riskdataBasketItemItemNrCurrency = default(string), string riskdataBasketItemItemNrItemID = default(string), string riskdataBasketItemItemNrManufacturer = default(string), string riskdataBasketItemItemNrProductTitle = default(string), string riskdataBasketItemItemNrQuantity = default(string), string riskdataBasketItemItemNrReceiverEmail = default(string), string riskdataBasketItemItemNrSize = default(string), string riskdataBasketItemItemNrSku = default(string), string riskdataBasketItemItemNrUpc = default(string), string riskdataPromotionsPromotionItemNrPromotionCode = default(string), string riskdataPromotionsPromotionItemNrPromotionDiscountAmount = default(string), string riskdataPromotionsPromotionItemNrPromotionDiscountCurrency = default(string), string riskdataPromotionsPromotionItemNrPromotionDiscountPercentage = default(string), string riskdataPromotionsPromotionItemNrPromotionName = default(string), string riskdataRiskProfileReference = default(string), string riskdataSkipRisk = default(string))
        {
            this.RiskdataCustomFieldName = riskdataCustomFieldName;
            this.RiskdataBasketItemItemNrAmountPerItem = riskdataBasketItemItemNrAmountPerItem;
            this.RiskdataBasketItemItemNrBrand = riskdataBasketItemItemNrBrand;
            this.RiskdataBasketItemItemNrCategory = riskdataBasketItemItemNrCategory;
            this.RiskdataBasketItemItemNrColor = riskdataBasketItemItemNrColor;
            this.RiskdataBasketItemItemNrCurrency = riskdataBasketItemItemNrCurrency;
            this.RiskdataBasketItemItemNrItemID = riskdataBasketItemItemNrItemID;
            this.RiskdataBasketItemItemNrManufacturer = riskdataBasketItemItemNrManufacturer;
            this.RiskdataBasketItemItemNrProductTitle = riskdataBasketItemItemNrProductTitle;
            this.RiskdataBasketItemItemNrQuantity = riskdataBasketItemItemNrQuantity;
            this.RiskdataBasketItemItemNrReceiverEmail = riskdataBasketItemItemNrReceiverEmail;
            this.RiskdataBasketItemItemNrSize = riskdataBasketItemItemNrSize;
            this.RiskdataBasketItemItemNrSku = riskdataBasketItemItemNrSku;
            this.RiskdataBasketItemItemNrUpc = riskdataBasketItemItemNrUpc;
            this.RiskdataPromotionsPromotionItemNrPromotionCode = riskdataPromotionsPromotionItemNrPromotionCode;
            this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount = riskdataPromotionsPromotionItemNrPromotionDiscountAmount;
            this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency = riskdataPromotionsPromotionItemNrPromotionDiscountCurrency;
            this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage = riskdataPromotionsPromotionItemNrPromotionDiscountPercentage;
            this.RiskdataPromotionsPromotionItemNrPromotionName = riskdataPromotionsPromotionItemNrPromotionName;
            this.RiskdataRiskProfileReference = riskdataRiskProfileReference;
            this.RiskdataSkipRisk = riskdataSkipRisk;
        }

        /// <summary>
        /// The data for your custom risk field. For more information, refer to [Create custom risk fields](https://docs.adyen.com/risk-management/configure-custom-risk-rules#step-1-create-custom-risk-fields).
        /// </summary>
        /// <value>The data for your custom risk field. For more information, refer to [Create custom risk fields](https://docs.adyen.com/risk-management/configure-custom-risk-rules#step-1-create-custom-risk-fields).</value>
        [DataMember(Name = "riskdata.[customFieldName]", EmitDefaultValue = false)]
        public string RiskdataCustomFieldName { get; set; }

        /// <summary>
        /// The price of item in the basket, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        /// <value>The price of item in the basket, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].amountPerItem", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrAmountPerItem { get; set; }

        /// <summary>
        /// Brand of the item.
        /// </summary>
        /// <value>Brand of the item.</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].brand", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrBrand { get; set; }

        /// <summary>
        /// Category of the item.
        /// </summary>
        /// <value>Category of the item.</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].category", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrCategory { get; set; }

        /// <summary>
        /// Color of the item.
        /// </summary>
        /// <value>Color of the item.</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].color", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrColor { get; set; }

        /// <summary>
        /// The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].currency", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrCurrency { get; set; }

        /// <summary>
        /// ID of the item.
        /// </summary>
        /// <value>ID of the item.</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].itemID", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrItemID { get; set; }

        /// <summary>
        /// Manufacturer of the item.
        /// </summary>
        /// <value>Manufacturer of the item.</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].manufacturer", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrManufacturer { get; set; }

        /// <summary>
        /// A text description of the product the invoice line refers to.
        /// </summary>
        /// <value>A text description of the product the invoice line refers to.</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].productTitle", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrProductTitle { get; set; }

        /// <summary>
        /// Quantity of the item purchased.
        /// </summary>
        /// <value>Quantity of the item purchased.</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].quantity", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrQuantity { get; set; }

        /// <summary>
        /// Email associated with the given product in the basket (usually in electronic gift cards).
        /// </summary>
        /// <value>Email associated with the given product in the basket (usually in electronic gift cards).</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].receiverEmail", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrReceiverEmail { get; set; }

        /// <summary>
        /// Size of the item.
        /// </summary>
        /// <value>Size of the item.</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].size", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrSize { get; set; }

        /// <summary>
        /// [Stock keeping unit](https://en.wikipedia.org/wiki/Stock_keeping_unit).
        /// </summary>
        /// <value>[Stock keeping unit](https://en.wikipedia.org/wiki/Stock_keeping_unit).</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].sku", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrSku { get; set; }

        /// <summary>
        /// [Universal Product Code](https://en.wikipedia.org/wiki/Universal_Product_Code).
        /// </summary>
        /// <value>[Universal Product Code](https://en.wikipedia.org/wiki/Universal_Product_Code).</value>
        [DataMember(Name = "riskdata.basket.item[itemNr].upc", EmitDefaultValue = false)]
        public string RiskdataBasketItemItemNrUpc { get; set; }

        /// <summary>
        /// Code of the promotion.
        /// </summary>
        /// <value>Code of the promotion.</value>
        [DataMember(Name = "riskdata.promotions.promotion[itemNr].promotionCode", EmitDefaultValue = false)]
        public string RiskdataPromotionsPromotionItemNrPromotionCode { get; set; }

        /// <summary>
        /// The discount amount of the promotion, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        /// <value>The discount amount of the promotion, represented in [minor units](https://docs.adyen.com/development-resources/currency-codes).</value>
        [DataMember(Name = "riskdata.promotions.promotion[itemNr].promotionDiscountAmount", EmitDefaultValue = false)]
        public string RiskdataPromotionsPromotionItemNrPromotionDiscountAmount { get; set; }

        /// <summary>
        /// The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://en.wikipedia.org/wiki/ISO_4217).</value>
        [DataMember(Name = "riskdata.promotions.promotion[itemNr].promotionDiscountCurrency", EmitDefaultValue = false)]
        public string RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency { get; set; }

        /// <summary>
        /// Promotion&#39;s percentage discount. It is represented in percentage value and there is no need to include the &#39;%&#39; sign.  e.g. for a promotion discount of 30%, the value of the field should be 30.
        /// </summary>
        /// <value>Promotion&#39;s percentage discount. It is represented in percentage value and there is no need to include the &#39;%&#39; sign.  e.g. for a promotion discount of 30%, the value of the field should be 30.</value>
        [DataMember(Name = "riskdata.promotions.promotion[itemNr].promotionDiscountPercentage", EmitDefaultValue = false)]
        public string RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage { get; set; }

        /// <summary>
        /// Name of the promotion.
        /// </summary>
        /// <value>Name of the promotion.</value>
        [DataMember(Name = "riskdata.promotions.promotion[itemNr].promotionName", EmitDefaultValue = false)]
        public string RiskdataPromotionsPromotionItemNrPromotionName { get; set; }

        /// <summary>
        /// Reference number of the risk profile that you want to apply to the payment. If not provided or left blank, the merchant-level account&#39;s default risk profile will be applied to the payment. For more information, see [dynamically assign a risk profile to a payment](https://docs.adyen.com/risk-management/create-and-use-risk-profiles#dynamically-assign-a-risk-profile-to-a-payment).
        /// </summary>
        /// <value>Reference number of the risk profile that you want to apply to the payment. If not provided or left blank, the merchant-level account&#39;s default risk profile will be applied to the payment. For more information, see [dynamically assign a risk profile to a payment](https://docs.adyen.com/risk-management/create-and-use-risk-profiles#dynamically-assign-a-risk-profile-to-a-payment).</value>
        [DataMember(Name = "riskdata.riskProfileReference", EmitDefaultValue = false)]
        public string RiskdataRiskProfileReference { get; set; }

        /// <summary>
        /// If this parameter is provided with the value **true**, risk checks for the payment request are skipped and the transaction will not get a risk score.
        /// </summary>
        /// <value>If this parameter is provided with the value **true**, risk checks for the payment request are skipped and the transaction will not get a risk score.</value>
        [DataMember(Name = "riskdata.skipRisk", EmitDefaultValue = false)]
        public string RiskdataSkipRisk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataRisk {\n");
            sb.Append("  RiskdataCustomFieldName: ").Append(RiskdataCustomFieldName).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrAmountPerItem: ").Append(RiskdataBasketItemItemNrAmountPerItem).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrBrand: ").Append(RiskdataBasketItemItemNrBrand).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrCategory: ").Append(RiskdataBasketItemItemNrCategory).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrColor: ").Append(RiskdataBasketItemItemNrColor).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrCurrency: ").Append(RiskdataBasketItemItemNrCurrency).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrItemID: ").Append(RiskdataBasketItemItemNrItemID).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrManufacturer: ").Append(RiskdataBasketItemItemNrManufacturer).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrProductTitle: ").Append(RiskdataBasketItemItemNrProductTitle).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrQuantity: ").Append(RiskdataBasketItemItemNrQuantity).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrReceiverEmail: ").Append(RiskdataBasketItemItemNrReceiverEmail).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrSize: ").Append(RiskdataBasketItemItemNrSize).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrSku: ").Append(RiskdataBasketItemItemNrSku).Append("\n");
            sb.Append("  RiskdataBasketItemItemNrUpc: ").Append(RiskdataBasketItemItemNrUpc).Append("\n");
            sb.Append("  RiskdataPromotionsPromotionItemNrPromotionCode: ").Append(RiskdataPromotionsPromotionItemNrPromotionCode).Append("\n");
            sb.Append("  RiskdataPromotionsPromotionItemNrPromotionDiscountAmount: ").Append(RiskdataPromotionsPromotionItemNrPromotionDiscountAmount).Append("\n");
            sb.Append("  RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency: ").Append(RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency).Append("\n");
            sb.Append("  RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage: ").Append(RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage).Append("\n");
            sb.Append("  RiskdataPromotionsPromotionItemNrPromotionName: ").Append(RiskdataPromotionsPromotionItemNrPromotionName).Append("\n");
            sb.Append("  RiskdataRiskProfileReference: ").Append(RiskdataRiskProfileReference).Append("\n");
            sb.Append("  RiskdataSkipRisk: ").Append(RiskdataSkipRisk).Append("\n");
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
            return this.Equals(input as AdditionalDataRisk);
        }

        /// <summary>
        /// Returns true if AdditionalDataRisk instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataRisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataRisk input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RiskdataCustomFieldName == input.RiskdataCustomFieldName ||
                    (this.RiskdataCustomFieldName != null &&
                    this.RiskdataCustomFieldName.Equals(input.RiskdataCustomFieldName))
                ) && 
                (
                    this.RiskdataBasketItemItemNrAmountPerItem == input.RiskdataBasketItemItemNrAmountPerItem ||
                    (this.RiskdataBasketItemItemNrAmountPerItem != null &&
                    this.RiskdataBasketItemItemNrAmountPerItem.Equals(input.RiskdataBasketItemItemNrAmountPerItem))
                ) && 
                (
                    this.RiskdataBasketItemItemNrBrand == input.RiskdataBasketItemItemNrBrand ||
                    (this.RiskdataBasketItemItemNrBrand != null &&
                    this.RiskdataBasketItemItemNrBrand.Equals(input.RiskdataBasketItemItemNrBrand))
                ) && 
                (
                    this.RiskdataBasketItemItemNrCategory == input.RiskdataBasketItemItemNrCategory ||
                    (this.RiskdataBasketItemItemNrCategory != null &&
                    this.RiskdataBasketItemItemNrCategory.Equals(input.RiskdataBasketItemItemNrCategory))
                ) && 
                (
                    this.RiskdataBasketItemItemNrColor == input.RiskdataBasketItemItemNrColor ||
                    (this.RiskdataBasketItemItemNrColor != null &&
                    this.RiskdataBasketItemItemNrColor.Equals(input.RiskdataBasketItemItemNrColor))
                ) && 
                (
                    this.RiskdataBasketItemItemNrCurrency == input.RiskdataBasketItemItemNrCurrency ||
                    (this.RiskdataBasketItemItemNrCurrency != null &&
                    this.RiskdataBasketItemItemNrCurrency.Equals(input.RiskdataBasketItemItemNrCurrency))
                ) && 
                (
                    this.RiskdataBasketItemItemNrItemID == input.RiskdataBasketItemItemNrItemID ||
                    (this.RiskdataBasketItemItemNrItemID != null &&
                    this.RiskdataBasketItemItemNrItemID.Equals(input.RiskdataBasketItemItemNrItemID))
                ) && 
                (
                    this.RiskdataBasketItemItemNrManufacturer == input.RiskdataBasketItemItemNrManufacturer ||
                    (this.RiskdataBasketItemItemNrManufacturer != null &&
                    this.RiskdataBasketItemItemNrManufacturer.Equals(input.RiskdataBasketItemItemNrManufacturer))
                ) && 
                (
                    this.RiskdataBasketItemItemNrProductTitle == input.RiskdataBasketItemItemNrProductTitle ||
                    (this.RiskdataBasketItemItemNrProductTitle != null &&
                    this.RiskdataBasketItemItemNrProductTitle.Equals(input.RiskdataBasketItemItemNrProductTitle))
                ) && 
                (
                    this.RiskdataBasketItemItemNrQuantity == input.RiskdataBasketItemItemNrQuantity ||
                    (this.RiskdataBasketItemItemNrQuantity != null &&
                    this.RiskdataBasketItemItemNrQuantity.Equals(input.RiskdataBasketItemItemNrQuantity))
                ) && 
                (
                    this.RiskdataBasketItemItemNrReceiverEmail == input.RiskdataBasketItemItemNrReceiverEmail ||
                    (this.RiskdataBasketItemItemNrReceiverEmail != null &&
                    this.RiskdataBasketItemItemNrReceiverEmail.Equals(input.RiskdataBasketItemItemNrReceiverEmail))
                ) && 
                (
                    this.RiskdataBasketItemItemNrSize == input.RiskdataBasketItemItemNrSize ||
                    (this.RiskdataBasketItemItemNrSize != null &&
                    this.RiskdataBasketItemItemNrSize.Equals(input.RiskdataBasketItemItemNrSize))
                ) && 
                (
                    this.RiskdataBasketItemItemNrSku == input.RiskdataBasketItemItemNrSku ||
                    (this.RiskdataBasketItemItemNrSku != null &&
                    this.RiskdataBasketItemItemNrSku.Equals(input.RiskdataBasketItemItemNrSku))
                ) && 
                (
                    this.RiskdataBasketItemItemNrUpc == input.RiskdataBasketItemItemNrUpc ||
                    (this.RiskdataBasketItemItemNrUpc != null &&
                    this.RiskdataBasketItemItemNrUpc.Equals(input.RiskdataBasketItemItemNrUpc))
                ) && 
                (
                    this.RiskdataPromotionsPromotionItemNrPromotionCode == input.RiskdataPromotionsPromotionItemNrPromotionCode ||
                    (this.RiskdataPromotionsPromotionItemNrPromotionCode != null &&
                    this.RiskdataPromotionsPromotionItemNrPromotionCode.Equals(input.RiskdataPromotionsPromotionItemNrPromotionCode))
                ) && 
                (
                    this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount == input.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount ||
                    (this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount != null &&
                    this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount.Equals(input.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount))
                ) && 
                (
                    this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency == input.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency ||
                    (this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency != null &&
                    this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency.Equals(input.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency))
                ) && 
                (
                    this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage == input.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage ||
                    (this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage != null &&
                    this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage.Equals(input.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage))
                ) && 
                (
                    this.RiskdataPromotionsPromotionItemNrPromotionName == input.RiskdataPromotionsPromotionItemNrPromotionName ||
                    (this.RiskdataPromotionsPromotionItemNrPromotionName != null &&
                    this.RiskdataPromotionsPromotionItemNrPromotionName.Equals(input.RiskdataPromotionsPromotionItemNrPromotionName))
                ) && 
                (
                    this.RiskdataRiskProfileReference == input.RiskdataRiskProfileReference ||
                    (this.RiskdataRiskProfileReference != null &&
                    this.RiskdataRiskProfileReference.Equals(input.RiskdataRiskProfileReference))
                ) && 
                (
                    this.RiskdataSkipRisk == input.RiskdataSkipRisk ||
                    (this.RiskdataSkipRisk != null &&
                    this.RiskdataSkipRisk.Equals(input.RiskdataSkipRisk))
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
                if (this.RiskdataCustomFieldName != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataCustomFieldName.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrAmountPerItem != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrAmountPerItem.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrBrand != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrBrand.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrCategory != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrCategory.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrColor != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrColor.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrCurrency.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrItemID != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrItemID.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrManufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrManufacturer.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrProductTitle != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrProductTitle.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrQuantity.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrReceiverEmail != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrReceiverEmail.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrSize != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrSize.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrSku != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrSku.GetHashCode();
                }
                if (this.RiskdataBasketItemItemNrUpc != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataBasketItemItemNrUpc.GetHashCode();
                }
                if (this.RiskdataPromotionsPromotionItemNrPromotionCode != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataPromotionsPromotionItemNrPromotionCode.GetHashCode();
                }
                if (this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataPromotionsPromotionItemNrPromotionDiscountAmount.GetHashCode();
                }
                if (this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataPromotionsPromotionItemNrPromotionDiscountCurrency.GetHashCode();
                }
                if (this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataPromotionsPromotionItemNrPromotionDiscountPercentage.GetHashCode();
                }
                if (this.RiskdataPromotionsPromotionItemNrPromotionName != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataPromotionsPromotionItemNrPromotionName.GetHashCode();
                }
                if (this.RiskdataRiskProfileReference != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataRiskProfileReference.GetHashCode();
                }
                if (this.RiskdataSkipRisk != null)
                {
                    hashCode = (hashCode * 59) + this.RiskdataSkipRisk.GetHashCode();
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
