using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SuspendAccountHolderRequest
{
    /// <summary>
    /// The code of the account holder to be suspended.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }
}
