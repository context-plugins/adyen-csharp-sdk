using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The status of the card delivery.
/// <para>
/// Possible values: <b>created</b>, <b>rejected</b>, <b>processing</b>, <b>produced</b>, <b>shipped</b>, <b>delivered</b>, <b>notApplicable</b>, <b>unknown</b>.
/// </para>
/// </summary>
public record CardOrderItemDeliveryStatus3
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
