using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccountVerificationReportResponse
{
    /// <summary>
    /// A list of bank accounts with their respective information.
    /// </summary>
    [JsonPropertyName("accounts")]
    public required IReadOnlyList<VerifiedAccount> Accounts { get; init; }

    /// <summary>
    /// The location where the third-party individual's bank account is registered.
    /// </summary>
    [JsonPropertyName("country")]
    public required AccountVerificationCountry1 Country { get; init; }

    /// <summary>
    /// The unique identifier for the specific report.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }
}
