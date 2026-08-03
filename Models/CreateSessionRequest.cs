using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateSessionRequest
{
    /// <summary>
    /// The unique identifier of your merchant account.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The setup token provided by the POS Mobile SDK.
    /// - When using the Android POS Mobile SDK, obtain the token through the <c>AuthenticationService.authenticate(setupToken)</c> callback of <c>AuthenticationService</c>.
    /// - When using the iOS POS Mobile SDK, obtain the token through the <c>PaymentServiceDelegate.register(with:)</c> callback of <c>PaymentServiceDelegate</c>.
    /// </summary>
    [JsonPropertyName("setupToken")]
    [MaxLength(50000)]
    public required string SetupToken { get; init; }

    /// <summary>
    /// The unique identifier of the store that you want to process transactions for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }
}
