using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The region of operation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Region1>))]
public sealed record Region1 : StringEnum<Region1>
{
    private Region1(string value) : base(value)
    {
    }

    public static readonly Region1 Au = new("AU");

    public static readonly Region1 Ch = new("CH");

    public static readonly Region1 Eu = new("EU");

    public static readonly Region1 Na = new("NA");

    public static Region1 FromValue(string value) => FromValueCore(value);
}
