using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record AccountHolderResourceProperties
{
    /// <summary>
    /// The unique identifier of the resource connected to the component. For <see href="https://docs.adyen.com/platforms/build-user-dashboards">Platform Experience components</see>, this is the account holder linked to the balance account shown in the component.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    [MinLength(1)]
    public required string AccountHolderId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
