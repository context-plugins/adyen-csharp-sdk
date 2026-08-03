using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Empty.
/// Content of the Logout Request message.
/// </summary>
public record LogoutRequest
{
    /// <summary>
    /// Indicates that the POI terminal is able to or has to go to maintenance. Sent in the Logout Request to express that after closing the session, the POI may go to maintenance.
    /// </summary>
    [JsonPropertyName("MaintenanceAllowed")]
    public bool? MaintenanceAllowed { get; init; } = false;
}
