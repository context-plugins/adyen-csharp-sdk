using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Payment method status. Possible values:
/// * <b>valid</b>
/// * <b>pending</b>
/// * <b>invalid</b>
/// * <b>rejected</b>, The status of the verification checks for the supporting entity capability.
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
///   <item><description><b>rejected</b>: Adyen has verified the information, but found reasons to not allow the capability., The status of the verification checks for the capability.</description></item>
/// </list>
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
public sealed record VerificationStatus : OpenStringEnum<VerificationStatus>
{
    private VerificationStatus(string value) : base(value)
    {
    }

    public static readonly VerificationStatus Valid = new("valid");

    public static readonly VerificationStatus Pending = new("pending");

    public static readonly VerificationStatus Invalid = new("invalid");

    public static readonly VerificationStatus Rejected = new("rejected");

    public TResult Match<TResult>(Func<TResult> onValid,
        Func<TResult> onPending,
        Func<TResult> onInvalid,
        Func<TResult> onRejected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Valid => onValid(),
            _ when this == Pending => onPending(),
            _ when this == Invalid => onInvalid(),
            _ when this == Rejected => onRejected(),
            _ => otherwise(Value)
        };

    public void Match(Action onValid, Action onPending, Action onInvalid, Action onRejected, Action<string> otherwise)
    {
        if (this == Valid) onValid();
        else if (this == Pending) onPending();
        else if (this == Invalid) onInvalid();
        else if (this == Rejected) onRejected();
        else otherwise(Value);
    }
}
