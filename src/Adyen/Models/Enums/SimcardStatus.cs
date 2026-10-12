using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the status of the SIM card in the payment terminal. Can be updated and received only at terminal level, and only for models that support cellular connectivity.
/// <para>
/// Possible values:
/// * <b>ACTIVATED</b>: the SIM card is activated. Cellular connectivity may still need to be enabled on the terminal itself, in the <b>Network</b> settings.
/// * <b>INVENTORY</b>: the SIM card is not activated. The terminal can't use cellular connectivity.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SimcardStatus>))]
public sealed record SimcardStatus : OpenStringEnum<SimcardStatus>
{
    private SimcardStatus(string value) : base(value)
    {
    }

    public static readonly SimcardStatus Activated = new("ACTIVATED");

    public static readonly SimcardStatus Inventory = new("INVENTORY");

    public TResult Match<TResult>(Func<TResult> onActivated,
        Func<TResult> onInventory,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Activated => onActivated(),
            _ when this == Inventory => onInventory(),
            _ => otherwise(Value)
        };

    public void Match(Action onActivated, Action onInventory, Action<string> otherwise)
    {
        if (this == Activated) onActivated();
        else if (this == Inventory) onInventory();
        else otherwise(Value);
    }
}
