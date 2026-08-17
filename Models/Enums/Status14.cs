using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The current status of the grant. Possible values: <b>Pending</b>, <b>Active</b>, <b>Repaid</b>, <b>WrittenOff</b>, <b>Failed</b>, <b>Revoked</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status14>))]
public sealed record Status14 : StringEnum<Status14>
{
    private Status14(string value) : base(value)
    {
    }

    public static readonly Status14 Pending = new("Pending");

    public static readonly Status14 Active = new("Active");

    public static readonly Status14 Repaid = new("Repaid");

    public static readonly Status14 Failed = new("Failed");

    public static readonly Status14 WrittenOff = new("WrittenOff");

    public static readonly Status14 Revoked = new("Revoked");

    public static Status14 FromValue(string value) => FromValueCore(value);
}
