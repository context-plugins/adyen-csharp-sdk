using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CloseAccountRequest
{
    /// <summary>
    /// The code of account to be closed.
    /// </summary>
    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; init; }
}
