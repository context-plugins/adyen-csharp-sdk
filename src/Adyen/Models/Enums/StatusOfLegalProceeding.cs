using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of any current or past legal action taken against the legal entity.
/// <para>
/// Possible values: <b>noLegalActionsTaken</b>, <b>underJudicialAdministration</b>, <b>bankruptcyInsolvency</b>, <b>otherLegalMeasures</b>
/// </para>
/// <para>
/// If the value of this field is <b>noLegalActionsTaken</b>, then <c>dateOfInitiationOfLegalProceeding</c> is not required. Otherwise, it is required.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusOfLegalProceeding>))]
public sealed record StatusOfLegalProceeding : OpenStringEnum<StatusOfLegalProceeding>
{
    private StatusOfLegalProceeding(string value) : base(value)
    {
    }

    public static readonly StatusOfLegalProceeding NoLegalActionsTaken = new("noLegalActionsTaken");

    public static readonly StatusOfLegalProceeding UnderJudicialAdministration = new("underJudicialAdministration");

    public static readonly StatusOfLegalProceeding BankruptcyInsolvency = new("bankruptcyInsolvency");

    public static readonly StatusOfLegalProceeding OtherLegalMeasures = new("otherLegalMeasures");

    public TResult Match<TResult>(Func<TResult> onNoLegalActionsTaken,
        Func<TResult> onUnderJudicialAdministration,
        Func<TResult> onBankruptcyInsolvency,
        Func<TResult> onOtherLegalMeasures,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoLegalActionsTaken => onNoLegalActionsTaken(),
            _ when this == UnderJudicialAdministration => onUnderJudicialAdministration(),
            _ when this == BankruptcyInsolvency => onBankruptcyInsolvency(),
            _ when this == OtherLegalMeasures => onOtherLegalMeasures(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoLegalActionsTaken,
        Action onUnderJudicialAdministration,
        Action onBankruptcyInsolvency,
        Action onOtherLegalMeasures,
        Action<string> otherwise)
    {
        if (this == NoLegalActionsTaken) onNoLegalActionsTaken();
        else if (this == UnderJudicialAdministration) onUnderJudicialAdministration();
        else if (this == BankruptcyInsolvency) onBankruptcyInsolvency();
        else if (this == OtherLegalMeasures) onOtherLegalMeasures();
        else otherwise(Value);
    }
}
