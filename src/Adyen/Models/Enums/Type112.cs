using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of entity that owns the bank account or card.
/// <para>
/// Possible values: <b>individual</b>, <b>organization</b>, or <b>unknown</b>.
/// </para>
/// <para>
/// Required when <c>category</c> is <b>card</b>. In this case, the value must be <b>individual</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type112>))]
public sealed record Type112 : OpenStringEnum<Type112>
{
    private Type112(string value) : base(value)
    {
    }

    public static readonly Type112 Individual = new("individual");

    public static readonly Type112 Organization = new("organization");

    public static readonly Type112 Unknown = new("unknown");

    public TResult Match<TResult>(Func<TResult> onIndividual,
        Func<TResult> onOrganization,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Individual => onIndividual(),
            _ when this == Organization => onOrganization(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onIndividual, Action onOrganization, Action onUnknown, Action<string> otherwise)
    {
        if (this == Individual) onIndividual();
        else if (this == Organization) onOrganization();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
