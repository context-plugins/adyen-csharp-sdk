using System;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record BalanceTransferResponse
{
    /// <summary>
    /// The date when the balance transfer was performed.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Adyen's 16-character string reference associated with the balance transfer.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
