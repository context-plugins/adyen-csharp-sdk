using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PerformVerificationRequest
{
    /// <summary>
    /// The code of the account holder to verify.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The state required for the account holder.
    /// &gt; Permitted values: <c>Processing</c>, <c>Payout</c>.
    /// </summary>
    [JsonPropertyName("accountStateType")]
    public required AccountStateType AccountStateType { get; init; }

    /// <summary>
    /// The tier required for the account holder.
    /// </summary>
    [JsonPropertyName("tier")]
    public required int Tier { get; init; }
}
