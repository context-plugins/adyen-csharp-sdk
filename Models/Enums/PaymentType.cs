using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Normal</b>
/// * <b>Refund</b>
/// * <b>OneTimeReservation</b>
/// * <b>FirstReservation</b>
/// * <b>UpdateReservation</b>
/// * <b>Completion</b>
/// * <b>CashAdvance</b>
/// * <b>CashDeposit</b>
/// * <b>Recurring</b>
/// * <b>Instalment</b>
/// * <b>IssuerInstalment</b>
/// * <b>PaidOut</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentType>))]
public sealed record PaymentType : StringEnum<PaymentType>
{
    private PaymentType(string value) : base(value)
    {
    }

    public static readonly PaymentType Normal = new("Normal");

    public static readonly PaymentType Refund = new("Refund");

    public static readonly PaymentType OneTimeReservation = new("OneTimeReservation");

    public static readonly PaymentType FirstReservation = new("FirstReservation");

    public static readonly PaymentType UpdateReservation = new("UpdateReservation");

    public static readonly PaymentType Completion = new("Completion");

    public static readonly PaymentType CashAdvance = new("CashAdvance");

    public static readonly PaymentType CashDeposit = new("CashDeposit");

    public static readonly PaymentType Recurring = new("Recurring");

    public static readonly PaymentType Instalment = new("Instalment");

    public static readonly PaymentType IssuerInstalment = new("IssuerInstalment");

    public static readonly PaymentType PaidOut = new("PaidOut");

    public static PaymentType FromValue(string value) => FromValueCore(value);
}
