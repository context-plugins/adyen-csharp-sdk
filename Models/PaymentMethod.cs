using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentMethod
{
    /// <summary>
    /// A list of apps for this payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apps")]
    public IReadOnlyList<PaymentMethodUpiapps>? Apps { get; init; }

    /// <summary>
    /// Brand for the selected gift card. For example: plastix, hmclub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public string? Brand { get; init; }

    /// <summary>
    /// List of possible brands. For example: visa, mc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brands")]
    public IReadOnlyList<string>? Brands { get; init; }

    /// <summary>
    /// The configuration of the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public IReadOnlyDictionary<string, string>? Configuration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    public FundingSource? FundingSource { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public PaymentMethodGroup? Group { get; init; }

    /// <summary>
    /// All input details to be provided to complete the payment with this payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inputDetails")]
    public IReadOnlyList<InputDetail>? InputDetails { get; init; }

    /// <summary>
    /// A list of issuers for this payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuers")]
    public IReadOnlyList<PaymentMethodIssuer>? Issuers { get; init; }

    /// <summary>
    /// The displayable name of this payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Indicates whether this payment method should be promoted or not.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promoted")]
    public bool? Promoted { get; init; }

    /// <summary>
    /// The unique payment method code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
