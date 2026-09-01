using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record InterchangeData
{
    /// <summary>
    /// The currency and value of the adjusted interchange fee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchangeAmount")]
    public Amount17? InterchangeAmount { get; init; }

    /// <summary>
    /// A 3-character alphanumeric code assigned by Visa that identifies the specific interchange reimbursement program a transaction qualified for. The code is assigned based on the card type, entry mode, and security data provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchangeRateIndicator")]
    public string? InterchangeRateIndicator { get; init; }

    /// <summary>
    /// The type of events data.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>interchangeData</b>: information about the interchange fee applied to a transaction.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "interchangeData";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
