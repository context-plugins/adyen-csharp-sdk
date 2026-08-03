using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BankAccountIdentificationType>))]
public sealed record BankAccountIdentificationType : StringEnum<BankAccountIdentificationType>
{
    private BankAccountIdentificationType(string value) : base(value)
    {
    }

    public static readonly BankAccountIdentificationType AuLocal = new("auLocal");

    public static readonly BankAccountIdentificationType BrLocal = new("brLocal");

    public static readonly BankAccountIdentificationType CaLocal = new("caLocal");

    public static readonly BankAccountIdentificationType CzLocal = new("czLocal");

    public static readonly BankAccountIdentificationType DkLocal = new("dkLocal");

    public static readonly BankAccountIdentificationType HkLocal = new("hkLocal");

    public static readonly BankAccountIdentificationType HuLocal = new("huLocal");

    public static readonly BankAccountIdentificationType Iban = new("iban");

    public static readonly BankAccountIdentificationType InLocal = new("inLocal");

    public static readonly BankAccountIdentificationType JpLocal = new("jpLocal");

    public static readonly BankAccountIdentificationType Legacy = new("legacy");

    public static readonly BankAccountIdentificationType MxLocal = new("mxLocal");

    public static readonly BankAccountIdentificationType MyLocal = new("myLocal");

    public static readonly BankAccountIdentificationType NoLocal = new("noLocal");

    public static readonly BankAccountIdentificationType NumberAndBic = new("numberAndBic");

    public static readonly BankAccountIdentificationType NzLocal = new("nzLocal");

    public static readonly BankAccountIdentificationType PlLocal = new("plLocal");

    public static readonly BankAccountIdentificationType SeLocal = new("seLocal");

    public static readonly BankAccountIdentificationType SgLocal = new("sgLocal");

    public static readonly BankAccountIdentificationType UkLocal = new("ukLocal");

    public static readonly BankAccountIdentificationType UsLocal = new("usLocal");

    public static BankAccountIdentificationType FromValue(string value) => FromValueCore(value);
}
