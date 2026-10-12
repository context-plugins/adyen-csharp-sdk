using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;
using Adyen.Models.OneOf;

namespace Adyen.Models;

public record TransferRoute
{
    /// <summary>
    /// The type of transfer.
    /// <para>
    ///  Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>bank</b>: Transfer to a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see> or a bank account.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public Category2? Category { get; init; }

    /// <summary>
    /// The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, <b>US</b> or <b>NL</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The three-character ISO currency code of transfer. For example, <b>USD</b> or <b>EUR</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// The priority for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. Possible values:
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
    [JsonPropertyName("priority")]
    public Priority2? Priority { get; init; }

    /// <summary>
    /// A set of rules defined by clearing houses and banking partners. Your transfer request must adhere to these rules to ensure successful initiation of transfer. Based on the priority, one or more requirements may be returned. Each requirement is defined with a <c>type</c> and <c>description</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requirements")]
    public IReadOnlyList<Requirement>? Requirements { get; init; }
}
