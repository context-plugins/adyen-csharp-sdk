using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ExecutionResult>))]
public sealed record ExecutionResult : OpenStringEnum<ExecutionResult>
{
    private ExecutionResult(string value) : base(value)
    {
    }

    public static readonly ExecutionResult Failed = new("failed");

    public static readonly ExecutionResult Succeeded = new("succeeded");

    public static readonly ExecutionResult Skipped = new("skipped");

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
