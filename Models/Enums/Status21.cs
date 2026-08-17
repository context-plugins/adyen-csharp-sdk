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
public sealed record Status21 : StringEnum<Status21>
{
    private Status21(string value) : base(value)
    {
    }

    public static readonly Status21 Boarded = new("boarded");

    public static readonly Status21 Deployed = new("deployed");

    public static readonly Status21 Inventory = new("inventory");

    public static readonly Status21 ReassignmentInProgress = new("reassignmentInProgress");

    public static Status21 FromValue(string value) => FromValueCore(value);
}
