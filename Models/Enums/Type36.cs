using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>mbway</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type36>))]
public sealed record Type36 : StringEnum<Type36>
{
    private Type36(string value) : base(value)
    {
    }

    public static readonly Type36 Mbway = new("mbway");

    public static Type36 FromValue(string value) => FromValueCore(value);
}
