using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdateMerchantApiCredentialRequest
{
    /// <summary>
    /// Indicates if the API credential is enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The new list of <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origins</see> for the API credential.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedOrigins")]
    public IReadOnlyList<string>? AllowedOrigins { get; init; }

    /// <summary>
    /// Description of the API credential.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// List of <see href="https://docs.adyen.com/development-resources/api-credentials#roles-1">roles</see> for the API credential. Only roles assigned to 'ws@Company.&lt;CompanyName&gt;' can be assigned to other API credentials.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roles")]
    public IReadOnlyList<string>? Roles { get; init; }

    /// <summary>
    /// The subject DN of the certificate issued by Adyen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subjectDN")]
    public string? SubjectDn { get; init; }
}
