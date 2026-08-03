using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetStoresUnderAccountRequest
{
    /// <summary>
    /// The company account. If you only specify this parameter, the response includes the stores of all merchant accounts that are associated with the company account.
    /// </summary>
    [JsonPropertyName("companyAccount")]
    public required string CompanyAccount { get; init; }

    /// <summary>
    /// The merchant account. With this parameter, the response only includes the stores of the specified merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }
}
