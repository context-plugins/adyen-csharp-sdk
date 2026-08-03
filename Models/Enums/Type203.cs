using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>iban</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type203>))]
public sealed record Type203 : StringEnum<Type203>
{
    private Type203(string value) : base(value)
    {
    }

    public static readonly Type203 Iban = new("iban");

    public static Type203 FromValue(string value) => FromValueCore(value);
}
