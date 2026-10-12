using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CheckoutSessionInstallmentOption
{
    /// <summary>
    /// Defines the type of installment plan. If not set, defaults to <b>regular</b>.
    /// <para>
    /// Possible values:
    /// * <b>regular</b>
    /// * <b>revolving</b>
    /// * <b>bonus</b>
    /// * <b>with_interest</b>
    /// * <b>buynow_paylater</b>
    /// * <b>nointerest_bonus</b>
    /// * <b>interest_bonus</b>
    /// * <b>refund_prctg</b>
    /// * <b>nointeres_refund_prctg</b>
    /// * <b>interes_refund_prctg</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plans")]
    public IReadOnlyList<Plan1>? Plans { get; init; }

    /// <summary>
    /// Preselected number of installments offered for this payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preselectedValue")]
    public int? PreselectedValue { get; init; }

    /// <summary>
    /// An array of the number of installments that the shopper can choose from. For example, <b>[2,3,5]</b>. This cannot be specified simultaneously with <c>maxValue</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<int>? Values { get; init; }
}
