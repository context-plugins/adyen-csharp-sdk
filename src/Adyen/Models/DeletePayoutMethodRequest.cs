using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeletePayoutMethodRequest
{
    /// <summary>
    /// The code of the account holder, from which to delete the payout methods.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The codes of the payout methods to be deleted.
    /// </summary>
    [JsonPropertyName("payoutMethodCodes")]
    public required IReadOnlyList<string> PayoutMethodCodes { get; init; }
}
