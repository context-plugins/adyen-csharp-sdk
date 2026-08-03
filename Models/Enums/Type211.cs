using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the delivery method.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type211>))]
public sealed record Type211 : StringEnum<Type211>
{
    private Type211(string value) : base(value)
    {
    }

    public static readonly Type211 Shipping = new("Shipping");

    public static Type211 FromValue(string value) => FromValueCore(value);
}
