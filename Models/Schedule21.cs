using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains the details about the schedule that determines when the top up is executed.
/// </summary>
public record Schedule21
{
    /// <summary>
    /// The type of schedule at which the top up is executed.
    /// * <b>weekdays</b>: pull in funds Monday-Friday at 07:00 AM in the local timezone of the balance account.
    /// <list type="bullet">
    ///   <item><description><b>weekly</b>: pull in funds every Monday at 07:00 AM in the local timezone of the balance account.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>monthly</b>: pull in funds every first of the month at 07:00 AM in the local timezone of the balance account.</description></item>
    ///   <item><description><b>null</b> (default): continuous monitoring.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public required ScheduleType1 Type { get; init; }
}
