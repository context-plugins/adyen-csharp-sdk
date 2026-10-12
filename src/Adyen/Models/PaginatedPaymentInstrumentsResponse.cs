using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaginatedPaymentInstrumentsResponse
{
    /// <summary>
    /// Indicates whether there are more items on the next page.
    /// </summary>
    [JsonPropertyName("hasNext")]
    public required bool HasNext { get; init; }

    /// <summary>
    /// Indicates whether there are more items on the previous page.
    /// </summary>
    [JsonPropertyName("hasPrevious")]
    public required bool HasPrevious { get; init; }

    /// <summary>
    /// List of payment instruments associated with the balance account.
    /// </summary>
    [JsonPropertyName("paymentInstruments")]
    public required IReadOnlyList<PaymentInstrument1> PaymentInstruments { get; init; }
}
