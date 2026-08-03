using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Informs you if the name validation was performed. Possible values:
/// <para>
/// <b>performed</b>, <b>notPerformed</b>, <b>notSupported</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status11>))]
public sealed record Status11 : StringEnum<Status11>
{
    private Status11(string value) : base(value)
    {
    }

    public static readonly Status11 NotPerformed = new("notPerformed");

    public static readonly Status11 NotSupported = new("notSupported");

    public static readonly Status11 Performed = new("performed");

    public static Status11 FromValue(string value) => FromValueCore(value);
}
