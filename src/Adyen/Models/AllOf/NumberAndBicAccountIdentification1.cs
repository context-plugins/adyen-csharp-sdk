using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, NumberAndBicAccountIdentification1.
/// </summary>
[JsonConverter(typeof(NumberAndBicAccountIdentification1Converter))]
public record NumberAndBicAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required NumberAndBicAccountIdentification1Properties NumberAndBicAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out NumberAndBicAccountIdentification1Properties numberAndBicAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        numberAndBicAccountIdentification1Properties = NumberAndBicAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(NumberAndBicAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator NumberAndBicAccountIdentification1Properties(NumberAndBicAccountIdentification1 value) =>
        value.NumberAndBicAccountIdentification1Properties;
}

file class NumberAndBicAccountIdentification1Converter : JsonConverter<NumberAndBicAccountIdentification1>
{
    public override NumberAndBicAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var numberAndBicAccountIdentification1Properties = root.Deserialize<NumberAndBicAccountIdentification1Properties>(
            options) ??
            throw new JsonException("Failed to deserialize NumberAndBicAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(
                bankAccountIdentification.AdditionalProperties,
                numberAndBicAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        numberAndBicAccountIdentification1Properties.AdditionalProperties.Clear();
        return new NumberAndBicAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            NumberAndBicAccountIdentification1Properties = numberAndBicAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        NumberAndBicAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.NumberAndBicAccountIdentification1Properties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
