using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PartyRole>))]
public sealed record PartyRole : OpenStringEnum<PartyRole>
{
    private PartyRole(string value) : base(value)
    {
    }

    public static readonly PartyRole Holder = new("HOLDER");

    public static readonly PartyRole AuthorizedUser = new("AUTHORIZED_USER");

    public static readonly PartyRole Other = new("OTHER");

    public static readonly PartyRole Unknown = new("UNKNOWN");

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
