using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record StoredValueAccountStatus
{
    [JsonPropertyName("StoredValueAccountID")]
    public required StoredValueAccountId2 StoredValueAccountId { get; init; }

    /// <summary>
    /// If relevant and known.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CurrentBalance")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? CurrentBalance { get; init; }
}
