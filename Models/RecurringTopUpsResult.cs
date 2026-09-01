using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record RecurringTopUpsResult
{
    [JsonPropertyName("link")]
    public required Link Link { get; init; }

    [JsonPropertyName("recurringTopUps")]
    public required IReadOnlyList<RecurringTopUp> RecurringTopUps { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
