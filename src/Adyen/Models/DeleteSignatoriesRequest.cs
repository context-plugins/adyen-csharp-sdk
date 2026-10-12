using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeleteSignatoriesRequest
{
    /// <summary>
    /// The code of the account holder from which to delete the signatories.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// Array of codes of the signatories to be deleted.
    /// </summary>
    [JsonPropertyName("signatoryCodes")]
    public required IReadOnlyList<string> SignatoryCodes { get; init; }
}
