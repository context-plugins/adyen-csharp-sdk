using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ancv</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type51>))]
public sealed record Type51 : StringEnum<Type51>
{
    private Type51(string value) : base(value)
    {
    }

    public static readonly Type51 Ancv = new("ancv");

    public static Type51 FromValue(string value) => FromValueCore(value);
}
