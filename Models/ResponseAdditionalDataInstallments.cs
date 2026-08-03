using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalDataInstallments
{
    /// <summary>
    /// Type of installment. The value of <c>installmentType</c> should be <b>IssuerFinanced</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.installmentType")]
    public string? InstallmentPaymentDataInstallmentType { get; init; }

    /// <summary>
    /// Annual interest rate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].annualPercentageRate")]
    public string? InstallmentPaymentDataOptionItemNrAnnualPercentageRate { get; init; }

    /// <summary>
    /// First Installment Amount in minor units.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].firstInstallmentAmount")]
    public string? InstallmentPaymentDataOptionItemNrFirstInstallmentAmount { get; init; }

    /// <summary>
    /// Installment fee amount in minor units.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].installmentFee")]
    public string? InstallmentPaymentDataOptionItemNrInstallmentFee { get; init; }

    /// <summary>
    /// Interest rate for the installment period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].interestRate")]
    public string? InstallmentPaymentDataOptionItemNrInterestRate { get; init; }

    /// <summary>
    /// Maximum number of installments possible for this payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].maximumNumberOfInstallments")]
    public string? InstallmentPaymentDataOptionItemNrMaximumNumberOfInstallments { get; init; }

    /// <summary>
    /// Minimum number of installments possible for this payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].minimumNumberOfInstallments")]
    public string? InstallmentPaymentDataOptionItemNrMinimumNumberOfInstallments { get; init; }

    /// <summary>
    /// Total number of installments possible for this payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].numberOfInstallments")]
    public string? InstallmentPaymentDataOptionItemNrNumberOfInstallments { get; init; }

    /// <summary>
    /// Subsequent Installment Amount in minor units.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].subsequentInstallmentAmount")]
    public string? InstallmentPaymentDataOptionItemNrSubsequentInstallmentAmount { get; init; }

    /// <summary>
    /// Total amount in minor units.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.option[itemNr].totalAmountDue")]
    public string? InstallmentPaymentDataOptionItemNrTotalAmountDue { get; init; }

    /// <summary>
    /// Possible values:
    /// * PayInInstallmentsOnly
    /// * PayInFullOnly
    /// * PayInFullOrInstallments
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.paymentOptions")]
    public string? InstallmentPaymentDataPaymentOptions { get; init; }

    /// <summary>
    /// The number of installments that the payment amount should be charged with.
    /// <para>
    /// Example: 5
    /// &gt; Only relevant for card payments in countries that support installments.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installments.value")]
    public string? InstallmentsValue { get; init; }
}
