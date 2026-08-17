using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// Contains the bank account details. The fields required in this object depend on the country of the bank account and the currency of the transfer.
/// </summary>
[JsonConverter(typeof(AccountIdentification2Converter))]
public record AccountIdentification2
{
    private readonly Optional<IbanAccountIdentification> _ibanAccountIdentificationValue;

    private readonly Optional<NumberAndBicAccountIdentification> _numberAndBicAccountIdentificationValue;

    private readonly Optional<AuLocalAccountIdentification> _auLocalAccountIdentificationValue;

    private readonly Optional<CzLocalAccountIdentification> _czLocalAccountIdentificationValue;

    private readonly Optional<NoLocalAccountIdentification> _noLocalAccountIdentificationValue;

    private readonly Optional<PlLocalAccountIdentification> _plLocalAccountIdentificationValue;

    private readonly Optional<HuLocalAccountIdentification> _huLocalAccountIdentificationValue;

    private readonly Optional<SeLocalAccountIdentification> _seLocalAccountIdentificationValue;

    private readonly Optional<SgLocalAccountIdentification> _sgLocalAccountIdentificationValue;

    private readonly Optional<UkLocalAccountIdentification> _ukLocalAccountIdentificationValue;

    private readonly Optional<UsLocalAccountIdentification> _usLocalAccountIdentificationValue;

    private readonly Optional<BrLocalAccountIdentification> _brLocalAccountIdentificationValue;

    private readonly Optional<DkLocalAccountIdentification> _dkLocalAccountIdentificationValue;

    private readonly Optional<CaLocalAccountIdentification> _caLocalAccountIdentificationValue;

    private readonly Optional<NzLocalAccountIdentification> _nzLocalAccountIdentificationValue;

    private readonly Optional<HkLocalAccountIdentification> _hkLocalAccountIdentificationValue;

    private AccountIdentification2(Optional<IbanAccountIdentification> ibanAccountIdentificationValue,
        Optional<NumberAndBicAccountIdentification> numberAndBicAccountIdentificationValue,
        Optional<AuLocalAccountIdentification> auLocalAccountIdentificationValue,
        Optional<CzLocalAccountIdentification> czLocalAccountIdentificationValue,
        Optional<NoLocalAccountIdentification> noLocalAccountIdentificationValue,
        Optional<PlLocalAccountIdentification> plLocalAccountIdentificationValue,
        Optional<HuLocalAccountIdentification> huLocalAccountIdentificationValue,
        Optional<SeLocalAccountIdentification> seLocalAccountIdentificationValue,
        Optional<SgLocalAccountIdentification> sgLocalAccountIdentificationValue,
        Optional<UkLocalAccountIdentification> ukLocalAccountIdentificationValue,
        Optional<UsLocalAccountIdentification> usLocalAccountIdentificationValue,
        Optional<BrLocalAccountIdentification> brLocalAccountIdentificationValue,
        Optional<DkLocalAccountIdentification> dkLocalAccountIdentificationValue,
        Optional<CaLocalAccountIdentification> caLocalAccountIdentificationValue,
        Optional<NzLocalAccountIdentification> nzLocalAccountIdentificationValue,
        Optional<HkLocalAccountIdentification> hkLocalAccountIdentificationValue)
    {
        _ibanAccountIdentificationValue = ibanAccountIdentificationValue;
        _numberAndBicAccountIdentificationValue = numberAndBicAccountIdentificationValue;
        _auLocalAccountIdentificationValue = auLocalAccountIdentificationValue;
        _czLocalAccountIdentificationValue = czLocalAccountIdentificationValue;
        _noLocalAccountIdentificationValue = noLocalAccountIdentificationValue;
        _plLocalAccountIdentificationValue = plLocalAccountIdentificationValue;
        _huLocalAccountIdentificationValue = huLocalAccountIdentificationValue;
        _seLocalAccountIdentificationValue = seLocalAccountIdentificationValue;
        _sgLocalAccountIdentificationValue = sgLocalAccountIdentificationValue;
        _ukLocalAccountIdentificationValue = ukLocalAccountIdentificationValue;
        _usLocalAccountIdentificationValue = usLocalAccountIdentificationValue;
        _brLocalAccountIdentificationValue = brLocalAccountIdentificationValue;
        _dkLocalAccountIdentificationValue = dkLocalAccountIdentificationValue;
        _caLocalAccountIdentificationValue = caLocalAccountIdentificationValue;
        _nzLocalAccountIdentificationValue = nzLocalAccountIdentificationValue;
        _hkLocalAccountIdentificationValue = hkLocalAccountIdentificationValue;
    }

    public static AccountIdentification2 IbanAccountIdentification(IbanAccountIdentification value) =>
        new(Optional<IbanAccountIdentification>.Some(value),
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

    public static AccountIdentification2 NumberAndBicAccountIdentification(NumberAndBicAccountIdentification value) =>
        new(default,
            Optional<NumberAndBicAccountIdentification>.Some(value),
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

    public static AccountIdentification2 AuLocalAccountIdentification(AuLocalAccountIdentification value) =>
        new(default,
            default,
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
            default);

    public static AccountIdentification2 CzLocalAccountIdentification(CzLocalAccountIdentification value) =>
        new(default,
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

    public static AccountIdentification2 NoLocalAccountIdentification(NoLocalAccountIdentification value) =>
        new(default,
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
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification2 PlLocalAccountIdentification(PlLocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<PlLocalAccountIdentification>.Some(value),
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

    public static AccountIdentification2 HuLocalAccountIdentification(HuLocalAccountIdentification value) =>
        new(default,
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

    public static AccountIdentification2 SeLocalAccountIdentification(SeLocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SeLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification2 SgLocalAccountIdentification(SgLocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SgLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification2 UkLocalAccountIdentification(UkLocalAccountIdentification value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UkLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification2 UsLocalAccountIdentification(UsLocalAccountIdentification value) =>
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
            Optional<UsLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static AccountIdentification2 BrLocalAccountIdentification(BrLocalAccountIdentification value) =>
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
            Optional<BrLocalAccountIdentification>.Some(value),
            default,
            default,
            default,
            default);

    public static AccountIdentification2 DkLocalAccountIdentification(DkLocalAccountIdentification value) =>
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
            Optional<DkLocalAccountIdentification>.Some(value),
            default,
            default,
            default);

    public static AccountIdentification2 CaLocalAccountIdentification(CaLocalAccountIdentification value) =>
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
            Optional<CaLocalAccountIdentification>.Some(value),
            default,
            default);

    public static AccountIdentification2 NzLocalAccountIdentification(NzLocalAccountIdentification value) =>
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
            Optional<NzLocalAccountIdentification>.Some(value),
            default);

    public static AccountIdentification2 HkLocalAccountIdentification(HkLocalAccountIdentification value) =>
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
            Optional<HkLocalAccountIdentification>.Some(value));

    public bool TryGetIbanAccountIdentification(out IbanAccountIdentification value) =>
        _ibanAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetNumberAndBicAccountIdentification(out NumberAndBicAccountIdentification value) =>
        _numberAndBicAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetAuLocalAccountIdentification(out AuLocalAccountIdentification value) =>
        _auLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetCzLocalAccountIdentification(out CzLocalAccountIdentification value) =>
        _czLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetNoLocalAccountIdentification(out NoLocalAccountIdentification value) =>
        _noLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetPlLocalAccountIdentification(out PlLocalAccountIdentification value) =>
        _plLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetHuLocalAccountIdentification(out HuLocalAccountIdentification value) =>
        _huLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetSeLocalAccountIdentification(out SeLocalAccountIdentification value) =>
        _seLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetSgLocalAccountIdentification(out SgLocalAccountIdentification value) =>
        _sgLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetUkLocalAccountIdentification(out UkLocalAccountIdentification value) =>
        _ukLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetUsLocalAccountIdentification(out UsLocalAccountIdentification value) =>
        _usLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetBrLocalAccountIdentification(out BrLocalAccountIdentification value) =>
        _brLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetDkLocalAccountIdentification(out DkLocalAccountIdentification value) =>
        _dkLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetCaLocalAccountIdentification(out CaLocalAccountIdentification value) =>
        _caLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetNzLocalAccountIdentification(out NzLocalAccountIdentification value) =>
        _nzLocalAccountIdentificationValue.TryGetValue(out value);

    public bool TryGetHkLocalAccountIdentification(out HkLocalAccountIdentification value) =>
        _hkLocalAccountIdentificationValue.TryGetValue(out value);

    public static implicit operator AccountIdentification2(IbanAccountIdentification value) =>
        IbanAccountIdentification(value);

    public static implicit operator AccountIdentification2(NumberAndBicAccountIdentification value) =>
        NumberAndBicAccountIdentification(value);

    public static implicit operator AccountIdentification2(AuLocalAccountIdentification value) =>
        AuLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(CzLocalAccountIdentification value) =>
        CzLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(NoLocalAccountIdentification value) =>
        NoLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(PlLocalAccountIdentification value) =>
        PlLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(HuLocalAccountIdentification value) =>
        HuLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(SeLocalAccountIdentification value) =>
        SeLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(SgLocalAccountIdentification value) =>
        SgLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(UkLocalAccountIdentification value) =>
        UkLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(UsLocalAccountIdentification value) =>
        UsLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(BrLocalAccountIdentification value) =>
        BrLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(DkLocalAccountIdentification value) =>
        DkLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(CaLocalAccountIdentification value) =>
        CaLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(NzLocalAccountIdentification value) =>
        NzLocalAccountIdentification(value);

    public static implicit operator AccountIdentification2(HkLocalAccountIdentification value) =>
        HkLocalAccountIdentification(value);
}

file sealed class AccountIdentification2Converter : JsonConverter<AccountIdentification2>
{
    public override AccountIdentification2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            "iban" => AccountIdentification2.IbanAccountIdentification(root.Deserialize<IbanAccountIdentification>(options)!),
            "numberAndBic" => AccountIdentification2.NumberAndBicAccountIdentification(root.Deserialize<NumberAndBicAccountIdentification>(options)!),
            "auLocal" => AccountIdentification2.AuLocalAccountIdentification(root.Deserialize<AuLocalAccountIdentification>(options)!),
            "czLocal" => AccountIdentification2.CzLocalAccountIdentification(root.Deserialize<CzLocalAccountIdentification>(options)!),
            "noLocal" => AccountIdentification2.NoLocalAccountIdentification(root.Deserialize<NoLocalAccountIdentification>(options)!),
            "plLocal" => AccountIdentification2.PlLocalAccountIdentification(root.Deserialize<PlLocalAccountIdentification>(options)!),
            "huLocal" => AccountIdentification2.HuLocalAccountIdentification(root.Deserialize<HuLocalAccountIdentification>(options)!),
            "seLocal" => AccountIdentification2.SeLocalAccountIdentification(root.Deserialize<SeLocalAccountIdentification>(options)!),
            "sgLocal" => AccountIdentification2.SgLocalAccountIdentification(root.Deserialize<SgLocalAccountIdentification>(options)!),
            "ukLocal" => AccountIdentification2.UkLocalAccountIdentification(root.Deserialize<UkLocalAccountIdentification>(options)!),
            "usLocal" => AccountIdentification2.UsLocalAccountIdentification(root.Deserialize<UsLocalAccountIdentification>(options)!),
            "brLocal" => AccountIdentification2.BrLocalAccountIdentification(root.Deserialize<BrLocalAccountIdentification>(options)!),
            "dkLocal" => AccountIdentification2.DkLocalAccountIdentification(root.Deserialize<DkLocalAccountIdentification>(options)!),
            "caLocal" => AccountIdentification2.CaLocalAccountIdentification(root.Deserialize<CaLocalAccountIdentification>(options)!),
            "nzLocal" => AccountIdentification2.NzLocalAccountIdentification(root.Deserialize<NzLocalAccountIdentification>(options)!),
            "hkLocal" => AccountIdentification2.HkLocalAccountIdentification(root.Deserialize<HkLocalAccountIdentification>(options)!),
            _ => throw new JsonException($"JSON does not match IbanAccountIdentification or NumberAndBicAccountIdentification or AuLocalAccountIdentification or CzLocalAccountIdentification or NoLocalAccountIdentification or PlLocalAccountIdentification or HuLocalAccountIdentification or SeLocalAccountIdentification or SgLocalAccountIdentification or UkLocalAccountIdentification or UsLocalAccountIdentification or BrLocalAccountIdentification or DkLocalAccountIdentification or CaLocalAccountIdentification or NzLocalAccountIdentification or HkLocalAccountIdentification schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, AccountIdentification2 value, JsonSerializerOptions options)
    {
        if (value.TryGetIbanAccountIdentification(out var ibanAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, ibanAccountIdentificationValue, options);
        }
        else if (value.TryGetNumberAndBicAccountIdentification(out var numberAndBicAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, numberAndBicAccountIdentificationValue, options);
        }
        else if (value.TryGetAuLocalAccountIdentification(out var auLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, auLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetCzLocalAccountIdentification(out var czLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, czLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetNoLocalAccountIdentification(out var noLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, noLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetPlLocalAccountIdentification(out var plLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, plLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetHuLocalAccountIdentification(out var huLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, huLocalAccountIdentificationValue, options);
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
        else if (value.TryGetBrLocalAccountIdentification(out var brLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, brLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetDkLocalAccountIdentification(out var dkLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, dkLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetCaLocalAccountIdentification(out var caLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, caLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetNzLocalAccountIdentification(out var nzLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, nzLocalAccountIdentificationValue, options);
        }
        else if (value.TryGetHkLocalAccountIdentification(out var hkLocalAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, hkLocalAccountIdentificationValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AccountIdentification2)} contains no valid value to serialize.");
        }
    }
}
