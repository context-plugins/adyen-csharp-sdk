using System;
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
public sealed record PayoutSpeed4 : OpenStringEnum<PayoutSpeed4>
{
    private PayoutSpeed4(string value) : base(value)
    {
    }

    public static readonly PayoutSpeed4 Instant = new("INSTANT");

    public static readonly PayoutSpeed4 SameDay = new("SAME_DAY");

    public static readonly PayoutSpeed4 Standard = new("STANDARD");

    public TResult Match<TResult>(Func<TResult> onInstant,
        Func<TResult> onSameDay,
        Func<TResult> onStandard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Instant => onInstant(),
            _ when this == SameDay => onSameDay(),
            _ when this == Standard => onStandard(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstant, Action onSameDay, Action onStandard, Action<string> otherwise)
    {
        if (this == Instant) onInstant();
        else if (this == SameDay) onSameDay();
        else if (this == Standard) onStandard();
        else otherwise(Value);
    }
}
