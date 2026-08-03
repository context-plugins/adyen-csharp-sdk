using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// On a terminal that supports 3G or 4G connectivity, indicates the status of the primary SIM card in the terminal.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status32>))]
public sealed record Status32 : StringEnum<Status32>
{
    private Status32(string value) : base(value)
    {
    }

    public static readonly Status32 Activated = new("activated");

    public static readonly Status32 Deactivated = new("deactivated");

    public static readonly Status32 Deprecated = new("deprecated");

    public static readonly Status32 Inventory = new("inventory");

    public static readonly Status32 ReadyForActivation = new("readyForActivation");

    public static Status32 FromValue(string value) => FromValueCore(value);
}
