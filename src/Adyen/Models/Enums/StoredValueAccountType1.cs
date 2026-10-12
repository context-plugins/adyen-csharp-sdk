using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of stored value account. Allows the distinction of the stored value instrument to access the stored value account.
/// Possible values:
/// * <b>GiftCard</b>
/// * <b>Other</b>
/// * <b>PhoneCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueAccountType1>))]
public sealed record StoredValueAccountType1 : OpenStringEnum<StoredValueAccountType1>
{
    private StoredValueAccountType1(string value) : base(value)
    {
    }

    public static readonly StoredValueAccountType1 GiftCard = new("GiftCard");

    public static readonly StoredValueAccountType1 PhoneCard = new("PhoneCard");

    public static readonly StoredValueAccountType1 Other = new("Other");

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
