using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

[JsonConverter(typeof(RequirementConverter))]
public record Requirement
{
    private readonly Optional<AmountMinMaxRequirement> _amountMinMaxRequirementValue;

    private readonly Optional<AdditionalBankIdentificationRequirement> _additionalBankIdentificationRequirementValue;

    private readonly Optional<AddressRequirement> _addressRequirementValue;

    private readonly Optional<AmountNonZeroDecimalsRequirement> _amountNonZeroDecimalsRequirementValue;

    private readonly Optional<BankAccountIdentificationTypeRequirement> _bankAccountIdentificationTypeRequirementValue;

    private readonly Optional<IbanAccountIdentificationRequirement> _ibanAccountIdentificationRequirementValue;

    private readonly Optional<PaymentInstrumentRequirement> _paymentInstrumentRequirementValue;

    private readonly Optional<UsInternationalAchAddressRequirement> _usInternationalAchAddressRequirementValue;

    private readonly Optional<UsInstantPayoutAddressRequirement> _usInstantPayoutAddressRequirementValue;

    private readonly Optional<UsInternationalAchPriorityRequirement> _usInternationalAchPriorityRequirementValue;

    private Requirement(Optional<AmountMinMaxRequirement> amountMinMaxRequirementValue,
        Optional<AdditionalBankIdentificationRequirement> additionalBankIdentificationRequirementValue,
        Optional<AddressRequirement> addressRequirementValue,
        Optional<AmountNonZeroDecimalsRequirement> amountNonZeroDecimalsRequirementValue,
        Optional<BankAccountIdentificationTypeRequirement> bankAccountIdentificationTypeRequirementValue,
        Optional<IbanAccountIdentificationRequirement> ibanAccountIdentificationRequirementValue,
        Optional<PaymentInstrumentRequirement> paymentInstrumentRequirementValue,
        Optional<UsInternationalAchAddressRequirement> usInternationalAchAddressRequirementValue,
        Optional<UsInstantPayoutAddressRequirement> usInstantPayoutAddressRequirementValue,
        Optional<UsInternationalAchPriorityRequirement> usInternationalAchPriorityRequirementValue)
    {
        _amountMinMaxRequirementValue = amountMinMaxRequirementValue;
        _additionalBankIdentificationRequirementValue = additionalBankIdentificationRequirementValue;
        _addressRequirementValue = addressRequirementValue;
        _amountNonZeroDecimalsRequirementValue = amountNonZeroDecimalsRequirementValue;
        _bankAccountIdentificationTypeRequirementValue = bankAccountIdentificationTypeRequirementValue;
        _ibanAccountIdentificationRequirementValue = ibanAccountIdentificationRequirementValue;
        _paymentInstrumentRequirementValue = paymentInstrumentRequirementValue;
        _usInternationalAchAddressRequirementValue = usInternationalAchAddressRequirementValue;
        _usInstantPayoutAddressRequirementValue = usInstantPayoutAddressRequirementValue;
        _usInternationalAchPriorityRequirementValue = usInternationalAchPriorityRequirementValue;
    }

    public static Requirement AmountMinMaxRequirement(AmountMinMaxRequirement value) =>
        new(
            Optional<AmountMinMaxRequirement>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Requirement AdditionalBankIdentificationRequirement(AdditionalBankIdentificationRequirement value) =>
        new(
            default,
            Optional<AdditionalBankIdentificationRequirement>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Requirement AddressRequirement(AddressRequirement value) =>
        new(
            default,
            default,
            Optional<AddressRequirement>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static Requirement AmountNonZeroDecimalsRequirement(AmountNonZeroDecimalsRequirement value) =>
        new(
            default,
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
        new(
            default,
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
        new(
            default,
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
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<PaymentInstrumentRequirement>.Some(value),
            default,
            default,
            default);

    public static Requirement UsInternationalAchAddressRequirement(UsInternationalAchAddressRequirement value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UsInternationalAchAddressRequirement>.Some(value),
            default,
            default);

    public static Requirement UsInstantPayoutAddressRequirement(UsInstantPayoutAddressRequirement value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UsInstantPayoutAddressRequirement>.Some(value),
            default);

    public static Requirement UsInternationalAchPriorityRequirement(UsInternationalAchPriorityRequirement value) =>
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
            Optional<UsInternationalAchPriorityRequirement>.Some(value));

    public bool TryGetAmountMinMaxRequirement(out AmountMinMaxRequirement value) =>
        _amountMinMaxRequirementValue.TryGetValue(out value);

    public bool TryGetAdditionalBankIdentificationRequirement(out AdditionalBankIdentificationRequirement value) =>
        _additionalBankIdentificationRequirementValue.TryGetValue(out value);

    public bool TryGetAddressRequirement(out AddressRequirement value) =>
        _addressRequirementValue.TryGetValue(out value);

    public bool TryGetAmountNonZeroDecimalsRequirement(out AmountNonZeroDecimalsRequirement value) =>
        _amountNonZeroDecimalsRequirementValue.TryGetValue(out value);

    public bool TryGetBankAccountIdentificationTypeRequirement(out BankAccountIdentificationTypeRequirement value) =>
        _bankAccountIdentificationTypeRequirementValue.TryGetValue(out value);

    public bool TryGetIbanAccountIdentificationRequirement(out IbanAccountIdentificationRequirement value) =>
        _ibanAccountIdentificationRequirementValue.TryGetValue(out value);

    public bool TryGetPaymentInstrumentRequirement(out PaymentInstrumentRequirement value) =>
        _paymentInstrumentRequirementValue.TryGetValue(out value);

    public bool TryGetUsInternationalAchAddressRequirement(out UsInternationalAchAddressRequirement value) =>
        _usInternationalAchAddressRequirementValue.TryGetValue(out value);

    public bool TryGetUsInstantPayoutAddressRequirement(out UsInstantPayoutAddressRequirement value) =>
        _usInstantPayoutAddressRequirementValue.TryGetValue(out value);

    public bool TryGetUsInternationalAchPriorityRequirement(out UsInternationalAchPriorityRequirement value) =>
        _usInternationalAchPriorityRequirementValue.TryGetValue(out value);

    public static implicit operator Requirement(AmountMinMaxRequirement value) => AmountMinMaxRequirement(value);

    public static implicit operator Requirement(AdditionalBankIdentificationRequirement value) =>
        AdditionalBankIdentificationRequirement(value);

    public static implicit operator Requirement(AddressRequirement value) => AddressRequirement(value);

    public static implicit operator Requirement(AmountNonZeroDecimalsRequirement value) =>
        AmountNonZeroDecimalsRequirement(value);

    public static implicit operator Requirement(BankAccountIdentificationTypeRequirement value) =>
        BankAccountIdentificationTypeRequirement(value);

    public static implicit operator Requirement(IbanAccountIdentificationRequirement value) =>
        IbanAccountIdentificationRequirement(value);

    public static implicit operator Requirement(PaymentInstrumentRequirement value) =>
        PaymentInstrumentRequirement(value);

    public static implicit operator Requirement(UsInternationalAchAddressRequirement value) =>
        UsInternationalAchAddressRequirement(value);

    public static implicit operator Requirement(UsInstantPayoutAddressRequirement value) =>
        UsInstantPayoutAddressRequirement(value);

    public static implicit operator Requirement(UsInternationalAchPriorityRequirement value) =>
        UsInternationalAchPriorityRequirement(value);
}

file sealed class RequirementConverter : JsonConverter<Requirement>
{
    public override Requirement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
            "amountMinMaxRequirement" => Requirement.AmountMinMaxRequirement(root.Deserialize<AmountMinMaxRequirement>(
                options)!),
            "additionalBankIdentificationRequirement" => Requirement.AdditionalBankIdentificationRequirement(
                root.Deserialize<AdditionalBankIdentificationRequirement>(options)!),
            "addressRequirement" => Requirement.AddressRequirement(root.Deserialize<AddressRequirement>(options)!),
            "amountNonZeroDecimalsRequirement" => Requirement.AmountNonZeroDecimalsRequirement(
                root.Deserialize<AmountNonZeroDecimalsRequirement>(options)!),
            "bankAccountIdentificationTypeRequirement" => Requirement.BankAccountIdentificationTypeRequirement(
                root.Deserialize<BankAccountIdentificationTypeRequirement>(options)!),
            "ibanAccountIdentificationRequirement" => Requirement.IbanAccountIdentificationRequirement(
                root.Deserialize<IbanAccountIdentificationRequirement>(options)!),
            "paymentInstrumentRequirement" => Requirement.PaymentInstrumentRequirement(
                root.Deserialize<PaymentInstrumentRequirement>(options)!),
            "usInternationalAchAddressRequirement" => Requirement.UsInternationalAchAddressRequirement(
                root.Deserialize<UsInternationalAchAddressRequirement>(options)!),
            "usInstantPayoutAddressRequirement" => Requirement.UsInstantPayoutAddressRequirement(
                root.Deserialize<UsInstantPayoutAddressRequirement>(options)!),
            "usInternationalAchPriorityRequirement" => Requirement.UsInternationalAchPriorityRequirement(
                root.Deserialize<UsInternationalAchPriorityRequirement>(options)!),
            _ => throw new JsonException(
                $"JSON does not match AmountMinMaxRequirement or AdditionalBankIdentificationRequirement or AddressRequirement or AmountNonZeroDecimalsRequirement or BankAccountIdentificationTypeRequirement or IbanAccountIdentificationRequirement or PaymentInstrumentRequirement or UsInternationalAchAddressRequirement or UsInstantPayoutAddressRequirement or UsInternationalAchPriorityRequirement schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, Requirement value, JsonSerializerOptions options)
    {
        if (value.TryGetAmountMinMaxRequirement(out var amountMinMaxRequirementValue))
        {
            JsonSerializer.Serialize(writer, amountMinMaxRequirementValue, options);
        }
        else if (value.TryGetAdditionalBankIdentificationRequirement(
            out var additionalBankIdentificationRequirementValue))
        {
            JsonSerializer.Serialize(writer, additionalBankIdentificationRequirementValue, options);
        }
        else if (value.TryGetAddressRequirement(out var addressRequirementValue))
        {
            JsonSerializer.Serialize(writer, addressRequirementValue, options);
        }
        else if (value.TryGetAmountNonZeroDecimalsRequirement(out var amountNonZeroDecimalsRequirementValue))
        {
            JsonSerializer.Serialize(writer, amountNonZeroDecimalsRequirementValue, options);
        }
        else if (value.TryGetBankAccountIdentificationTypeRequirement(
            out var bankAccountIdentificationTypeRequirementValue))
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
        else if (value.TryGetUsInternationalAchAddressRequirement(out var usInternationalAchAddressRequirementValue))
        {
            JsonSerializer.Serialize(writer, usInternationalAchAddressRequirementValue, options);
        }
        else if (value.TryGetUsInstantPayoutAddressRequirement(out var usInstantPayoutAddressRequirementValue))
        {
            JsonSerializer.Serialize(writer, usInstantPayoutAddressRequirementValue, options);
        }
        else if (value.TryGetUsInternationalAchPriorityRequirement(out var usInternationalAchPriorityRequirementValue))
        {
            JsonSerializer.Serialize(writer, usInternationalAchPriorityRequirementValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Requirement)} contains no valid value to serialize.");
        }
    }
}
