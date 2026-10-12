using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The legal entity of the account holder.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LegalEntity2>))]
public sealed record LegalEntity2 : OpenStringEnum<LegalEntity2>
{
    private LegalEntity2(string value) : base(value)
    {
    }

    public static readonly LegalEntity2 Business = new("Business");

    public static readonly LegalEntity2 Individual = new("Individual");

    public static readonly LegalEntity2 NonProfit = new("NonProfit");

    public static readonly LegalEntity2 Partnership = new("Partnership");

    public static readonly LegalEntity2 PublicCompany = new("PublicCompany");

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
