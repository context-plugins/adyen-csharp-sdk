using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Defines a recurring payment type. Required when creating a token to store payment details.
/// Allowed values:
/// * <c>Subscription</c> – A transaction for a fixed or variable amount, which follows a fixed schedule.
/// * <c>CardOnFile</c> – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
/// * <c>UnscheduledCardOnFile</c> – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RecurringProcessingModel1>))]
public sealed record RecurringProcessingModel1 : OpenStringEnum<RecurringProcessingModel1>
{
    private RecurringProcessingModel1(string value) : base(value)
    {
    }

    public static readonly RecurringProcessingModel1 CardOnFile = new("CardOnFile");

    public static readonly RecurringProcessingModel1 Subscription = new("Subscription");

    public static readonly RecurringProcessingModel1 UnscheduledCardOnFile = new("UnscheduledCardOnFile");

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
