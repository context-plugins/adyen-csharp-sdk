using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Connectivity
{
    /// <summary>
    /// Indicates the status of the SIM card in the payment terminal. Can be updated and received only at terminal level, and only for models that support cellular connectivity.
    /// <para>
    /// Possible values:
    /// * <b>ACTIVATED</b>: the SIM card is activated. Cellular connectivity may still need to be enabled on the terminal itself, in the <b>Network</b> settings.
    /// * <b>INVENTORY</b>: the SIM card is not activated. The terminal can't use cellular connectivity.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("simcardStatus")]
    public SimcardStatus? SimcardStatus { get; init; }

    /// <summary>
    /// The list of local and public URLs to send notifications to when using local integrations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalIPAddressURL")]
    public EventUrl3? TerminalIpAddressUrl { get; init; }
}
