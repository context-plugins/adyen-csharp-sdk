using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AssociationStatus>))]
public sealed record AssociationStatus : OpenStringEnum<AssociationStatus>
{
    private AssociationStatus(string value) : base(value)
    {
    }

    public static readonly AssociationStatus PendingApproval = new("pendingApproval");

    public static readonly AssociationStatus Active = new("active");

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
