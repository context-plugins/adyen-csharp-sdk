using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LogoutRequest3
{
    /// <summary>
    /// Indicates that the POI terminal is able to or has to go to maintenance. Sent in the Logout Request to express that after closing the session, the POI may go to maintenance.
    /// </summary>
    [JsonPropertyName("MaintenanceAllowed")]
    public bool? MaintenanceAllowed { get; init; } = false;
}
