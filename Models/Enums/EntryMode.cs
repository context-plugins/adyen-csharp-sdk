using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntryMode>))]
public sealed record EntryMode : StringEnum<EntryMode>
{
    private EntryMode(string value) : base(value)
    {
    }

    public static readonly EntryMode Rfid = new("RFID");

    public static readonly EntryMode Keyed = new("Keyed");

    public static readonly EntryMode Manual = new("Manual");

    public static readonly EntryMode File = new("File");

    public static readonly EntryMode Scanned = new("Scanned");

    public static readonly EntryMode MagStripe = new("MagStripe");

    public static readonly EntryMode Icc = new("ICC");

    public static readonly EntryMode SynchronousIcc = new("SynchronousICC");

    public static readonly EntryMode Tapped = new("Tapped");

    public static readonly EntryMode Contactless = new("Contactless");

    public static readonly EntryMode Mobile = new("Mobile");

    public static EntryMode FromValue(string value) => FromValueCore(value);
}
