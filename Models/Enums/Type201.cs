using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the webhook you are configuring. Set to <b>balance</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type201>))]
public sealed record Type201 : StringEnum<Type201>
{
    private Type201(string value) : base(value)
    {
    }

    public static readonly Type201 Balance = new("balance");

    public static Type201 FromValue(string value) => FromValueCore(value);
}
