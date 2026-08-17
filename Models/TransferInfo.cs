using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransferInfo
{
    /// <summary>
    /// The amount of the transfer.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// The unique identifier of the source <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id">balance account</see>.
    /// <para>
    /// If you want to make a transfer using a <b>virtual</b> <b>bankAccount</b> assigned to the balance account, you must specify the <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/paymentInstruments#responses-200-id">payment instrument ID</see> of the <b>virtual</b> <b>bankAccount</b>. If you only specify a balance account ID, Adyen uses the default <b>physical</b> <b>bankAccount</b> payment instrument assigned to the balance account.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// The category of the transfer.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>bank</b>: A transfer involving a <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see> or a bank account.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>card</b>: A transfer involving a third-party card.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>internal</b>: A transfer between <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id">balance accounts</see> within your platform.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>issuedCard</b>: A transfer initiated by an Adyen-issued card.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>platformPayment</b>: Funds movements related to payments that are acquired for your users.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>topUp</b>: An incoming transfer initiated by your user to top up their balance account.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("category")]
    public required Category3 Category { get; init; }

    /// <summary>
    /// The other party involved in the funds transfer. A bank account, a balance account, a card, or a transfer instrument is required.
    /// </summary>
    [JsonPropertyName("counterparty")]
    public required CounterpartyInfoV31 Counterparty { get; init; }

    /// <summary>
    /// Your description for the transfer. It is used by most banks as the transfer description. We recommend sending a maximum of 140 characters, otherwise the description may be truncated.
    /// <para>
    /// Supported characters: <b>[a-z] [A-Z] [0-9] / - ?</b> <b>: ( ) . , ' + Space</b>
    /// </para>
    /// <para>
    /// Supported characters for <b>regular</b> and <b>fast</b> transfers to a US counterparty: <b>[a-z] [A-Z] [0-9] &amp; $ % # @</b> <b>~ = + - _ ' " ! ?</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(140)]
    public string? Description { get; init; }

    /// <summary>
    /// The date when the transfer will be processed. This date must be within 30 days of the current date.
    /// <para>
    /// Until the <c>executionDate</c>:
    /// - The <c>status</c> of the transfer remains as <b>received</b>.
    /// - The <c>reason</c> of the transfer remains as <b>pending</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("executionDate")]
    public ExecutionDate3? ExecutionDate { get; init; }

    /// <summary>
    /// The unique identifier of the source <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/paymentInstruments#responses-200-id">payment instrument</see>.
    /// <para>
    /// If you want to make a transfer using a <b>virtual</b> <b>bankAccount</b>, you must specify the payment instrument ID of the <b>virtual</b> <b>bankAccount</b>. If you only specify a balance account ID, Adyen uses the default <b>physical</b> <b>bankAccount</b> payment instrument assigned to the balance account.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrumentId")]
    public string? PaymentInstrumentId { get; init; }

    /// <summary>
    /// The list of priorities for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. You can provide multiple priorities. Adyen will try to pay out using the priority you list first. If that's not possible, it moves on to the next option in the order of your provided priorities.
    /// <para>
    /// Possible values:
    /// </para>
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
    /// <para>
    /// Required for transfers with <c>category</c> <b>bank</b>. For more details, see <see href="https://docs.adyen.com/payouts/payout-service/payout-to-users/#fallback-priorities">fallback priorities</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priorities")]
    public IReadOnlyList<Priority1>? Priorities { get; init; }

    /// <summary>
    /// The priority for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. Required for transfers with <c>category</c> <b>bank</b>.
    /// <para>
    /// Possible values:
    /// </para>
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
    public Priority1? Priority { get; init; }

    /// <summary>
    /// Your reference for the transfer, used internally within your platform. If you don't provide this in the request, Adyen generates a unique reference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(80)]
    public string? Reference { get; init; }

    /// <summary>
    /// A reference that is sent to the recipient. This reference is also sent in all webhooks related to the transfer, so you can use it to track statuses for both parties involved in the funds movement.
    /// <para>
    ///  Supported characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>. The maximum length depends on the <c>category</c>.
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>internal</b>: 80 characters</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>bank</b>: 35 characters when transferring to an IBAN, 15 characters for others.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceForBeneficiary")]
    public string? ReferenceForBeneficiary { get; init; }

    /// <summary>
    /// Contains information required for triggering transfer reviews.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review")]
    public TransferRequestReview2? Review { get; init; }

    /// <summary>
    /// The type of transfer.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>bankTransfer</b>: for push transfers to a transfer instrument or a bank account. The <c>category</c> must be <b>bank</b>.</description></item>
    ///   <item><description><b>internalTransfer</b>: for push transfers between balance accounts. The <c>category</c> must be <b>internal</b>.</description></item>
    ///   <item><description><b>internalDirectDebit</b>: for pull transfers (direct debits) between balance accounts. The <c>category</c> must be <b>internal</b>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type113? Type { get; init; }

    /// <summary>
    /// The ultimate sender of the funds of the transfer (ultimate debtor).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultimateParty")]
    public UltimatePartyIdentification1? UltimateParty { get; init; }
}
