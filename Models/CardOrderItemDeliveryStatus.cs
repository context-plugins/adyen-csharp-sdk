using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CardOrderItemDeliveryStatus
{
    /// <summary>
    /// An error message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status7? Status { get; init; }

    /// <summary>
    /// The tracking number of the PIN delivery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trackingNumber")]
    public string? TrackingNumber { get; init; }
}
