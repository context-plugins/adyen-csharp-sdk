using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record StoreDetailAndSubmitRequest
{
    /// <summary>
    /// This field contains additional data, which may be required for a particular request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// A container object for the payable amount information of the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount Amount { get; init; }

    /// <summary>
    /// A container for bank account data.
    /// &gt; This field is mandatory if <c>card</c> is not provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank")]
    public BankAccount? Bank { get; init; }

    /// <summary>
    /// The billing address.
    /// <para>
    /// &gt; The <c>billingAddress</c> object is required for cross-border payouts to and from Canada. Include all of the fields within this object.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public Address? BillingAddress { get; init; }

    /// <summary>
    /// A container for card data.
    /// &gt; This field is mandatory if <c>bank</c> is not provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card? Card { get; init; }

    /// <summary>
    /// The date of birth.
    /// Format: <see href="https://www.w3.org/TR/NOTE-datetime">ISO-8601</see>; example: YYYY-MM-DD
    /// For Paysafecard it must be the same as used when registering the Paysafecard account.
    /// &gt; This field is mandatory for natural persons.
    /// </summary>
    [JsonPropertyName("dateOfBirth")]
    public required DateTimeOffset DateOfBirth { get; init; }

    /// <summary>
    /// The type of the entity the payout is processed for.
    /// </summary>
    [JsonPropertyName("entityType")]
    public required EntityType1 EntityType { get; init; }

    /// <summary>
    /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudOffset")]
    public int? FraudOffset { get; init; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The shopper's nationality.
    /// <para>
    /// A valid value is an ISO 2-character country code (e.g. 'NL').
    /// </para>
    /// </summary>
    [JsonPropertyName("nationality")]
    [MaxLength(2)]
    public required string Nationality { get; init; }

    /// <summary>
    /// A container for the type of recurring contract to be retrieved.
    /// <para>
    /// The recurring.contract must be set to <c>PAYOUT</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("recurring")]
    public required Recurring Recurring { get; init; }

    /// <summary>
    /// The merchant reference for this payment. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// The name of the brand to make a payout to.
    /// <para>
    /// For Paysafecard it must be set to <c>paysafecard</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectedBrand")]
    public string? SelectedBrand { get; init; }

    /// <summary>
    /// The shopper's email address.
    /// </summary>
    [JsonPropertyName("shopperEmail")]
    public required string ShopperEmail { get; init; }

    /// <summary>
    /// The shopper's name.
    /// <para>
    /// When the <c>entityType</c> is <c>Company</c>, the <c>shopperName.lastName</c> must contain the company name.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public Name? ShopperName { get; init; }

    /// <summary>
    /// The shopper's reference for the payment transaction.
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }

    /// <summary>
    /// The description of this payout. This description is shown on the bank statement of the shopper (if this is supported by the chosen payment method).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperStatement")]
    public string? ShopperStatement { get; init; }

    /// <summary>
    /// The shopper's social security number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("socialSecurityNumber")]
    public string? SocialSecurityNumber { get; init; }

    /// <summary>
    /// The shopper's phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    public string? TelephoneNumber { get; init; }
}
