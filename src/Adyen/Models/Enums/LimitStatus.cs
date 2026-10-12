using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transfer limit. Possible values:
/// * <b>active</b>: the limit is currently active.
/// * <b>inactive</b>: the limit is currently inactive.
/// * <b>pendingSCA</b>: the limit is pending until your user performs SCA.
/// * <b>scheduled</b>: the limit is scheduled to become active at a future date.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LimitStatus>))]
public sealed record LimitStatus : OpenStringEnum<LimitStatus>
{
    private LimitStatus(string value) : base(value)
    {
    }

    public static readonly LimitStatus Active = new("active");

    public static readonly LimitStatus Inactive = new("inactive");

    public static readonly LimitStatus PendingSca = new("pendingSCA");

    public static readonly LimitStatus Scheduled = new("scheduled");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onInactive,
        Func<TResult> onPendingSca,
        Func<TResult> onScheduled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Inactive => onInactive(),
            _ when this == PendingSca => onPendingSca(),
            _ when this == Scheduled => onScheduled(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive,
        Action onInactive,
        Action onPendingSca,
        Action onScheduled,
        Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Inactive) onInactive();
        else if (this == PendingSca) onPendingSca();
        else if (this == Scheduled) onScheduled();
        else otherwise(Value);
    }
}
