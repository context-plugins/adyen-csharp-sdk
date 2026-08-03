using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the payment instrument. For example, "BankAccount" or "Card".
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInstrumentType>))]
public sealed record PaymentInstrumentType : StringEnum<PaymentInstrumentType>
{
    private PaymentInstrumentType(string value) : base(value)
    {
    }

    public static readonly PaymentInstrumentType BankAccount = new("BankAccount");

    public static readonly PaymentInstrumentType Card = new("Card");

    public static PaymentInstrumentType FromValue(string value) => FromValueCore(value);
}
