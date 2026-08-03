using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>hkLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1810>))]
public sealed record Type1810 : StringEnum<Type1810>
{
    private Type1810(string value) : base(value)
    {
    }

    public static readonly Type1810 HkLocal = new("hkLocal");

    public static Type1810 FromValue(string value) => FromValueCore(value);
}
