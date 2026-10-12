using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of information contained in the attachment: <b>receipt</b>, <b>correspondence</b>, <b>other</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AttachmentType1>))]
public sealed record AttachmentType1 : OpenStringEnum<AttachmentType1>
{
    private AttachmentType1(string value) : base(value)
    {
    }

    public static readonly AttachmentType1 Receipt = new("receipt");

    public static readonly AttachmentType1 Correspondence = new("correspondence");

    public static readonly AttachmentType1 Other = new("other");

    public TResult Match<TResult>(Func<TResult> onReceipt,
        Func<TResult> onCorrespondence,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Receipt => onReceipt(),
            _ when this == Correspondence => onCorrespondence(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onReceipt, Action onCorrespondence, Action onOther, Action<string> otherwise)
    {
        if (this == Receipt) onReceipt();
        else if (this == Correspondence) onCorrespondence();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
