using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record TotalFilter
{
    /// <summary>
    /// Identification of a POI System or a POI Terminal for the Sale to POI protocol.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIID")]
    [RegularExpression("^.+$")]
    public string? Poiid { get; init; }

    /// <summary>
    /// Identification of a Sale System or a Sale Terminal for the Sale to POI protocol.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleID")]
    [RegularExpression("^.+$")]
    public string? SaleId { get; init; }

    /// <summary>
    /// Identification of the Cashier or Operator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OperatorID")]
    [RegularExpression("^.+$")]
    public string? OperatorId { get; init; }

    /// <summary>
    /// Shift number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ShiftNumber")]
    [RegularExpression("^.+$")]
    public string? ShiftNumber { get; init; }

    /// <summary>
    /// Sent if totals in the response have to be computed only for this particular value of TotalsGroupID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalsGroupID")]
    [RegularExpression("^.{1,16}$")]
    public string? TotalsGroupId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
