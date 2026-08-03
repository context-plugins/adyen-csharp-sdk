using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalConnectivityWifi
{
    /// <summary>
    /// The terminal's IP address in the Wi-Fi network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The terminal's MAC address in the Wi-Fi network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; init; }

    /// <summary>
    /// The SSID of the Wi-Fi network that the terminal is connected to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssid")]
    public string? Ssid { get; init; }
}
