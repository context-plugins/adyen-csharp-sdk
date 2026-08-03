using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value5>))]
public sealed record Value5 : StringEnum<Value5>
{
    private Value5(string value) : base(value)
    {
    }

    public static readonly Value5 BalanceAccount = new("balanceAccount");

    public static readonly Value5 BusinessAccount = new("businessAccount");

    public static Value5 FromValue(string value) => FromValueCore(value);
}
