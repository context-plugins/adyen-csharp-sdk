using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content of the Get Totals Request message.
/// </summary>
public record GetTotalsRequest2
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

    /// <summary>
    /// Filter to compute the totals.
    /// Used for the Get Totals, to request totals for a (or a combination of) particular value of the POI Terminal, Sale Terminal, Cashier, Shift, or TotalsGroupID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalFilter")]
    public TotalFilter2? TotalFilter { get; init; }
}
