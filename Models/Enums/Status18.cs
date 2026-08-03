using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The current status of the grant. Possible values: <b>Pending</b>, <b>Active</b>, <b>Repaid</b>, <b>WrittenOff</b>, <b>Failed</b>, <b>Revoked</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status18>))]
public sealed record Status18 : StringEnum<Status18>
{
    private Status18(string value) : base(value)
    {
    }

    public static readonly Status18 Pending = new("Pending");

    public static readonly Status18 Active = new("Active");

    public static readonly Status18 Repaid = new("Repaid");

    public static readonly Status18 Failed = new("Failed");

    public static readonly Status18 WrittenOff = new("WrittenOff");

    public static readonly Status18 Revoked = new("Revoked");

    public static Status18 FromValue(string value) => FromValueCore(value);
}
