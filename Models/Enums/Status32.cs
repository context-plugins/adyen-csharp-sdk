using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the check.
/// <para>
/// Possible values: <b>AWAITING_DATA</b> , <b>DATA_PROVIDED</b>, <b>FAILED</b>, <b>INVALID_DATA</b>, <b>PASSED</b>, <b>PENDING</b>, <b>RETRY_LIMIT_REACHED</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status32>))]
public sealed record Status32 : StringEnum<Status32>
{
    private Status32(string value) : base(value)
    {
    }

    public static readonly Status32 AwaitingData = new("AWAITING_DATA");

    public static readonly Status32 DataProvided = new("DATA_PROVIDED");

    public static readonly Status32 Failed = new("FAILED");

    public static readonly Status32 InvalidData = new("INVALID_DATA");

    public static readonly Status32 Passed = new("PASSED");

    public static readonly Status32 Pending = new("PENDING");

    public static readonly Status32 PendingReview = new("PENDING_REVIEW");

    public static readonly Status32 RetryLimitReached = new("RETRY_LIMIT_REACHED");

    public static readonly Status32 Unchecked = new("UNCHECKED");

    public static Status32 FromValue(string value) => FromValueCore(value);
}
