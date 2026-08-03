using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListNonprofitsRequest
{
    /// <summary>
    /// The unique identifiers of the account holders to be included in a donation campaign.
    /// </summary>
    [JsonPropertyName("accountHolderIds")]
    [MinLength(1)]
    public required IReadOnlyList<string> AccountHolderIds { get; init; }
}
