using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BalanceWebhookSettingProperties
{
    /// <summary>
    /// The list of settings and criteria for triggering the <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhook</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conditions")]
    public IReadOnlyList<Condition>? Conditions { get; init; }
}
