using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<LegalArrangementMember>))]
public sealed record LegalArrangementMember : OpenStringEnum<LegalArrangementMember>
{
    private LegalArrangementMember(string value) : base(value)
    {
    }

    public static readonly LegalArrangementMember Beneficiary = new("Beneficiary");

    public static readonly LegalArrangementMember ControllingPerson = new("ControllingPerson");

    public static readonly LegalArrangementMember Partner = new("Partner");

    public static readonly LegalArrangementMember Protector = new("Protector");

    public static readonly LegalArrangementMember Settlor = new("Settlor");

    public static readonly LegalArrangementMember Shareholder = new("Shareholder");

    public static readonly LegalArrangementMember Trustee = new("Trustee");

    public TResult Match<TResult>(Func<TResult> onBeneficiary,
        Func<TResult> onControllingPerson,
        Func<TResult> onPartner,
        Func<TResult> onProtector,
        Func<TResult> onSettlor,
        Func<TResult> onShareholder,
        Func<TResult> onTrustee,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Beneficiary => onBeneficiary(),
            _ when this == ControllingPerson => onControllingPerson(),
            _ when this == Partner => onPartner(),
            _ when this == Protector => onProtector(),
            _ when this == Settlor => onSettlor(),
            _ when this == Shareholder => onShareholder(),
            _ when this == Trustee => onTrustee(),
            _ => otherwise(Value)
        };

    public void Match(Action onBeneficiary,
        Action onControllingPerson,
        Action onPartner,
        Action onProtector,
        Action onSettlor,
        Action onShareholder,
        Action onTrustee,
        Action<string> otherwise)
    {
        if (this == Beneficiary) onBeneficiary();
        else if (this == ControllingPerson) onControllingPerson();
        else if (this == Partner) onPartner();
        else if (this == Protector) onProtector();
        else if (this == Settlor) onSettlor();
        else if (this == Shareholder) onShareholder();
        else if (this == Trustee) onTrustee();
        else otherwise(Value);
    }
}
