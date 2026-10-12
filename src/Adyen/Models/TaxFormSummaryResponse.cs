using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record TaxFormSummaryResponse
{
    /// <summary>
    /// A list of tax form summaries, where each summary consists of the legal entity and the tax years in which the legal entity has a tax form.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<Summary> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
