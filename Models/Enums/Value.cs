using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value>))]
public sealed record Value : StringEnum<Value>
{
    private Value(string value) : base(value)
    {
    }

    public static readonly Value BalanceAccount = new("balanceAccount");

    public static readonly Value BankAccount = new("bankAccount");

    public static readonly Value Card = new("card");

    public static readonly Value TransferInstrument = new("transferInstrument");

    public static Value FromValue(string value) => FromValueCore(value);
}
