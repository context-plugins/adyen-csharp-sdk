using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the verification checks for the supporting entity capability.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>pending</b>: Adyen is running the verification.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>invalid</b>: The verification failed. Check if the <c>errors</c> array contains more information.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>valid</b>: The verification has been successfully completed.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>rejected</b>: Adyen has verified the information, but found reasons to not allow the capability.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus>))]
public sealed record VerificationStatus : StringEnum<VerificationStatus>
{
    private VerificationStatus(string value) : base(value)
    {
    }

    public static readonly VerificationStatus Invalid = new("invalid");

    public static readonly VerificationStatus Pending = new("pending");

    public static readonly VerificationStatus Rejected = new("rejected");

    public static readonly VerificationStatus Valid = new("valid");

    public static VerificationStatus FromValue(string value) => FromValueCore(value);
}
