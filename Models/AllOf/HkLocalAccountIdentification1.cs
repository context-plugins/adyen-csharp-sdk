using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, HKLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(HkLocalAccountIdentification1Converter))]
public record HkLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required HkLocalAccountIdentification1Properties HkLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out HkLocalAccountIdentification1Properties hkLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        hkLocalAccountIdentification1Properties = HkLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(HkLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator HkLocalAccountIdentification1Properties(HkLocalAccountIdentification1 value) =>
        value.HkLocalAccountIdentification1Properties;
}

file class HkLocalAccountIdentification1Converter : JsonConverter<HkLocalAccountIdentification1>
{
    public override HkLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var hkLocalAccountIdentification1Properties = root.Deserialize<HkLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize HkLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                hkLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        hkLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new HkLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            HkLocalAccountIdentification1Properties = hkLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        HkLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.HkLocalAccountIdentification1Properties,
                options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
