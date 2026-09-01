using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, HULocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(HuLocalAccountIdentification1Converter))]
public record HuLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required HuLocalAccountIdentification1Properties HuLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out HuLocalAccountIdentification1Properties huLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        huLocalAccountIdentification1Properties = HuLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(HuLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator HuLocalAccountIdentification1Properties(HuLocalAccountIdentification1 value) =>
        value.HuLocalAccountIdentification1Properties;
}

file class HuLocalAccountIdentification1Converter : JsonConverter<HuLocalAccountIdentification1>
{
    public override HuLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var huLocalAccountIdentification1Properties = root.Deserialize<HuLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize HuLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                huLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        huLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new HuLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            HuLocalAccountIdentification1Properties = huLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        HuLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.HuLocalAccountIdentification1Properties,
                options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
