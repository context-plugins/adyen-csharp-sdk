using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalDataCard
{
    /// <summary>
    /// This is an ALT ID (alternate ID) mapped to the Card PAN.
    /// <para>
    /// &gt; Returned only in case of Ecommerce Card Payment in India
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardAltID")]
    public string? CardAltId { get; init; }

    /// <summary>
    /// The first six digits of the card number.
    /// <para>
    /// This is the <see href="https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin">Bank Identification Number (BIN)</see> for card numbers with a six-digit BIN.
    /// </para>
    /// <para>
    /// Example: 521234
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardBin")]
    public string? CardBin { get; init; }

    /// <summary>
    /// The cardholder name passed in the payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardHolderName")]
    public string? CardHolderName { get; init; }

    /// <summary>
    /// The bank or the financial institution granting lines of credit through card association branded payment cards. This information can be included when available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardIssuingBank")]
    public string? CardIssuingBank { get; init; }

    /// <summary>
    /// The country where the card was issued.
    /// <para>
    /// Example: US
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardIssuingCountry")]
    public string? CardIssuingCountry { get; init; }

    /// <summary>
    /// The currency in which the card is issued, if this information is available. Provided as the currency code or currency number from the ISO-4217 standard.
    /// <para>
    /// Example: USD
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardIssuingCurrency")]
    public string? CardIssuingCurrency { get; init; }

    /// <summary>
    /// The card payment method used for the transaction.
    /// <para>
    /// Example: amex
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardPaymentMethod")]
    public string? CardPaymentMethod { get; init; }

    /// <summary>
    /// The Card Product ID represents the type of card following card scheme product definitions and can be returned for Adyen Acquiring service level payments.
    /// <para>
    /// Example values Visa:
    /// * <b>A</b> - Visa Traditional
    /// * <b>B</b> - Visa Traditional Rewards
    /// * <b>C</b> - Visa Signature
    /// * <b>D</b> - Visa Signature Preferred
    /// * <b>F</b> - Visa Classic
    /// </para>
    /// <para>
    /// Example values Mastercard:
    /// * <b>MCC</b> - Mastercard Card
    /// * <b>MCE</b> - Mastercard Electronic Card
    /// * <b>MCF</b> - Mastercard Corporate Fleet Card
    /// * <b>MCG</b> - Gold Mastercard Card
    /// * <b>MCH</b> - Mastercard Premium Charge
    /// * <b>MCI</b> - Mastercard Select Debit
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardProductId")]
    public string? CardProductId { get; init; }

    /// <summary>
    /// The last four digits of a card number.
    /// <para>
    /// &gt; Returned only in case of a card payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardSummary")]
    public string? CardSummary { get; init; }

    /// <summary>
    /// The first eight digits of the card number. Only returned if the card number is 16 digits or more.
    /// <para>
    /// This is the <see href="https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin">Bank Identification Number (BIN)</see> for card numbers with an eight-digit BIN.
    /// </para>
    /// <para>
    /// Example: 52123423
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerBin")]
    public string? IssuerBin { get; init; }
}
