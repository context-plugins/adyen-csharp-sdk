using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The relevant data according to the transfer category.
/// </summary>
[JsonConverter(typeof(CategoryDataConverter))]
public record CategoryData
{
    private readonly Optional<BankCategoryData> _bankCategoryDataValue;

    private readonly Optional<InternalCategoryData> _internalCategoryDataValue;

    private readonly Optional<IssuedCard> _issuedCardValue;

    private readonly Optional<PlatformPayment> _platformPaymentValue;

    private CategoryData(Optional<BankCategoryData> bankCategoryDataValue,
        Optional<InternalCategoryData> internalCategoryDataValue,
        Optional<IssuedCard> issuedCardValue,
        Optional<PlatformPayment> platformPaymentValue)
    {
        _bankCategoryDataValue = bankCategoryDataValue;
        _internalCategoryDataValue = internalCategoryDataValue;
        _issuedCardValue = issuedCardValue;
        _platformPaymentValue = platformPaymentValue;
    }

    public static CategoryData BankCategoryData(BankCategoryData value) =>
        new(Optional<BankCategoryData>.Some(value), default, default, default);

    public static CategoryData InternalCategoryData(InternalCategoryData value) =>
        new(default, Optional<InternalCategoryData>.Some(value), default, default);

    public static CategoryData IssuedCard(IssuedCard value) =>
        new(default, default, Optional<IssuedCard>.Some(value), default);

    public static CategoryData PlatformPayment(PlatformPayment value) =>
        new(default, default, default, Optional<PlatformPayment>.Some(value));

    public bool TryGetBankCategoryData(out BankCategoryData value) =>
        _bankCategoryDataValue.TryGetValue(out value);

    public bool TryGetInternalCategoryData(out InternalCategoryData value) =>
        _internalCategoryDataValue.TryGetValue(out value);

    public bool TryGetIssuedCard(out IssuedCard value) => _issuedCardValue.TryGetValue(out value);

    public bool TryGetPlatformPayment(out PlatformPayment value) =>
        _platformPaymentValue.TryGetValue(out value);

    public static implicit operator CategoryData(BankCategoryData value) => BankCategoryData(value);

    public static implicit operator CategoryData(InternalCategoryData value) => InternalCategoryData(value);

    public static implicit operator CategoryData(IssuedCard value) => IssuedCard(value);

    public static implicit operator CategoryData(PlatformPayment value) => PlatformPayment(value);
}

file sealed class CategoryDataConverter : JsonConverter<CategoryData>
{
    public override CategoryData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<BankCategoryData>(root, options, out var bankCategoryDataValue))
        {
            return CategoryData.BankCategoryData(bankCategoryDataValue);
        }
        if (JsonSerializer.TryDeserialize<InternalCategoryData>(root, options, out var internalCategoryDataValue))
        {
            return CategoryData.InternalCategoryData(internalCategoryDataValue);
        }
        if (JsonSerializer.TryDeserialize<IssuedCard>(root, options, out var issuedCardValue))
        {
            return CategoryData.IssuedCard(issuedCardValue);
        }
        if (JsonSerializer.TryDeserialize<PlatformPayment>(root, options, out var platformPaymentValue))
        {
            return CategoryData.PlatformPayment(platformPaymentValue);
        }
        throw new JsonException($"JSON does not match BankCategoryData or InternalCategoryData or IssuedCard or PlatformPayment schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CategoryData value, JsonSerializerOptions options)
    {
        if (value.TryGetBankCategoryData(out var bankCategoryDataValue))
        {
            JsonSerializer.Serialize(writer, bankCategoryDataValue, options);
        }
        else if (value.TryGetInternalCategoryData(out var internalCategoryDataValue))
        {
            JsonSerializer.Serialize(writer, internalCategoryDataValue, options);
        }
        else if (value.TryGetIssuedCard(out var issuedCardValue))
        {
            JsonSerializer.Serialize(writer, issuedCardValue, options);
        }
        else if (value.TryGetPlatformPayment(out var platformPaymentValue))
        {
            JsonSerializer.Serialize(writer, platformPaymentValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CategoryData)} contains no valid value to serialize.");
        }
    }
}
