using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>klarna_network</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type69>))]
public sealed record Type69 : StringEnum<Type69>
{
    private Type69(string value) : base(value)
    {
    }

    public static readonly Type69 KlarnaNetwork = new("klarna_network");

    public static Type69 FromValue(string value) => FromValueCore(value);
}
