using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains information about the card. Required when you create a payment instrument of <c>type</c> <b>card</b>.
/// </summary>
public record CardInfo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public AuthenticationModel? Authentication { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public CardConfiguration? Configuration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryContact")]
    public DeliveryContact? DeliveryContact { get; init; }

    [JsonPropertyName("formFactor")]
    public required FormFactor1 FormFactor { get; init; }

    /// <summary>
    /// The 3DS configuration of the physical or the virtual card. Possible values: <b>fullySupported</b>, <b>secureCorporate</b>.
    /// &gt; Reach out to your Adyen contact to get the values relevant for your integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSecure")]
    public string? ThreeDsecure { get; init; }

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
