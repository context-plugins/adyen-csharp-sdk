using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Card2
{
    /// <summary>
    /// Contains the card user's password and mobile phone number. This is required when you issue cards that can be used to make online payments within the EEA and the UK, or can be added to digital wallets. Refer to <see href="https://docs.adyen.com/issuing/3d-secure-and-wallets">3D Secure and digital wallets</see> for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public Authentication1? Authentication { get; init; }

    /// <summary>
    /// The bank identification number (BIN) of the card number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bin")]
    public string? Bin { get; init; }

    /// <summary>
    /// The brand of the physical or the virtual card.
    /// Possible values: <b>visa</b>, <b>mc</b>.
    /// </summary>
    [JsonPropertyName("brand")]
    public required string Brand { get; init; }

    /// <summary>
    /// The brand variant of the physical or the virtual card. For example, <b>visadebit</b> or <b>mcprepaid</b>.
    /// &gt;Reach out to your Adyen contact to get the values relevant for your integration.
    /// </summary>
    [JsonPropertyName("brandVariant")]
    public required string BrandVariant { get; init; }

    /// <summary>
    /// The name of the cardholder.
    ///  Maximum length: 26 characters.
    /// </summary>
    [JsonPropertyName("cardholderName")]
    [MaxLength(26)]
    public required string CardholderName { get; init; }

    /// <summary>
    /// Contains information about the configuration profile for your cards. The configuration profile consists of settings required when creating a physical or a virtual card. You identify a configuration profile with its <c>configurationProfileId</c>.
    /// <para>
    /// When you provide this field in a request, you can override the settings of an existing configuration profile.
    /// </para>
    /// <para>
    /// Reach out to your Adyen contact to get the values that you can send in this object.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public CardConfiguration2? Configuration { get; init; }

    /// <summary>
    /// The CVC2 value of the card.
    /// &gt; The CVC2 is not sent by default. This is only returned in the <c>POST</c> response for single-use virtual cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvc")]
    public string? Cvc { get; init; }

    /// <summary>
    /// The delivery contact (name and address) for physical card delivery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryContact")]
    public DeliveryContact1? DeliveryContact { get; init; }

    /// <summary>
    /// The expiration date of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public Expiry2? Expiration { get; init; }

    /// <summary>
    /// The form factor of the card.
    /// Possible values: <b>virtual</b>, <b>physical</b>.
    /// </summary>
    [JsonPropertyName("formFactor")]
    public required FormFactor1 FormFactor { get; init; }

    /// <summary>
    /// Last last four digits of the card number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastFour")]
    public string? LastFour { get; init; }

    /// <summary>
    /// The primary account number (PAN) of the card.
    /// &gt; The PAN is masked by default and returned only for single-use virtual cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// The 3DS configuration of the physical or the virtual card. Possible values: <b>fullySupported</b>, <b>secureCorporate</b>.
    /// &gt; Reach out to your Adyen contact to get the values relevant for your integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSecure")]
    public string? ThreeDSecure { get; init; }

    /// <summary>
    /// Specifies how many times the card can be used. Possible values: <b>singleUse</b>, <b>multiUse</b>.
    /// <para>
    /// &gt; Reach out to your Adyen contact to determine the value relevant for your integration.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage")]
    public string? Usage { get; init; }
}
