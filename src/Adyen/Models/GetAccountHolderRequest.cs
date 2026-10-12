using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetAccountHolderRequest
{
    /// <summary>
    /// The code of the account of which to retrieve the details.
    /// &gt; Required if no <c>accountHolderCode</c> is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; init; }

    /// <summary>
    /// The code of the account holder of which to retrieve the details.
    /// &gt; Required if no <c>accountCode</c> is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderCode")]
    public string? AccountHolderCode { get; init; }

    /// <summary>
    /// True if the request should return the account holder details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showDetails")]
    public bool? ShowDetails { get; init; }
}
