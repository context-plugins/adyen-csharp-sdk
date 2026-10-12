using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TransactionStatus>))]
public sealed record TransactionStatus : OpenStringEnum<TransactionStatus>
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

    public static readonly TransactionStatus ChargebackReversedCorrectionReceived = new(
        "ChargebackReversedCorrectionReceived");

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

    public static readonly TransactionStatus SecondChargebackCorrectionReceived = new(
        "SecondChargebackCorrectionReceived");

    public static readonly TransactionStatus SecondChargebackReceived = new("SecondChargebackReceived");

    public TResult Match<TResult>(Func<TResult> onBalanceNotPaidOutTransfer,
        Func<TResult> onBalancePlatformFundTransfer,
        Func<TResult> onBalancePlatformSweep,
        Func<TResult> onBalancePlatformSweepReturned,
        Func<TResult> onChargeback,
        Func<TResult> onChargebackCorrection,
        Func<TResult> onChargebackCorrectionReceived,
        Func<TResult> onChargebackReceived,
        Func<TResult> onChargebackReversed,
        Func<TResult> onChargebackReversedCorrection,
        Func<TResult> onChargebackReversedCorrectionReceived,
        Func<TResult> onChargebackReversedReceived,
        Func<TResult> onConverted,
        Func<TResult> onCreditClosed,
        Func<TResult> onCreditFailed,
        Func<TResult> onCreditReversed,
        Func<TResult> onCreditReversedReceived,
        Func<TResult> onCreditSuspended,
        Func<TResult> onCredited,
        Func<TResult> onDebitFailed,
        Func<TResult> onDebitReversedReceived,
        Func<TResult> onDebited,
        Func<TResult> onDebitedReversed,
        Func<TResult> onDepositCorrectionCredited,
        Func<TResult> onDepositCorrectionDebited,
        Func<TResult> onDepositCorrectionReceived,
        Func<TResult> onFee,
        Func<TResult> onFeeReceived,
        Func<TResult> onFundTransfer,
        Func<TResult> onFundTransferReversed,
        Func<TResult> onInvoiceDeductionCredited,
        Func<TResult> onInvoiceDeductionDebited,
        Func<TResult> onInvoiceDeductionReceived,
        Func<TResult> onManualCorrected,
        Func<TResult> onManualCorrectionCredited,
        Func<TResult> onManualCorrectionDebited,
        Func<TResult> onMerchantPayin,
        Func<TResult> onMerchantPayinReceived,
        Func<TResult> onMerchantPayinReversed,
        Func<TResult> onPayout,
        Func<TResult> onPayoutReversed,
        Func<TResult> onPendingCredit,
        Func<TResult> onPendingDebit,
        Func<TResult> onPendingFundTransfer,
        Func<TResult> onReCredited,
        Func<TResult> onReCreditedReceived,
        Func<TResult> onSecondChargeback,
        Func<TResult> onSecondChargebackCorrection,
        Func<TResult> onSecondChargebackCorrectionReceived,
        Func<TResult> onSecondChargebackReceived,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BalanceNotPaidOutTransfer => onBalanceNotPaidOutTransfer(),
            _ when this == BalancePlatformFundTransfer => onBalancePlatformFundTransfer(),
            _ when this == BalancePlatformSweep => onBalancePlatformSweep(),
            _ when this == BalancePlatformSweepReturned => onBalancePlatformSweepReturned(),
            _ when this == Chargeback => onChargeback(),
            _ when this == ChargebackCorrection => onChargebackCorrection(),
            _ when this == ChargebackCorrectionReceived => onChargebackCorrectionReceived(),
            _ when this == ChargebackReceived => onChargebackReceived(),
            _ when this == ChargebackReversed => onChargebackReversed(),
            _ when this == ChargebackReversedCorrection => onChargebackReversedCorrection(),
            _ when this == ChargebackReversedCorrectionReceived => onChargebackReversedCorrectionReceived(),
            _ when this == ChargebackReversedReceived => onChargebackReversedReceived(),
            _ when this == Converted => onConverted(),
            _ when this == CreditClosed => onCreditClosed(),
            _ when this == CreditFailed => onCreditFailed(),
            _ when this == CreditReversed => onCreditReversed(),
            _ when this == CreditReversedReceived => onCreditReversedReceived(),
            _ when this == CreditSuspended => onCreditSuspended(),
            _ when this == Credited => onCredited(),
            _ when this == DebitFailed => onDebitFailed(),
            _ when this == DebitReversedReceived => onDebitReversedReceived(),
            _ when this == Debited => onDebited(),
            _ when this == DebitedReversed => onDebitedReversed(),
            _ when this == DepositCorrectionCredited => onDepositCorrectionCredited(),
            _ when this == DepositCorrectionDebited => onDepositCorrectionDebited(),
            _ when this == DepositCorrectionReceived => onDepositCorrectionReceived(),
            _ when this == Fee => onFee(),
            _ when this == FeeReceived => onFeeReceived(),
            _ when this == FundTransfer => onFundTransfer(),
            _ when this == FundTransferReversed => onFundTransferReversed(),
            _ when this == InvoiceDeductionCredited => onInvoiceDeductionCredited(),
            _ when this == InvoiceDeductionDebited => onInvoiceDeductionDebited(),
            _ when this == InvoiceDeductionReceived => onInvoiceDeductionReceived(),
            _ when this == ManualCorrected => onManualCorrected(),
            _ when this == ManualCorrectionCredited => onManualCorrectionCredited(),
            _ when this == ManualCorrectionDebited => onManualCorrectionDebited(),
            _ when this == MerchantPayin => onMerchantPayin(),
            _ when this == MerchantPayinReceived => onMerchantPayinReceived(),
            _ when this == MerchantPayinReversed => onMerchantPayinReversed(),
            _ when this == Payout => onPayout(),
            _ when this == PayoutReversed => onPayoutReversed(),
            _ when this == PendingCredit => onPendingCredit(),
            _ when this == PendingDebit => onPendingDebit(),
            _ when this == PendingFundTransfer => onPendingFundTransfer(),
            _ when this == ReCredited => onReCredited(),
            _ when this == ReCreditedReceived => onReCreditedReceived(),
            _ when this == SecondChargeback => onSecondChargeback(),
            _ when this == SecondChargebackCorrection => onSecondChargebackCorrection(),
            _ when this == SecondChargebackCorrectionReceived => onSecondChargebackCorrectionReceived(),
            _ when this == SecondChargebackReceived => onSecondChargebackReceived(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalanceNotPaidOutTransfer,
        Action onBalancePlatformFundTransfer,
        Action onBalancePlatformSweep,
        Action onBalancePlatformSweepReturned,
        Action onChargeback,
        Action onChargebackCorrection,
        Action onChargebackCorrectionReceived,
        Action onChargebackReceived,
        Action onChargebackReversed,
        Action onChargebackReversedCorrection,
        Action onChargebackReversedCorrectionReceived,
        Action onChargebackReversedReceived,
        Action onConverted,
        Action onCreditClosed,
        Action onCreditFailed,
        Action onCreditReversed,
        Action onCreditReversedReceived,
        Action onCreditSuspended,
        Action onCredited,
        Action onDebitFailed,
        Action onDebitReversedReceived,
        Action onDebited,
        Action onDebitedReversed,
        Action onDepositCorrectionCredited,
        Action onDepositCorrectionDebited,
        Action onDepositCorrectionReceived,
        Action onFee,
        Action onFeeReceived,
        Action onFundTransfer,
        Action onFundTransferReversed,
        Action onInvoiceDeductionCredited,
        Action onInvoiceDeductionDebited,
        Action onInvoiceDeductionReceived,
        Action onManualCorrected,
        Action onManualCorrectionCredited,
        Action onManualCorrectionDebited,
        Action onMerchantPayin,
        Action onMerchantPayinReceived,
        Action onMerchantPayinReversed,
        Action onPayout,
        Action onPayoutReversed,
        Action onPendingCredit,
        Action onPendingDebit,
        Action onPendingFundTransfer,
        Action onReCredited,
        Action onReCreditedReceived,
        Action onSecondChargeback,
        Action onSecondChargebackCorrection,
        Action onSecondChargebackCorrectionReceived,
        Action onSecondChargebackReceived,
        Action<string> otherwise)
    {
        if (this == BalanceNotPaidOutTransfer) onBalanceNotPaidOutTransfer();
        else if (this == BalancePlatformFundTransfer) onBalancePlatformFundTransfer();
        else if (this == BalancePlatformSweep) onBalancePlatformSweep();
        else if (this == BalancePlatformSweepReturned) onBalancePlatformSweepReturned();
        else if (this == Chargeback) onChargeback();
        else if (this == ChargebackCorrection) onChargebackCorrection();
        else if (this == ChargebackCorrectionReceived) onChargebackCorrectionReceived();
        else if (this == ChargebackReceived) onChargebackReceived();
        else if (this == ChargebackReversed) onChargebackReversed();
        else if (this == ChargebackReversedCorrection) onChargebackReversedCorrection();
        else if (this == ChargebackReversedCorrectionReceived) onChargebackReversedCorrectionReceived();
        else if (this == ChargebackReversedReceived) onChargebackReversedReceived();
        else if (this == Converted) onConverted();
        else if (this == CreditClosed) onCreditClosed();
        else if (this == CreditFailed) onCreditFailed();
        else if (this == CreditReversed) onCreditReversed();
        else if (this == CreditReversedReceived) onCreditReversedReceived();
        else if (this == CreditSuspended) onCreditSuspended();
        else if (this == Credited) onCredited();
        else if (this == DebitFailed) onDebitFailed();
        else if (this == DebitReversedReceived) onDebitReversedReceived();
        else if (this == Debited) onDebited();
        else if (this == DebitedReversed) onDebitedReversed();
        else if (this == DepositCorrectionCredited) onDepositCorrectionCredited();
        else if (this == DepositCorrectionDebited) onDepositCorrectionDebited();
        else if (this == DepositCorrectionReceived) onDepositCorrectionReceived();
        else if (this == Fee) onFee();
        else if (this == FeeReceived) onFeeReceived();
        else if (this == FundTransfer) onFundTransfer();
        else if (this == FundTransferReversed) onFundTransferReversed();
        else if (this == InvoiceDeductionCredited) onInvoiceDeductionCredited();
        else if (this == InvoiceDeductionDebited) onInvoiceDeductionDebited();
        else if (this == InvoiceDeductionReceived) onInvoiceDeductionReceived();
        else if (this == ManualCorrected) onManualCorrected();
        else if (this == ManualCorrectionCredited) onManualCorrectionCredited();
        else if (this == ManualCorrectionDebited) onManualCorrectionDebited();
        else if (this == MerchantPayin) onMerchantPayin();
        else if (this == MerchantPayinReceived) onMerchantPayinReceived();
        else if (this == MerchantPayinReversed) onMerchantPayinReversed();
        else if (this == Payout) onPayout();
        else if (this == PayoutReversed) onPayoutReversed();
        else if (this == PendingCredit) onPendingCredit();
        else if (this == PendingDebit) onPendingDebit();
        else if (this == PendingFundTransfer) onPendingFundTransfer();
        else if (this == ReCredited) onReCredited();
        else if (this == ReCreditedReceived) onReCreditedReceived();
        else if (this == SecondChargeback) onSecondChargeback();
        else if (this == SecondChargebackCorrection) onSecondChargebackCorrection();
        else if (this == SecondChargebackCorrectionReceived) onSecondChargebackCorrectionReceived();
        else if (this == SecondChargebackReceived) onSecondChargebackReceived();
        else otherwise(Value);
    }
}
