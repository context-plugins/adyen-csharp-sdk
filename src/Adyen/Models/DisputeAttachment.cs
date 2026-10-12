using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DisputeAttachment
{
    /// <summary>
    /// The type of information contained in the attachment: <b>receipt</b>, <b>correspondence</b>, <b>other</b>.
    /// </summary>
    [JsonPropertyName("attachmentType")]
    public required AttachmentType1 AttachmentType { get; init; }

    /// <summary>
    /// The content of the image. An attachment must be base64-encoded data. Make sure that all base64-encoded data strings are generated without line breaks or "wrapping". For example, do not use <c>Base64.NO_WRAP</c> in Java, or its equivalent in other languages. Newline characters at the end of the base64-encoded data string will also result in a malformed input error.
    /// </summary>
    [JsonPropertyName("content")]
    [MinLength(1)]
    public required string Content { get; init; }

    /// <summary>
    /// The name of the attachment, including its filename extension. Supported filename extensions: <b>jpeg</b>, <b>pdf</b>, <b>tiff</b>.
    /// </summary>
    [JsonPropertyName("fileName")]
    [StringLength(17, MinimumLength = 4)]
    [RegularExpression("([^\\s]+(\\.(?i)(jpeg|tiff|pdf))$)")]
    public required string FileName { get; init; }

    /// <summary>
    /// The unique identifier of the attachment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
