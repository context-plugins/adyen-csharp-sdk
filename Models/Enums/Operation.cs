using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of string matching operation. Possible values:  <b>startsWith</b>, <b>endsWith</b>, <b>isEqualTo</b>, <b>contains</b>,
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Operation>))]
public sealed record Operation : StringEnum<Operation>
{
    private Operation(string value) : base(value)
    {
    }

    public static readonly Operation Contains = new("contains");

    public static readonly Operation EndsWith = new("endsWith");

    public static readonly Operation IsEqualTo = new("isEqualTo");

    public static readonly Operation StartsWith = new("startsWith");

    public static Operation FromValue(string value) => FromValueCore(value);
}
