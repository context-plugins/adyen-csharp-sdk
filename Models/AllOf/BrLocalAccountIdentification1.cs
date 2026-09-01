using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, BRLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(BrLocalAccountIdentification1Converter))]
public record BrLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required BrLocalAccountIdentification1Properties BrLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out BrLocalAccountIdentification1Properties brLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        brLocalAccountIdentification1Properties = BrLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(BrLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator BrLocalAccountIdentification1Properties(BrLocalAccountIdentification1 value) =>
        value.BrLocalAccountIdentification1Properties;
}

file class BrLocalAccountIdentification1Converter : JsonConverter<BrLocalAccountIdentification1>
{
    public override BrLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var brLocalAccountIdentification1Properties = root.Deserialize<BrLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize BrLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                brLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        brLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new BrLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            BrLocalAccountIdentification1Properties = brLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        BrLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BrLocalAccountIdentification1Properties,
                options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
