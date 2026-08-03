using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Credit card data.
/// <para>
/// Optional if <c>shopperReference</c> and <c>selectedRecurringDetailReference</c> are provided.
/// </para>
/// </summary>
public record Card2
{
    /// <summary>
    /// The <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid">card verification code</see> (1-20 characters). Depending on the card brand, it is known also as:
    /// * CVV2/CVC2 – length: 3 digits
    /// * CID – length: 4 digits
    /// &gt; If you are using <see href="https://docs.adyen.com/classic-integration/cse-integration-ecommerce">Client-Side Encryption</see>, the CVC code is present in the encrypted data. You must never post the card details to the server.
    /// &gt; This field must be always present in a <see href="https://docs.adyen.com/classic-integration/recurring-payments">one-click payment request</see>.
    /// &gt; When this value is returned in a response, it is always empty because it is not stored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvc")]
    [StringLength(20, MinimumLength = 1)]
    public string? Cvc { get; init; }

    /// <summary>
    /// The card expiry month.
    /// Format: 2 digits, zero-padded for single digits. For example:
    /// * 03 = March
    /// * 11 = November
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryMonth")]
    [StringLength(2, MinimumLength = 1)]
    public string? ExpiryMonth { get; init; }

    /// <summary>
    /// The card expiry year.
    /// Format: 4 digits. For example: 2020
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryYear")]
    [StringLength(4, MinimumLength = 4)]
    public string? ExpiryYear { get; init; }

    /// <summary>
    /// The name of the cardholder, as printed on the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holderName")]
    [StringLength(50, MinimumLength = 1)]
    public string? HolderName { get; init; }

    /// <summary>
    /// The issue number of the card (for some UK debit cards only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issueNumber")]
    [StringLength(2, MinimumLength = 1)]
    public string? IssueNumber { get; init; }

    /// <summary>
    /// The card number (4-19 characters). Do not use any separators.
    /// When this value is returned in a response, only the last 4 digits of the card number are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [StringLength(19, MinimumLength = 4)]
    public string? Number { get; init; }

    /// <summary>
    /// The month component of the start date (for some UK debit cards only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startMonth")]
    [StringLength(2, MinimumLength = 1)]
    public string? StartMonth { get; init; }

    /// <summary>
    /// The year component of the start date (for some UK debit cards only).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startYear")]
    [StringLength(4, MinimumLength = 4)]
    public string? StartYear { get; init; }
}
