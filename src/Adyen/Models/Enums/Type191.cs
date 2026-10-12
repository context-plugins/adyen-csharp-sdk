using System;
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
public sealed record Type191 : OpenStringEnum<Type191>
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

    public TResult Match<TResult>(Func<TResult> onLimitedPartnership,
        Func<TResult> onGeneralPartnership,
        Func<TResult> onFamilyPartnership,
        Func<TResult> onCommercialPartnership,
        Func<TResult> onPublicPartnership,
        Func<TResult> onOtherPartnership,
        Func<TResult> onGbr,
        Func<TResult> onGmbh,
        Func<TResult> onKgaa,
        Func<TResult> onCv,
        Func<TResult> onVof,
        Func<TResult> onMaatschap,
        Func<TResult> onPrivateFundLimitedPartnership,
        Func<TResult> onBusinessTrustEntity,
        Func<TResult> onBusinessPartnership,
        Func<TResult> onLimitedLiabilityPartnership,
        Func<TResult> onEg,
        Func<TResult> onCooperative,
        Func<TResult> onVos,
        Func<TResult> onComunidadDeBienes,
        Func<TResult> onHerenciaYacente,
        Func<TResult> onComunidadDePropietarios,
        Func<TResult> onSep,
        Func<TResult> onSca,
        Func<TResult> onBt,
        Func<TResult> onKkt,
        Func<TResult> onScs,
        Func<TResult> onSnc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LimitedPartnership => onLimitedPartnership(),
            _ when this == GeneralPartnership => onGeneralPartnership(),
            _ when this == FamilyPartnership => onFamilyPartnership(),
            _ when this == CommercialPartnership => onCommercialPartnership(),
            _ when this == PublicPartnership => onPublicPartnership(),
            _ when this == OtherPartnership => onOtherPartnership(),
            _ when this == Gbr => onGbr(),
            _ when this == Gmbh => onGmbh(),
            _ when this == Kgaa => onKgaa(),
            _ when this == Cv => onCv(),
            _ when this == Vof => onVof(),
            _ when this == Maatschap => onMaatschap(),
            _ when this == PrivateFundLimitedPartnership => onPrivateFundLimitedPartnership(),
            _ when this == BusinessTrustEntity => onBusinessTrustEntity(),
            _ when this == BusinessPartnership => onBusinessPartnership(),
            _ when this == LimitedLiabilityPartnership => onLimitedLiabilityPartnership(),
            _ when this == Eg => onEg(),
            _ when this == Cooperative => onCooperative(),
            _ when this == Vos => onVos(),
            _ when this == ComunidadDeBienes => onComunidadDeBienes(),
            _ when this == HerenciaYacente => onHerenciaYacente(),
            _ when this == ComunidadDePropietarios => onComunidadDePropietarios(),
            _ when this == Sep => onSep(),
            _ when this == Sca => onSca(),
            _ when this == Bt => onBt(),
            _ when this == Kkt => onKkt(),
            _ when this == Scs => onScs(),
            _ when this == Snc => onSnc(),
            _ => otherwise(Value)
        };

    public void Match(Action onLimitedPartnership,
        Action onGeneralPartnership,
        Action onFamilyPartnership,
        Action onCommercialPartnership,
        Action onPublicPartnership,
        Action onOtherPartnership,
        Action onGbr,
        Action onGmbh,
        Action onKgaa,
        Action onCv,
        Action onVof,
        Action onMaatschap,
        Action onPrivateFundLimitedPartnership,
        Action onBusinessTrustEntity,
        Action onBusinessPartnership,
        Action onLimitedLiabilityPartnership,
        Action onEg,
        Action onCooperative,
        Action onVos,
        Action onComunidadDeBienes,
        Action onHerenciaYacente,
        Action onComunidadDePropietarios,
        Action onSep,
        Action onSca,
        Action onBt,
        Action onKkt,
        Action onScs,
        Action onSnc,
        Action<string> otherwise)
    {
        if (this == LimitedPartnership) onLimitedPartnership();
        else if (this == GeneralPartnership) onGeneralPartnership();
        else if (this == FamilyPartnership) onFamilyPartnership();
        else if (this == CommercialPartnership) onCommercialPartnership();
        else if (this == PublicPartnership) onPublicPartnership();
        else if (this == OtherPartnership) onOtherPartnership();
        else if (this == Gbr) onGbr();
        else if (this == Gmbh) onGmbh();
        else if (this == Kgaa) onKgaa();
        else if (this == Cv) onCv();
        else if (this == Vof) onVof();
        else if (this == Maatschap) onMaatschap();
        else if (this == PrivateFundLimitedPartnership) onPrivateFundLimitedPartnership();
        else if (this == BusinessTrustEntity) onBusinessTrustEntity();
        else if (this == BusinessPartnership) onBusinessPartnership();
        else if (this == LimitedLiabilityPartnership) onLimitedLiabilityPartnership();
        else if (this == Eg) onEg();
        else if (this == Cooperative) onCooperative();
        else if (this == Vos) onVos();
        else if (this == ComunidadDeBienes) onComunidadDeBienes();
        else if (this == HerenciaYacente) onHerenciaYacente();
        else if (this == ComunidadDePropietarios) onComunidadDePropietarios();
        else if (this == Sep) onSep();
        else if (this == Sca) onSca();
        else if (this == Bt) onBt();
        else if (this == Kkt) onKkt();
        else if (this == Scs) onScs();
        else if (this == Snc) onSnc();
        else otherwise(Value);
    }
}
