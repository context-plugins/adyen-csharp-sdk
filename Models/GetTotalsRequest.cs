using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// It conveys information from the Sale System related to the scope and the format of the totals to be computed by the POI System.
/// Content of the Get Totals Request message.
/// </summary>
public record GetTotalsRequest
{
    /// <summary>
    /// Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.
    /// Required to present totals per value of element included in this cluster (POI Terminal, Sale Terminal, Cashier, Shift, TotalsGroupID).
    /// Possible values:
    /// * <b>OperatorID</b>
    /// * <b>POIID</b>
    /// * <b>SaleID</b>
    /// * <b>ShiftNumber</b>
    /// * <b>TotalsGroupID</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalDetails")]
    public IReadOnlyList<TotalDetail>? TotalDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalFilter")]
    public TotalFilter? TotalFilter { get; init; }
}
