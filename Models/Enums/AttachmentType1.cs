using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of information contained in the attachment: <b>receipt</b>, <b>correspondence</b>, <b>other</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AttachmentType1>))]
public sealed record AttachmentType1 : StringEnum<AttachmentType1>
{
    private AttachmentType1(string value) : base(value)
    {
    }

    public static readonly AttachmentType1 Receipt = new("receipt");

    public static readonly AttachmentType1 Correspondence = new("correspondence");

    public static readonly AttachmentType1 Other = new("other");

    public static AttachmentType1 FromValue(string value) => FromValueCore(value);
}
