using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BalanceTransferRequest
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }

    /// <summary>
    /// The unique identifier of the source merchant account from which funds are deducted.
    /// </summary>
    [JsonPropertyName("fromMerchant")]
    [MinLength(1)]
    public required string FromMerchant { get; init; }

    /// <summary>
    /// A reference for the balance transfer. Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [StringLength(80, MinimumLength = 0)]
    public string? Reference { get; init; }

    /// <summary>
    /// The unique identifier of the destination merchant account to which funds are transferred.
    /// </summary>
    [JsonPropertyName("toMerchant")]
    [MinLength(1)]
    public required string ToMerchant { get; init; }

    [JsonPropertyName("type")]
    public required BalanceTransferType2 Type { get; init; }
}
