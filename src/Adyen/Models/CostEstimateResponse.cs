using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CostEstimateResponse
{
    /// <summary>
    /// Card BIN details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardBin")]
    public CardBin1? CardBin { get; init; }

    /// <summary>
    /// The estimated cost (scheme fee + interchange) in the settlement currency. If the settlement currency cannot be determined, the fee in EUR is returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("costEstimateAmount")]
    public Amount? CostEstimateAmount { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("costEstimateReference")]
    public string? CostEstimateReference { get; init; }

    /// <summary>
    /// The result of the cost estimation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public string? ResultCode { get; init; }
}
