using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, NOLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(NoLocalAccountIdentification1Converter))]
public record NoLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required NoLocalAccountIdentification1Properties NoLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out NoLocalAccountIdentification1Properties noLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        noLocalAccountIdentification1Properties = NoLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(NoLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator NoLocalAccountIdentification1Properties(NoLocalAccountIdentification1 value) =>
        value.NoLocalAccountIdentification1Properties;
}

file class NoLocalAccountIdentification1Converter : JsonConverter<NoLocalAccountIdentification1>
{
    public override NoLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var noLocalAccountIdentification1Properties = root.Deserialize<NoLocalAccountIdentification1Properties>(
            options) ??
            throw new JsonException("Failed to deserialize NoLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(
                bankAccountIdentification.AdditionalProperties,
                noLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        noLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new NoLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            NoLocalAccountIdentification1Properties = noLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        NoLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.NoLocalAccountIdentification1Properties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
