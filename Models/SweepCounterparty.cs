using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SweepCounterparty
{
    /// <summary>
    /// The unique identifier of the destination or source <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id">balance account</see>.
    /// <para>
    ///  &gt; If you are updating the counterparty from a transfer instrument to a balance account, set <c>transferInstrumentId</c> to <b>null</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// The merchant account that will be the source of funds.
    /// <para>
    /// You can only use this parameter with sweeps of <c>type</c> <b>pull</b> and if you are processing payments with Adyen.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// The unique identifier of the destination or source <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see> depending on the sweep <c>type</c>
    /// <para>
    /// . To set up automated top-up sweeps to balance accounts in your <see href="https://docs.adyen.com/marketplaces/top-up-balance-account/#before-you-begin">marketplace</see> or <see href="https://docs.adyen.com/platforms/top-up-balance-account/#before-you-begin">platform</see>, use this parameter in combination with a <c>merchantAccount</c> and a sweep <c>type</c> of <b>pull</b>.
    /// </para>
    /// <para>
    /// Top-up sweeps start a direct debit request from the source transfer instrument. Contact Adyen Support to enable this feature.&gt; If you are updating the counterparty from a balance account to a transfer instrument, set <c>balanceAccountId</c> to <b>null</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }
}
