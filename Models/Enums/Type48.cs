using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ratepay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type48>))]
public sealed record Type48 : StringEnum<Type48>
{
    private Type48(string value) : base(value)
    {
    }

    public static readonly Type48 Ratepay = new("ratepay");

    public static readonly Type48 RatepayDirectdebit = new("ratepay_directdebit");

    public static Type48 FromValue(string value) => FromValueCore(value);
}
