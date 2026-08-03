using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type44>))]
public sealed record Type44 : StringEnum<Type44>
{
    private Type44(string value) : base(value)
    {
    }

    public static readonly Type44 Pix = new("pix");

    public static Type44 FromValue(string value) => FromValueCore(value);
}
