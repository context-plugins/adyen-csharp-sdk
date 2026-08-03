using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DinersInfo
{
    /// <summary>
    /// MID (Merchant ID) number. Required for merchants operating in Japan.
    /// Format: 14 numeric characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("midNumber")]
    [MaxLength(14)]
    public string? MidNumber { get; init; }

    /// <summary>
    /// Indicates whether the JCB Merchant ID is reused from a previously configured JCB payment method.
    /// The default value is <b>false</b>.
    /// For merchants operating in Japan, this field is required and must be set to <b>true</b>.
    /// </summary>
    [JsonPropertyName("reuseMidNumber")]
    public required bool ReuseMidNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceLevel")]
    public ServiceLevel1? ServiceLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
