using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>GiftCard</b>
/// * <b>PhoneCard</b>
/// * <b>Other</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueAccountType>))]
public sealed record StoredValueAccountType : OpenStringEnum<StoredValueAccountType>
{
    private StoredValueAccountType(string value) : base(value)
    {
    }

    public static readonly StoredValueAccountType GiftCard = new("GiftCard");

    public static readonly StoredValueAccountType PhoneCard = new("PhoneCard");

    public static readonly StoredValueAccountType Other = new("Other");

    public TResult Match<TResult>(Func<TResult> onGiftCard,
        Func<TResult> onPhoneCard,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GiftCard => onGiftCard(),
            _ when this == PhoneCard => onPhoneCard(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onGiftCard, Action onPhoneCard, Action onOther, Action<string> otherwise)
    {
        if (this == GiftCard) onGiftCard();
        else if (this == PhoneCard) onPhoneCard();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
