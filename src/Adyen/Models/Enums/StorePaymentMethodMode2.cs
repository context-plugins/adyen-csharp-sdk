using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the details of the payment method will be stored for the shopper. Possible values:
/// * <b>disabled</b> – No details will be stored (default).
/// * <b>askForConsent</b> – If the <c>shopperReference</c> is provided, the Drop-in/Component shows a checkbox where the shopper can select to store their payment details for card payments.
/// * <b>enabled</b> – If the <c>shopperReference</c> is provided, the details will be stored without asking the shopper for consent.
///  When set to <b>askForConsent</b> or <b>enabled</b>, you must also include the <c>recurringProcessingModel</c> parameter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StorePaymentMethodMode2>))]
public sealed record StorePaymentMethodMode2 : OpenStringEnum<StorePaymentMethodMode2>
{
    private StorePaymentMethodMode2(string value) : base(value)
    {
    }

    public static readonly StorePaymentMethodMode2 AskForConsent = new("askForConsent");

    public static readonly StorePaymentMethodMode2 Disabled = new("disabled");

    public static readonly StorePaymentMethodMode2 Enabled = new("enabled");

    public TResult Match<TResult>(Func<TResult> onAskForConsent,
        Func<TResult> onDisabled,
        Func<TResult> onEnabled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AskForConsent => onAskForConsent(),
            _ when this == Disabled => onDisabled(),
            _ when this == Enabled => onEnabled(),
            _ => otherwise(Value)
        };

    public void Match(Action onAskForConsent, Action onDisabled, Action onEnabled, Action<string> otherwise)
    {
        if (this == AskForConsent) onAskForConsent();
        else if (this == Disabled) onDisabled();
        else if (this == Enabled) onEnabled();
        else otherwise(Value);
    }
}
