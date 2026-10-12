using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of instalment transaction. For requesting an instalment payment transaction.
/// Possible values:
/// * <b>DeferredInstalments</b>
/// * <b>EqualInstalments</b>
/// * <b>InequalInstalments</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InstalmentType>))]
public sealed record InstalmentType : OpenStringEnum<InstalmentType>
{
    private InstalmentType(string value) : base(value)
    {
    }

    public static readonly InstalmentType DeferredInstalments = new("DeferredInstalments");

    public static readonly InstalmentType EqualInstalments = new("EqualInstalments");

    public static readonly InstalmentType InequalInstalments = new("InequalInstalments");

    public TResult Match<TResult>(Func<TResult> onDeferredInstalments,
        Func<TResult> onEqualInstalments,
        Func<TResult> onInequalInstalments,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DeferredInstalments => onDeferredInstalments(),
            _ when this == EqualInstalments => onEqualInstalments(),
            _ when this == InequalInstalments => onInequalInstalments(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeferredInstalments,
        Action onEqualInstalments,
        Action onInequalInstalments,
        Action<string> otherwise)
    {
        if (this == DeferredInstalments) onDeferredInstalments();
        else if (this == EqualInstalments) onEqualInstalments();
        else if (this == InequalInstalments) onInequalInstalments();
        else otherwise(Value);
    }
}
