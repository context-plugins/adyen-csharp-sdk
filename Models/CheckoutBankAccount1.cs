using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The details of the bank account, from which the payment should be made.
/// &gt; Either <c>bankAccount</c> or <c>card</c> field must be provided in a payment request.
/// </summary>
public record CheckoutBankAccount1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public AccountType11? AccountType { get; init; }

    /// <summary>
    /// The bank account number (without separators).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountNumber")]
    public string? BankAccountNumber { get; init; }

    /// <summary>
    /// The bank city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankCity")]
    public string? BankCity { get; init; }

    /// <summary>
    /// The location id of the bank. The field value is <c>nil</c> in most cases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankLocationId")]
    public string? BankLocationId { get; init; }

    /// <summary>
    /// The name of the bank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankName")]
    public string? BankName { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/ISO_9362">Business Identifier Code</see> (BIC) is the SWIFT address assigned to a bank. The field value is <c>nil</c> in most cases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bic")]
    public string? Bic { get; init; }

    /// <summary>
    /// Country code where the bank is located.
    /// <para>
    /// A valid value is an ISO two-character country code (e.g. 'NL').
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/International_Bank_Account_Number">International Bank Account Number</see> (IBAN).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    public string? Iban { get; init; }

    /// <summary>
    /// The name of the bank account holder.
    /// If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example:
    /// * χ12 is converted to ch12.
    /// * üA is converted to euA.
    /// * Peter Møller is converted to Peter Mller, because banks don't accept 'ø'.
    /// After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example:
    /// * John17 - allowed.
    /// * J17 - allowed.
    /// * 171 - not allowed.
    /// * John-7 - allowed.
    /// &gt; If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerName")]
    public string? OwnerName { get; init; }

    /// <summary>
    /// The bank account holder's tax ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxId")]
    public string? TaxId { get; init; }
}
