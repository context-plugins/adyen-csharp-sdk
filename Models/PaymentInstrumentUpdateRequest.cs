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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public CardInfo? Card { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusReason")]
    public StatusReason2? StatusReason { get; init; }
}
