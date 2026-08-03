using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdatePayoutScheduleRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public ActionModel? Action { get; init; }

    /// <summary>
    /// The reason for the payout schedule update.
    /// &gt; This field is required when the <c>schedule</c> parameter is set to <c>HOLD</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    [JsonPropertyName("schedule")]
    public required Schedule1 Schedule { get; init; }
}
