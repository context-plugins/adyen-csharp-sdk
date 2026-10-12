using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies a role or capacity of the party in relation to the bank account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartyRole2>))]
public sealed record PartyRole2 : OpenStringEnum<PartyRole2>
{
    private PartyRole2(string value) : base(value)
    {
    }

    public static readonly PartyRole2 Holder = new("HOLDER");

    public static readonly PartyRole2 AuthorizedUser = new("AUTHORIZED_USER");

    public static readonly PartyRole2 Other = new("OTHER");

    public static readonly PartyRole2 Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onHolder,
        Func<TResult> onAuthorizedUser,
        Func<TResult> onOther,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Holder => onHolder(),
            _ when this == AuthorizedUser => onAuthorizedUser(),
            _ when this == Other => onOther(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onHolder,
        Action onAuthorizedUser,
        Action onOther,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Holder) onHolder();
        else if (this == AuthorizedUser) onAuthorizedUser();
        else if (this == Other) onOther();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
