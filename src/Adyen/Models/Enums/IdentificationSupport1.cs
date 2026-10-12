using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Support of the loyalty account identification. Allows knowing where and how you have found the loyalty account identification.
/// Possible values:
/// * <b>HybridCard</b>
/// * <b>LinkedCard</b>
/// * <b>LoyaltyCard</b>
/// * <b>NoCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationSupport1>))]
public sealed record IdentificationSupport1 : OpenStringEnum<IdentificationSupport1>
{
    private IdentificationSupport1(string value) : base(value)
    {
    }

    public static readonly IdentificationSupport1 NoCard = new("NoCard");

    public static readonly IdentificationSupport1 LoyaltyCard = new("LoyaltyCard");

    public static readonly IdentificationSupport1 HybridCard = new("HybridCard");

    public static readonly IdentificationSupport1 LinkedCard = new("LinkedCard");

    public TResult Match<TResult>(Func<TResult> onNoCard,
        Func<TResult> onLoyaltyCard,
        Func<TResult> onHybridCard,
        Func<TResult> onLinkedCard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoCard => onNoCard(),
            _ when this == LoyaltyCard => onLoyaltyCard(),
            _ when this == HybridCard => onHybridCard(),
            _ when this == LinkedCard => onLinkedCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoCard,
        Action onLoyaltyCard,
        Action onHybridCard,
        Action onLinkedCard,
        Action<string> otherwise)
    {
        if (this == NoCard) onNoCard();
        else if (this == LoyaltyCard) onLoyaltyCard();
        else if (this == HybridCard) onHybridCard();
        else if (this == LinkedCard) onLinkedCard();
        else otherwise(Value);
    }
}
