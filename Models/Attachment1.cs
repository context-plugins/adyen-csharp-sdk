using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Object that contains the document.
/// </summary>
public record Attachment1
{
    /// <summary>
    /// The document in Base64-encoded string format.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    /// <summary>
    /// The file format.
    /// <para>
    ///  Possible values: <b>application/pdf</b>, <b>image/jpg</b>, <b>image/jpeg</b>, <b>image/png</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contentType")]
    public string? ContentType { get; init; }

    /// <summary>
    /// The name of the file including the file extension.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filename")]
    public string? Filename { get; init; }

    /// <summary>
    /// The name of the file including the file extension.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pageName")]
    public string? PageName { get; init; }

    /// <summary>
    /// Specifies which side of the ID card is uploaded.
    /// <list type="bullet">
    ///   <item><description>If the <c>type</c> is <b>driversLicense</b> or <b>identityCard</b>, you must set this to <b>front</b> or <b>back</b> and include both sides in the same API request.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>For any other types, when this is omitted, we infer the page number based on the order of attachments.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pageType")]
    public string? PageType { get; init; }
}
