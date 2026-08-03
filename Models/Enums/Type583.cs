using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>threeDS2</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type583>))]
public sealed record Type583 : StringEnum<Type583>
{
    private Type583(string value) : base(value)
    {
    }

    public static readonly Type583 ThreeDs2 = new("threeDS2");

    public static Type583 FromValue(string value) => FromValueCore(value);
}
