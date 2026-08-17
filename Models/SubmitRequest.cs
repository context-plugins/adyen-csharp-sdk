using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SubmitRequest
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
    /// The date of birth.
    /// Format: ISO-8601; example: YYYY-MM-DD
    /// <para>
    /// For Paysafecard it must be the same as used when registering the Paysafecard account.
    /// </para>
    /// <para>
    /// &gt; This field is mandatory for natural persons.
    /// &gt; This field is required to update the existing <c>dateOfBirth</c> that is associated with this recurring contract.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// The type of the entity the payout is processed for.
    /// <para>
    /// Allowed values:
    /// * NaturalPerson
    /// * Company
    /// &gt; This field is required to update the existing <c>entityType</c> that is associated with this recurring contract.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityType")]
    public EntityType2? EntityType { get; init; }

    /// <summary>
    /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudOffset")]
    public int? FraudOffset { get; init; }

    /// <summary>
    /// The merchant account identifier you want to process the transaction request with.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The shopper's nationality.
    /// <para>
    /// A valid value is an ISO 2-character country code (e.g. 'NL').
    /// </para>
    /// <para>
    /// &gt; This field is required to update the existing nationality that is associated with this recurring contract.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    public string? Nationality { get; init; }

    /// <summary>
    /// A container for the type of recurring contract to be retrieved.
    /// <para>
    /// The <c>recurring.contract</c> must be set to "PAYOUT".
    /// </para>
    /// </summary>
    [JsonPropertyName("recurring")]
    public required Recurring Recurring { get; init; }

    /// <summary>
    /// The merchant reference for this payout. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> you want to use for this payout.
    /// <para>
    /// You can use the value LATEST to select the most recently used recurring detail.
    /// </para>
    /// </summary>
    [JsonPropertyName("selectedRecurringDetailReference")]
    public required string SelectedRecurringDetailReference { get; init; }

    /// <summary>
    /// The shopper's email address.
    /// </summary>
    [JsonPropertyName("shopperEmail")]
    public required string ShopperEmail { get; init; }

    /// <summary>
    /// The shopper's name.
    /// <para>
    /// In case the <c>entityType</c> is <c>Company</c>, the <c>shopperName.lastName</c> must contain the company name.
    /// </para>
    /// <para>
    /// &gt; This field is required to update the existing <c>shopperName</c> associated with a recurring contract.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public Name? ShopperName { get; init; }

    /// <summary>
    /// The shopper's reference for the payout transaction.
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
}
