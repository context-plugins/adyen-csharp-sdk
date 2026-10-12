using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeleteShareholderRequest
{
    /// <summary>
    /// The code of the Account Holder from which to delete the Shareholders.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The code(s) of the Shareholders to be deleted.
    /// </summary>
    [JsonPropertyName("shareholderCodes")]
    public required IReadOnlyList<string> ShareholderCodes { get; init; }
}
