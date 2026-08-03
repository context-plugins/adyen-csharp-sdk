using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CompanyBalances
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantBalancesOverview")]
    public IReadOnlyList<MerchantBalance>? MerchantBalancesOverview { get; init; }
}
