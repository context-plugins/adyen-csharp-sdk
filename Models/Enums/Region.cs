using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The region of operation. For example, <b>NA</b>, <b>EU</b>, <b>CH</b>, <b>AU</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Region>))]
public sealed record Region : StringEnum<Region>
{
    private Region(string value) : base(value)
    {
    }

    public static readonly Region Na = new("NA");

    public static readonly Region Eu = new("EU");

    public static readonly Region Ch = new("CH");

    public static readonly Region Au = new("AU");

    public static Region FromValue(string value) => FromValueCore(value);
}
