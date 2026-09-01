using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, CZLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(CzLocalAccountIdentification1Converter))]
public record CzLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required CzLocalAccountIdentification1Properties CzLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out CzLocalAccountIdentification1Properties czLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        czLocalAccountIdentification1Properties = CzLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(CzLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator CzLocalAccountIdentification1Properties(CzLocalAccountIdentification1 value) =>
        value.CzLocalAccountIdentification1Properties;
}

file class CzLocalAccountIdentification1Converter : JsonConverter<CzLocalAccountIdentification1>
{
    public override CzLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var czLocalAccountIdentification1Properties = root.Deserialize<CzLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize CzLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                czLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        czLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new CzLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            CzLocalAccountIdentification1Properties = czLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        CzLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.CzLocalAccountIdentification1Properties,
                options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
