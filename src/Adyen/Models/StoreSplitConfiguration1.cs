using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Rules for Adyen for Platforms merchants to split the transaction amount and fees.
/// </summary>
public record StoreSplitConfiguration1
{
    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id">unique identifier of the balance account</see> to which the split amount must be booked, depending on the defined <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/splitConfigurations#request-rules-splitLogic">split logic</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/platforms/automatic-split-configuration/create-split-configuration/">split configuration profile</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitConfigurationId")]
    public string? SplitConfigurationId { get; init; }
}
