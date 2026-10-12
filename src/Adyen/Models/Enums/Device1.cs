using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>CashierDisplay</b>
/// * <b>CustomerDisplay</b>
/// * <b>CashierInput</b>
/// * <b>CustomerInput</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Device1>))]
public sealed record Device1 : OpenStringEnum<Device1>
{
    private Device1(string value) : base(value)
    {
    }

    public static readonly Device1 CashierDisplay = new("CashierDisplay");

    public static readonly Device1 CustomerDisplay = new("CustomerDisplay");

    public static readonly Device1 CashierInput = new("CashierInput");

    public static readonly Device1 CustomerInput = new("CustomerInput");

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
