using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SdkUiType>))]
public sealed record SdkUiType : OpenStringEnum<SdkUiType>
{
    private SdkUiType(string value) : base(value)
    {
    }

    public static readonly SdkUiType MultiSelect = new("multiSelect");

    public static readonly SdkUiType OtherHtml = new("otherHtml");

    public static readonly SdkUiType OutOfBand = new("outOfBand");

    public static readonly SdkUiType SingleSelect = new("singleSelect");

    public static readonly SdkUiType Text = new("text");

    public TResult Match<TResult>(Func<TResult> onMultiSelect,
        Func<TResult> onOtherHtml,
        Func<TResult> onOutOfBand,
        Func<TResult> onSingleSelect,
        Func<TResult> onText,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MultiSelect => onMultiSelect(),
            _ when this == OtherHtml => onOtherHtml(),
            _ when this == OutOfBand => onOutOfBand(),
            _ when this == SingleSelect => onSingleSelect(),
            _ when this == Text => onText(),
            _ => otherwise(Value)
        };

    public void Match(Action onMultiSelect,
        Action onOtherHtml,
        Action onOutOfBand,
        Action onSingleSelect,
        Action onText,
        Action<string> otherwise)
    {
        if (this == MultiSelect) onMultiSelect();
        else if (this == OtherHtml) onOtherHtml();
        else if (this == OutOfBand) onOutOfBand();
        else if (this == SingleSelect) onSingleSelect();
        else if (this == Text) onText();
        else otherwise(Value);
    }
}
