using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the details of the payment method will be stored for the shopper. Possible values:
/// * <b>disabled</b> – No details will be stored (default).
/// * <b>askForConsent</b> – If the <c>shopperReference</c> is provided, the Drop-in/Component shows a checkbox where the shopper can select to store their payment details for card payments.
/// * <b>enabled</b> – If the <c>shopperReference</c> is provided, the details will be stored without asking the shopper for consent.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StorePaymentMethodMode>))]
public sealed record StorePaymentMethodMode : StringEnum<StorePaymentMethodMode>
{
    private StorePaymentMethodMode(string value) : base(value)
    {
    }

    public static readonly StorePaymentMethodMode AskForConsent = new("askForConsent");

    public static readonly StorePaymentMethodMode Disabled = new("disabled");

    public static readonly StorePaymentMethodMode Enabled = new("enabled");

    public static StorePaymentMethodMode FromValue(string value) => FromValueCore(value);
}
