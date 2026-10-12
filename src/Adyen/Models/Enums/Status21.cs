using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the reassignment. Possible values:
///  * <c>reassignmentInProgress</c>: the terminal was boarded and is now scheduled to remove the configuration. Wait for the terminal to synchronize with the Adyen platform.
///  * <c>deployed</c>: the terminal is deployed and reassigned.
///  * <c>inventory</c>: the terminal is in inventory and cannot process transactions.
///  * <c>boarded</c>: the terminal is boarded to a store, or a merchant account representing a store, and can process transactions.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status21>))]
public sealed record Status21 : OpenStringEnum<Status21>
{
    private Status21(string value) : base(value)
    {
    }

    public static readonly Status21 Boarded = new("boarded");

    public static readonly Status21 Deployed = new("deployed");

    public static readonly Status21 Inventory = new("inventory");

    public static readonly Status21 ReassignmentInProgress = new("reassignmentInProgress");

    public TResult Match<TResult>(Func<TResult> onBoarded,
        Func<TResult> onDeployed,
        Func<TResult> onInventory,
        Func<TResult> onReassignmentInProgress,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Boarded => onBoarded(),
            _ when this == Deployed => onDeployed(),
            _ when this == Inventory => onInventory(),
            _ when this == ReassignmentInProgress => onReassignmentInProgress(),
            _ => otherwise(Value)
        };

    public void Match(Action onBoarded,
        Action onDeployed,
        Action onInventory,
        Action onReassignmentInProgress,
        Action<string> otherwise)
    {
        if (this == Boarded) onBoarded();
        else if (this == Deployed) onDeployed();
        else if (this == Inventory) onInventory();
        else if (this == ReassignmentInProgress) onReassignmentInProgress();
        else otherwise(Value);
    }
}
