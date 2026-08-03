using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the verification checks for the capability.
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
[JsonConverter(typeof(StringEnumConverter<VerificationStatus1>))]
public sealed record VerificationStatus1 : StringEnum<VerificationStatus1>
{
    private VerificationStatus1(string value) : base(value)
    {
    }

    public static readonly VerificationStatus1 Invalid = new("invalid");

    public static readonly VerificationStatus1 Pending = new("pending");

    public static readonly VerificationStatus1 Rejected = new("rejected");

    public static readonly VerificationStatus1 Valid = new("valid");

    public static VerificationStatus1 FromValue(string value) => FromValueCore(value);
}
