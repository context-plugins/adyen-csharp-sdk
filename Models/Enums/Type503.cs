using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the action.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type503>))]
public sealed record Type503 : StringEnum<Type503>
{
    private Type503(string value) : base(value)
    {
    }

    public static readonly Type503 BankTransfer = new("bankTransfer");

    public static Type503 FromValue(string value) => FromValueCore(value);
}
