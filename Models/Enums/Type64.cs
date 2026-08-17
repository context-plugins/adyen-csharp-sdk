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
[JsonConverter(typeof(StringEnumConverter<Type64>))]
public sealed record Type64 : StringEnum<Type64>
{
    private Type64(string value) : base(value)
    {
    }

    public static readonly Type64 AdyenAccount = new("adyenAccount");

    public static readonly Type64 AdyenCapital = new("adyenCapital");

    public static readonly Type64 AdyenCard = new("adyenCard");

    public static readonly Type64 AdyenChargeCard = new("adyenChargeCard");

    public static readonly Type64 AdyenForPlatformsAdvanced = new("adyenForPlatformsAdvanced");

    public static readonly Type64 AdyenForPlatformsManage = new("adyenForPlatformsManage");

    public static readonly Type64 AdyenFranchisee = new("adyenFranchisee");

    public static readonly Type64 AdyenIssuing = new("adyenIssuing");

    public static readonly Type64 AdyenPccr = new("adyenPccr");

    public static readonly Type64 KycOnInvite = new("kycOnInvite");

    public static Type64 FromValue(string value) => FromValueCore(value);
}
