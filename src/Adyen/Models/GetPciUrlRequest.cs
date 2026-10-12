using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetPciUrlRequest
{
    /// <summary>
    /// The account holder code you provided when you created the account holder.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The URL where the account holder will be redirected back to after they fill out the questionnaire, or if their session times out. Maximum length of 500 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnUrl")]
    public string? ReturnUrl { get; init; }
}
