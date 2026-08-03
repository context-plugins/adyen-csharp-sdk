using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record StoreDetail
{
    [JsonPropertyName("address")]
    public required ViasAddress Address { get; init; }

    /// <summary>
    /// The phone number of the store provided as a single string.  It will be handled as a landline phone.
    /// <para>
    /// Examples: "0031 6 11 22 33 44", "+316/1122-3344", "(0031) 611223344"
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullPhoneNumber")]
    public string? FullPhoneNumber { get; init; }

    /// <summary>
    /// Store logo for payment method setup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    /// <summary>
    /// The merchant account to which the store belongs.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The merchant category code (MCC) that classifies the business of the account holder.
    /// </summary>
    [JsonPropertyName("merchantCategoryCode")]
    public required string MerchantCategoryCode { get; init; }

    /// <summary>
    /// Merchant house number for payment method setup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantHouseNumber")]
    public string? MerchantHouseNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public PhoneNumber3? PhoneNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteraction? ShopperInteraction { get; init; }

    /// <summary>
    /// The unique reference for the split configuration, returned when you configure splits in your Customer Area. When this is provided, the <c>virtualAccount</c> is also required. Adyen uses the configuration and the <c>virtualAccount</c> to split funds between accounts in your platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitConfigurationUUID")]
    public string? SplitConfigurationUuid { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status? Status { get; init; }

    /// <summary>
    /// Adyen-generated unique alphanumeric identifier (UUID) for the store, returned in the response when you create a store. Required when updating an existing store in an <c>/updateAccountHolder</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }

    /// <summary>
    /// The name of the account holder's store. This value is shown in shopper statements.
    /// <list type="bullet">
    ///   <item><description>Length: Between 3 to 22 characters</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>The following characters are *not* supported: <b>:;}{$#@!|&lt;&gt;%^*+=\\</b></description></item>
    /// </list>
    /// <para>
    /// <b>Note:</b> storeName does not appear in American Express shopper statements by default. Contact Adyen Support to enable this for American Express.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeName")]
    public string? StoreName { get; init; }

    /// <summary>
    /// Your unique identifier for the store. The Customer Area also uses this value for the store description.
    /// <list type="bullet">
    ///   <item><description>Length: Between 3 to 128 characters</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>The following characters are *not* supported: <b>:;}{$#@!|&lt;&gt;%^*+=\\</b></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeReference")]
    public string? StoreReference { get; init; }

    /// <summary>
    /// The account holder's <c>accountCode</c> where the split amount will be sent. Required when you provide the <c>splitConfigurationUUID</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("virtualAccount")]
    public string? VirtualAccount { get; init; }

    /// <summary>
    /// URL of the ecommerce store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webAddress")]
    public string? WebAddress { get; init; }
}
