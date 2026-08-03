using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TerminalConnectivityCellular
{
    /// <summary>
    /// The integrated circuit card identifier (ICCID) of the primary SIM card in the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iccid")]
    public string? Iccid { get; init; }

    /// <summary>
    /// The integrated circuit card identifier (ICCID) of the secondary SIM card in the terminal, typically used for a <see href="https://docs.adyen.com/point-of-sale/design-your-integration/network-and-connectivity/cellular-failover/#using-a-third-party-sim-card">third-party SIM card</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iccid2")]
    public string? Iccid2 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status32? Status { get; init; }
}
