using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransferRouteRequest
{
    /// <summary>
    /// The unique identifier of the source <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id">balance account</see>.
    /// Required if <c>counterparty</c> is <b>transferInstrumentId</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// The unique identifier assigned to the balance platform associated with the account holder.
    /// </summary>
    [JsonPropertyName("balancePlatform")]
    public required string BalancePlatform { get; init; }

    /// <summary>
    /// The type of transfer. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>bank</b>: Transfer to a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see> or a bank account.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; } = "bank";

    /// <summary>
    /// The recipient of the funds transfer. A bank account or a transfer instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public Counterparty1? Counterparty { get; init; }

    /// <summary>
    /// The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, <b>US</b> or <b>NL</b>.
    ///  &gt; Either <c>counterparty</c> or <c>country</c> field must be provided in a transfer route request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The three-character ISO currency code of transfer. For example, <b>USD</b> or <b>EUR</b>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The list of priorities for the bank transfer. Priorities set the speed at which the transfer is sent and the fees that you have to pay. Multiple values can be provided.
    /// Possible values:
    /// <list type="bullet">
    ///   <item><description><b>regular</b>: For normal, low-value transactions.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>fast</b>: A faster way to transfer funds, but the fees are higher. Recommended for high-priority, low-value transactions.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>wire</b>: The fastest way to transfer funds, but this has the highest fees. Recommended for high-priority, high-value transactions.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>instant</b>: For instant funds transfers within the United States and in <see href="https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html">SEPA locations</see>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>crossBorder</b>: For high-value transfers to a recipient in a different country.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>internal</b>: For transfers to an Adyen-issued business bank account (by bank account number/IBAN).</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priorities")]
    public IReadOnlyList<Priority1>? Priorities { get; init; }
}
