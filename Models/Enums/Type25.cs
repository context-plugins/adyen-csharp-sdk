using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ideal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type25>))]
public sealed record Type25 : StringEnum<Type25>
{
    private Type25(string value) : base(value)
    {
    }

    public static readonly Type25 Ideal = new("ideal");

    public static Type25 FromValue(string value) => FromValueCore(value);
}
