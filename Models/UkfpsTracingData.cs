using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UkfpsTracingData
{
    /// <summary>
    /// The FPS trace number. This is a unique identifier assigned to transfers processed by <see href="https://www.bankofengland.co.uk/payment-systems/services/faster-payments-service">FPS</see>.
    /// </summary>
    [JsonPropertyName("fpid")]
    public required string Fpid { get; init; }

    /// <summary>
    /// <b>ukFps</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type88 Type { get; init; }
}
