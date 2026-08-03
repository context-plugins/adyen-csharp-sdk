using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccountParty
{
    [JsonPropertyName("identity")]
    public required Identity Identity { get; init; }

    [JsonPropertyName("role")]
    public required PartyRole2 Role { get; init; }
}
