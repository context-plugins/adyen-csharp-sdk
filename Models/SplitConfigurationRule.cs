using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SplitConfigurationRule
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardRegion")]
    public CardRegion? CardRegion { get; init; }

    /// <summary>
    /// The currency condition that defines whether the split logic applies.
    /// Its value must be a three-character <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    [JsonPropertyName("fundingSource")]
    public required FundingSource1 FundingSource { get; init; }

    /// <summary>
    /// The payment method condition that defines whether the split logic applies.
    /// <para>
    /// Possible values:
    /// * <see href="https://docs.adyen.com/development-resources/paymentmethodvariant">Payment method variant</see>: Apply the split logic for a specific payment method.
    /// * <b>ANY</b>: Apply the split logic for all available payment methods.
    /// </para>
    /// </summary>
    [JsonPropertyName("paymentMethod")]
    public required string PaymentMethod { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; init; }

    [JsonPropertyName("shopperInteraction")]
    public required ShopperInteraction11 ShopperInteraction { get; init; }

    [JsonPropertyName("splitLogic")]
    public required SplitConfigurationLogic SplitLogic { get; init; }
}
