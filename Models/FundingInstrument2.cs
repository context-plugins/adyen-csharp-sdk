using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Details of the card or token used to fund the pay-in transaction.
/// </summary>
public record FundingInstrument2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardIdentification")]
    public CardIdentification? CardIdentification { get; init; }

    /// <summary>
    /// The unique reference assigned by the card network for the pay-in transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkPaymentReference")]
    public string? NetworkPaymentReference { get; init; }

    /// <summary>
    /// Your internal reference that identifies this funding instrument. Required if <c>sourceOfFunds</c> is <b>DEPOSIT_ACCOUNT</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceOfFunds")]
    public SourceOfFunds2? SourceOfFunds { get; init; }
}
