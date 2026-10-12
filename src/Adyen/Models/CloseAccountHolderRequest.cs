using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CloseAccountHolderRequest
{
    /// <summary>
    /// The code of the Account Holder to be closed.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }
}
