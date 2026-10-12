using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer or transaction. For example, <b>refund</b>, <b>payment</b>, <b>internalTransfer</b>, <b>bankTransfer</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type83>))]
public sealed record Type83 : OpenStringEnum<Type83>
{
    private Type83(string value) : base(value)
    {
    }

    public static readonly Type83 Payment = new("payment");

    public static readonly Type83 Capture = new("capture");

    public static readonly Type83 CaptureReversal = new("captureReversal");

    public static readonly Type83 Refund = new("refund");

    public static readonly Type83 RefundReversal = new("refundReversal");

    public static readonly Type83 Chargeback = new("chargeback");

    public static readonly Type83 ChargebackCorrection = new("chargebackCorrection");

    public static readonly Type83 ChargebackReversal = new("chargebackReversal");

    public static readonly Type83 ChargebackReversalCorrection = new("chargebackReversalCorrection");

    public static readonly Type83 SecondChargeback = new("secondChargeback");

    public static readonly Type83 SecondChargebackCorrection = new("secondChargebackCorrection");

    public static readonly Type83 AtmWithdrawal = new("atmWithdrawal");

    public static readonly Type83 AtmWithdrawalReversal = new("atmWithdrawalReversal");

    public static readonly Type83 InternalTransfer = new("internalTransfer");

    public static readonly Type83 InternalDirectDebit = new("internalDirectDebit");

    public static readonly Type83 ManualCorrection = new("manualCorrection");

    public static readonly Type83 InvoiceDeduction = new("invoiceDeduction");

    public static readonly Type83 DepositCorrection = new("depositCorrection");

    public static readonly Type83 ReserveAdjustment = new("reserveAdjustment");

    public static readonly Type83 BankTransfer = new("bankTransfer");

    public static readonly Type83 BankDirectDebit = new("bankDirectDebit");

    public static readonly Type83 CardTransfer = new("cardTransfer");

    public static readonly Type83 MiscCost = new("miscCost");

    public static readonly Type83 PaymentCost = new("paymentCost");

    public static readonly Type83 Fee = new("fee");

    public static readonly Type83 Leftover = new("leftover");

    public static readonly Type83 Grant = new("grant");

    public static readonly Type83 CapitalFundsCollection = new("capitalFundsCollection");

    public static readonly Type83 CashOutInstruction = new("cashOutInstruction");

    public static readonly Type83 CashoutFee = new("cashoutFee");

    public static readonly Type83 CashoutRepayment = new("cashoutRepayment");

    public static readonly Type83 CashoutFunding = new("cashoutFunding");

    public static readonly Type83 Repayment = new("repayment");

    public static readonly Type83 Installment = new("installment");

    public static readonly Type83 InstallmentReversal = new("installmentReversal");

    public static readonly Type83 BalanceAdjustment = new("balanceAdjustment");

    public static readonly Type83 BalanceRollover = new("balanceRollover");

    public static readonly Type83 BalanceMigration = new("balanceMigration");

    public TResult Match<TResult>(Func<TResult> onPayment,
        Func<TResult> onCapture,
        Func<TResult> onCaptureReversal,
        Func<TResult> onRefund,
        Func<TResult> onRefundReversal,
        Func<TResult> onChargeback,
        Func<TResult> onChargebackCorrection,
        Func<TResult> onChargebackReversal,
        Func<TResult> onChargebackReversalCorrection,
        Func<TResult> onSecondChargeback,
        Func<TResult> onSecondChargebackCorrection,
        Func<TResult> onAtmWithdrawal,
        Func<TResult> onAtmWithdrawalReversal,
        Func<TResult> onInternalTransfer,
        Func<TResult> onInternalDirectDebit,
        Func<TResult> onManualCorrection,
        Func<TResult> onInvoiceDeduction,
        Func<TResult> onDepositCorrection,
        Func<TResult> onReserveAdjustment,
        Func<TResult> onBankTransfer,
        Func<TResult> onBankDirectDebit,
        Func<TResult> onCardTransfer,
        Func<TResult> onMiscCost,
        Func<TResult> onPaymentCost,
        Func<TResult> onFee,
        Func<TResult> onLeftover,
        Func<TResult> onGrant,
        Func<TResult> onCapitalFundsCollection,
        Func<TResult> onCashOutInstruction,
        Func<TResult> onCashoutFee,
        Func<TResult> onCashoutRepayment,
        Func<TResult> onCashoutFunding,
        Func<TResult> onRepayment,
        Func<TResult> onInstallment,
        Func<TResult> onInstallmentReversal,
        Func<TResult> onBalanceAdjustment,
        Func<TResult> onBalanceRollover,
        Func<TResult> onBalanceMigration,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Payment => onPayment(),
            _ when this == Capture => onCapture(),
            _ when this == CaptureReversal => onCaptureReversal(),
            _ when this == Refund => onRefund(),
            _ when this == RefundReversal => onRefundReversal(),
            _ when this == Chargeback => onChargeback(),
            _ when this == ChargebackCorrection => onChargebackCorrection(),
            _ when this == ChargebackReversal => onChargebackReversal(),
            _ when this == ChargebackReversalCorrection => onChargebackReversalCorrection(),
            _ when this == SecondChargeback => onSecondChargeback(),
            _ when this == SecondChargebackCorrection => onSecondChargebackCorrection(),
            _ when this == AtmWithdrawal => onAtmWithdrawal(),
            _ when this == AtmWithdrawalReversal => onAtmWithdrawalReversal(),
            _ when this == InternalTransfer => onInternalTransfer(),
            _ when this == InternalDirectDebit => onInternalDirectDebit(),
            _ when this == ManualCorrection => onManualCorrection(),
            _ when this == InvoiceDeduction => onInvoiceDeduction(),
            _ when this == DepositCorrection => onDepositCorrection(),
            _ when this == ReserveAdjustment => onReserveAdjustment(),
            _ when this == BankTransfer => onBankTransfer(),
            _ when this == BankDirectDebit => onBankDirectDebit(),
            _ when this == CardTransfer => onCardTransfer(),
            _ when this == MiscCost => onMiscCost(),
            _ when this == PaymentCost => onPaymentCost(),
            _ when this == Fee => onFee(),
            _ when this == Leftover => onLeftover(),
            _ when this == Grant => onGrant(),
            _ when this == CapitalFundsCollection => onCapitalFundsCollection(),
            _ when this == CashOutInstruction => onCashOutInstruction(),
            _ when this == CashoutFee => onCashoutFee(),
            _ when this == CashoutRepayment => onCashoutRepayment(),
            _ when this == CashoutFunding => onCashoutFunding(),
            _ when this == Repayment => onRepayment(),
            _ when this == Installment => onInstallment(),
            _ when this == InstallmentReversal => onInstallmentReversal(),
            _ when this == BalanceAdjustment => onBalanceAdjustment(),
            _ when this == BalanceRollover => onBalanceRollover(),
            _ when this == BalanceMigration => onBalanceMigration(),
            _ => otherwise(Value)
        };

    public void Match(Action onPayment,
        Action onCapture,
        Action onCaptureReversal,
        Action onRefund,
        Action onRefundReversal,
        Action onChargeback,
        Action onChargebackCorrection,
        Action onChargebackReversal,
        Action onChargebackReversalCorrection,
        Action onSecondChargeback,
        Action onSecondChargebackCorrection,
        Action onAtmWithdrawal,
        Action onAtmWithdrawalReversal,
        Action onInternalTransfer,
        Action onInternalDirectDebit,
        Action onManualCorrection,
        Action onInvoiceDeduction,
        Action onDepositCorrection,
        Action onReserveAdjustment,
        Action onBankTransfer,
        Action onBankDirectDebit,
        Action onCardTransfer,
        Action onMiscCost,
        Action onPaymentCost,
        Action onFee,
        Action onLeftover,
        Action onGrant,
        Action onCapitalFundsCollection,
        Action onCashOutInstruction,
        Action onCashoutFee,
        Action onCashoutRepayment,
        Action onCashoutFunding,
        Action onRepayment,
        Action onInstallment,
        Action onInstallmentReversal,
        Action onBalanceAdjustment,
        Action onBalanceRollover,
        Action onBalanceMigration,
        Action<string> otherwise)
    {
        if (this == Payment) onPayment();
        else if (this == Capture) onCapture();
        else if (this == CaptureReversal) onCaptureReversal();
        else if (this == Refund) onRefund();
        else if (this == RefundReversal) onRefundReversal();
        else if (this == Chargeback) onChargeback();
        else if (this == ChargebackCorrection) onChargebackCorrection();
        else if (this == ChargebackReversal) onChargebackReversal();
        else if (this == ChargebackReversalCorrection) onChargebackReversalCorrection();
        else if (this == SecondChargeback) onSecondChargeback();
        else if (this == SecondChargebackCorrection) onSecondChargebackCorrection();
        else if (this == AtmWithdrawal) onAtmWithdrawal();
        else if (this == AtmWithdrawalReversal) onAtmWithdrawalReversal();
        else if (this == InternalTransfer) onInternalTransfer();
        else if (this == InternalDirectDebit) onInternalDirectDebit();
        else if (this == ManualCorrection) onManualCorrection();
        else if (this == InvoiceDeduction) onInvoiceDeduction();
        else if (this == DepositCorrection) onDepositCorrection();
        else if (this == ReserveAdjustment) onReserveAdjustment();
        else if (this == BankTransfer) onBankTransfer();
        else if (this == BankDirectDebit) onBankDirectDebit();
        else if (this == CardTransfer) onCardTransfer();
        else if (this == MiscCost) onMiscCost();
        else if (this == PaymentCost) onPaymentCost();
        else if (this == Fee) onFee();
        else if (this == Leftover) onLeftover();
        else if (this == Grant) onGrant();
        else if (this == CapitalFundsCollection) onCapitalFundsCollection();
        else if (this == CashOutInstruction) onCashOutInstruction();
        else if (this == CashoutFee) onCashoutFee();
        else if (this == CashoutRepayment) onCashoutRepayment();
        else if (this == CashoutFunding) onCashoutFunding();
        else if (this == Repayment) onRepayment();
        else if (this == Installment) onInstallment();
        else if (this == InstallmentReversal) onInstallmentReversal();
        else if (this == BalanceAdjustment) onBalanceAdjustment();
        else if (this == BalanceRollover) onBalanceRollover();
        else if (this == BalanceMigration) onBalanceMigration();
        else otherwise(Value);
    }
}
