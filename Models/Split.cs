using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Split
{
    /// <summary>
    /// The unique identifier of the account to which the split amount is booked. Required if <c>type</c> is <b>MarketPlace</b> or <b>BalanceAccount</b>.
    /// <list type="bullet">
    ///   <item><description><see href="https://docs.adyen.com/classic-platforms">Classic Platforms integration</see>: The <see href="https://docs.adyen.com/api-explorer/Account/latest/post/updateAccount#request-accountCode"><c>accountCode</c></see> of the account to which the split amount is booked.</description></item>
    ///   <item><description><see href="https://docs.adyen.com/adyen-for-platforms-model">Balance Platform</see>: The <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/get/balanceAccounts/_id_#path-id"><c>balanceAccountId</c></see> of the account to which the split amount is booked.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public string? Account { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount31? Amount { get; init; }

    /// <summary>
    /// Your description for the split item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Your unique reference for the part of the payment booked to the specified <c>account</c>.
    /// <para>
    /// This is required if <c>type</c> is <b>MarketPlace</b> (<see href="https://docs.adyen.com/classic-platforms">Classic Platforms integration</see>) or <b>BalanceAccount</b> (<see href="https://docs.adyen.com/adyen-for-platforms-model">Balance Platform</see>).
    /// </para>
    /// <para>
    /// For the other types, we also recommend providing a <b>unique</b> reference so you can reconcile the split and the associated payment in the transaction overview and in the reports.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    [JsonPropertyName("type")]
    public required Type111 Type { get; init; }
}
