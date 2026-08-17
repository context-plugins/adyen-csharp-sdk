using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the verification process for the bank account.
/// <para>
/// Possible values:
/// * <b>valid</b>: the verification was successful.
/// * <b>pending</b>: the verification is in progress.
/// * <b>invalid</b>: the information provided is not complete.
/// * <b>rejected</b>:  there are reasons to refuse working with this entity.
/// </para>
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
