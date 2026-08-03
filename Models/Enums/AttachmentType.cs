using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AttachmentType>))]
public sealed record AttachmentType : StringEnum<AttachmentType>
{
    private AttachmentType(string value) : base(value)
    {
    }

    public static readonly AttachmentType Receipt = new("receipt");

    public static readonly AttachmentType Correspondence = new("correspondence");

    public static readonly AttachmentType Other = new("other");

    public static AttachmentType FromValue(string value) => FromValueCore(value);
}
