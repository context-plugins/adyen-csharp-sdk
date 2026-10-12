using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The <see href="https://docs.adyen.com/classic-platforms/verification-process/legal-arrangements#types-of-legal-arrangements">type of legal arrangement</see>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>Association</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Partnership</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>SoleProprietorship</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Trust</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type110>))]
public sealed record Type110 : OpenStringEnum<Type110>
{
    private Type110(string value) : base(value)
    {
    }

    public static readonly Type110 Association = new("Association");

    public static readonly Type110 Partnership = new("Partnership");

    public static readonly Type110 SoleProprietorship = new("SoleProprietorship");

    public static readonly Type110 Trust = new("Trust");

    public TResult Match<TResult>(Func<TResult> onAssociation,
        Func<TResult> onPartnership,
        Func<TResult> onSoleProprietorship,
        Func<TResult> onTrust,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Association => onAssociation(),
            _ when this == Partnership => onPartnership(),
            _ when this == SoleProprietorship => onSoleProprietorship(),
            _ when this == Trust => onTrust(),
            _ => otherwise(Value)
        };

    public void Match(Action onAssociation,
        Action onPartnership,
        Action onSoleProprietorship,
        Action onTrust,
        Action<string> otherwise)
    {
        if (this == Association) onAssociation();
        else if (this == Partnership) onPartnership();
        else if (this == SoleProprietorship) onSoleProprietorship();
        else if (this == Trust) onTrust();
        else otherwise(Value);
    }
}
