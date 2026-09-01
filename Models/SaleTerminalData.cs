using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Information related to the software and hardware features of the Sale Terminal.
/// Sent in the Login Request if a Sale Terminal is involved in the login. In other messages, sent when a logical device is out of order (SaleCapabilities) or when other data have changed or were missing in the Login.
/// </summary>
public record SaleTerminalData
{
    /// <summary>
    /// Identification of a group of transactions on a POI Terminal, having the same Sale features.
    /// Could be used to group POI for reconciliation or other purpose defined by the Sale System. The default value is assigned by the Login Request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalsGroupID")]
    [RegularExpression("^.{1,16}$")]
    public string? TotalsGroupId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
