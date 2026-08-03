using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ach</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : StringEnum<Type9>
{
    private Type9(string value) : base(value)
    {
    }

    public static readonly Type9 Ach = new("ach");

    public static readonly Type9 AchPlaid = new("ach_plaid");

    public static Type9 FromValue(string value) => FromValueCore(value);
}
