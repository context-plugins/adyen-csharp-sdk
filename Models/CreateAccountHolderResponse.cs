using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateAccountHolderResponse
{
    /// <summary>
    /// The code of a new account created for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; init; }

    /// <summary>
    /// The code of the new account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderCode")]
    public string? AccountHolderCode { get; init; }

    /// <summary>
    /// Details of the new account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderDetails")]
    public AccountHolderDetails2? AccountHolderDetails { get; init; }

    /// <summary>
    /// The status of the new account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderStatus")]
    public AccountHolderStatus2? AccountHolderStatus { get; init; }

    /// <summary>
    /// The description of the new account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// A list of fields that caused the <c>/createAccountHolder</c> request to fail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalidFields")]
    public IReadOnlyList<ErrorFieldType>? InvalidFields { get; init; }

    /// <summary>
    /// The type of legal entity of the new account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalEntity")]
    public LegalEntity1? LegalEntity { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>, with which the prospective account holder primarily deals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryCurrency")]
    public string? PrimaryCurrency { get; init; }

    /// <summary>
    /// The reference of a request. Can be used to uniquely identify the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The result code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public string? ResultCode { get; init; }

    /// <summary>
    /// The details of KYC Verification of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification")]
    public KycVerificationResult1? Verification { get; init; }

    /// <summary>
    /// The identifier of the profile that applies to this entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationProfile")]
    public string? VerificationProfile { get; init; }
}
