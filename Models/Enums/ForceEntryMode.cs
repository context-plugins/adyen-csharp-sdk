using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ForceEntryMode>))]
public sealed record ForceEntryMode : StringEnum<ForceEntryMode>
{
    private ForceEntryMode(string value) : base(value)
    {
    }

    public static readonly ForceEntryMode Rfid = new("RFID");

    public static readonly ForceEntryMode Keyed = new("Keyed");

    public static readonly ForceEntryMode Manual = new("Manual");

    public static readonly ForceEntryMode File = new("File");

    public static readonly ForceEntryMode Scanned = new("Scanned");

    public static readonly ForceEntryMode MagStripe = new("MagStripe");

    public static readonly ForceEntryMode Icc = new("ICC");

    public static readonly ForceEntryMode SynchronousIcc = new("SynchronousICC");

    public static readonly ForceEntryMode Tapped = new("Tapped");

    public static readonly ForceEntryMode Contactless = new("Contactless");

    public static readonly ForceEntryMode CheckReader = new("CheckReader");

    public static ForceEntryMode FromValue(string value) => FromValueCore(value);
}
