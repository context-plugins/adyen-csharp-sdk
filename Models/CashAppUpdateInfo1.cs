using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>cashapp</b>.
/// </summary>
public record CashAppUpdateInfo1
{
    /// <summary>
    /// The URL of the logo image shown in Cash App checkout next to payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; init; }

    /// <summary>
    /// The merchant display name shown in Cash App checkout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantName")]
    public string? MerchantName { get; init; }
}
