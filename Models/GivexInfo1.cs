using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>givex</b>.
/// </summary>
public record GivexInfo1
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

    /// <summary>
    /// The sales channel used for the payment.
    /// </summary>
    [JsonPropertyName("paymentFlow")]
    public required PaymentFlow PaymentFlow { get; init; }

    /// <summary>
    /// The username provided by the acquirer.
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; init; }
}
