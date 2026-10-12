using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The recurring settings for the payment. Use this property when you want to enable <see href="https://docs.adyen.com/classic-integration/recurring-payments">recurring payments</see>., A container for the type of a recurring contract to be retrieved.
/// <para>
/// The contract value needs to match the contract value submitted in the payment transaction used to create a recurring contract.
/// However, if <c>ONECLICK,RECURRING</c> is the original contract definition in the initial payment, then <c>contract</c> should take either <c>ONECLICK</c> or <c>RECURRING</c>, depending on whether or not you want the shopper to enter their card's security code when they finalize their purchase., A container for the type of recurring contract to be retrieved.
/// </para>
/// <para>
/// The recurring.contract must be set to <c>PAYOUT</c>, A container for the type of recurring contract to be retrieved.
/// </para>
/// <para>
/// The <c>recurring.contract</c> must be set to "PAYOUT"., The recurring settings for the payment. Use this property when you want to enable <see href="https://docs.adyen.com/classic-integration/recurring-payments">recurring payments</see>., The recurring settings for the payment. Use this property when you want to enable <see href="https://docs.adyen.com/online-payments/tokenization">recurring payments</see>.
/// </para>
/// </summary>
public record Recurring
{
    /// <summary>
    /// The type of recurring contract to be used.
    /// Possible values:
    /// * <c>ONECLICK</c> – Payment details can be used to initiate a one-click payment, where the shopper enters the <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid">card security code (CVC/CVV)</see>.
    /// * <c>RECURRING</c> – Payment details can be used without the card security code to initiate <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp">card-not-present transactions</see>.
    /// * <c>ONECLICK,RECURRING</c> – Payment details can be used regardless of whether the shopper is on your site or not.
    /// * <c>PAYOUT</c> – Payment details can be used to <see href="https://docs.adyen.com/online-payments/online-payouts">make a payout</see>.
    /// * <c>EXTERNAL</c> - Use this when you store payment details and send the raw card number or network token directly in your API request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contract")]
    public Contract? Contract { get; init; }

    /// <summary>
    /// A descriptive name for this detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailName")]
    public string? RecurringDetailName { get; init; }

    /// <summary>
    /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringExpiry")]
    public DateTimeOffset? RecurringExpiry { get; init; }

    /// <summary>
    /// Minimum number of days between authorisations. Only for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringFrequency")]
    public string? RecurringFrequency { get; init; }

    /// <summary>
    /// The name of the token service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenService")]
    public TokenService? TokenService { get; init; }
}
