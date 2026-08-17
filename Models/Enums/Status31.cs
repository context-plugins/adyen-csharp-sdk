using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// On a terminal that supports 3G or 4G connectivity, indicates the status of the primary SIM card in the terminal.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status31>))]
public sealed record Status31 : StringEnum<Status31>
{
    private Status31(string value) : base(value)
    {
    }

    public static readonly Status31 Activated = new("activated");

    public static readonly Status31 Deactivated = new("deactivated");

    public static readonly Status31 Deprecated = new("deprecated");

    public static readonly Status31 Inventory = new("inventory");

    public static readonly Status31 ReadyForActivation = new("readyForActivation");

    public static Status31 FromValue(string value) => FromValueCore(value);
}
