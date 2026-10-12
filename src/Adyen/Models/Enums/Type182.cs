using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of legal entity.
/// <para>
/// Possible values: <b>individual</b>, <b>organization</b>, <b>soleProprietorship</b>, or <b>trust</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type182>))]
public sealed record Type182 : OpenStringEnum<Type182>
{
    private Type182(string value) : base(value)
    {
    }

    public static readonly Type182 Individual = new("individual");

    public static readonly Type182 Organization = new("organization");

    public static readonly Type182 SoleProprietorship = new("soleProprietorship");

    public static readonly Type182 Trust = new("trust");

    public static readonly Type182 UnincorporatedPartnership = new("unincorporatedPartnership");

    public TResult Match<TResult>(Func<TResult> onIndividual,
        Func<TResult> onOrganization,
        Func<TResult> onSoleProprietorship,
        Func<TResult> onTrust,
        Func<TResult> onUnincorporatedPartnership,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Individual => onIndividual(),
            _ when this == Organization => onOrganization(),
            _ when this == SoleProprietorship => onSoleProprietorship(),
            _ when this == Trust => onTrust(),
            _ when this == UnincorporatedPartnership => onUnincorporatedPartnership(),
            _ => otherwise(Value)
        };

    public void Match(Action onIndividual,
        Action onOrganization,
        Action onSoleProprietorship,
        Action onTrust,
        Action onUnincorporatedPartnership,
        Action<string> otherwise)
    {
        if (this == Individual) onIndividual();
        else if (this == Organization) onOrganization();
        else if (this == SoleProprietorship) onSoleProprietorship();
        else if (this == Trust) onTrust();
        else if (this == UnincorporatedPartnership) onUnincorporatedPartnership();
        else otherwise(Value);
    }
}
