using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record StoredPaymentMethodResource
{
    /// <summary>
    /// The alias of the credit card number.
    /// <para>
    /// Applies only to recurring contracts storing credit card details
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    /// <summary>
    /// The alias type of the credit card number.
    /// <para>
    /// Applies only to recurring contracts storing credit card details.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliasType")]
    public string? AliasType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress7? BillingAddress { get; init; }

    /// <summary>
    /// The brand of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public string? Brand { get; init; }

    /// <summary>
    /// The bank identification number (BIN) of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardBin")]
    public string? CardBin { get; init; }

    /// <summary>
    /// The date when the recurring details were created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// The month the card expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryMonth")]
    public string? ExpiryMonth { get; init; }

    /// <summary>
    /// The last two digits of the year the card expires. For example, <b>22</b> for the year 2022.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryYear")]
    public string? ExpiryYear { get; init; }

    /// <summary>
    /// The response code returned by an external system (for example after a provisioning operation).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalResponseCode")]
    public string? ExternalResponseCode { get; init; }

    /// <summary>
    /// The token reference of a linked token in an external system (for example a network token reference).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalTokenReference")]
    public string? ExternalTokenReference { get; init; }

    /// <summary>
    /// The PSP reference of the first payment that created this recurring detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstPspReference")]
    public string? FirstPspReference { get; init; }

    /// <summary>
    /// The unique payment method code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holderName")]
    public string? HolderName { get; init; }

    /// <summary>
    /// The IBAN of the bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    public string? Iban { get; init; }

    /// <summary>
    /// A unique identifier of this stored payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The name of the issuer of token or card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerName")]
    public string? IssuerName { get; init; }

    /// <summary>
    /// The last four digits of the PAN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastFour")]
    public string? LastFour { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mandate")]
    public TokenMandate? Mandate { get; init; }

    /// <summary>
    /// The display name of the stored payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.
    /// <para>
    /// This contains either the Mastercard Trace ID or the Visa Transaction ID.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkTxReference")]
    public string? NetworkTxReference { get; init; }

    /// <summary>
    /// The name of the bank account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerName")]
    public string? OwnerName { get; init; }

    /// <summary>
    /// The shopper’s email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

    /// <summary>
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.
    /// &gt; Your reference must not include personally identifiable information (PII) such as name or email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    [StringLength(256, MinimumLength = 3)]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// Defines a recurring payment type.
    /// Allowed values:
    /// * <c>Subscription</c> – A transaction for a fixed or variable amount, which follows a fixed schedule.
    /// * <c>CardOnFile</c> – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
    /// * <c>UnscheduledCardOnFile</c> – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportedRecurringProcessingModels")]
    public IReadOnlyList<string>? SupportedRecurringProcessingModels { get; init; }

    /// <summary>
    /// The type of payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
