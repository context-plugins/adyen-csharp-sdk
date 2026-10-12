using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RequestActivationResponse
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyId")]
    public string? CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the merchant account you requested to activate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantId")]
    public string? MerchantId { get; init; }
}
