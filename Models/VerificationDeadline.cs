using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record VerificationDeadline
{
    /// <summary>
    /// The names of the capabilities to be disallowed.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public required IReadOnlyList<Capability> Capabilities { get; init; }

    /// <summary>
    /// The unique identifiers of the bank account(s) that the deadline applies to
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityIds")]
    public IReadOnlyList<string>? EntityIds { get; init; }

    /// <summary>
    /// The date that verification is due by before capabilities are disallowed.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public required DateTimeOffset ExpiresAt { get; init; }
}
