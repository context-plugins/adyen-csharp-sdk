using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the association.
/// <para>
/// Possible values: <b>active</b> or <b>pendingApproval</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssociationStatus1>))]
public sealed record AssociationStatus1 : OpenStringEnum<AssociationStatus1>
{
    private AssociationStatus1(string value) : base(value)
    {
    }

    public static readonly AssociationStatus1 PendingApproval = new("pendingApproval");

    public static readonly AssociationStatus1 Active = new("active");

    public TResult Match<TResult>(Func<TResult> onPendingApproval,
        Func<TResult> onActive,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PendingApproval => onPendingApproval(),
            _ when this == Active => onActive(),
            _ => otherwise(Value)
        };

    public void Match(Action onPendingApproval, Action onActive, Action<string> otherwise)
    {
        if (this == PendingApproval) onPendingApproval();
        else if (this == Active) onActive();
        else otherwise(Value);
    }
}
