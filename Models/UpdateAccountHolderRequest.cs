using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateAccountHolderRequest
{
    /// <summary>
    /// The code of the Account Holder to be updated.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The details to which the Account Holder should be updated.
    /// <para>
    /// Required if a processingTier is not provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderDetails")]
    public AccountHolderDetails4? AccountHolderDetails { get; init; }

    /// <summary>
    /// A description of the account holder, maximum 256 characters. You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores <c>_</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The legal entity type of the account holder. This determines the information that should be provided in the request.
    /// <para>
    /// Possible values: <b>Business</b>, <b>Individual</b>, or <b>NonProfit</b>.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>If set to <b>Business</b> or <b>NonProfit</b>, then <c>accountHolderDetails.businessDetails</c> must be provided, with at least one entry in the <c>accountHolderDetails.businessDetails.shareholders</c> list.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>If set to <b>Individual</b>, then <c>accountHolderDetails.individualDetails</c> must be provided.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalEntity")]
    public LegalEntity? LegalEntity { get; init; }

    /// <summary>
    /// The primary three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>, to which the account holder should be updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryCurrency")]
    public string? PrimaryCurrency { get; init; }

    /// <summary>
    /// The processing tier to which the Account Holder should be updated.
    /// &gt;The processing tier can not be lowered through this request.
    /// <para>
    /// &gt;Required if accountHolderDetails are not provided.
    /// </para>
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
