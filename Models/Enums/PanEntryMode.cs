using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the method used for entering the PAN to initiate a transaction.
/// <para>
/// Possible values: <b>manual</b>, <b>chip</b>, <b>magstripe</b>, <b>contactless</b>, <b>cof</b>, <b>ecommerce</b>, <b>token</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PanEntryMode>))]
public sealed record PanEntryMode : StringEnum<PanEntryMode>
{
    private PanEntryMode(string value) : base(value)
    {
    }

    public static readonly PanEntryMode Chip = new("chip");

    public static readonly PanEntryMode Cof = new("cof");

    public static readonly PanEntryMode Contactless = new("contactless");

    public static readonly PanEntryMode Ecommerce = new("ecommerce");

    public static readonly PanEntryMode Magstripe = new("magstripe");

    public static readonly PanEntryMode Manual = new("manual");

    public static readonly PanEntryMode Token = new("token");

    public static PanEntryMode FromValue(string value) => FromValueCore(value);
}
