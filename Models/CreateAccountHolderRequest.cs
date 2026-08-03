using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateAccountHolderRequest
{
    /// <summary>
    /// Your unique identifier for the prospective account holder.
    /// The length must be between three (3) and fifty (50) characters long. Only letters, digits, and hyphens (-) are allowed.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    [JsonPropertyName("accountHolderDetails")]
    public required AccountHolderDetails AccountHolderDetails { get; init; }

    /// <summary>
    /// If set to <b>true</b>, an account with the default options is automatically created for the account holder.
    /// By default, this field is set to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createDefaultAccount")]
    public bool? CreateDefaultAccount { get; init; }

    /// <summary>
    /// A description of the prospective account holder, maximum 256 characters. You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores <c>_</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("legalEntity")]
    public required LegalEntity LegalEntity { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>, with which the prospective account holder primarily deals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryCurrency")]
    public string? PrimaryCurrency { get; init; }

    /// <summary>
    /// The starting <see href="https://docs.adyen.com/classic-platforms/onboarding-and-verification/precheck-kyc-information">processing tier</see> for the prospective account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingTier")]
    public int? ProcessingTier { get; init; }

    /// <summary>
    /// The identifier of the profile that applies to this entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationProfile")]
    public string? VerificationProfile { get; init; }
}
