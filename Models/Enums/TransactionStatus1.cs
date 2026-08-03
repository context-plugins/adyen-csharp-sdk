using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transaction.
/// &gt;Permitted values: <c>PendingCredit</c>, <c>CreditFailed</c>, <c>CreditClosed</c>, <c>CreditSuspended</c>, <c>Credited</c>, <c>Converted</c>, <c>PendingDebit</c>, <c>DebitFailed</c>, <c>Debited</c>, <c>DebitReversedReceived</c>, <c>DebitedReversed</c>, <c>ChargebackReceived</c>, <c>Chargeback</c>, <c>ChargebackReversedReceived</c>, <c>ChargebackReversed</c>, <c>Payout</c>, <c>PayoutReversed</c>, <c>FundTransfer</c>, <c>PendingFundTransfer</c>, <c>ManualCorrected</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionStatus1>))]
public sealed record TransactionStatus1 : StringEnum<TransactionStatus1>
{
    private TransactionStatus1(string value) : base(value)
    {
    }

    public static readonly TransactionStatus1 BalanceNotPaidOutTransfer = new("BalanceNotPaidOutTransfer");

    public static readonly TransactionStatus1 BalancePlatformFundTransfer = new("BalancePlatformFundTransfer");

    public static readonly TransactionStatus1 BalancePlatformSweep = new("BalancePlatformSweep");

    public static readonly TransactionStatus1 BalancePlatformSweepReturned = new("BalancePlatformSweepReturned");

    public static readonly TransactionStatus1 Chargeback = new("Chargeback");

    public static readonly TransactionStatus1 ChargebackCorrection = new("ChargebackCorrection");

    public static readonly TransactionStatus1 ChargebackCorrectionReceived = new("ChargebackCorrectionReceived");

    public static readonly TransactionStatus1 ChargebackReceived = new("ChargebackReceived");

    public static readonly TransactionStatus1 ChargebackReversed = new("ChargebackReversed");

    public static readonly TransactionStatus1 ChargebackReversedCorrection = new("ChargebackReversedCorrection");

    public static readonly TransactionStatus1 ChargebackReversedCorrectionReceived = new("ChargebackReversedCorrectionReceived");

    public static readonly TransactionStatus1 ChargebackReversedReceived = new("ChargebackReversedReceived");

    public static readonly TransactionStatus1 Converted = new("Converted");

    public static readonly TransactionStatus1 CreditClosed = new("CreditClosed");

    public static readonly TransactionStatus1 CreditFailed = new("CreditFailed");

    public static readonly TransactionStatus1 CreditReversed = new("CreditReversed");

    public static readonly TransactionStatus1 CreditReversedReceived = new("CreditReversedReceived");

    public static readonly TransactionStatus1 CreditSuspended = new("CreditSuspended");

    public static readonly TransactionStatus1 Credited = new("Credited");

    public static readonly TransactionStatus1 DebitFailed = new("DebitFailed");

    public static readonly TransactionStatus1 DebitReversedReceived = new("DebitReversedReceived");

    public static readonly TransactionStatus1 Debited = new("Debited");

    public static readonly TransactionStatus1 DebitedReversed = new("DebitedReversed");

    public static readonly TransactionStatus1 DepositCorrectionCredited = new("DepositCorrectionCredited");

    public static readonly TransactionStatus1 DepositCorrectionDebited = new("DepositCorrectionDebited");

    public static readonly TransactionStatus1 DepositCorrectionReceived = new("DepositCorrectionReceived");

    public static readonly TransactionStatus1 Fee = new("Fee");

    public static readonly TransactionStatus1 FeeReceived = new("FeeReceived");

    public static readonly TransactionStatus1 FundTransfer = new("FundTransfer");

    public static readonly TransactionStatus1 FundTransferReversed = new("FundTransferReversed");

    public static readonly TransactionStatus1 InvoiceDeductionCredited = new("InvoiceDeductionCredited");

    public static readonly TransactionStatus1 InvoiceDeductionDebited = new("InvoiceDeductionDebited");

    public static readonly TransactionStatus1 InvoiceDeductionReceived = new("InvoiceDeductionReceived");

    public static readonly TransactionStatus1 ManualCorrected = new("ManualCorrected");

    public static readonly TransactionStatus1 ManualCorrectionCredited = new("ManualCorrectionCredited");

    public static readonly TransactionStatus1 ManualCorrectionDebited = new("ManualCorrectionDebited");

    public static readonly TransactionStatus1 MerchantPayin = new("MerchantPayin");

    public static readonly TransactionStatus1 MerchantPayinReceived = new("MerchantPayinReceived");

    public static readonly TransactionStatus1 MerchantPayinReversed = new("MerchantPayinReversed");

    public static readonly TransactionStatus1 Payout = new("Payout");

    public static readonly TransactionStatus1 PayoutReversed = new("PayoutReversed");

    public static readonly TransactionStatus1 PendingCredit = new("PendingCredit");

    public static readonly TransactionStatus1 PendingDebit = new("PendingDebit");

    public static readonly TransactionStatus1 PendingFundTransfer = new("PendingFundTransfer");

    public static readonly TransactionStatus1 ReCredited = new("ReCredited");

    public static readonly TransactionStatus1 ReCreditedReceived = new("ReCreditedReceived");

    public static readonly TransactionStatus1 SecondChargeback = new("SecondChargeback");

    public static readonly TransactionStatus1 SecondChargebackCorrection = new("SecondChargebackCorrection");

    public static readonly TransactionStatus1 SecondChargebackCorrectionReceived = new("SecondChargebackCorrectionReceived");

    public static readonly TransactionStatus1 SecondChargebackReceived = new("SecondChargebackReceived");

    public static TransactionStatus1 FromValue(string value) => FromValueCore(value);
}
