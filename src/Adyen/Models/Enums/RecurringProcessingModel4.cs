using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Defines a recurring payment type. Required when <c>storePaymentMethodMode</c> is set to <b>askForConsent</b> or <b>enabled</b>.
/// Possible values:
/// * <b>Subscription</b> – A transaction for a fixed or variable amount, which follows a fixed schedule.
/// * <b>CardOnFile</b> – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
/// * <b>UnscheduledCardOnFile</b> – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RecurringProcessingModel4>))]
public sealed record RecurringProcessingModel4 : OpenStringEnum<RecurringProcessingModel4>
{
    private RecurringProcessingModel4(string value) : base(value)
    {
    }

    public static readonly RecurringProcessingModel4 CardOnFile = new("CardOnFile");

    public static readonly RecurringProcessingModel4 Subscription = new("Subscription");

    public static readonly RecurringProcessingModel4 UnscheduledCardOnFile = new("UnscheduledCardOnFile");

    public TResult Match<TResult>(Func<TResult> onCardOnFile,
        Func<TResult> onSubscription,
        Func<TResult> onUnscheduledCardOnFile,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CardOnFile => onCardOnFile(),
            _ when this == Subscription => onSubscription(),
            _ when this == UnscheduledCardOnFile => onUnscheduledCardOnFile(),
            _ => otherwise(Value)
        };

    public void Match(Action onCardOnFile,
        Action onSubscription,
        Action onUnscheduledCardOnFile,
        Action<string> otherwise)
    {
        if (this == CardOnFile) onCardOnFile();
        else if (this == Subscription) onSubscription();
        else if (this == UnscheduledCardOnFile) onUnscheduledCardOnFile();
        else otherwise(Value);
    }
}
