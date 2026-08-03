using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CostEstimateResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardBin")]
    public CardBin? CardBin { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("costEstimateAmount")]
    public CostEstimateAmount? CostEstimateAmount { get; init; }

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
