using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information related an instalment transaction. To request an instalment to the issuer, or to make individual instalments of a payment transaction.
/// </summary>
public record Instalment1
{
    /// <summary>
    /// Type of instalment transaction. For requesting an instalment payment transaction.
    /// Possible values:
    /// * <b>DeferredInstalments</b>
    /// * <b>EqualInstalments</b>
    /// * <b>InequalInstalments</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("InstalmentType")]
    public InstalmentType? InstalmentType { get; init; }

    /// <summary>
    /// Sequence number of the instalment. For an instalment payment transaction, number of the payment, from 1 to TotalNbOfPayments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SequenceNumber")]
    public int? SequenceNumber { get; init; }

    /// <summary>
    /// Identification of an instalment plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PlanID")]
    [RegularExpression("^.+$")]
    public string? PlanId { get; init; }

    /// <summary>
    /// Period of time with defined unit of time. A period between 2 payment instalments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Period")]
    public int? Period { get; init; }

    /// <summary>
    /// Type of instalment transaction.
    /// Possible values:
    /// * <b>Annual</b>
    /// * <b>Daily</b>
    /// * <b>Monthly</b>
    /// * <b>Weekly</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PeriodUnit")]
    public PeriodUnit1? PeriodUnit { get; init; }

    /// <summary>
    /// First date of a payment. For instalment, the date of the first payments, if not immediate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("FirstPaymentDate")]
    public DateTimeOffset? FirstPaymentDate { get; init; }

    /// <summary>
    /// Total number of payments. For instalment, the number of payments, including the first one.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TotalNbOfPayments")]
    public int? TotalNbOfPayments { get; init; }

    /// <summary>
    /// Sum of a collection of amounts. Total amount of the payment instalments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CumulativeAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? CumulativeAmount { get; init; }

    /// <summary>
    /// First amount of the payment instalments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("FirstAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? FirstAmount { get; init; }

    /// <summary>
    /// Charges related to a transaction. Charge related to the payment instalments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Charges")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? Charges { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
