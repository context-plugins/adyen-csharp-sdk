using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentInstrumentUpdateRequest
{
    /// <summary>
    /// The unique identifier of the balance account associated with this payment instrument.
    /// &gt;You can only change the balance account ID if the payment instrument has <b>inactive</b> status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balanceAccountId")]
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// Object that contains information about the card payment instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public CardInfo2? Card { get; init; }

    /// <summary>
    /// The status of the payment instrument. If a status is not specified when creating a payment instrument, it is set to <b>active</b> by default. However, there can be exceptions for cards based on the <c>card.formFactor</c> and the <c>issuingCountryCode</c>. For example, when issuing physical cards in the US, the default status is <b>inactive</b>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>active</b>:  The payment instrument is active and can be used to make payments.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>inactive</b>: The payment instrument is inactive and cannot be used to make payments.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>suspended</b>: The payment instrument is suspended, either because it was stolen or lost.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>closed</b>: The payment instrument is permanently closed. This action cannot be undone.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status10? Status { get; init; }

    /// <summary>
    /// Comment for the status of the payment instrument.
    /// <para>
    /// Required if <c>statusReason</c> is <b>other</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusComment")]
    public string? StatusComment { get; init; }

    /// <summary>
    /// The reason for updating the status of the payment instrument.
    /// <para>
    /// Possible values: <b>lost</b>, <b>stolen</b>, <b>damaged</b>, <b>suspectedFraud</b>, <b>expired</b>, <b>endOfLife</b>, <b>accountClosure</b>, <b>other</b>.
    /// If the reason is <b>other</b>, you must also send the <c>statusComment</c> parameter describing the status change.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusReason")]
    public StatusReason2? StatusReason { get; init; }
}
