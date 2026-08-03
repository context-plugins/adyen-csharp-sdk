using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListStoredPaymentMethodsResponse
{
    /// <summary>
    /// Your merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.
    /// &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// List of all stored payment methods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethods")]
    public IReadOnlyList<StoredPaymentMethodResource>? StoredPaymentMethods { get; init; }
}
