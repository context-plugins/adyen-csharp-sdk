using System.Text.Json.Serialization;
using Adyen.Models.OneOf;

namespace Adyen.Models;

/// <summary>
/// Contains information about the legal entity's bank account.
/// </summary>
public record BankAccountInfo1
{
    /// <summary>
    /// Identification of the bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountIdentification")]
    public AccountIdentification2? AccountIdentification { get; init; }

    /// <summary>
    /// The type of bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public string? AccountType { get; init; }

    /// <summary>
    /// The name of the banking institution where the bank account is held.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankName")]
    public string? BankName { get; init; }

    /// <summary>
    /// The two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code where the bank account is registered. For example, <b>NL</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// Identifies if the bank account was created through <see href="https://docs.adyen.com/release-notes/platforms-and-financial-products#releaseNote=2023-05-08-hosted-onboarding">instant bank verification</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trustedSource")]
    public bool? TrustedSource { get; init; }
}
