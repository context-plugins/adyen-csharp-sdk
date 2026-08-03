using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to <see href="https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata">3D Secure API reference</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChallengeCancel>))]
public sealed record ChallengeCancel : StringEnum<ChallengeCancel>
{
    private ChallengeCancel(string value) : base(value)
    {
    }

    public static readonly ChallengeCancel _01 = new("01");

    public static readonly ChallengeCancel _02 = new("02");

    public static readonly ChallengeCancel _03 = new("03");

    public static readonly ChallengeCancel _04 = new("04");

    public static readonly ChallengeCancel _05 = new("05");

    public static readonly ChallengeCancel _06 = new("06");

    public static readonly ChallengeCancel _07 = new("07");

    public static ChallengeCancel FromValue(string value) => FromValueCore(value);
}
