using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HeadOn.Classic.Adyen.Model.MarketPay
{
    /// <summary>
    /// Transaction
    /// </summary>
    [DataContract(Name = "Transaction")]
    public class Transaction : IEquatable<Transaction>, IValidatableObject
    {
        /// <summary>
        /// The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;CreditClosed&#x60;, &#x60;CreditSuspended&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;.
        /// </summary>
        /// <value>The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;CreditClosed&#x60;, &#x60;CreditSuspended&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusEnum
        {
            /// <summary>
            /// Enum BalanceNotPaidOutTransfer for value: BalanceNotPaidOutTransfer
            /// </summary>
            [EnumMember(Value = "BalanceNotPaidOutTransfer")]
            BalanceNotPaidOutTransfer = 1,

            /// <summary>
            /// Enum Chargeback for value: Chargeback
            /// </summary>
            [EnumMember(Value = "Chargeback")]
            Chargeback = 2,

            /// <summary>
            /// Enum ChargebackCorrection for value: ChargebackCorrection
            /// </summary>
            [EnumMember(Value = "ChargebackCorrection")]
            ChargebackCorrection = 3,

            /// <summary>
            /// Enum ChargebackCorrectionReceived for value: ChargebackCorrectionReceived
            /// </summary>
            [EnumMember(Value = "ChargebackCorrectionReceived")]
            ChargebackCorrectionReceived = 4,

            /// <summary>
            /// Enum ChargebackReceived for value: ChargebackReceived
            /// </summary>
            [EnumMember(Value = "ChargebackReceived")]
            ChargebackReceived = 5,

            /// <summary>
            /// Enum ChargebackReversed for value: ChargebackReversed
            /// </summary>
            [EnumMember(Value = "ChargebackReversed")]
            ChargebackReversed = 6,

            /// <summary>
            /// Enum ChargebackReversedCorrection for value: ChargebackReversedCorrection
            /// </summary>
            [EnumMember(Value = "ChargebackReversedCorrection")]
            ChargebackReversedCorrection = 7,

            /// <summary>
            /// Enum ChargebackReversedCorrectionReceived for value: ChargebackReversedCorrectionReceived
            /// </summary>
            [EnumMember(Value = "ChargebackReversedCorrectionReceived")]
            ChargebackReversedCorrectionReceived = 8,

            /// <summary>
            /// Enum ChargebackReversedReceived for value: ChargebackReversedReceived
            /// </summary>
            [EnumMember(Value = "ChargebackReversedReceived")]
            ChargebackReversedReceived = 9,

            /// <summary>
            /// Enum Converted for value: Converted
            /// </summary>
            [EnumMember(Value = "Converted")]
            Converted = 10,

            /// <summary>
            /// Enum CreditClosed for value: CreditClosed
            /// </summary>
            [EnumMember(Value = "CreditClosed")]
            CreditClosed = 11,

            /// <summary>
            /// Enum CreditFailed for value: CreditFailed
            /// </summary>
            [EnumMember(Value = "CreditFailed")]
            CreditFailed = 12,

            /// <summary>
            /// Enum CreditReversed for value: CreditReversed
            /// </summary>
            [EnumMember(Value = "CreditReversed")]
            CreditReversed = 13,

            /// <summary>
            /// Enum CreditReversedReceived for value: CreditReversedReceived
            /// </summary>
            [EnumMember(Value = "CreditReversedReceived")]
            CreditReversedReceived = 14,

            /// <summary>
            /// Enum CreditSuspended for value: CreditSuspended
            /// </summary>
            [EnumMember(Value = "CreditSuspended")]
            CreditSuspended = 15,

            /// <summary>
            /// Enum Credited for value: Credited
            /// </summary>
            [EnumMember(Value = "Credited")]
            Credited = 16,

            /// <summary>
            /// Enum DebitFailed for value: DebitFailed
            /// </summary>
            [EnumMember(Value = "DebitFailed")]
            DebitFailed = 17,

            /// <summary>
            /// Enum DebitReversedReceived for value: DebitReversedReceived
            /// </summary>
            [EnumMember(Value = "DebitReversedReceived")]
            DebitReversedReceived = 18,

            /// <summary>
            /// Enum Debited for value: Debited
            /// </summary>
            [EnumMember(Value = "Debited")]
            Debited = 19,

            /// <summary>
            /// Enum DebitedReversed for value: DebitedReversed
            /// </summary>
            [EnumMember(Value = "DebitedReversed")]
            DebitedReversed = 20,

            /// <summary>
            /// Enum DepositCorrectionCredited for value: DepositCorrectionCredited
            /// </summary>
            [EnumMember(Value = "DepositCorrectionCredited")]
            DepositCorrectionCredited = 21,

            /// <summary>
            /// Enum DepositCorrectionDebited for value: DepositCorrectionDebited
            /// </summary>
            [EnumMember(Value = "DepositCorrectionDebited")]
            DepositCorrectionDebited = 22,

            /// <summary>
            /// Enum Fee for value: Fee
            /// </summary>
            [EnumMember(Value = "Fee")]
            Fee = 23,

            /// <summary>
            /// Enum FundTransfer for value: FundTransfer
            /// </summary>
            [EnumMember(Value = "FundTransfer")]
            FundTransfer = 24,

            /// <summary>
            /// Enum FundTransferReversed for value: FundTransferReversed
            /// </summary>
            [EnumMember(Value = "FundTransferReversed")]
            FundTransferReversed = 25,

            /// <summary>
            /// Enum InvoiceDeductionCredited for value: InvoiceDeductionCredited
            /// </summary>
            [EnumMember(Value = "InvoiceDeductionCredited")]
            InvoiceDeductionCredited = 26,

            /// <summary>
            /// Enum InvoiceDeductionDebited for value: InvoiceDeductionDebited
            /// </summary>
            [EnumMember(Value = "InvoiceDeductionDebited")]
            InvoiceDeductionDebited = 27,

            /// <summary>
            /// Enum ManualCorrected for value: ManualCorrected
            /// </summary>
            [EnumMember(Value = "ManualCorrected")]
            ManualCorrected = 28,

            /// <summary>
            /// Enum ManualCorrectionCredited for value: ManualCorrectionCredited
            /// </summary>
            [EnumMember(Value = "ManualCorrectionCredited")]
            ManualCorrectionCredited = 29,

            /// <summary>
            /// Enum ManualCorrectionDebited for value: ManualCorrectionDebited
            /// </summary>
            [EnumMember(Value = "ManualCorrectionDebited")]
            ManualCorrectionDebited = 30,

            /// <summary>
            /// Enum MerchantPayin for value: MerchantPayin
            /// </summary>
            [EnumMember(Value = "MerchantPayin")]
            MerchantPayin = 31,

            /// <summary>
            /// Enum MerchantPayinReversed for value: MerchantPayinReversed
            /// </summary>
            [EnumMember(Value = "MerchantPayinReversed")]
            MerchantPayinReversed = 32,

            /// <summary>
            /// Enum Payout for value: Payout
            /// </summary>
            [EnumMember(Value = "Payout")]
            Payout = 33,

            /// <summary>
            /// Enum PayoutReversed for value: PayoutReversed
            /// </summary>
            [EnumMember(Value = "PayoutReversed")]
            PayoutReversed = 34,

            /// <summary>
            /// Enum PendingCredit for value: PendingCredit
            /// </summary>
            [EnumMember(Value = "PendingCredit")]
            PendingCredit = 35,

            /// <summary>
            /// Enum PendingDebit for value: PendingDebit
            /// </summary>
            [EnumMember(Value = "PendingDebit")]
            PendingDebit = 36,

            /// <summary>
            /// Enum PendingFundTransfer for value: PendingFundTransfer
            /// </summary>
            [EnumMember(Value = "PendingFundTransfer")]
            PendingFundTransfer = 37,

            /// <summary>
            /// Enum SecondChargeback for value: SecondChargeback
            /// </summary>
            [EnumMember(Value = "SecondChargeback")]
            SecondChargeback = 38,

            /// <summary>
            /// Enum SecondChargebackCorrection for value: SecondChargebackCorrection
            /// </summary>
            [EnumMember(Value = "SecondChargebackCorrection")]
            SecondChargebackCorrection = 39,

            /// <summary>
            /// Enum SecondChargebackCorrectionReceived for value: SecondChargebackCorrectionReceived
            /// </summary>
            [EnumMember(Value = "SecondChargebackCorrectionReceived")]
            SecondChargebackCorrectionReceived = 40,

            /// <summary>
            /// Enum SecondChargebackReceived for value: SecondChargebackReceived
            /// </summary>
            [EnumMember(Value = "SecondChargebackReceived")]
            SecondChargebackReceived = 41

        }


        /// <summary>
        /// The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;CreditClosed&#x60;, &#x60;CreditSuspended&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;.
        /// </summary>
        /// <value>The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;CreditClosed&#x60;, &#x60;CreditSuspended&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;.</value>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public TransactionStatusEnum? TransactionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="balanceAccountId">The balance platform account ID of the balance platform to which payout was made.</param>
        /// <param name="bankAccountDetail">bankAccountDetail.</param>
        /// <param name="captureMerchantReference">The merchant reference of a related capture..</param>
        /// <param name="capturePspReference">The psp reference of a related capture..</param>
        /// <param name="creationDate">The date on which the transaction was performed..</param>
        /// <param name="description">A description of the transaction..</param>
        /// <param name="destinationAccountCode">The code of the account to which funds were credited during an outgoing fund transfer..</param>
        /// <param name="disputePspReference">The psp reference of the related dispute..</param>
        /// <param name="disputeReasonCode">The reason code of a dispute..</param>
        /// <param name="merchantReference">The merchant reference of a transaction..</param>
        /// <param name="paymentPspReference">The psp reference of the related authorisation or transfer..</param>
        /// <param name="payoutPspReference">The psp reference of the related payout..</param>
        /// <param name="pspReference">The psp reference of a transaction..</param>
        /// <param name="sourceAccountCode">The code of the account from which funds were debited during an incoming fund transfer..</param>
        /// <param name="transactionStatus">The status of the transaction. &gt;Permitted values: &#x60;PendingCredit&#x60;, &#x60;CreditFailed&#x60;, &#x60;CreditClosed&#x60;, &#x60;CreditSuspended&#x60;, &#x60;Credited&#x60;, &#x60;Converted&#x60;, &#x60;PendingDebit&#x60;, &#x60;DebitFailed&#x60;, &#x60;Debited&#x60;, &#x60;DebitReversedReceived&#x60;, &#x60;DebitedReversed&#x60;, &#x60;ChargebackReceived&#x60;, &#x60;Chargeback&#x60;, &#x60;ChargebackReversedReceived&#x60;, &#x60;ChargebackReversed&#x60;, &#x60;Payout&#x60;, &#x60;PayoutReversed&#x60;, &#x60;FundTransfer&#x60;, &#x60;PendingFundTransfer&#x60;, &#x60;ManualCorrected&#x60;..</param>
        /// <param name="transferCode">The transfer code of the transaction..</param>
        public Transaction(Amount amount = default(Amount), string balanceAccountId = default(string), BankAccountDetail bankAccountDetail = default(BankAccountDetail), string captureMerchantReference = default(string), string capturePspReference = default(string), DateTime creationDate = default(DateTime), string description = default(string), string destinationAccountCode = default(string), string disputePspReference = default(string), string disputeReasonCode = default(string), string merchantReference = default(string), string paymentPspReference = default(string), string payoutPspReference = default(string), string pspReference = default(string), string sourceAccountCode = default(string), TransactionStatusEnum? transactionStatus = default(TransactionStatusEnum?), string transferCode = default(string))
        {
            Amount = amount;
            BalanceAccountId = balanceAccountId;
            BankAccountDetail = bankAccountDetail;
            CaptureMerchantReference = captureMerchantReference;
            CapturePspReference = capturePspReference;
            CreationDate = creationDate;
            Description = description;
            DestinationAccountCode = destinationAccountCode;
            DisputePspReference = disputePspReference;
            DisputeReasonCode = disputeReasonCode;
            MerchantReference = merchantReference;
            PaymentPspReference = paymentPspReference;
            PayoutPspReference = payoutPspReference;
            PspReference = pspReference;
            SourceAccountCode = sourceAccountCode;
            TransactionStatus = transactionStatus;
            TransferCode = transferCode;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The balance platform account ID of the balance platform to which payout was made
        /// </summary>
        /// <value>The balance platform account ID of the balance platform to which payout was made</value>
        [DataMember(Name = "balanceAccountId", EmitDefaultValue = false)]
        public string BalanceAccountId { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountDetail
        /// </summary>
        [DataMember(Name = "bankAccountDetail", EmitDefaultValue = false)]
        public BankAccountDetail BankAccountDetail { get; set; }

        /// <summary>
        /// The merchant reference of a related capture.
        /// </summary>
        /// <value>The merchant reference of a related capture.</value>
        [DataMember(Name = "captureMerchantReference", EmitDefaultValue = false)]
        public string CaptureMerchantReference { get; set; }

        /// <summary>
        /// The psp reference of a related capture.
        /// </summary>
        /// <value>The psp reference of a related capture.</value>
        [DataMember(Name = "capturePspReference", EmitDefaultValue = false)]
        public string CapturePspReference { get; set; }

        /// <summary>
        /// The date on which the transaction was performed.
        /// </summary>
        /// <value>The date on which the transaction was performed.</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// A description of the transaction.
        /// </summary>
        /// <value>A description of the transaction.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The code of the account to which funds were credited during an outgoing fund transfer.
        /// </summary>
        /// <value>The code of the account to which funds were credited during an outgoing fund transfer.</value>
        [DataMember(Name = "destinationAccountCode", EmitDefaultValue = false)]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// The psp reference of the related dispute.
        /// </summary>
        /// <value>The psp reference of the related dispute.</value>
        [DataMember(Name = "disputePspReference", EmitDefaultValue = false)]
        public string DisputePspReference { get; set; }

        /// <summary>
        /// The reason code of a dispute.
        /// </summary>
        /// <value>The reason code of a dispute.</value>
        [DataMember(Name = "disputeReasonCode", EmitDefaultValue = false)]
        public string DisputeReasonCode { get; set; }

        /// <summary>
        /// The merchant reference of a transaction.
        /// </summary>
        /// <value>The merchant reference of a transaction.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The psp reference of the related authorisation or transfer.
        /// </summary>
        /// <value>The psp reference of the related authorisation or transfer.</value>
        [DataMember(Name = "paymentPspReference", EmitDefaultValue = false)]
        public string PaymentPspReference { get; set; }

        /// <summary>
        /// The psp reference of the related payout.
        /// </summary>
        /// <value>The psp reference of the related payout.</value>
        [DataMember(Name = "payoutPspReference", EmitDefaultValue = false)]
        public string PayoutPspReference { get; set; }

        /// <summary>
        /// The psp reference of a transaction.
        /// </summary>
        /// <value>The psp reference of a transaction.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The code of the account from which funds were debited during an incoming fund transfer.
        /// </summary>
        /// <value>The code of the account from which funds were debited during an incoming fund transfer.</value>
        [DataMember(Name = "sourceAccountCode", EmitDefaultValue = false)]
        public string SourceAccountCode { get; set; }

        /// <summary>
        /// The transfer code of the transaction.
        /// </summary>
        /// <value>The transfer code of the transaction.</value>
        [DataMember(Name = "transferCode", EmitDefaultValue = false)]
        public string TransferCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BalanceAccountId: ").Append(BalanceAccountId).Append("\n");
            sb.Append("  BankAccountDetail: ").Append(BankAccountDetail).Append("\n");
            sb.Append("  CaptureMerchantReference: ").Append(CaptureMerchantReference).Append("\n");
            sb.Append("  CapturePspReference: ").Append(CapturePspReference).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  DisputePspReference: ").Append(DisputePspReference).Append("\n");
            sb.Append("  DisputeReasonCode: ").Append(DisputeReasonCode).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  PaymentPspReference: ").Append(PaymentPspReference).Append("\n");
            sb.Append("  PayoutPspReference: ").Append(PayoutPspReference).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  TransferCode: ").Append(TransferCode).Append("\n");
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
            return Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
        {
            if (input == null)
                return false;

            return
                (
                    Amount == input.Amount ||
                    (Amount != null &&
                    Amount.Equals(input.Amount))
                ) &&
                (
                    BalanceAccountId == input.BalanceAccountId ||
                    (BalanceAccountId != null &&
                    BalanceAccountId.Equals(input.BalanceAccountId))
                ) &&
                (
                    BankAccountDetail == input.BankAccountDetail ||
                    (BankAccountDetail != null &&
                    BankAccountDetail.Equals(input.BankAccountDetail))
                ) &&
                (
                    CaptureMerchantReference == input.CaptureMerchantReference ||
                    (CaptureMerchantReference != null &&
                    CaptureMerchantReference.Equals(input.CaptureMerchantReference))
                ) &&
                (
                    CapturePspReference == input.CapturePspReference ||
                    (CapturePspReference != null &&
                    CapturePspReference.Equals(input.CapturePspReference))
                ) &&
                (
                    CreationDate == input.CreationDate ||
                    (CreationDate != null &&
                    CreationDate.Equals(input.CreationDate))
                ) &&
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) &&
                (
                    DestinationAccountCode == input.DestinationAccountCode ||
                    (DestinationAccountCode != null &&
                    DestinationAccountCode.Equals(input.DestinationAccountCode))
                ) &&
                (
                    DisputePspReference == input.DisputePspReference ||
                    (DisputePspReference != null &&
                    DisputePspReference.Equals(input.DisputePspReference))
                ) &&
                (
                    DisputeReasonCode == input.DisputeReasonCode ||
                    (DisputeReasonCode != null &&
                    DisputeReasonCode.Equals(input.DisputeReasonCode))
                ) &&
                (
                    MerchantReference == input.MerchantReference ||
                    (MerchantReference != null &&
                    MerchantReference.Equals(input.MerchantReference))
                ) &&
                (
                    PaymentPspReference == input.PaymentPspReference ||
                    (PaymentPspReference != null &&
                    PaymentPspReference.Equals(input.PaymentPspReference))
                ) &&
                (
                    PayoutPspReference == input.PayoutPspReference ||
                    (PayoutPspReference != null &&
                    PayoutPspReference.Equals(input.PayoutPspReference))
                ) &&
                (
                    PspReference == input.PspReference ||
                    (PspReference != null &&
                    PspReference.Equals(input.PspReference))
                ) &&
                (
                    SourceAccountCode == input.SourceAccountCode ||
                    (SourceAccountCode != null &&
                    SourceAccountCode.Equals(input.SourceAccountCode))
                ) &&
                (
                    TransactionStatus == input.TransactionStatus ||
                    TransactionStatus.Equals(input.TransactionStatus)
                ) &&
                (
                    TransferCode == input.TransferCode ||
                    (TransferCode != null &&
                    TransferCode.Equals(input.TransferCode))
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
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (BalanceAccountId != null)
                    hashCode = hashCode * 59 + BalanceAccountId.GetHashCode();
                if (BankAccountDetail != null)
                    hashCode = hashCode * 59 + BankAccountDetail.GetHashCode();
                if (CaptureMerchantReference != null)
                    hashCode = hashCode * 59 + CaptureMerchantReference.GetHashCode();
                if (CapturePspReference != null)
                    hashCode = hashCode * 59 + CapturePspReference.GetHashCode();
                if (CreationDate != null)
                    hashCode = hashCode * 59 + CreationDate.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (DestinationAccountCode != null)
                    hashCode = hashCode * 59 + DestinationAccountCode.GetHashCode();
                if (DisputePspReference != null)
                    hashCode = hashCode * 59 + DisputePspReference.GetHashCode();
                if (DisputeReasonCode != null)
                    hashCode = hashCode * 59 + DisputeReasonCode.GetHashCode();
                if (MerchantReference != null)
                    hashCode = hashCode * 59 + MerchantReference.GetHashCode();
                if (PaymentPspReference != null)
                    hashCode = hashCode * 59 + PaymentPspReference.GetHashCode();
                if (PayoutPspReference != null)
                    hashCode = hashCode * 59 + PayoutPspReference.GetHashCode();
                if (PspReference != null)
                    hashCode = hashCode * 59 + PspReference.GetHashCode();
                if (SourceAccountCode != null)
                    hashCode = hashCode * 59 + SourceAccountCode.GetHashCode();
                hashCode = hashCode * 59 + TransactionStatus.GetHashCode();
                if (TransferCode != null)
                    hashCode = hashCode * 59 + TransferCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}