using System.Text.Json.Serialization;

namespace Adyen.Models;

public record FundOrigin
{
    /// <summary>
    /// The address where to send the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public Address3? BillingAddress { get; init; }

    /// <summary>
    /// The email address of the person funding the money.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

    /// <summary>
    /// The name of the person funding the money.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public Name1? ShopperName { get; init; }

    /// <summary>
    /// The phone number of the person funding the money.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    public string? TelephoneNumber { get; init; }

    /// <summary>
    /// The unique identifier of the wallet where the funds are coming from.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletIdentifier")]
    public string? WalletIdentifier { get; init; }
}
