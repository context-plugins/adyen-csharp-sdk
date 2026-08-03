using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>visacheckout</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type55>))]
public sealed record Type55 : StringEnum<Type55>
{
    private Type55(string value) : base(value)
    {
    }

    public static readonly Type55 Visacheckout = new("visacheckout");

    public static Type55 FromValue(string value) => FromValueCore(value);
}
