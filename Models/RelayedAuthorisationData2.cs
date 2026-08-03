using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// If you are using relayed authorisation, this object contains information from the relayed authorisation response from your server.
/// </summary>
public record RelayedAuthorisationData2
{
    /// <summary>
    /// Contains key-value pairs of your references and descriptions, for example, <c>customId</c>:<c>your-own-custom-field-12345</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// Your reference for the relayed authorisation data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }
}
