using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record InterchangeData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchangeAmount")]
    public InterchangeAmount? InterchangeAmount { get; init; }

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
    public required Type85 Type { get; init; }
}
