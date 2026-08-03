using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>platformPayment</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type63>))]
public sealed record Type63 : StringEnum<Type63>
{
    private Type63(string value) : base(value)
    {
    }

    public static readonly Type63 PlatformPayment = new("platformPayment");

    public static Type63 FromValue(string value) => FromValueCore(value);
}
