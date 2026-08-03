using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>diners</b>.
/// For merchants operating in Japan, Diners payments are processed through the JCB network. This means that you must include <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">JCB-specific fields</see>/paymentMethodSettings/(paymentMethodId)#request-jcb) in this object.
/// </summary>
public record DinersInfo1
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
