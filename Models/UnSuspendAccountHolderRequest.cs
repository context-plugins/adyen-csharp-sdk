using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UnSuspendAccountHolderRequest
{
    /// <summary>
    /// The code of the account holder to be reinstated.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }
}
