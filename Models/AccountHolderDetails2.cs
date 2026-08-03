using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details of the new account holder.
/// </summary>
public record AccountHolderDetails2
{
    [JsonPropertyName("address")]
    public required ViasAddress Address { get; init; }

    /// <summary>
    /// Array of bank accounts associated with the account holder. For details about the required <c>bankAccountDetail</c> fields, see <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountDetails")]
    public IReadOnlyList<BankAccountDetail>? BankAccountDetails { get; init; }

    /// <summary>
    /// The opaque reference value returned by the Adyen API during bank account login.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAggregatorDataReference")]
    public string? BankAggregatorDataReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessDetails")]
    public BusinessDetails? BusinessDetails { get; init; }

    /// <summary>
    /// The email address of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The phone number of the account holder provided as a single string. It will be handled as a landline phone.
    /// <b>Examples:</b> "0031 6 11 22 33 44", "+316/1122-3344", "(0031) 611223344"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullPhoneNumber")]
    public string? FullPhoneNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("individualDetails")]
    public IndividualDetails? IndividualDetails { get; init; }

    /// <summary>
    /// Date when you last reviewed the account holder's information, in ISO-8601 YYYY-MM-DD format. For example, <b>2020-01-31</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastReviewDate")]
    public string? LastReviewDate { get; init; }

    /// <summary>
    /// An array containing information about the account holder's <see href="https://docs.adyen.com/classic-platforms/verification-process/legal-arrangements">legal arrangements</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangements")]
    public IReadOnlyList<LegalArrangementDetail>? LegalArrangements { get; init; }

    /// <summary>
    /// The Merchant Category Code of the account holder.
    /// &gt; If not specified in the request, this will be derived from the platform account (which is configured by Adyen).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCategoryCode")]
    public string? MerchantCategoryCode { get; init; }

    /// <summary>
    /// A set of key and value pairs for general use by the account holder or merchant.
    /// The keys do not have specific names and may be used for storing miscellaneous data as desired.
    /// &gt; The values being stored have a maximum length of eighty (80) characters and will be truncated if necessary.
    /// &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// Array of tokenized card details associated with the account holder. For details about how you can use the tokens to pay out, refer to <see href="https://docs.adyen.com/classic-platforms/payout-to-cards">Pay out to cards</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutMethods")]
    public IReadOnlyList<PayoutMethod>? PayoutMethods { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public PhoneNumber3? PhoneNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("principalBusinessAddress")]
    public ViasAddress? PrincipalBusinessAddress { get; init; }

    /// <summary>
    /// Array of stores associated with the account holder. Required when onboarding account holders that have an Adyen <see href="https://docs.adyen.com/classic-platforms/platforms-for-pos">point of sale</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeDetails")]
    public IReadOnlyList<StoreDetail>? StoreDetails { get; init; }

    /// <summary>
    /// The URL of the website of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }
}
