using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the check.
/// <para>
/// Possible values: <b>AWAITING_DATA</b> , <b>DATA_PROVIDED</b>, <b>FAILED</b>, <b>INVALID_DATA</b>, <b>PASSED</b>, <b>PENDING</b>, <b>RETRY_LIMIT_REACHED</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status3>))]
public sealed record Status3 : StringEnum<Status3>
{
    private Status3(string value) : base(value)
    {
    }

    public static readonly Status3 AwaitingData = new("AWAITING_DATA");

    public static readonly Status3 DataProvided = new("DATA_PROVIDED");

    public static readonly Status3 Failed = new("FAILED");

    public static readonly Status3 InvalidData = new("INVALID_DATA");

    public static readonly Status3 Passed = new("PASSED");

    public static readonly Status3 Pending = new("PENDING");

    public static readonly Status3 PendingReview = new("PENDING_REVIEW");

    public static readonly Status3 RetryLimitReached = new("RETRY_LIMIT_REACHED");

    public static readonly Status3 Unchecked = new("UNCHECKED");

    public static Status3 FromValue(string value) => FromValueCore(value);
}
