using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ModificationResult
{
    /// <summary>
    /// This field contains additional data, which may be returned in a particular modification response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    [JsonPropertyName("response")]
    public required ResponseModel Response { get; init; }
}
