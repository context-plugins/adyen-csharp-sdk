using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record IdealAuthenticateRequest
{
    /// <summary>
    /// The unique identifier for an account holder.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    [StringLength(150, MinimumLength = 1)]
    public required string AccountHolderId { get; init; }

    /// <summary>
    /// A payload provided by iDEAL to complete the authentication process.
    /// </summary>
    [JsonPropertyName("payload")]
    [StringLength(400, MinimumLength = 1)]
    public required string Payload { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
