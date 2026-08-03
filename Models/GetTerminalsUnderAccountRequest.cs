using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetTerminalsUnderAccountRequest
{
    /// <summary>
    /// Your company account. If you only specify this parameter, the response includes all terminals at all account levels.
    /// </summary>
    [JsonPropertyName("companyAccount")]
    public required string CompanyAccount { get; init; }

    /// <summary>
    /// The merchant account. This is required if you are retrieving the terminals assigned to a store.If you don't specify a <c>store</c> the response includes the terminals assigned to the specified merchant account and the terminals assigned to the stores under this merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// The store code of the store. With this parameter, the response only includes the terminals assigned to the specified store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }
}
