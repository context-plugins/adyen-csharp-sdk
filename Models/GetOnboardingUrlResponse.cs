using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetOnboardingUrlResponse
{
    /// <summary>
    /// Information about any invalid fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalidFields")]
    public IReadOnlyList<ErrorFieldType>? InvalidFields { get; init; }

    /// <summary>
    /// The reference of a request. Can be used to uniquely identify the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The URL to the Hosted Onboarding Page where you should redirect your sub-merchant. This URL must be used within 30 seconds and can only be used once.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; init; }

    /// <summary>
    /// The result code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public string? ResultCode { get; init; }
}
