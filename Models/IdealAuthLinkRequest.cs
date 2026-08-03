using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IdealAuthLinkRequest
{
    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    [StringLength(150, MinimumLength = 1)]
    public required string AccountHolderId { get; init; }
}
