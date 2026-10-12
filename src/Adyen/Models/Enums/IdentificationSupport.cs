using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Support of the loyalty account identification. Allows knowing where and how you have found the loyalty account identification.
/// Possible values:
/// * <b>NoCard</b>
/// * <b>LoyaltyCard</b>
/// * <b>HybridCard</b>
/// * <b>LinkedCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationSupport>))]
public sealed record IdentificationSupport : OpenStringEnum<IdentificationSupport>
{
    private IdentificationSupport(string value) : base(value)
    {
    }

    public static readonly IdentificationSupport NoCard = new("NoCard");

    public static readonly IdentificationSupport LoyaltyCard = new("LoyaltyCard");

    public static readonly IdentificationSupport HybridCard = new("HybridCard");

    public static readonly IdentificationSupport LinkedCard = new("LinkedCard");

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
