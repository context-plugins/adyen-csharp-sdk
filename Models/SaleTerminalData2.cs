using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Information related to the software and hardware feature of the Sale Terminal.
/// Present if the login involve a Sale Terminal.
/// </summary>
public record SaleTerminalData2
{
    /// <summary>
    /// Identification of a group of transactions on a POI Terminal, having the same Sale features.
    /// Could be used to group POI for reconciliation or other purpose defined by the Sale System. The default value is assigned by the Login Request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalsGroupID")]
    [RegularExpression("^.{1,16}$")]
    public string? TotalsGroupId { get; init; }
}
