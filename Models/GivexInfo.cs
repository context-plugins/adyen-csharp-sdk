using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record GivexInfo
{
    /// <summary>
    /// The three-character ISO currency code, such as <b>EUR</b>.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public required string CurrencyCode { get; init; }

    /// <summary>
    /// The password provided by the acquirer.
    /// </summary>
    [JsonPropertyName("password")]
    public required string Password { get; init; }

    [JsonPropertyName("paymentFlow")]
    public required ShopperInteraction PaymentFlow { get; init; }

    /// <summary>
    /// The username provided by the acquirer.
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; init; }
}
