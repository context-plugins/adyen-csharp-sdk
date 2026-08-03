using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CompanyApiCredential
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public ApiCredentialLinks? Links { get; init; }

    /// <summary>
    /// Indicates if the API credential is enabled. Must be set to <b>true</b> to use the credential in your integration.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// List of IP addresses from which your client can make requests.
    /// <para>
    /// If the list is empty, we allow requests from any IP.
    /// If the list is not empty and we get a request from an IP which is not on the list, you get a security error.
    /// </para>
    /// </summary>
    [JsonPropertyName("allowedIpAddresses")]
    public required IReadOnlyList<string> AllowedIpAddresses { get; init; }

    /// <summary>
    /// List containing the <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origins</see> linked to the API credential.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedOrigins")]
    public IReadOnlyList<AllowedOrigin>? AllowedOrigins { get; init; }

    /// <summary>
    /// List of merchant accounts that the API credential has explicit access to.
    ///  If the credential has access to a company, this implies access to all merchant accounts and no merchants for that company will be included.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("associatedMerchantAccounts")]
    public IReadOnlyList<string>? AssociatedMerchantAccounts { get; init; }

    /// <summary>
    /// Public key used for <see href="https://docs.adyen.com/development-resources/client-side-authentication">client-side authentication</see>. The client key is required for Drop-in and Components integrations.
    /// </summary>
    [JsonPropertyName("clientKey")]
    public required string ClientKey { get; init; }

    /// <summary>
    /// Description of the API credential.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(50)]
    public string? Description { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// List of <see href="https://docs.adyen.com/development-resources/api-credentials#roles-1">roles</see> for the API credential.
    /// </summary>
    [JsonPropertyName("roles")]
    public required IReadOnlyList<string> Roles { get; init; }

    /// <summary>
    /// The subject DN of the certificate issued by Adyen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subjectDN")]
    public string? SubjectDn { get; init; }

    /// <summary>
    /// The name of the <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see>, for example <b>ws@Company.TestCompany</b>.
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; init; }
}
