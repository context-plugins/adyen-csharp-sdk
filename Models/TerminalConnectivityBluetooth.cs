using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalConnectivityBluetooth
{
    /// <summary>
    /// The terminal's Bluetooth IP address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The terminal's Bluetooth MAC address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; init; }
}
