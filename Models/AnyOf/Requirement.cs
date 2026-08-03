using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

[JsonConverter(typeof(RequirementConverter))]
public record Requirement
{
    private readonly Optional<AdditionalBankIdentificationRequirement> _additionalBankIdentificationRequirementValue;

    private readonly Optional<AddressRequirement> _addressRequirementValue;

    private readonly Optional<AmountMinMaxRequirement> _amountMinMaxRequirementValue;

    private readonly Optional<AmountNonZeroDecimalsRequirement> _amountNonZeroDecimalsRequirementValue;

    private readonly Optional<BankAccountIdentificationTypeRequirement> _bankAccountIdentificationTypeRequirementValue;

    private readonly Optional<IbanAccountIdentificationRequirement> _ibanAccountIdentificationRequirementValue;

    private readonly Optional<PaymentInstrumentRequirement> _paymentInstrumentRequirementValue;

    private readonly Optional<UsinstantPayoutAddressRequirement> _usinstantPayoutAddressRequirementValue;

    private readonly Optional<UsinternationalAchAddressRequirement> _usinternationalAchAddressRequirementValue;

    private readonly Optional<UsinternationalAchPriorityRequirement> _usinternationalAchPriorityRequirementValue;

    private Requirement(Optional<AdditionalBankIdentificationRequirement> additionalBankIdentificationRequirementValue,
        Optional<AddressRequirement> addressRequirementValue,
        Optional<AmountMinMaxRequirement> amountMinMaxRequirementValue,
        Optional<AmountNonZeroDecimalsRequirement> amountNonZeroDecimalsRequirementValue,
        Optional<BankAccountIdentificationTypeRequirement> bankAccountIdentificationTypeRequirementValue,
        Optional<IbanAccountIdentificationRequirement> ibanAccountIdentificationRequirementValue,
        Optional<PaymentInstrumentRequirement> paymentInstrumentRequirementValue,
        Optional<UsinstantPayoutAddressRequirement> usinstantPayoutAddressRequirementValue,
        Optional<UsinternationalAchAddressRequirement> usinternationalAchAddressRequirementValue,
        Optional<UsinternationalAchPriorityRequirement> usinternationalAchPriorityRequirementValue)
    {
        _additionalBankIdentificationRequirementValue = additionalBankIdentificationRequirementValue;
        _addressRequirementValue = addressRequirementValue;
        _amountMinMaxRequirementValue = amountMinMaxRequirementValue;
        _amountNonZeroDecimalsRequirementValue = amountNonZeroDecimalsRequirementValue;
        _bankAccountIdentificationTypeRequirementValue = bankAccountIdentificationTypeRequirementValue;
        _ibanAccountIdentificationRequirementValue = ibanAccountIdentificationRequirementValue;
        _paymentInstrumentRequirementValue = paymentInstrumentRequirementValue;
        _usinstantPayoutAddressRequirementValue = usinstantPayoutAddressRequirementValue;
        _usinternationalAchAddressRequirementValue = usinternationalAchAddressRequirementValue;
        _usinternationalAchPriorityRequirementValue = usinternationalAchPriorityRequirementValue;
    }

    public static Requirement AdditionalBankIdentificationRequirement(AdditionalBankIdentificationRequirement value) =>
        new(Optional<AdditionalBankIdentificationRequirement>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Requirement AddressRequirement(AddressRequirement value) =>
        new(default,
            Optional<AddressRequirement>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Requirement AmountMinMaxRequirement(AmountMinMaxRequirement value) =>
        new(default,
            default,
            Optional<AmountMinMaxRequirement>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Requirement AmountNonZeroDecimalsRequirement(AmountNonZeroDecimalsRequirement value) =>
        new(default,
            default,
            default,
            Optional<AmountNonZeroDecimalsRequirement>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static Requirement BankAccountIdentificationTypeRequirement(BankAccountIdentificationTypeRequirement value) =>
        new(default,
            default,
            default,
            default,
            Optional<BankAccountIdentificationTypeRequirement>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static Requirement IbanAccountIdentificationRequirement(IbanAccountIdentificationRequirement value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<IbanAccountIdentificationRequirement>.Some(value),
            default,
            default,
            default,
            default);

    public static Requirement PaymentInstrumentRequirement(PaymentInstrumentRequirement value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<PaymentInstrumentRequirement>.Some(value),
            default,
            default,
            default);

    public static Requirement UsinstantPayoutAddressRequirement(UsinstantPayoutAddressRequirement value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UsinstantPayoutAddressRequirement>.Some(value),
            default,
            default);

    public static Requirement UsinternationalAchAddressRequirement(UsinternationalAchAddressRequirement value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UsinternationalAchAddressRequirement>.Some(value),
            default);

    public static Requirement UsinternationalAchPriorityRequirement(UsinternationalAchPriorityRequirement value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UsinternationalAchPriorityRequirement>.Some(value));

    public bool TryGetAdditionalBankIdentificationRequirement(out AdditionalBankIdentificationRequirement value) =>
        _additionalBankIdentificationRequirementValue.TryGetValue(out value);

    public bool TryGetAddressRequirement(out AddressRequirement value) =>
        _addressRequirementValue.TryGetValue(out value);

    public bool TryGetAmountMinMaxRequirement(out AmountMinMaxRequirement value) =>
        _amountMinMaxRequirementValue.TryGetValue(out value);

    public bool TryGetAmountNonZeroDecimalsRequirement(out AmountNonZeroDecimalsRequirement value) =>
        _amountNonZeroDecimalsRequirementValue.TryGetValue(out value);

    public bool TryGetBankAccountIdentificationTypeRequirement(out BankAccountIdentificationTypeRequirement value) =>
        _bankAccountIdentificationTypeRequirementValue.TryGetValue(out value);

    public bool TryGetIbanAccountIdentificationRequirement(out IbanAccountIdentificationRequirement value) =>
        _ibanAccountIdentificationRequirementValue.TryGetValue(out value);

    public bool TryGetPaymentInstrumentRequirement(out PaymentInstrumentRequirement value) =>
        _paymentInstrumentRequirementValue.TryGetValue(out value);

    public bool TryGetUsinstantPayoutAddressRequirement(out UsinstantPayoutAddressRequirement value) =>
        _usinstantPayoutAddressRequirementValue.TryGetValue(out value);

    public bool TryGetUsinternationalAchAddressRequirement(out UsinternationalAchAddressRequirement value) =>
        _usinternationalAchAddressRequirementValue.TryGetValue(out value);

    public bool TryGetUsinternationalAchPriorityRequirement(out UsinternationalAchPriorityRequirement value) =>
        _usinternationalAchPriorityRequirementValue.TryGetValue(out value);

    public static implicit operator Requirement(AdditionalBankIdentificationRequirement value) =>
        AdditionalBankIdentificationRequirement(value);

    public static implicit operator Requirement(AddressRequirement value) => AddressRequirement(value);

    public static implicit operator Requirement(AmountMinMaxRequirement value) =>
        AmountMinMaxRequirement(value);

    public static implicit operator Requirement(AmountNonZeroDecimalsRequirement value) =>
        AmountNonZeroDecimalsRequirement(value);

    public static implicit operator Requirement(BankAccountIdentificationTypeRequirement value) =>
        BankAccountIdentificationTypeRequirement(value);

    public static implicit operator Requirement(IbanAccountIdentificationRequirement value) =>
        IbanAccountIdentificationRequirement(value);

    public static implicit operator Requirement(PaymentInstrumentRequirement value) =>
        PaymentInstrumentRequirement(value);

    public static implicit operator Requirement(UsinstantPayoutAddressRequirement value) =>
        UsinstantPayoutAddressRequirement(value);

    public static implicit operator Requirement(UsinternationalAchAddressRequirement value) =>
        UsinternationalAchAddressRequirement(value);

    public static implicit operator Requirement(UsinternationalAchPriorityRequirement value) =>
        UsinternationalAchPriorityRequirement(value);
}

file sealed class RequirementConverter : JsonConverter<Requirement>
{
    public override Requirement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AdditionalBankIdentificationRequirement>(root,
            options,
            out var additionalBankIdentificationRequirementValue))
        {
            return Requirement.AdditionalBankIdentificationRequirement(additionalBankIdentificationRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<AddressRequirement>(root, options, out var addressRequirementValue))
        {
            return Requirement.AddressRequirement(addressRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<AmountMinMaxRequirement>(root,
            options,
            out var amountMinMaxRequirementValue))
        {
            return Requirement.AmountMinMaxRequirement(amountMinMaxRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<AmountNonZeroDecimalsRequirement>(root,
            options,
            out var amountNonZeroDecimalsRequirementValue))
        {
            return Requirement.AmountNonZeroDecimalsRequirement(amountNonZeroDecimalsRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<BankAccountIdentificationTypeRequirement>(root,
            options,
            out var bankAccountIdentificationTypeRequirementValue))
        {
            return Requirement.BankAccountIdentificationTypeRequirement(bankAccountIdentificationTypeRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<IbanAccountIdentificationRequirement>(root,
            options,
            out var ibanAccountIdentificationRequirementValue))
        {
            return Requirement.IbanAccountIdentificationRequirement(ibanAccountIdentificationRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<PaymentInstrumentRequirement>(root,
            options,
            out var paymentInstrumentRequirementValue))
        {
            return Requirement.PaymentInstrumentRequirement(paymentInstrumentRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<UsinstantPayoutAddressRequirement>(root,
            options,
            out var usinstantPayoutAddressRequirementValue))
        {
            return Requirement.UsinstantPayoutAddressRequirement(usinstantPayoutAddressRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<UsinternationalAchAddressRequirement>(root,
            options,
            out var usinternationalAchAddressRequirementValue))
        {
            return Requirement.UsinternationalAchAddressRequirement(usinternationalAchAddressRequirementValue);
        }
        if (JsonSerializer.TryDeserialize<UsinternationalAchPriorityRequirement>(root,
            options,
            out var usinternationalAchPriorityRequirementValue))
        {
            return Requirement.UsinternationalAchPriorityRequirement(usinternationalAchPriorityRequirementValue);
        }
        throw new JsonException($"JSON does not match AdditionalBankIdentificationRequirement or AddressRequirement or AmountMinMaxRequirement or AmountNonZeroDecimalsRequirement or BankAccountIdentificationTypeRequirement or IbanAccountIdentificationRequirement or PaymentInstrumentRequirement or UsinstantPayoutAddressRequirement or UsinternationalAchAddressRequirement or UsinternationalAchPriorityRequirement schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Requirement value, JsonSerializerOptions options)
    {
        if (value.TryGetAdditionalBankIdentificationRequirement(out var additionalBankIdentificationRequirementValue))
        {
            JsonSerializer.Serialize(writer, additionalBankIdentificationRequirementValue, options);
        }
        else if (value.TryGetAddressRequirement(out var addressRequirementValue))
        {
            JsonSerializer.Serialize(writer, addressRequirementValue, options);
        }
        else if (value.TryGetAmountMinMaxRequirement(out var amountMinMaxRequirementValue))
        {
            JsonSerializer.Serialize(writer, amountMinMaxRequirementValue, options);
        }
        else if (value.TryGetAmountNonZeroDecimalsRequirement(out var amountNonZeroDecimalsRequirementValue))
        {
            JsonSerializer.Serialize(writer, amountNonZeroDecimalsRequirementValue, options);
        }
        else if (value.TryGetBankAccountIdentificationTypeRequirement(out var bankAccountIdentificationTypeRequirementValue))
        {
            JsonSerializer.Serialize(writer, bankAccountIdentificationTypeRequirementValue, options);
        }
        else if (value.TryGetIbanAccountIdentificationRequirement(out var ibanAccountIdentificationRequirementValue))
        {
            JsonSerializer.Serialize(writer, ibanAccountIdentificationRequirementValue, options);
        }
        else if (value.TryGetPaymentInstrumentRequirement(out var paymentInstrumentRequirementValue))
        {
            JsonSerializer.Serialize(writer, paymentInstrumentRequirementValue, options);
        }
        else if (value.TryGetUsinstantPayoutAddressRequirement(out var usinstantPayoutAddressRequirementValue))
        {
            JsonSerializer.Serialize(writer, usinstantPayoutAddressRequirementValue, options);
        }
        else if (value.TryGetUsinternationalAchAddressRequirement(out var usinternationalAchAddressRequirementValue))
        {
            JsonSerializer.Serialize(writer, usinternationalAchAddressRequirementValue, options);
        }
        else if (value.TryGetUsinternationalAchPriorityRequirement(out var usinternationalAchPriorityRequirementValue))
        {
            JsonSerializer.Serialize(writer, usinternationalAchPriorityRequirementValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Requirement)} contains no valid value to serialize.");
        }
    }
}
