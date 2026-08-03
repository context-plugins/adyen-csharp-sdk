using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<LegalArrangementMember>))]
public sealed record LegalArrangementMember : StringEnum<LegalArrangementMember>
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

    public static LegalArrangementMember FromValue(string value) => FromValueCore(value);
}
