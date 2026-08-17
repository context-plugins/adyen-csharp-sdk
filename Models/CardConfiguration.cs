using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardConfiguration
{
    /// <summary>
    /// The activation label attached to the card that contains the activation instructions.
    /// <para>
    /// This field overrides the activation label design ID defined in the card configuration profile.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activation")]
    public string? Activation { get; init; }

    /// <summary>
    /// Your app's URL, if you want to activate cards through your app. For example, <b>my-app://ref1236a7d</b>. A QR code is created based on this URL, and is included in the carrier. Before you use this field, reach out to your Adyen contact to set up the QR code process.
    /// <para>
    /// Maximum length: 255 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activationUrl")]
    [MaxLength(255)]
    public string? ActivationUrl { get; init; }

    /// <summary>
    /// Overrides the shipment bulk address defined in the card configuration profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bulkAddress")]
    public BulkAddress1? BulkAddress { get; init; }

    /// <summary>
    /// The unique identifier of the card image. This image is printed on the full front of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardImageId")]
    public string? CardImageId { get; init; }

    /// <summary>
    /// The letter or packaging to which the card is attached.
    /// <para>
    /// This field overrides the carrier design ID defined in the card configuration profile.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrier")]
    public string? Carrier { get; init; }

    /// <summary>
    /// The unique identifier of the carrier image. This image is printed on the letter to which the card is attached.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierImageId")]
    public string? CarrierImageId { get; init; }

    /// <summary>
    /// The unique identifier of the card configuration profile that contains the settings that are applied to the card. For example, the envelope and PIN mailer designs or the logistics company handling the shipment.
    /// <para>
    /// You can override some of the existing settings in the configuration profile by providing the corresponding fields in the <c>configuration</c> object. For example, send the <c>shipmentMethod</c> to override the logistics company defined in the card configuration profile.
    /// </para>
    /// </summary>
    [JsonPropertyName("configurationProfileId")]
    public required string ConfigurationProfileId { get; init; }

    /// <summary>
    /// The three-letter <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO-4217</see> currency code of the card. For example, <b>EUR</b>.
    /// <para>
    /// This field overrides the existing currency setting on the card configuration profile.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// Overrides the envelope design ID defined in the card configuration profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("envelope")]
    public string? Envelope { get; init; }

    /// <summary>
    /// Any additional material, such as marketing material, that is shipped together with the card.
    /// <para>
    /// This field overrides the insert design ID defined in the card configuration profile.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("insert")]
    public string? Insert { get; init; }

    /// <summary>
    /// The two-letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO-639-1</see> language code of the card. For example, <b>en</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// The unique identifier of the logo image. This image is printed on the partial front of the card, for example, a logo on the upper right corner.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logoImageId")]
    public string? LogoImageId { get; init; }

    /// <summary>
    /// The letter on which the PIN of the card is printed.
    /// <para>
    /// This field overrides the PIN mailer design ID defined in the card configuration profile.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinMailer")]
    public string? PinMailer { get; init; }

    /// <summary>
    /// Print Line.
    /// <para>
    /// Text printed on the physical card below the cardholder name. You provide the value, which can be up to 26 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("printLine")]
    public string? PrintLine { get; init; }

    /// <summary>
    /// The logistics company that ships the card.
    /// <para>
    /// This field overrides the logistics company defined in the card configuration profile.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipmentMethod")]
    public string? ShipmentMethod { get; init; }
}
