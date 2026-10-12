using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The legal entity type.
/// <para>
/// Possible values: <b>Business</b>, <b>Individual</b>, <b>NonProfit</b>, <b>PublicCompany</b>, or <b>Partnership</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LegalEntityType>))]
public sealed record LegalEntityType : OpenStringEnum<LegalEntityType>
{
    private LegalEntityType(string value) : base(value)
    {
    }

    public static readonly LegalEntityType Business = new("Business");

    public static readonly LegalEntityType Individual = new("Individual");

    public static readonly LegalEntityType NonProfit = new("NonProfit");

    public static readonly LegalEntityType Partnership = new("Partnership");

    public static readonly LegalEntityType PublicCompany = new("PublicCompany");

    public TResult Match<TResult>(Func<TResult> onBusiness,
        Func<TResult> onIndividual,
        Func<TResult> onNonProfit,
        Func<TResult> onPartnership,
        Func<TResult> onPublicCompany,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Business => onBusiness(),
            _ when this == Individual => onIndividual(),
            _ when this == NonProfit => onNonProfit(),
            _ when this == Partnership => onPartnership(),
            _ when this == PublicCompany => onPublicCompany(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusiness,
        Action onIndividual,
        Action onNonProfit,
        Action onPartnership,
        Action onPublicCompany,
        Action<string> otherwise)
    {
        if (this == Business) onBusiness();
        else if (this == Individual) onIndividual();
        else if (this == NonProfit) onNonProfit();
        else if (this == Partnership) onPartnership();
        else if (this == PublicCompany) onPublicCompany();
        else otherwise(Value);
    }
}
