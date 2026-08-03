using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RefundNotPaidOutTransfersRequest
{
    /// <summary>
    /// The code of the account from which to perform the refund(s).
    /// </summary>
    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; init; }

    /// <summary>
    /// The code of the Account Holder which owns the account from which to perform the refund(s).
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }
}
