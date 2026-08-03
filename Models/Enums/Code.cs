using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The code for the status of the grant. Possible values:
/// - <b>Pending</b>
/// - <b>Active</b>
/// - <b>Repaid</b>
/// - <b>WrittenOff</b>
/// - <b>Failed</b>
/// - <b>Revoked</b>
/// - <b>Requested</b>
/// - <b>Reviewing</b>
/// - <b>Approved</b>
/// - <b>Rejected</b>
/// - <b>Cancelled</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Code>))]
public sealed record Code : StringEnum<Code>
{
    private Code(string value) : base(value)
    {
    }

    public static readonly Code Pending = new("Pending");

    public static readonly Code Active = new("Active");

    public static readonly Code Repaid = new("Repaid");

    public static readonly Code WrittenOff = new("WrittenOff");

    public static readonly Code Failed = new("Failed");

    public static readonly Code Revoked = new("Revoked");

    public static readonly Code Requested = new("Requested");

    public static readonly Code Reviewing = new("Reviewing");

    public static readonly Code Approved = new("Approved");

    public static readonly Code Rejected = new("Rejected");

    public static readonly Code Cancelled = new("Cancelled");

    public static Code FromValue(string value) => FromValueCore(value);
}
