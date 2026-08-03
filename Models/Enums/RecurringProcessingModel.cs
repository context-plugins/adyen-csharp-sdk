using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Defines a recurring payment type. Required when creating a token to store payment details or using stored payment details.
/// Allowed values:
/// * <c>Subscription</c> – A transaction for a fixed or variable amount, which follows a fixed schedule.
/// * <c>CardOnFile</c> – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
/// * <c>UnscheduledCardOnFile</c> – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RecurringProcessingModel>))]
public sealed record RecurringProcessingModel : StringEnum<RecurringProcessingModel>
{
    private RecurringProcessingModel(string value) : base(value)
    {
    }

    public static readonly RecurringProcessingModel CardOnFile = new("CardOnFile");

    public static readonly RecurringProcessingModel Subscription = new("Subscription");

    public static readonly RecurringProcessingModel UnscheduledCardOnFile = new("UnscheduledCardOnFile");

    public static RecurringProcessingModel FromValue(string value) => FromValueCore(value);
}
