using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record StoredValueAccountStatus
{
    /// <summary>
    /// Identification of the stored value account or the stored value card and the associated product sold by the Sale System for stored value requests.
    /// </summary>
    [JsonPropertyName("StoredValueAccountID")]
    public required StoredValueAccountId StoredValueAccountId { get; init; }

    /// <summary>
    /// If relevant and known.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CurrentBalance")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? CurrentBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
