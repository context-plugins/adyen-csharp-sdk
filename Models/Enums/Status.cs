using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Informs you if the name validation was performed. Possible values:
/// <para>
/// <b>performed</b>, <b>notPerformed</b>, <b>notSupported</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : StringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status NotPerformed = new("notPerformed");

    public static readonly Status NotSupported = new("notSupported");

    public static readonly Status Performed = new("performed");

    public static Status FromValue(string value) => FromValueCore(value);
}
