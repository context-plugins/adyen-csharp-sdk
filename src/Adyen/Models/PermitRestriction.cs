using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PermitRestriction
{
    /// <summary>
    /// The total sum amount of one or more payments made using this permit may not exceed this amount if set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAmount")]
    public Amount? MaxAmount { get; init; }

    /// <summary>
    /// The amount of any single payment using this permit may not exceed this amount if set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("singleTransactionLimit")]
    public Amount? SingleTransactionLimit { get; init; }

    /// <summary>
    /// Only a single payment can be made using this permit if set to true, otherwise multiple payments are allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("singleUse")]
    public bool? SingleUse { get; init; }
}
