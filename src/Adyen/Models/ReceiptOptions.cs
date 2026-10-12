using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ReceiptOptions
{
    /// <summary>
    /// The text of the first header line to be shown on the receipt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headerLine1")]
    [MaxLength(100)]
    public string? HeaderLine1 { get; init; }

    /// <summary>
    /// The text of the second header line to be shown on the receipt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headerLine2")]
    [MaxLength(100)]
    public string? HeaderLine2 { get; init; }

    /// <summary>
    /// The receipt logo converted to a Base64-encoded string. The image must be a .bmp file of &lt; 256 KB, dimensions 240 (H) x 384 (W) px.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    [MaxLength(350000)]
    public string? Logo { get; init; }

    /// <summary>
    /// Indicates whether a screen appears asking if you want to print the shopper receipt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promptBeforePrinting")]
    public bool? PromptBeforePrinting { get; init; }

    /// <summary>
    /// Data to print on the receipt as a QR code. This can include static text and the following variables:
    /// <list type="bullet">
    ///   <item><description><c>${merchantreference}</c>: the merchant reference of the transaction.</description></item>
    ///   <item><description><c>${pspreference}</c>: the PSP reference of the transaction.</description></item>
    /// </list>
    /// <para>
    ///  For example, <b>http://www.example.com/order/${pspreference}/${merchantreference}</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qrCodeData")]
    public string? QrCodeData { get; init; }
}
