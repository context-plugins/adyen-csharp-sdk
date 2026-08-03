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
public sealed record LimitStatus : StringEnum<LimitStatus>
{
    private LimitStatus(string value) : base(value)
    {
    }

    public static readonly LimitStatus Active = new("active");

    public static readonly LimitStatus Inactive = new("inactive");

    public static readonly LimitStatus PendingSca = new("pendingSCA");

    public static readonly LimitStatus Scheduled = new("scheduled");

    public static LimitStatus FromValue(string value) => FromValueCore(value);
}
