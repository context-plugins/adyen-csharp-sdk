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
public sealed record StorePaymentMethodMode2 : StringEnum<StorePaymentMethodMode2>
{
    private StorePaymentMethodMode2(string value) : base(value)
    {
    }

    public static readonly StorePaymentMethodMode2 AskForConsent = new("askForConsent");

    public static readonly StorePaymentMethodMode2 Disabled = new("disabled");

    public static readonly StorePaymentMethodMode2 Enabled = new("enabled");

    public static StorePaymentMethodMode2 FromValue(string value) => FromValueCore(value);
}
