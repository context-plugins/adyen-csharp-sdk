using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier or the Customer.
/// Copy.
/// Possible values:
/// * <b>CashierDisplay</b>
/// * <b>CashierInput</b>
/// * <b>CustomerDisplay</b>
/// * <b>CustomerInput</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Device3>))]
public sealed record Device3 : OpenStringEnum<Device3>
{
    private Device3(string value) : base(value)
    {
    }

    public static readonly Device3 CashierDisplay = new("CashierDisplay");

    public static readonly Device3 CustomerDisplay = new("CustomerDisplay");

    public static readonly Device3 CashierInput = new("CashierInput");

    public static readonly Device3 CustomerInput = new("CustomerInput");

    public TResult Match<TResult>(Func<TResult> onCashierDisplay,
        Func<TResult> onCustomerDisplay,
        Func<TResult> onCashierInput,
        Func<TResult> onCustomerInput,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CashierDisplay => onCashierDisplay(),
            _ when this == CustomerDisplay => onCustomerDisplay(),
            _ when this == CashierInput => onCashierInput(),
            _ when this == CustomerInput => onCustomerInput(),
            _ => otherwise(Value)
        };

    public void Match(Action onCashierDisplay,
        Action onCustomerDisplay,
        Action onCashierInput,
        Action onCustomerInput,
        Action<string> otherwise)
    {
        if (this == CashierDisplay) onCashierDisplay();
        else if (this == CustomerDisplay) onCustomerDisplay();
        else if (this == CashierInput) onCashierInput();
        else if (this == CustomerInput) onCustomerInput();
        else otherwise(Value);
    }
}
