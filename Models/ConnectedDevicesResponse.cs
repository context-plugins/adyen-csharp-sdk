using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ConnectedDevicesResponse
{
    /// <summary>
    /// A list of the unique IDs of the devices that have an active cloud connection.
    /// The IDs are payment terminal IDs in the format _[terminal model]-[serial number]_ (for example, P400‑123456789), or SDK installation IDs as used in Mobile solutions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uniqueDeviceIds")]
    public IReadOnlyList<string>? UniqueDeviceIds { get; init; }
}
