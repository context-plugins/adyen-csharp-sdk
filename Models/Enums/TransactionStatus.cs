using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TransactionStatus>))]
public sealed record TransactionStatus : StringEnum<TransactionStatus>
{
    private TransactionStatus(string value) : base(value)
    {
    }

    public static readonly TransactionStatus BalanceNotPaidOutTransfer = new("BalanceNotPaidOutTransfer");

    public static readonly TransactionStatus BalancePlatformFundTransfer = new("BalancePlatformFundTransfer");

    public static readonly TransactionStatus BalancePlatformSweep = new("BalancePlatformSweep");

    public static readonly TransactionStatus BalancePlatformSweepReturned = new("BalancePlatformSweepReturned");

    public static readonly TransactionStatus Chargeback = new("Chargeback");

    public static readonly TransactionStatus ChargebackCorrection = new("ChargebackCorrection");

    public static readonly TransactionStatus ChargebackCorrectionReceived = new("ChargebackCorrectionReceived");

    public static readonly TransactionStatus ChargebackReceived = new("ChargebackReceived");

    public static readonly TransactionStatus ChargebackReversed = new("ChargebackReversed");

    public static readonly TransactionStatus ChargebackReversedCorrection = new("ChargebackReversedCorrection");

    public static readonly TransactionStatus ChargebackReversedCorrectionReceived = new("ChargebackReversedCorrectionReceived");

    public static readonly TransactionStatus ChargebackReversedReceived = new("ChargebackReversedReceived");

    public static readonly TransactionStatus Converted = new("Converted");

    public static readonly TransactionStatus CreditClosed = new("CreditClosed");

    public static readonly TransactionStatus CreditFailed = new("CreditFailed");

    public static readonly TransactionStatus CreditReversed = new("CreditReversed");

    public static readonly TransactionStatus CreditReversedReceived = new("CreditReversedReceived");

    public static readonly TransactionStatus CreditSuspended = new("CreditSuspended");

    public static readonly TransactionStatus Credited = new("Credited");

    public static readonly TransactionStatus DebitFailed = new("DebitFailed");

    public static readonly TransactionStatus DebitReversedReceived = new("DebitReversedReceived");

    public static readonly TransactionStatus Debited = new("Debited");

    public static readonly TransactionStatus DebitedReversed = new("DebitedReversed");

    public static readonly TransactionStatus DepositCorrectionCredited = new("DepositCorrectionCredited");

    public static readonly TransactionStatus DepositCorrectionDebited = new("DepositCorrectionDebited");

    public static readonly TransactionStatus DepositCorrectionReceived = new("DepositCorrectionReceived");

    public static readonly TransactionStatus Fee = new("Fee");

    public static readonly TransactionStatus FeeReceived = new("FeeReceived");

    public static readonly TransactionStatus FundTransfer = new("FundTransfer");

    public static readonly TransactionStatus FundTransferReversed = new("FundTransferReversed");

    public static readonly TransactionStatus InvoiceDeductionCredited = new("InvoiceDeductionCredited");

    public static readonly TransactionStatus InvoiceDeductionDebited = new("InvoiceDeductionDebited");

    public static readonly TransactionStatus InvoiceDeductionReceived = new("InvoiceDeductionReceived");

    public static readonly TransactionStatus ManualCorrected = new("ManualCorrected");

    public static readonly TransactionStatus ManualCorrectionCredited = new("ManualCorrectionCredited");

    public static readonly TransactionStatus ManualCorrectionDebited = new("ManualCorrectionDebited");

    public static readonly TransactionStatus MerchantPayin = new("MerchantPayin");

    public static readonly TransactionStatus MerchantPayinReceived = new("MerchantPayinReceived");

    public static readonly TransactionStatus MerchantPayinReversed = new("MerchantPayinReversed");

    public static readonly TransactionStatus Payout = new("Payout");

    public static readonly TransactionStatus PayoutReversed = new("PayoutReversed");

    public static readonly TransactionStatus PendingCredit = new("PendingCredit");

    public static readonly TransactionStatus PendingDebit = new("PendingDebit");

    public static readonly TransactionStatus PendingFundTransfer = new("PendingFundTransfer");

    public static readonly TransactionStatus ReCredited = new("ReCredited");

    public static readonly TransactionStatus ReCreditedReceived = new("ReCreditedReceived");

    public static readonly TransactionStatus SecondChargeback = new("SecondChargeback");

    public static readonly TransactionStatus SecondChargebackCorrection = new("SecondChargebackCorrection");

    public static readonly TransactionStatus SecondChargebackCorrectionReceived = new("SecondChargebackCorrectionReceived");

    public static readonly TransactionStatus SecondChargebackReceived = new("SecondChargebackReceived");

    public static TransactionStatus FromValue(string value) => FromValueCore(value);
}
