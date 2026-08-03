using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>czLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type163>))]
public sealed record Type163 : StringEnum<Type163>
{
    private Type163(string value) : base(value)
    {
    }

    public static readonly Type163 CzLocal = new("czLocal");

    public static Type163 FromValue(string value) => FromValueCore(value);
}
