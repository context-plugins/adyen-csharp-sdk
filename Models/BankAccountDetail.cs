using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The details of the bank account to where a payout was made.
/// </summary>
public record BankAccountDetail
{
    /// <summary>
    /// The bank account number (without separators).
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// The type of bank account.
    /// Only applicable to bank accounts held in the USA.
    /// The permitted values are: <c>checking</c>, <c>savings</c>.
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public string? AccountType { get; init; }

    /// <summary>
    /// The name of the bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountName")]
    public string? BankAccountName { get; init; }

    /// <summary>
    /// Merchant reference to the bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountReference")]
    public string? BankAccountReference { get; init; }

    /// <summary>
    /// The unique identifier (UUID) of the Bank Account.
    /// &gt;If, during an account holder create or update request, this field is left blank (but other fields provided), a new Bank Account will be created with a procedurally-generated UUID.
    /// <para>
    /// &gt;If, during an account holder create request, a UUID is provided, the creation of the Bank Account will fail while the creation of the account holder will continue.
    /// </para>
    /// <para>
    /// &gt;If, during an account holder update request, a UUID that is not correlated with an existing Bank Account is provided, the update of the account holder will fail.
    /// </para>
    /// <para>
    /// &gt;If, during an account holder update request, a UUID that is correlated with an existing Bank Account is provided, the existing Bank Account will be updated.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountUUID")]
    public string? BankAccountUuid { get; init; }

    /// <summary>
    /// The bank identifier code.
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankBicSwift")]
    public string? BankBicSwift { get; init; }

    /// <summary>
    /// The city in which the bank branch is located.
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankCity")]
    public string? BankCity { get; init; }

    /// <summary>
    /// The bank code of the banking institution with which the bank account is registered.
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankCode")]
    public string? BankCode { get; init; }

    /// <summary>
    /// The name of the banking institution with which the bank account is held.
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankName")]
    public string? BankName { get; init; }

    /// <summary>
    /// The branch code of the branch under which the bank account is registered. The value to be specified in this parameter depends on the country of the bank account:
    /// * United States - Routing number
    /// * United Kingdom - Sort code
    /// * Germany - Bankleitzahl
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("branchCode")]
    public string? BranchCode { get; init; }

    /// <summary>
    /// The check code of the bank account.
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkCode")]
    public string? CheckCode { get; init; }

    /// <summary>
    /// The two-letter country code in which the bank account is registered.
    /// &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. 'NL').
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The currency in which the bank account deals.
    /// &gt;The permitted currency codes are defined in ISO-4217 (e.g. 'EUR').
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; init; }

    /// <summary>
    /// The international bank account number.
    /// &gt;The IBAN standard is defined in ISO-13616.
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    public string? Iban { get; init; }

    /// <summary>
    /// The city of residence of the bank account owner.
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerCity")]
    public string? OwnerCity { get; init; }

    /// <summary>
    /// The country code of the country of residence of the bank account owner.
    /// &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. 'NL').
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerCountryCode")]
    public string? OwnerCountryCode { get; init; }

    /// <summary>
    /// The date of birth of the bank account owner.
    /// The date should be in ISO-8601 format yyyy-mm-dd (e.g. 2000-01-31).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerDateOfBirth")]
    public string? OwnerDateOfBirth { get; init; }

    /// <summary>
    /// The house name or number of the residence of the bank account owner.
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerHouseNumberOrName")]
    public string? OwnerHouseNumberOrName { get; init; }

    /// <summary>
    /// The name of the bank account owner.
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerName")]
    public string? OwnerName { get; init; }

    /// <summary>
    /// The country code of the country of nationality of the bank account owner.
    /// &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. 'NL').
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerNationality")]
    public string? OwnerNationality { get; init; }

    /// <summary>
    /// The postal code of the residence of the bank account owner.
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerPostalCode")]
    public string? OwnerPostalCode { get; init; }

    /// <summary>
    /// The state of residence of the bank account owner.
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerState")]
    public string? OwnerState { get; init; }

    /// <summary>
    /// The street name of the residence of the bank account owner.
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerStreet")]
    public string? OwnerStreet { get; init; }

    /// <summary>
    /// If set to true, the bank account is a primary account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryAccount")]
    public bool? PrimaryAccount { get; init; }

    /// <summary>
    /// The tax ID number.
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxId")]
    public string? TaxId { get; init; }

    /// <summary>
    /// The URL to be used for bank account verification.
    /// This may be generated on bank account creation.
    /// <para>
    /// &gt;Refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/required-information">Required information</see> for details on field requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("urlForVerification")]
    public string? UrlForVerification { get; init; }
}
