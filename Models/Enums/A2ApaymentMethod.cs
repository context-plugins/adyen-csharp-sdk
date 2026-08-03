using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ideal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<A2ApaymentMethod>))]
public sealed record A2ApaymentMethod : StringEnum<A2ApaymentMethod>
{
    private A2ApaymentMethod(string value) : base(value)
    {
    }

    public static readonly A2ApaymentMethod Ideal = new("ideal");

    public static A2ApaymentMethod FromValue(string value) => FromValueCore(value);
}
