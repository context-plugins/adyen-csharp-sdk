using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The person or entity funding the money.
/// </summary>
public record FundOrigin1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress7? BillingAddress { get; init; }

    /// <summary>
    /// The email address of the person funding the money.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public ShopperName? ShopperName { get; init; }

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
