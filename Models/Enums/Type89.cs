using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>usAch</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type89>))]
public sealed record Type89 : StringEnum<Type89>
{
    private Type89(string value) : base(value)
    {
    }

    public static readonly Type89 UsAch = new("usAch");

    public static Type89 FromValue(string value) => FromValueCore(value);
}
