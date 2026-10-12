using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreatePermitResult
{
    /// <summary>
    /// List of new permits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("permitResultList")]
    public IReadOnlyList<PermitResult>? PermitResultList { get; init; }

    /// <summary>
    /// A unique reference associated with the request. This value is globally unique; quote it when communicating with us about this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }
}
