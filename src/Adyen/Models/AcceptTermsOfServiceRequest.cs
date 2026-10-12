using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AcceptTermsOfServiceRequest
{
    /// <summary>
    /// The legal entity ID of the user accepting the Terms of Service.
    /// <para>
    /// For organizations, this must be the individual legal entity ID of an authorized signatory for the organization.
    /// </para>
    /// <para>
    /// For sole proprietorships, this must be the individual legal entity ID of the owner.
    /// </para>
    /// <para>
    /// For individuals, this must be the individual legal entity id of either the individual, parent, or guardian.
    /// </para>
    /// </summary>
    [JsonPropertyName("acceptedBy")]
    public required string AcceptedBy { get; init; }

    /// <summary>
    /// The IP address of the user accepting the Terms of Service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }
}
