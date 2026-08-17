using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record KlarnaResponseInfo
{
    /// <summary>
    /// Indicates the status of <see href="https://docs.adyen.com/online-payments/capture#automatic-capture">Automatic capture</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoCapture")]
    public bool? AutoCapture { get; init; }

    /// <summary>
    /// The email address for disputes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disputeEmail")]
    public string? DisputeEmail { get; init; }

    /// <summary>
    /// The region of operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("region")]
    public Region1? Region { get; init; }

    /// <summary>
    /// The email address of merchant support.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; init; }
}
