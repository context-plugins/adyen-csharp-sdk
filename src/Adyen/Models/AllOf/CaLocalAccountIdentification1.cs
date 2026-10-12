using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, CALocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(CaLocalAccountIdentification1Converter))]
public record CaLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required CaLocalAccountIdentification1Properties CaLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out CaLocalAccountIdentification1Properties caLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        caLocalAccountIdentification1Properties = CaLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(CaLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator CaLocalAccountIdentification1Properties(CaLocalAccountIdentification1 value) =>
        value.CaLocalAccountIdentification1Properties;
}

file class CaLocalAccountIdentification1Converter : JsonConverter<CaLocalAccountIdentification1>
{
    public override CaLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var caLocalAccountIdentification1Properties = root.Deserialize<CaLocalAccountIdentification1Properties>(
            options) ??
            throw new JsonException("Failed to deserialize CaLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(
                bankAccountIdentification.AdditionalProperties,
                caLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        caLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new CaLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            CaLocalAccountIdentification1Properties = caLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        CaLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.CaLocalAccountIdentification1Properties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
