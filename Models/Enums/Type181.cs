using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Default payment method details. Common for scheme payment methods, and for simple payment method details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type181>))]
public sealed record Type181 : StringEnum<Type181>
{
    private Type181(string value) : base(value)
    {
    }

    public static readonly Type181 Scheme = new("scheme");

    public static Type181 FromValue(string value) => FromValueCore(value);
}
