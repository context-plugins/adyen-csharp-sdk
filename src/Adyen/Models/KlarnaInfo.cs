using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record KlarnaInfo
{
    /// <summary>
    /// Indicates the status of <see href="https://docs.adyen.com/online-payments/capture#automatic-capture">Automatic capture</see>. Default value: <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoCapture")]
    public bool? AutoCapture { get; init; }

    /// <summary>
    /// The email address for disputes.
    /// </summary>
    [JsonPropertyName("disputeEmail")]
    public required string DisputeEmail { get; init; }

    /// <summary>
    /// The region of operation. For example, <b>NA</b>, <b>EU</b>, <b>CH</b>, <b>AU</b>.
    /// </summary>
    [JsonPropertyName("region")]
    public required Region Region { get; init; }

    /// <summary>
    /// The email address of merchant support.
    /// </summary>
    [JsonPropertyName("supportEmail")]
    public required string SupportEmail { get; init; }
}
