using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The legal entity type of the account holder. This determines the information that should be provided in the request.
/// <para>
/// Possible values: <b>Business</b>, <b>Individual</b>, or <b>NonProfit</b>.
/// </para>
/// <list type="bullet">
///   <item><description>If set to <b>Business</b> or <b>NonProfit</b>, then <c>accountHolderDetails.businessDetails</c> must be provided, with at least one entry in the <c>accountHolderDetails.businessDetails.shareholders</c> list.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>If set to <b>Individual</b>, then <c>accountHolderDetails.individualDetails</c> must be provided.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LegalEntity>))]
public sealed record LegalEntity : OpenStringEnum<LegalEntity>
{
    private LegalEntity(string value) : base(value)
    {
    }

    public static readonly LegalEntity Business = new("Business");

    public static readonly LegalEntity Individual = new("Individual");

    public static readonly LegalEntity NonProfit = new("NonProfit");

    public static readonly LegalEntity Partnership = new("Partnership");

    public static readonly LegalEntity PublicCompany = new("PublicCompany");

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
