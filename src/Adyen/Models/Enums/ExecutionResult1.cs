using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the payout execution.
/// <para>
/// Possible values:
/// - <b>succeeded</b>: The payout was sent successfully.
/// - <b>failed</b>: The payout could not be sent because an error occurred.
/// - <b>skipped</b>: The payout was not triggered as expected.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExecutionResult1>))]
public sealed record ExecutionResult1 : OpenStringEnum<ExecutionResult1>
{
    private ExecutionResult1(string value) : base(value)
    {
    }

    public static readonly ExecutionResult1 Failed = new("failed");

    public static readonly ExecutionResult1 Succeeded = new("succeeded");

    public static readonly ExecutionResult1 Skipped = new("skipped");

    public TResult Match<TResult>(Func<TResult> onFailed,
        Func<TResult> onSucceeded,
        Func<TResult> onSkipped,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Failed => onFailed(),
            _ when this == Succeeded => onSucceeded(),
            _ when this == Skipped => onSkipped(),
            _ => otherwise(Value)
        };

    public void Match(Action onFailed, Action onSucceeded, Action onSkipped, Action<string> otherwise)
    {
        if (this == Failed) onFailed();
        else if (this == Succeeded) onSucceeded();
        else if (this == Skipped) onSkipped();
        else otherwise(Value);
    }
}
