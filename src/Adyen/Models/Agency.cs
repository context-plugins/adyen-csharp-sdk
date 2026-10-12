using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Agency
{
    /// <summary>
    /// The reference number for the invoice, issued by the agency.
    /// * Encoding: ASCII
    /// * minLength: 1 character
    /// * maxLength: 6 characters
    /// * <b>additionalData key:</b> <c>airline.agency_invoice_number</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; init; }

    /// <summary>
    /// The two-letter agency plan identifier.
    /// * Encoding: ASCII
    /// * minLength: 2 characters
    /// * maxLength: 2 characters
    /// * <b>additionalData key:</b> <c>airline.agency_plan_name</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("planName")]
    public string? PlanName { get; init; }
}
