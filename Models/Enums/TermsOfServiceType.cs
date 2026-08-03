using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TermsOfServiceType>))]
public sealed record TermsOfServiceType : StringEnum<TermsOfServiceType>
{
    private TermsOfServiceType(string value) : base(value)
    {
    }

    public static readonly TermsOfServiceType AdyenAccount = new("adyenAccount");

    public static readonly TermsOfServiceType AdyenCapital = new("adyenCapital");

    public static readonly TermsOfServiceType AdyenCard = new("adyenCard");

    public static readonly TermsOfServiceType AdyenChargeCard = new("adyenChargeCard");

    public static readonly TermsOfServiceType AdyenForPlatformsAdvanced = new("adyenForPlatformsAdvanced");

    public static readonly TermsOfServiceType AdyenForPlatformsManage = new("adyenForPlatformsManage");

    public static readonly TermsOfServiceType AdyenFranchisee = new("adyenFranchisee");

    public static readonly TermsOfServiceType AdyenIssuing = new("adyenIssuing");

    public static readonly TermsOfServiceType AdyenPccr = new("adyenPccr");

    public static readonly TermsOfServiceType KycOnInvite = new("kycOnInvite");

    public static TermsOfServiceType FromValue(string value) => FromValueCore(value);
}
