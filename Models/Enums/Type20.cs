using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the webhook you are configuring. Set to <b>balance</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type20>))]
public sealed record Type20 : StringEnum<Type20>
{
    private Type20(string value) : base(value)
    {
    }

    public static readonly Type20 Balance = new("balance");

    public static Type20 FromValue(string value) => FromValueCore(value);
}
