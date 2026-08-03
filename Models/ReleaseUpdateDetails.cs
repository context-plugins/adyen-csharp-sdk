using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ReleaseUpdateDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type62? Type { get; init; }

    /// <summary>
    /// Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updateAtFirstMaintenanceCall")]
    public bool? UpdateAtFirstMaintenanceCall { get; init; }
}
