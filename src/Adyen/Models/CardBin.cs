using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardBin
{
    /// <summary>
    /// The first 6 digit of the card number. Enable this field via merchant account settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bin")]
    public string? Bin { get; init; }

    /// <summary>
    /// If true, it indicates a commercial card. Enable this field via merchant account settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commercial")]
    public bool? Commercial { get; init; }

    /// <summary>
    /// The card funding source. Valid values are:
    /// * CHARGE
    /// * CREDIT
    /// * DEBIT
    /// * DEFERRED_DEBIT
    /// * PREPAID
    /// * PREPAID_RELOADABLE
    /// * PREPAID_NONRELOADABLE
    /// &gt; Enable this field via merchant account settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    public string? FundingSource { get; init; }

    /// <summary>
    /// Indicates availability of funds.
    /// <para>
    /// Visa:
    /// * "I" (fast funds are supported)
    /// * "N" (otherwise)
    /// </para>
    /// <para>
    /// Mastercard:
    /// * "I" (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list)
    /// * "N" (otherwise)
    /// &gt; Returned when you verify a card BIN or estimate costs, and only if <c>payoutEligible</c> is different from "N" or "U".
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundsAvailability")]
    public string? FundsAvailability { get; init; }

    /// <summary>
    /// The first 8 digit of the card number. Enable this field via merchant account settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerBin")]
    public string? IssuerBin { get; init; }

    /// <summary>
    /// The issuing bank of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuingBank")]
    public string? IssuingBank { get; init; }

    /// <summary>
    /// The country where the card was issued from.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuingCountry")]
    public string? IssuingCountry { get; init; }

    /// <summary>
    /// The currency of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuingCurrency")]
    public string? IssuingCurrency { get; init; }

    /// <summary>
    /// The payment method associated with the card (e.g. visa, mc, or amex).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public string? PaymentMethod { get; init; }

    /// <summary>
    /// Indicates whether a payout is eligible or not for this card.
    /// <para>
    /// Visa:
    /// * "Y"
    /// * "N"
    /// </para>
    /// <para>
    /// Mastercard:
    /// * "Y" (domestic and cross-border)
    /// * "D" (only domestic)
    /// * "N" (no MoneySend)
    /// * "U" (unknown)
    /// &gt; Returned when you verify a card BIN or estimate costs, and only if <c>payoutEligible</c> is different from "N" or "U".
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutEligible")]
    public string? PayoutEligible { get; init; }

    /// <summary>
    /// The last four digits of the card number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary")]
    public string? Summary { get; init; }
}
