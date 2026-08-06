using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LegalEntityResourceProperties
{
    /// <summary>
    /// The unique identifier of the resource connected to the component.
    /// For <see href="https://docs.adyen.com/platforms/onboard-users/components">Onboarding components</see>, this is the legal entity that has a contractual relationship with your platform and owns the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments">transfer instrument</see>. For sole proprietorships, this is the legal entity of the individual owner.
    /// </summary>
    [JsonPropertyName("legalEntityId")]
    [MinLength(1)]
    public required string LegalEntityId { get; init; }
}
