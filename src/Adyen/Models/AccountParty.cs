using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccountParty
{
    /// <summary>
    /// Contains the identity details of the party.
    /// </summary>
    [JsonPropertyName("identity")]
    public required Identity2 Identity { get; init; }

    /// <summary>
    /// Specifies a role or capacity of the party in relation to the bank account.
    /// </summary>
    [JsonPropertyName("role")]
    public required PartyRole2 Role { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
