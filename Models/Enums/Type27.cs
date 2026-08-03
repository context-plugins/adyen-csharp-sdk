using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>sepadirectdebit</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type27>))]
public sealed record Type27 : StringEnum<Type27>
{
    private Type27(string value) : base(value)
    {
    }

    public static readonly Type27 Sepadirectdebit = new("sepadirectdebit");

    public static Type27 FromValue(string value) => FromValueCore(value);
}
