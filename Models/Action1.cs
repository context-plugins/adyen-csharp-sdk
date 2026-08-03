using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Action1
{
    /// <summary>
    /// The code identifying the action that needs to be completed.
    /// </summary>
    [JsonPropertyName("actionCode")]
    public required string ActionCode { get; init; }

    /// <summary>
    /// Indicates whether this action has been successfully completed.
    /// </summary>
    [JsonPropertyName("resolved")]
    public required bool Resolved { get; init; }
}
