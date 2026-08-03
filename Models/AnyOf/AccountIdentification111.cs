using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Bank account identification.
/// </summary>
[JsonConverter(typeof(AccountIdentification111Converter))]
public record AccountIdentification111
{
    private readonly Optional<AulocalAccountIdentification> _aulocalAccountIdentificationValue;

    private readonly Optional<BrlocalAccountIdentification> _brlocalAccountIdentificationValue;

    private readonly Optional<CalocalAccountIdentification> _calocalAccountIdentificationValue;

    private readonly Optional<CzlocalAccountIdentification> _czlocalAccountIdentificationValue;

    private readonly Optional<DklocalAccountIdentification> _dklocalAccountIdentificationValue;

    private readonly Optional<HklocalAccountIdentification> _hklocalAccountIdentificationValue;

    private readonly Optional<HulocalAccountIdentification> _hulocalAccountIdentificationValue;

    private readonly Optional<IbanAccountIdentification1> _ibanAccountIdentification1Value;

    private readonly Optional<NolocalAccountIdentification> _nolocalAccountIdentificationValue;

    private readonly Optional<NzlocalAccountIdentification> _nzlocalAccountIdentificationValue;

    private readonly Optional<NumberAndBicAccountIdentification> _numberAndBicAccountIdentificationValue;

    private readonly Optional<PllocalAccountIdentification> _pllocalAccountIdentificationValue;

    private readonly Optional<SelocalAccountIdentification> _selocalAccountIdentificationValue;

    private readonly Optional<SglocalAccountIdentification> _sglocalAccountIdentificationValue;

    private readonly Optional<UklocalAccountIdentification> _uklocalAccountIdentificationValue;

    private readonly Optional<UslocalAccountIdentification> _uslocalAccountIdentificationValue;

    private AccountIdentification111(Optional<AulocalAccountIdentification> aulocalAccountIdentificationValue,
        Optional<BrlocalAccountIdentification> brlocalAccountIdentificationValue,
        Optional<CalocalAccountIdentification> calocalAccountIdentificationValue,
        Optional<CzlocalAccountIdentification> czlocalAccountIdentificationValue,
        Optional<DklocalAccountIdentification> dklocalAccountIdentificationValue,
        Optional<HklocalAccountIdentification> hklocalAccountIdentificationValue,
        Optional<HulocalAccountIdentification> hulocalAccountIdentificationValue,
        Optional<IbanAccountIdentification1> ibanAccountIdentification1Value,
        Optional<NolocalAccountIdentification> nolocalAccountIdentificationValue,
        Optional<NzlocalAccountIdentification> nzlocalAccountIdentificationValue,
        Optional<NumberAndBicAccountIdentification> numberAndBicAccountIdentificationValue,
        Optional<PllocalAccountIdentification> pllocalAccountIdentificationValue,
        Optional<SelocalAccountIdentification> selocalAccountIdentificationValue,
        Optional<SglocalAccountIdentification> sglocalAccountIdentificationValue,
        Optional<UklocalAccountIdentification> uklocalAccountIdentificationValue,
        Optional<UslocalAccountIdentification> uslocalAccountIdentificationValue)
    {
        _aulocalAccountIdentificationValue = aulocalAccountIdentificationValue;
        _brlocalAccountIdentificationValue = brlocalAccountIdentificationValue;
        _calocalAccountIdentificationValue = calocalAccountIdentificationValue;
        _czlocalAccountIdentificationValue = czlocalAccountIdentificationValue;
        _dklocalAccountIdentificationValue = dklocalAccountIdentificationValue;
        _hklocalAccountIdentificationValue = hklocalAccountIdentificationValue;
        _hulocalAccountIdentificationValue = hulocalAccountIdentificationValue;
        _ibanAccountIdentification1Value = ibanAccountIdentification1Value;
        _nolocalAccountIdentificationValue = nolocalAccountIdentificationValue;
        _nzlocalAccountIdentificationValue = nzlocalAccountIdentificationValue;
        _numberAndBicAccountIdentificationValue = numberAndBicAccountIdentificationValue;
        _pllocalAccountIdentificationValue = pllocalAccountIdentificationValue;
        _selocalAccountIdentificationValue = selocalAccountIdentificationValue;
        _sglocalAccountIdentificationValue = sglocalAccountIdentificationValue;
        _uklocalAccountIdentificationValue = uklocalAccountIdentificationValue;
        _uslocalAccountIdentificationValue = uslocalAccountIdentificationValue;
    }

    public static AccountIdentification111 AulocalAccountIdentification(AulocalAccountIdentification value) =>
        new(Optional<AulocalAccountIdentification>.Some(value),
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
            default);

    public static AccountIdentification111 BrlocalAccountIdentification(BrlocalAccountIdentification value) =>
        new(default,
            Optional<BrlocalAccountIdentification>.Some(value),
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

    public static AccountIdentification111 CalocalAccountIdentification(CalocalAccountIdentification value) =>
        new(default,
            default,
            Optional<CalocalAccountIdentification>.Some(value),
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

    public static AccountIdentification111 CzlocalAccountIdentification(CzlocalAccountIdentification value) =>
        new(default,
            default,
            default,
            Optional<CzlocalAccountIdentification>.Some(value),
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

    public static AccountIdentification111 DklocalAccountIdentification(DklocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            Optional<DklocalAccountIdentification>.Some(value),
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

    public static AccountIdentification111 HklocalAccountIdentification(HklocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<HklocalAccountIdentification>.Some(value),
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

    public static AccountIdentification111 HulocalAccountIdentification(HulocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<HulocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification111 IbanAccountIdentification1(IbanAccountIdentification1 value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<IbanAccountIdentification1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification111 NolocalAccountIdentification(NolocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<NolocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification111 NzlocalAccountIdentification(NzlocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<NzlocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification111 NumberAndBicAccountIdentification(NumberAndBicAccountIdentification value) =>
        new(default,
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

    public static AccountIdentification111 PllocalAccountIdentification(PllocalAccountIdentification value) =>
        new(default,
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
            Optional<PllocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default);

    public static AccountIdentification111 SelocalAccountIdentification(SelocalAccountIdentification value) =>
        new(default,
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
            Optional<SelocalAccountIdentification>.Some(value),
            default,
            default,
            default);

    public static AccountIdentification111 SglocalAccountIdentification(SglocalAccountIdentification value) =>
        new(default,
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
            Optional<SglocalAccountIdentification>.Some(value),
            default,
            default);

    public static AccountIdentification111 UklocalAccountIdentification(UklocalAccountIdentification value) =>
        new(default,
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
            Optional<UklocalAccountIdentification>.Some(value),
            default);

    public static AccountIdentification111 UslocalAccountIdentification(UslocalAccountIdentification value) =>
        new(default,
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
            Optional<UslocalAccountIdentification>.Some(value));

    public bool TryGetAulocalAccountIdentification(out AulocalAccountIdentification value) =>
        _aulocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetBrlocalAccountIdentification(out BrlocalAccountIdentification value) =>
        _brlocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetCalocalAccountIdentification(out CalocalAccountIdentification value) =>
        _calocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetCzlocalAccountIdentification(out CzlocalAccountIdentification value) =>
        _czlocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetDklocalAccountIdentification(out DklocalAccountIdentification value) =>
        _dklocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetHklocalAccountIdentification(out HklocalAccountIdentification value) =>
        _hklocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetHulocalAccountIdentification(out HulocalAccountIdentification value) =>
        _hulocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetIbanAccountIdentification1(out IbanAccountIdentification1 value) =>
        _ibanAccountIdentification1Value.TryGetValue(out value);

    public bool TryGetNolocalAccountIdentification(out NolocalAccountIdentification value) =>
        _nolocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetNzlocalAccountIdentification(out NzlocalAccountIdentification value) =>
        _nzlocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetNumberAndBicAccountIdentification(out NumberAndBicAccountIdentification value) =>
        _numberAndBicAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetPllocalAccountIdentification(out PllocalAccountIdentification value) =>
        _pllocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetSelocalAccountIdentification(out SelocalAccountIdentification value) =>
        _selocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetSglocalAccountIdentification(out SglocalAccountIdentification value) =>
        _sglocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetUklocalAccountIdentification(out UklocalAccountIdentification value) =>
        _uklocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetUslocalAccountIdentification(out UslocalAccountIdentification value) =>
        _uslocalAccountIdentificationValue.TryGetValue(out value);

    public static implicit operator AccountIdentification111(AulocalAccountIdentification value) =>
        AulocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(BrlocalAccountIdentification value) =>
        BrlocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(CalocalAccountIdentification value) =>
        CalocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(CzlocalAccountIdentification value) =>
        CzlocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(DklocalAccountIdentification value) =>
        DklocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(HklocalAccountIdentification value) =>
        HklocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(HulocalAccountIdentification value) =>
        HulocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(IbanAccountIdentification1 value) =>
        IbanAccountIdentification1(value);

    public static implicit operator AccountIdentification111(NolocalAccountIdentification value) =>
        NolocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(NzlocalAccountIdentification value) =>
        NzlocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(NumberAndBicAccountIdentification value) =>
        NumberAndBicAccountIdentification(value);

    public static implicit operator AccountIdentification111(PllocalAccountIdentification value) =>
        PllocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(SelocalAccountIdentification value) =>
        SelocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(SglocalAccountIdentification value) =>
        SglocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(UklocalAccountIdentification value) =>
        UklocalAccountIdentification(value);

    public static implicit operator AccountIdentification111(UslocalAccountIdentification value) =>
        UslocalAccountIdentification(value);
}

file sealed class AccountIdentification111Converter : JsonConverter<AccountIdentification111>
{
    public override AccountIdentification111 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AulocalAccountIdentification>(root,
            options,
            out var aulocalAccountIdentificationValue))
        {
            return AccountIdentification111.AulocalAccountIdentification(aulocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<BrlocalAccountIdentification>(root,
            options,
            out var brlocalAccountIdentificationValue))
        {
            return AccountIdentification111.BrlocalAccountIdentification(brlocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<CalocalAccountIdentification>(root,
            options,
            out var calocalAccountIdentificationValue))
        {
            return AccountIdentification111.CalocalAccountIdentification(calocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<CzlocalAccountIdentification>(root,
            options,
            out var czlocalAccountIdentificationValue))
        {
            return AccountIdentification111.CzlocalAccountIdentification(czlocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<DklocalAccountIdentification>(root,
            options,
            out var dklocalAccountIdentificationValue))
        {
            return AccountIdentification111.DklocalAccountIdentification(dklocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<HklocalAccountIdentification>(root,
            options,
            out var hklocalAccountIdentificationValue))
        {
            return AccountIdentification111.HklocalAccountIdentification(hklocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<HulocalAccountIdentification>(root,
            options,
            out var hulocalAccountIdentificationValue))
        {
            return AccountIdentification111.HulocalAccountIdentification(hulocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<IbanAccountIdentification1>(root,
            options,
            out var ibanAccountIdentification1Value))
        {
            return AccountIdentification111.IbanAccountIdentification1(ibanAccountIdentification1Value);
        }
        if (JsonSerializer.TryDeserialize<NolocalAccountIdentification>(root,
            options,
            out var nolocalAccountIdentificationValue))
        {
            return AccountIdentification111.NolocalAccountIdentification(nolocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<NzlocalAccountIdentification>(root,
            options,
            out var nzlocalAccountIdentificationValue))
        {
            return AccountIdentification111.NzlocalAccountIdentification(nzlocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<NumberAndBicAccountIdentification>(root,
            options,
            out var numberAndBicAccountIdentificationValue))
        {
            return AccountIdentification111.NumberAndBicAccountIdentification(numberAndBicAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<PllocalAccountIdentification>(root,
            options,
            out var pllocalAccountIdentificationValue))
        {
            return AccountIdentification111.PllocalAccountIdentification(pllocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<SelocalAccountIdentification>(root,
            options,
            out var selocalAccountIdentificationValue))
        {
            return AccountIdentification111.SelocalAccountIdentification(selocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<SglocalAccountIdentification>(root,
            options,
            out var sglocalAccountIdentificationValue))
        {
            return AccountIdentification111.SglocalAccountIdentification(sglocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<UklocalAccountIdentification>(root,
            options,
            out var uklocalAccountIdentificationValue))
        {
            return AccountIdentification111.UklocalAccountIdentification(uklocalAccountIdentificationValue);
        }
        if (JsonSerializer.TryDeserialize<UslocalAccountIdentification>(root,
            options,
            out var uslocalAccountIdentificationValue))
        {
            return AccountIdentification111.UslocalAccountIdentification(uslocalAccountIdentificationValue);
        }
        throw new JsonException($"JSON does not match AulocalAccountIdentification or BrlocalAccountIdentification or CalocalAccountIdentification or CzlocalAccountIdentification or DklocalAccountIdentification or HklocalAccountIdentification or HulocalAccountIdentification or IbanAccountIdentification1 or NolocalAccountIdentification or NzlocalAccountIdentification or NumberAndBicAccountIdentification or PllocalAccountIdentification or SelocalAccountIdentification or SglocalAccountIdentification or UklocalAccountIdentification or UslocalAccountIdentification schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AccountIdentification111 value, JsonSerializerOptions options)
    {
        if (value.TryGetAulocalAccountIdentification(out var aulocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, aulocalAccountIdentificationValue, options);
        }
        else if (value.TryGetBrlocalAccountIdentification(out var brlocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, brlocalAccountIdentificationValue, options);
        }
        else if (value.TryGetCalocalAccountIdentification(out var calocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, calocalAccountIdentificationValue, options);
        }
        else if (value.TryGetCzlocalAccountIdentification(out var czlocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, czlocalAccountIdentificationValue, options);
        }
        else if (value.TryGetDklocalAccountIdentification(out var dklocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, dklocalAccountIdentificationValue, options);
        }
        else if (value.TryGetHklocalAccountIdentification(out var hklocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, hklocalAccountIdentificationValue, options);
        }
        else if (value.TryGetHulocalAccountIdentification(out var hulocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, hulocalAccountIdentificationValue, options);
        }
        else if (value.TryGetIbanAccountIdentification1(out var ibanAccountIdentification1Value))
        {
            JsonSerializer.Serialize(writer, ibanAccountIdentification1Value, options);
        }
        else if (value.TryGetNolocalAccountIdentification(out var nolocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, nolocalAccountIdentificationValue, options);
        }
        else if (value.TryGetNzlocalAccountIdentification(out var nzlocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, nzlocalAccountIdentificationValue, options);
        }
        else if (value.TryGetNumberAndBicAccountIdentification(out var numberAndBicAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, numberAndBicAccountIdentificationValue, options);
        }
        else if (value.TryGetPllocalAccountIdentification(out var pllocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, pllocalAccountIdentificationValue, options);
        }
        else if (value.TryGetSelocalAccountIdentification(out var selocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, selocalAccountIdentificationValue, options);
        }
        else if (value.TryGetSglocalAccountIdentification(out var sglocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, sglocalAccountIdentificationValue, options);
        }
        else if (value.TryGetUklocalAccountIdentification(out var uklocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, uklocalAccountIdentificationValue, options);
        }
        else if (value.TryGetUslocalAccountIdentification(out var uslocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, uslocalAccountIdentificationValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AccountIdentification111)} contains no valid value to serialize.");
        }
    }
}
