using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Speed with which payouts for this account are processed. Permitted values: <c>STANDARD</c>, <c>SAME_DAY</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutSpeed>))]
public sealed record PayoutSpeed : StringEnum<PayoutSpeed>
{
    private PayoutSpeed(string value) : base(value)
    {
    }

    public static readonly PayoutSpeed Instant = new("INSTANT");

    public static readonly PayoutSpeed SameDay = new("SAME_DAY");

    public static readonly PayoutSpeed Standard = new("STANDARD");

    public static PayoutSpeed FromValue(string value) => FromValueCore(value);
}
