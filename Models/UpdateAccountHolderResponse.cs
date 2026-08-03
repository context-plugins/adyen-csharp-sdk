using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateAccountHolderResponse
{
    /// <summary>
    /// The code of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderCode")]
    public string? AccountHolderCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderDetails")]
    public AccountHolderDetails? AccountHolderDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderStatus")]
    public AccountHolderStatus? AccountHolderStatus { get; init; }

    /// <summary>
    /// The description of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// in case the account holder has not been updated, contains account holder fields, that did not pass the validation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalidFields")]
    public IReadOnlyList<ErrorFieldType>? InvalidFields { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalEntity")]
    public LegalEntity2? LegalEntity { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification")]
    public KycverificationResult? Verification { get; init; }

    /// <summary>
    /// The identifier of the profile that applies to this entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationProfile")]
    public string? VerificationProfile { get; init; }
}
