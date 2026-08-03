using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The folio information for the booking.
/// </summary>
public record Folio2
{
    /// <summary>
    /// The folio cash advances, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// * <b>additionalData key:</b> <c>lodging.folioCashAdvances</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashAdvances")]
    public long? CashAdvances { get; init; }

    /// <summary>
    /// The card acceptor's internal invoice or billing ID reference number.
    /// * Format: Alphanumeric
    /// * Must not start with a space
    /// * Must not contain any special characters
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>lodging.folioNumber</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }
}
