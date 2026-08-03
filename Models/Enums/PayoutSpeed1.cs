using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Speed at which payouts for this account are processed.
/// <para>
/// Possible values: <c>STANDARD</c> (default), <c>SAME_DAY</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutSpeed1>))]
public sealed record PayoutSpeed1 : StringEnum<PayoutSpeed1>
{
    private PayoutSpeed1(string value) : base(value)
    {
    }

    public static readonly PayoutSpeed1 Instant = new("INSTANT");

    public static readonly PayoutSpeed1 SameDay = new("SAME_DAY");

    public static readonly PayoutSpeed1 Standard = new("STANDARD");

    public static PayoutSpeed1 FromValue(string value) => FromValueCore(value);
}
