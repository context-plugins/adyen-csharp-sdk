using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// <b>klarna</b> or its variant details
/// </summary>
public record KlarnaResponseInfo1
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
