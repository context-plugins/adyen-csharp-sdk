using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// The relevant data according to the transfer category.
/// </summary>
[JsonConverter(typeof(CategoryDataConverter))]
public record CategoryData
{
    private readonly Optional<IssuedCard> _issuedCardValue;

    private readonly Optional<PlatformPayment> _platformPaymentValue;

    private readonly Optional<BankCategoryData> _bankCategoryDataValue;

    private readonly Optional<InternalCategoryData> _internalCategoryDataValue;

    private CategoryData(Optional<IssuedCard> issuedCardValue,
        Optional<PlatformPayment> platformPaymentValue,
        Optional<BankCategoryData> bankCategoryDataValue,
        Optional<InternalCategoryData> internalCategoryDataValue)
    {
        _issuedCardValue = issuedCardValue;
        _platformPaymentValue = platformPaymentValue;
        _bankCategoryDataValue = bankCategoryDataValue;
        _internalCategoryDataValue = internalCategoryDataValue;
    }

    public static CategoryData IssuedCard(IssuedCard value) =>
        new(Optional<IssuedCard>.Some(value), default, default, default);

    public static CategoryData PlatformPayment(PlatformPayment value) =>
        new(default, Optional<PlatformPayment>.Some(value), default, default);

    public static CategoryData BankCategoryData(BankCategoryData value) =>
        new(default, default, Optional<BankCategoryData>.Some(value), default);

    public static CategoryData InternalCategoryData(InternalCategoryData value) =>
        new(default, default, default, Optional<InternalCategoryData>.Some(value));

    public bool TryGetIssuedCard(out IssuedCard value) => _issuedCardValue.TryGetValue(out value);

    public bool TryGetPlatformPayment(out PlatformPayment value) => _platformPaymentValue.TryGetValue(out value);

    public bool TryGetBankCategoryData(out BankCategoryData value) => _bankCategoryDataValue.TryGetValue(out value);

    public bool TryGetInternalCategoryData(out InternalCategoryData value) =>
        _internalCategoryDataValue.TryGetValue(out value);

    public static implicit operator CategoryData(IssuedCard value) => IssuedCard(value);

    public static implicit operator CategoryData(PlatformPayment value) => PlatformPayment(value);

    public static implicit operator CategoryData(BankCategoryData value) => BankCategoryData(value);

    public static implicit operator CategoryData(InternalCategoryData value) => InternalCategoryData(value);
}

file sealed class CategoryDataConverter : JsonConverter<CategoryData>
{
    public override CategoryData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
            "issuedCard" => CategoryData.IssuedCard(root.Deserialize<IssuedCard>(options)!),
            "platformPayment" => CategoryData.PlatformPayment(root.Deserialize<PlatformPayment>(options)!),
            "bank" => CategoryData.BankCategoryData(root.Deserialize<BankCategoryData>(options)!),
            "internal" => CategoryData.InternalCategoryData(root.Deserialize<InternalCategoryData>(options)!),
            _ => throw new JsonException(
                $"JSON does not match IssuedCard or PlatformPayment or BankCategoryData or InternalCategoryData schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, CategoryData value, JsonSerializerOptions options)
    {
        if (value.TryGetIssuedCard(out var issuedCardValue))
        {
            JsonSerializer.Serialize(writer, issuedCardValue, options);
        }
        else if (value.TryGetPlatformPayment(out var platformPaymentValue))
        {
            JsonSerializer.Serialize(writer, platformPaymentValue, options);
        }
        else if (value.TryGetBankCategoryData(out var bankCategoryDataValue))
        {
            JsonSerializer.Serialize(writer, bankCategoryDataValue, options);
        }
        else if (value.TryGetInternalCategoryData(out var internalCategoryDataValue))
        {
            JsonSerializer.Serialize(writer, internalCategoryDataValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CategoryData)} contains no valid value to serialize.");
        }
    }
}
