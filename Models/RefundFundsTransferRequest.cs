using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RefundFundsTransferRequest
{
    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    /// <summary>
    /// A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// A PSP reference of the original fund transfer.
    /// </summary>
    [JsonPropertyName("originalReference")]
    public required string OriginalReference { get; init; }
}
