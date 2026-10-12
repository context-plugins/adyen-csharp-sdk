using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Shows the status of the Strong Customer Authentication (SCA) process.
/// <para>
/// Possible values: <b>required</b>, <b>notApplicable</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaOnApproval>))]
public sealed record ScaOnApproval : OpenStringEnum<ScaOnApproval>
{
    private ScaOnApproval(string value) : base(value)
    {
    }

    public static readonly ScaOnApproval Completed = new("completed");

    public static readonly ScaOnApproval NotApplicable = new("notApplicable");

    public static readonly ScaOnApproval Required = new("required");

    public TResult Match<TResult>(Func<TResult> onCompleted,
        Func<TResult> onNotApplicable,
        Func<TResult> onRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Completed => onCompleted(),
            _ when this == NotApplicable => onNotApplicable(),
            _ when this == Required => onRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompleted, Action onNotApplicable, Action onRequired, Action<string> otherwise)
    {
        if (this == Completed) onCompleted();
        else if (this == NotApplicable) onNotApplicable();
        else if (this == Required) onRequired();
        else otherwise(Value);
    }
}
