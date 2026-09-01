using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record IssuingTransactionData
{
    /// <summary>
    /// captureCycleId associated with transfer event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureCycleId")]
    public string? CaptureCycleId { get; init; }

    /// <summary>
    /// The type of events data.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>issuingTransactionData</b>: issuing transaction data</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "issuingTransactionData";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
