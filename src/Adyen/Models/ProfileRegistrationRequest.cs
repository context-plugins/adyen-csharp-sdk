using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record ProfileRegistrationRequest
{
    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    [StringLength(150, MinimumLength = 1)]
    public required string AccountHolderId { get; init; }

    /// <summary>
    /// The unique identifiers of the payment instruments to be associated with the iDEAL profile.
    /// </summary>
    [JsonPropertyName("paymentInstrumentIds")]
    [MinLength(1)]
    [MaxLength(100)]
    public required IReadOnlyList<string> PaymentInstrumentIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
