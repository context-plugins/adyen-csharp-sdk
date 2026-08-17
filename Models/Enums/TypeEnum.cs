using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ach</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Ach = new("ach");

    public static readonly TypeEnum AchPlaid = new("ach_plaid");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
