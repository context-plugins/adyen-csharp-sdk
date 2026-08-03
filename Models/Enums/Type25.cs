using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of Terms of Service.
/// <para>
/// Possible values:
/// *  <b>adyenForPlatformsManage</b>
/// *  <b>adyenIssuing</b>
/// *  <b>adyenForPlatformsAdvanced</b>
/// *  <b>adyenCapital</b>
/// *  <b>adyenAccount</b>
/// *  <b>adyenCard</b>
/// *  <b>adyenFranchisee</b>
/// *  <b>adyenPccr</b>
/// *  <b>adyenChargeCard</b>
/// *  <b>kycOnInvite</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type25>))]
public sealed record Type25 : StringEnum<Type25>
{
    private Type25(string value) : base(value)
    {
    }

    public static readonly Type25 AdyenAccount = new("adyenAccount");

    public static readonly Type25 AdyenCapital = new("adyenCapital");

    public static readonly Type25 AdyenCard = new("adyenCard");

    public static readonly Type25 AdyenChargeCard = new("adyenChargeCard");

    public static readonly Type25 AdyenForPlatformsAdvanced = new("adyenForPlatformsAdvanced");

    public static readonly Type25 AdyenForPlatformsManage = new("adyenForPlatformsManage");

    public static readonly Type25 AdyenFranchisee = new("adyenFranchisee");

    public static readonly Type25 AdyenIssuing = new("adyenIssuing");

    public static readonly Type25 AdyenPccr = new("adyenPccr");

    public static readonly Type25 KycOnInvite = new("kycOnInvite");

    public static Type25 FromValue(string value) => FromValueCore(value);
}
