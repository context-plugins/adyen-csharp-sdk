using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ReleaseUpdateDetails
{
    /// <summary>
    /// Type of terminal action: Update Release.
    /// </summary>
    [JsonPropertyName("type")]
    public Type61? Type { get; init; } = Type61.ReleaseUpdate;

    /// <summary>
    /// Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updateAtFirstMaintenanceCall")]
    public bool? UpdateAtFirstMaintenanceCall { get; init; }
}
