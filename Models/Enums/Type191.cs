using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of Partnership.
/// <para>
/// Possible values:
/// *  <b>limitedPartnership</b>
/// *  <b>generalPartnership</b>
/// *  <b>familyPartnership</b>
/// *  <b>commercialPartnership</b>
/// *  <b>publicPartnership</b>
/// *  <b>otherPartnership</b>
/// *  <b>gbr</b>
/// *  <b>gmbh</b>
/// *  <b>kgaa</b>
/// *  <b>cv</b>
/// *  <b>vof</b>
/// *  <b>maatschap</b>
/// *  <b>privateFundLimitedPartnership</b>
/// *  <b>businessTrustEntity</b>
/// *  <b>businessPartnership</b>
/// *  <b>limitedLiabilityPartnership</b>
/// *  <b>eg</b>
/// *  <b>cooperative</b>
/// *  <b>vos</b>
/// *  <b>comunidadDeBienes</b>
/// *  <b>herenciaYacente</b>
/// *  <b>comunidadDePropietarios</b>
/// *  <b>sep</b>
/// *  <b>sca</b>
/// *  <b>bt</b>
/// *  <b>kkt</b>
/// *  <b>scs</b>
/// *  <b>snc</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type191>))]
public sealed record Type191 : StringEnum<Type191>
{
    private Type191(string value) : base(value)
    {
    }

    public static readonly Type191 LimitedPartnership = new("limitedPartnership");

    public static readonly Type191 GeneralPartnership = new("generalPartnership");

    public static readonly Type191 FamilyPartnership = new("familyPartnership");

    public static readonly Type191 CommercialPartnership = new("commercialPartnership");

    public static readonly Type191 PublicPartnership = new("publicPartnership");

    public static readonly Type191 OtherPartnership = new("otherPartnership");

    public static readonly Type191 Gbr = new("gbr");

    public static readonly Type191 Gmbh = new("gmbh");

    public static readonly Type191 Kgaa = new("kgaa");

    public static readonly Type191 Cv = new("cv");

    public static readonly Type191 Vof = new("vof");

    public static readonly Type191 Maatschap = new("maatschap");

    public static readonly Type191 PrivateFundLimitedPartnership = new("privateFundLimitedPartnership");

    public static readonly Type191 BusinessTrustEntity = new("businessTrustEntity");

    public static readonly Type191 BusinessPartnership = new("businessPartnership");

    public static readonly Type191 LimitedLiabilityPartnership = new("limitedLiabilityPartnership");

    public static readonly Type191 Eg = new("eg");

    public static readonly Type191 Cooperative = new("cooperative");

    public static readonly Type191 Vos = new("vos");

    public static readonly Type191 ComunidadDeBienes = new("comunidadDeBienes");

    public static readonly Type191 HerenciaYacente = new("herenciaYacente");

    public static readonly Type191 ComunidadDePropietarios = new("comunidadDePropietarios");

    public static readonly Type191 Sep = new("sep");

    public static readonly Type191 Sca = new("sca");

    public static readonly Type191 Bt = new("bt");

    public static readonly Type191 Kkt = new("kkt");

    public static readonly Type191 Scs = new("scs");

    public static readonly Type191 Snc = new("snc");

    public static Type191 FromValue(string value) => FromValueCore(value);
}
