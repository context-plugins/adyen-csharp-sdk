using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Default payment method details. Common for scheme payment methods, and for simple payment method details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type141>))]
public sealed record Type141 : StringEnum<Type141>
{
    private Type141(string value) : base(value)
    {
    }

    public static readonly Type141 Bcmc = new("bcmc");

    public static readonly Type141 Scheme = new("scheme");

    public static readonly Type141 NetworkToken = new("networkToken");

    public static readonly Type141 Giftcard = new("giftcard");

    public static readonly Type141 Card = new("card");

    public static readonly Type141 Clicktopay = new("clicktopay");

    public static Type141 FromValue(string value) => FromValueCore(value);
}
