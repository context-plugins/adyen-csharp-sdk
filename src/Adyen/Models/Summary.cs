using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Summary
{
    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    [JsonPropertyName("legalEntityId")]
    public required string LegalEntityId { get; init; }

    /// <summary>
    /// The tax years for which the legal entity has a tax form.
    /// </summary>
    [JsonPropertyName("taxYears")]
    public required IReadOnlyList<int> TaxYears { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
