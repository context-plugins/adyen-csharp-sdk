using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record MandatePartyIdentification
{
    /// <summary>
    /// The full name of the entity that owns the bank account.
    /// <para>
    /// Supported characters: [a-z] [A-Z] [0-9] , . ; : - — / \ + &amp; ! ? @ ( ) " ' and space.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullName")]
    public string? FullName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
