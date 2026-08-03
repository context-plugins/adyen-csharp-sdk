using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Speed at which payouts for this account are processed.
/// <para>
/// Possible values: <c>STANDARD</c>, <c>SAME_DAY</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutSpeed4>))]
public sealed record PayoutSpeed4 : StringEnum<PayoutSpeed4>
{
    private PayoutSpeed4(string value) : base(value)
    {
    }

    public static readonly PayoutSpeed4 Instant = new("INSTANT");

    public static readonly PayoutSpeed4 SameDay = new("SAME_DAY");

    public static readonly PayoutSpeed4 Standard = new("STANDARD");

    public static PayoutSpeed4 FromValue(string value) => FromValueCore(value);
}
