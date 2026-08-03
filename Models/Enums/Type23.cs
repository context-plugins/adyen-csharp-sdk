using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>doku</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type23>))]
public sealed record Type23 : StringEnum<Type23>
{
    private Type23(string value) : base(value)
    {
    }

    public static readonly Type23 DokuMandiriVa = new("doku_mandiri_va");

    public static readonly Type23 DokuCimbVa = new("doku_cimb_va");

    public static readonly Type23 DokuDanamonVa = new("doku_danamon_va");

    public static readonly Type23 DokuBniVa = new("doku_bni_va");

    public static readonly Type23 DokuPermataLiteAtm = new("doku_permata_lite_atm");

    public static readonly Type23 DokuBriVa = new("doku_bri_va");

    public static readonly Type23 DokuBcaVa = new("doku_bca_va");

    public static readonly Type23 DokuAlfamart = new("doku_alfamart");

    public static readonly Type23 DokuIndomaret = new("doku_indomaret");

    public static readonly Type23 DokuWallet = new("doku_wallet");

    public static readonly Type23 DokuOvo = new("doku_ovo");

    public static Type23 FromValue(string value) => FromValueCore(value);
}
