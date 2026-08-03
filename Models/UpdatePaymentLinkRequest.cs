using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdatePaymentLinkRequest
{
    /// <summary>
    /// Status of the payment link. Possible values:
    /// * <b>expired</b>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status28 Status { get; init; }
}
