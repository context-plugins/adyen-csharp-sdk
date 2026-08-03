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
public sealed record StatusOfLegalProceeding : StringEnum<StatusOfLegalProceeding>
{
    private StatusOfLegalProceeding(string value) : base(value)
    {
    }

    public static readonly StatusOfLegalProceeding NoLegalActionsTaken = new("noLegalActionsTaken");

    public static readonly StatusOfLegalProceeding UnderJudicialAdministration = new("underJudicialAdministration");

    public static readonly StatusOfLegalProceeding BankruptcyInsolvency = new("bankruptcyInsolvency");

    public static readonly StatusOfLegalProceeding OtherLegalMeasures = new("otherLegalMeasures");

    public static StatusOfLegalProceeding FromValue(string value) => FromValueCore(value);
}
