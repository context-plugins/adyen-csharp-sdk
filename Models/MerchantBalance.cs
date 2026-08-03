using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MerchantBalance
{
    /// <summary>
    /// The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("availableFund")]
    public Amount3? AvailableFund { get; init; }

    /// <summary>
    /// The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deposit")]
    public Amount3? Deposit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nextPayout")]
    public Amount3? NextPayout { get; init; }

    /// <summary>
    /// The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pendingBalance")]
    public Amount3? PendingBalance { get; init; }

    /// <summary>
    /// The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reserve")]
    public Amount3? Reserve { get; init; }
}
