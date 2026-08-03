using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DeviceStatusResponse
{
    /// <summary>
    /// The unique identification of the device.
    /// This can be a payment terminal ID in the format _[terminal model]-[serial number]_ (for example, P400‑123456789), or an SDK installation ID as used in Mobile solutions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public DeviceStatus1? Status { get; init; }
}
