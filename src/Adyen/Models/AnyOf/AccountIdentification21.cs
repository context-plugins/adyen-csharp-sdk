using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Identification of the bank account.
/// </summary>
[JsonConverter(typeof(AccountIdentification21Converter))]
public record AccountIdentification21
{
    private readonly Optional<AuLocalAccountIdentification> _auLocalAccountIdentificationValue;

    private readonly Optional<CaLocalAccountIdentification> _caLocalAccountIdentificationValue;

    private readonly Optional<CzLocalAccountIdentification> _czLocalAccountIdentificationValue;

    private readonly Optional<DkLocalAccountIdentification> _dkLocalAccountIdentificationValue;

    private readonly Optional<HkLocalAccountIdentification> _hkLocalAccountIdentificationValue;

    private readonly Optional<HuLocalAccountIdentification> _huLocalAccountIdentificationValue;

    private readonly Optional<IbanAccountIdentification> _ibanAccountIdentificationValue;

    private readonly Optional<NoLocalAccountIdentification> _noLocalAccountIdentificationValue;

    private readonly Optional<NzLocalAccountIdentification> _nzLocalAccountIdentificationValue;

    private readonly Optional<NumberAndBicAccountIdentification> _numberAndBicAccountIdentificationValue;

    private readonly Optional<PlLocalAccountIdentification> _plLocalAccountIdentificationValue;

    private readonly Optional<SeLocalAccountIdentification> _seLocalAccountIdentificationValue;

    private readonly Optional<SgLocalAccountIdentification> _sgLocalAccountIdentificationValue;

    private readonly Optional<UkLocalAccountIdentification> _ukLocalAccountIdentificationValue;

    private readonly Optional<UsLocalAccountIdentification> _usLocalAccountIdentificationValue;

    private AccountIdentification21(Optional<AuLocalAccountIdentification> auLocalAccountIdentificationValue,
        Optional<CaLocalAccountIdentification> caLocalAccountIdentificationValue,
        Optional<CzLocalAccountIdentification> czLocalAccountIdentificationValue,
        Optional<DkLocalAccountIdentification> dkLocalAccountIdentificationValue,
        Optional<HkLocalAccountIdentification> hkLocalAccountIdentificationValue,
        Optional<HuLocalAccountIdentification> huLocalAccountIdentificationValue,
        Optional<IbanAccountIdentification> ibanAccountIdentificationValue,
        Optional<NoLocalAccountIdentification> noLocalAccountIdentificationValue,
        Optional<NzLocalAccountIdentification> nzLocalAccountIdentificationValue,
        Optional<NumberAndBicAccountIdentification> numberAndBicAccountIdentificationValue,
        Optional<PlLocalAccountIdentification> plLocalAccountIdentificationValue,
        Optional<SeLocalAccountIdentification> seLocalAccountIdentificationValue,
        Optional<SgLocalAccountIdentification> sgLocalAccountIdentificationValue,
        Optional<UkLocalAccountIdentification> ukLocalAccountIdentificationValue,
        Optional<UsLocalAccountIdentification> usLocalAccountIdentificationValue)
    {
        _auLocalAccountIdentificationValue = auLocalAccountIdentificationValue;
        _caLocalAccountIdentificationValue = caLocalAccountIdentificationValue;
        _czLocalAccountIdentificationValue = czLocalAccountIdentificationValue;
        _dkLocalAccountIdentificationValue = dkLocalAccountIdentificationValue;
        _hkLocalAccountIdentificationValue = hkLocalAccountIdentificationValue;
        _huLocalAccountIdentificationValue = huLocalAccountIdentificationValue;
        _ibanAccountIdentificationValue = ibanAccountIdentificationValue;
        _noLocalAccountIdentificationValue = noLocalAccountIdentificationValue;
        _nzLocalAccountIdentificationValue = nzLocalAccountIdentificationValue;
        _numberAndBicAccountIdentificationValue = numberAndBicAccountIdentificationValue;
        _plLocalAccountIdentificationValue = plLocalAccountIdentificationValue;
        _seLocalAccountIdentificationValue = seLocalAccountIdentificationValue;
        _sgLocalAccountIdentificationValue = sgLocalAccountIdentificationValue;
        _ukLocalAccountIdentificationValue = ukLocalAccountIdentificationValue;
        _usLocalAccountIdentificationValue = usLocalAccountIdentificationValue;
    }

    public static AccountIdentification21 AuLocalAccountIdentification(AuLocalAccountIdentification value) =>
        new(
            Optional<AuLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 CaLocalAccountIdentification(CaLocalAccountIdentification value) =>
        new(
            default,
            Optional<CaLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 CzLocalAccountIdentification(CzLocalAccountIdentification value) =>
        new(
            default,
            default,
            Optional<CzLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 DkLocalAccountIdentification(DkLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            Optional<DkLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 HkLocalAccountIdentification(HkLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            Optional<HkLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 HuLocalAccountIdentification(HuLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            Optional<HuLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 IbanAccountIdentification(IbanAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<IbanAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 NoLocalAccountIdentification(NoLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<NoLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 NzLocalAccountIdentification(NzLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<NzLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 NumberAndBicAccountIdentification(NumberAndBicAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<NumberAndBicAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification21 PlLocalAccountIdentification(PlLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PlLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default);

    public static AccountIdentification21 SeLocalAccountIdentification(SeLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SeLocalAccountIdentification>.Some(value),
            default,
            default,
            default);

    public static AccountIdentification21 SgLocalAccountIdentification(SgLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SgLocalAccountIdentification>.Some(value),
            default,
            default);

    public static AccountIdentification21 UkLocalAccountIdentification(UkLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UkLocalAccountIdentification>.Some(value),
            default);

    public static AccountIdentification21 UsLocalAccountIdentification(UsLocalAccountIdentification value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UsLocalAccountIdentification>.Some(value));

    public bool TryGetAuLocalAccountIdentification(out AuLocalAccountIdentification value) =>
        _auLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetCaLocalAccountIdentification(out CaLocalAccountIdentification value) =>
        _caLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetCzLocalAccountIdentification(out CzLocalAccountIdentification value) =>
        _czLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetDkLocalAccountIdentification(out DkLocalAccountIdentification value) =>
        _dkLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetHkLocalAccountIdentification(out HkLocalAccountIdentification value) =>
        _hkLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetHuLocalAccountIdentification(out HuLocalAccountIdentification value) =>
        _huLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetIbanAccountIdentification(out IbanAccountIdentification value) =>
        _ibanAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetNoLocalAccountIdentification(out NoLocalAccountIdentification value) =>
        _noLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetNzLocalAccountIdentification(out NzLocalAccountIdentification value) =>
        _nzLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetNumberAndBicAccountIdentification(out NumberAndBicAccountIdentification value) =>
        _numberAndBicAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetPlLocalAccountIdentification(out PlLocalAccountIdentification value) =>
        _plLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetSeLocalAccountIdentification(out SeLocalAccountIdentification value) =>
        _seLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetSgLocalAccountIdentification(out SgLocalAccountIdentification value) =>
        _sgLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetUkLocalAccountIdentification(out UkLocalAccountIdentification value) =>
        _ukLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetUsLocalAccountIdentification(out UsLocalAccountIdentification value) =>
        _usLocalAccountIdentificationValue.TryGetValue(out value);

    public static implicit operator AccountIdentification21(AuLocalAccountIdentification value) =>
        AuLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(CaLocalAccountIdentification value) =>
        CaLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(CzLocalAccountIdentification value) =>
        CzLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(DkLocalAccountIdentification value) =>
        DkLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(HkLocalAccountIdentification value) =>
        HkLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(HuLocalAccountIdentification value) =>
        HuLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(IbanAccountIdentification value) =>
        IbanAccountIdentification(value);

    public static implicit operator AccountIdentification21(NoLocalAccountIdentification value) =>
        NoLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(NzLocalAccountIdentification value) =>
        NzLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(NumberAndBicAccountIdentification value) =>
        NumberAndBicAccountIdentification(value);

    public static implicit operator AccountIdentification21(PlLocalAccountIdentification value) =>
        PlLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(SeLocalAccountIdentification value) =>
        SeLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(SgLocalAccountIdentification value) =>
        SgLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(UkLocalAccountIdentification value) =>
        UkLocalAccountIdentification(value);

    public static implicit operator AccountIdentification21(UsLocalAccountIdentification value) =>
        UsLocalAccountIdentification(value);
}

file sealed class AccountIdentification21Converter : JsonConverter<AccountIdentification21>
{
    public override AccountIdentification21 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AuLocalAccountIdentification>(
            root,
            options,
            out var auLocalAccountIdentificationValue))
        {
            return AccountIdentification21.AuLocalAccountIdentification(auLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<CaLocalAccountIdentification>(
            root,
            options,
            out var caLocalAccountIdentificationValue))
        {
            return AccountIdentification21.CaLocalAccountIdentification(caLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<CzLocalAccountIdentification>(
            root,
            options,
            out var czLocalAccountIdentificationValue))
        {
            return AccountIdentification21.CzLocalAccountIdentification(czLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<DkLocalAccountIdentification>(
            root,
            options,
            out var dkLocalAccountIdentificationValue))
        {
            return AccountIdentification21.DkLocalAccountIdentification(dkLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<HkLocalAccountIdentification>(
            root,
            options,
            out var hkLocalAccountIdentificationValue))
        {
            return AccountIdentification21.HkLocalAccountIdentification(hkLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<HuLocalAccountIdentification>(
            root,
            options,
            out var huLocalAccountIdentificationValue))
        {
            return AccountIdentification21.HuLocalAccountIdentification(huLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<IbanAccountIdentification>(
            root,
            options,
            out var ibanAccountIdentificationValue))
        {
            return AccountIdentification21.IbanAccountIdentification(ibanAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<NoLocalAccountIdentification>(
            root,
            options,
            out var noLocalAccountIdentificationValue))
        {
            return AccountIdentification21.NoLocalAccountIdentification(noLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<NzLocalAccountIdentification>(
            root,
            options,
            out var nzLocalAccountIdentificationValue))
        {
            return AccountIdentification21.NzLocalAccountIdentification(nzLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<NumberAndBicAccountIdentification>(
            root,
            options,
            out var numberAndBicAccountIdentificationValue))
        {
            return AccountIdentification21.NumberAndBicAccountIdentification(numberAndBicAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<PlLocalAccountIdentification>(
            root,
            options,
            out var plLocalAccountIdentificationValue))
        {
            return AccountIdentification21.PlLocalAccountIdentification(plLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<SeLocalAccountIdentification>(
            root,
            options,
            out var seLocalAccountIdentificationValue))
        {
            return AccountIdentification21.SeLocalAccountIdentification(seLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<SgLocalAccountIdentification>(
            root,
            options,
            out var sgLocalAccountIdentificationValue))
        {
            return AccountIdentification21.SgLocalAccountIdentification(sgLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<UkLocalAccountIdentification>(
            root,
            options,
            out var ukLocalAccountIdentificationValue))
        {
            return AccountIdentification21.UkLocalAccountIdentification(ukLocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<UsLocalAccountIdentification>(
            root,
            options,
            out var usLocalAccountIdentificationValue))
        {
            return AccountIdentification21.UsLocalAccountIdentification(usLocalAccountIdentificationValue);
        }
        throw new JsonException(
            $"JSON does not match AuLocalAccountIdentification or CaLocalAccountIdentification or CzLocalAccountIdentification or DkLocalAccountIdentification or HkLocalAccountIdentification or HuLocalAccountIdentification or IbanAccountIdentification or NoLocalAccountIdentification or NzLocalAccountIdentification or NumberAndBicAccountIdentification or PlLocalAccountIdentification or SeLocalAccountIdentification or SgLocalAccountIdentification or UkLocalAccountIdentification or UsLocalAccountIdentification schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AccountIdentification21 value, JsonSerializerOptions options)
    {
        if (value.TryGetAuLocalAccountIdentification(out var auLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, auLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetCaLocalAccountIdentification(out var caLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, caLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetCzLocalAccountIdentification(out var czLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, czLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetDkLocalAccountIdentification(out var dkLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, dkLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetHkLocalAccountIdentification(out var hkLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, hkLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetHuLocalAccountIdentification(out var huLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, huLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetIbanAccountIdentification(out var ibanAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, ibanAccountIdentificationValue, options);
        }
        else if (value.TryGetNoLocalAccountIdentification(out var noLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, noLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetNzLocalAccountIdentification(out var nzLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, nzLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetNumberAndBicAccountIdentification(out var numberAndBicAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, numberAndBicAccountIdentificationValue, options);
        }
        else if (value.TryGetPlLocalAccountIdentification(out var plLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, plLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetSeLocalAccountIdentification(out var seLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, seLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetSgLocalAccountIdentification(out var sgLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, sgLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetUkLocalAccountIdentification(out var ukLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, ukLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetUsLocalAccountIdentification(out var usLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, usLocalAccountIdentificationValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AccountIdentification21)} contains no valid value to serialize.");
        }
    }
}
