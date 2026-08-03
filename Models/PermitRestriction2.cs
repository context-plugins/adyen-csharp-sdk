using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Permit level restriction overrides.
/// </summary>
public record PermitRestriction2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAmount")]
    public MaxAmount3? MaxAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("singleTransactionLimit")]
    public SingleTransactionLimit? SingleTransactionLimit { get; init; }

    /// <summary>
    /// Only a single payment can be made using this permit if set to true, otherwise multiple payments are allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("singleUse")]
    public bool? SingleUse { get; init; }
}
