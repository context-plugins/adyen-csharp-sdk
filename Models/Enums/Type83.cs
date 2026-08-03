using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer or transaction. For example, <b>refund</b>, <b>payment</b>, <b>internalTransfer</b>, <b>bankTransfer</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type83>))]
public sealed record Type83 : StringEnum<Type83>
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

    public static Type83 FromValue(string value) => FromValueCore(value);
}
