using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The processing model used for the recurring transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RecurringProcessingModel7>))]
public sealed record RecurringProcessingModel7 : StringEnum<RecurringProcessingModel7>
{
    private RecurringProcessingModel7(string value) : base(value)
    {
    }

    public static readonly RecurringProcessingModel7 CardOnFile = new("CardOnFile");

    public static readonly RecurringProcessingModel7 Subscription = new("Subscription");

    public static readonly RecurringProcessingModel7 UnscheduledCardOnFile = new("UnscheduledCardOnFile");

    public static RecurringProcessingModel7 FromValue(string value) => FromValueCore(value);
}
