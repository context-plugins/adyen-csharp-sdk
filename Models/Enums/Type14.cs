using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Default payment method details. Common for scheme payment methods, and for simple payment method details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type14>))]
public sealed record Type14 : StringEnum<Type14>
{
    private Type14(string value) : base(value)
    {
    }

    public static readonly Type14 Bcmc = new("bcmc");

    public static readonly Type14 Scheme = new("scheme");

    public static readonly Type14 NetworkToken = new("networkToken");

    public static readonly Type14 Giftcard = new("giftcard");

    public static readonly Type14 Card = new("card");

    public static readonly Type14 Clicktopay = new("clicktopay");

    public static Type14 FromValue(string value) => FromValueCore(value);
}
