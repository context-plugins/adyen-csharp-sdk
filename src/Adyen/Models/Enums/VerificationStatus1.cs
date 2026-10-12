using System;
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
public sealed record VerificationStatus1 : OpenStringEnum<VerificationStatus1>
{
    private VerificationStatus1(string value) : base(value)
    {
    }

    public static readonly VerificationStatus1 Invalid = new("invalid");

    public static readonly VerificationStatus1 Pending = new("pending");

    public static readonly VerificationStatus1 Rejected = new("rejected");

    public static readonly VerificationStatus1 Valid = new("valid");

    public TResult Match<TResult>(Func<TResult> onInvalid,
        Func<TResult> onPending,
        Func<TResult> onRejected,
        Func<TResult> onValid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Invalid => onInvalid(),
            _ when this == Pending => onPending(),
            _ when this == Rejected => onRejected(),
            _ when this == Valid => onValid(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvalid, Action onPending, Action onRejected, Action onValid, Action<string> otherwise)
    {
        if (this == Invalid) onInvalid();
        else if (this == Pending) onPending();
        else if (this == Rejected) onRejected();
        else if (this == Valid) onValid();
        else otherwise(Value);
    }
}
