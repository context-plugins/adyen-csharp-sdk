using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of payment transaction. Elements requested by the Sale System that are related to the payment only.
/// Possible values:
/// * <b>CashAdvance</b>
/// * <b>CashDeposit</b>
/// * <b>Completion</b>
/// * <b>FirstReservation</b>
/// * <b>Instalment</b>
/// * <b>IssuerInstalment</b>
/// * <b>Normal</b>
/// * <b>OneTimeReservation</b>
/// * <b>PaidOut</b>
/// * <b>Recurring</b>
/// * <b>Refund</b>
/// * <b>UpdateReservation</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentType1>))]
public sealed record PaymentType1 : StringEnum<PaymentType1>
{
    private PaymentType1(string value) : base(value)
    {
    }

    public static readonly PaymentType1 Normal = new("Normal");

    public static readonly PaymentType1 Refund = new("Refund");

    public static readonly PaymentType1 OneTimeReservation = new("OneTimeReservation");

    public static readonly PaymentType1 FirstReservation = new("FirstReservation");

    public static readonly PaymentType1 UpdateReservation = new("UpdateReservation");

    public static readonly PaymentType1 Completion = new("Completion");

    public static readonly PaymentType1 CashAdvance = new("CashAdvance");

    public static readonly PaymentType1 CashDeposit = new("CashDeposit");

    public static readonly PaymentType1 Recurring = new("Recurring");

    public static readonly PaymentType1 Instalment = new("Instalment");

    public static readonly PaymentType1 IssuerInstalment = new("IssuerInstalment");

    public static readonly PaymentType1 PaidOut = new("PaidOut");

    public static PaymentType1 FromValue(string value) => FromValueCore(value);
}
