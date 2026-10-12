using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataRatepay
{
    /// <summary>
    /// Amount the customer has to pay each month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratepay.installmentAmount")]
    public string? RatepayInstallmentAmount { get; init; }

    /// <summary>
    /// Interest rate of this installment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratepay.interestRate")]
    public string? RatepayInterestRate { get; init; }

    /// <summary>
    /// Amount of the last installment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratepay.lastInstallmentAmount")]
    public string? RatepayLastInstallmentAmount { get; init; }

    /// <summary>
    /// Calendar day of the first payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratepay.paymentFirstday")]
    public string? RatepayPaymentFirstday { get; init; }

    /// <summary>
    /// Date the merchant delivered the goods to the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratepaydata.deliveryDate")]
    public string? RatepaydataDeliveryDate { get; init; }

    /// <summary>
    /// Date by which the customer must settle the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratepaydata.dueDate")]
    public string? RatepaydataDueDate { get; init; }

    /// <summary>
    /// Invoice date, defined by the merchant. If not included, the invoice date is set to the delivery date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratepaydata.invoiceDate")]
    public string? RatepaydataInvoiceDate { get; init; }

    /// <summary>
    /// Identification name or number for the invoice, defined by the merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratepaydata.invoiceId")]
    public string? RatepaydataInvoiceId { get; init; }
}
