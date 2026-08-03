using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SplitConfigurationLogic
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquiringFees")]
    public AcquiringFees? AcquiringFees { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalCommission")]
    public AdditionalCommission? AdditionalCommission { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenCommission")]
    public AdyenCommission? AdyenCommission { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenFees")]
    public AdyenFees? AdyenFees { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenMarkup")]
    public AdyenMarkup? AdyenMarkup { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargeback")]
    public Behavior? Chargeback { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargebackCostAllocation")]
    public ChargebackCostAllocation? ChargebackCostAllocation { get; init; }

    [JsonPropertyName("commission")]
    public required Commission Commission { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dcc")]
    public SplitDcc? Dcc { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchange")]
    public Interchange? Interchange { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentFee")]
    public PaymentFee? PaymentFee { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public Behavior? Refund { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refundCostAllocation")]
    public RefundCostAllocation? RefundCostAllocation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remainder")]
    public Remainder? Remainder { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schemeFee")]
    public SchemeFee? SchemeFee { get; init; }

    /// <summary>
    /// Unique identifier of the collection of split instructions that are applied when the rule conditions are met.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitLogicId")]
    public string? SplitLogicId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public Surcharge3? Surcharge { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip")]
    public Tip? Tip { get; init; }
}
