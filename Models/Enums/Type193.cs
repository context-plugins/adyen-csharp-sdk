using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>huLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type193>))]
public sealed record Type193 : StringEnum<Type193>
{
    private Type193(string value) : base(value)
    {
    }

    public static readonly Type193 HuLocal = new("huLocal");

    public static Type193 FromValue(string value) => FromValueCore(value);
}
