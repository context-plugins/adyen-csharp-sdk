using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of Strong Customer Authentication (SCA). Possible values:
/// * <b>notPerformed</b>: the requester was unable to successfully authenticate the request using SCA, or has an SCA exemption.
/// * <b>pending</b>: the request is pending SCA authentication.
/// * <b>performed</b>: the request is successfully authenticated using SCA.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaStatus>))]
public sealed record ScaStatus : StringEnum<ScaStatus>
{
    private ScaStatus(string value) : base(value)
    {
    }

    public static readonly ScaStatus NotPerformed = new("notPerformed");

    public static readonly ScaStatus Pending = new("pending");

    public static readonly ScaStatus Performed = new("performed");

    public static ScaStatus FromValue(string value) => FromValueCore(value);
}
