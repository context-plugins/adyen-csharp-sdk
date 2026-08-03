using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the length of time that the payment account was enrolled in the cardholder’s account with the 3DS Requestor.
/// Allowed values:
/// * <b>01</b> — No account (guest checkout)
/// * <b>02</b> — During this transaction
/// * <b>03</b> — Less than 30 days
/// * <b>04</b> — 30–60 days
/// * <b>05</b> — More than 60 days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentAccInd>))]
public sealed record PaymentAccInd : StringEnum<PaymentAccInd>
{
    private PaymentAccInd(string value) : base(value)
    {
    }

    public static readonly PaymentAccInd _01 = new("01");

    public static readonly PaymentAccInd _02 = new("02");

    public static readonly PaymentAccInd _03 = new("03");

    public static readonly PaymentAccInd _04 = new("04");

    public static readonly PaymentAccInd _05 = new("05");

    public static PaymentAccInd FromValue(string value) => FromValueCore(value);
}
