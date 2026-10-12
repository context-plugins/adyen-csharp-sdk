using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the document. Possible values: <b>ID</b>, <b>DRIVINGLICENSE</b>, <b>PASSPORT</b>, <b>SOCIALSECURITY</b>, <b>VISA</b>.
/// <para>
/// To delete an existing entry for a document <c>type</c>, send only the <c>type</c> field in your request.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type15>))]
public sealed record Type15 : OpenStringEnum<Type15>
{
    private Type15(string value) : base(value)
    {
    }

    public static readonly Type15 Drivinglicense = new("DRIVINGLICENSE");

    public static readonly Type15 Id = new("ID");

    public static readonly Type15 Passport = new("PASSPORT");

    public static readonly Type15 Socialsecurity = new("SOCIALSECURITY");

    public static readonly Type15 Visa = new("VISA");

    public TResult Match<TResult>(Func<TResult> onDrivinglicense,
        Func<TResult> onId,
        Func<TResult> onPassport,
        Func<TResult> onSocialsecurity,
        Func<TResult> onVisa,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Drivinglicense => onDrivinglicense(),
            _ when this == Id => onId(),
            _ when this == Passport => onPassport(),
            _ when this == Socialsecurity => onSocialsecurity(),
            _ when this == Visa => onVisa(),
            _ => otherwise(Value)
        };

    public void Match(Action onDrivinglicense,
        Action onId,
        Action onPassport,
        Action onSocialsecurity,
        Action onVisa,
        Action<string> otherwise)
    {
        if (this == Drivinglicense) onDrivinglicense();
        else if (this == Id) onId();
        else if (this == Passport) onPassport();
        else if (this == Socialsecurity) onSocialsecurity();
        else if (this == Visa) onVisa();
        else otherwise(Value);
    }
}
