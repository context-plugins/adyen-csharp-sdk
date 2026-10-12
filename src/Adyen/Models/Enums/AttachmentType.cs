using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AttachmentType>))]
public sealed record AttachmentType : OpenStringEnum<AttachmentType>
{
    private AttachmentType(string value) : base(value)
    {
    }

    public static readonly AttachmentType Receipt = new("receipt");

    public static readonly AttachmentType Correspondence = new("correspondence");

    public static readonly AttachmentType Other = new("other");

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
