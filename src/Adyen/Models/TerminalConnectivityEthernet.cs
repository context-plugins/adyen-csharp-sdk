using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalConnectivityEthernet
{
    /// <summary>
    /// The terminal's ethernet IP address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The ethernet link negotiation that the terminal uses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("linkNegotiation")]
    public string? LinkNegotiation { get; init; }

    /// <summary>
    /// The terminal's ethernet MAC address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; init; }
}
