using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, PLLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(PlLocalAccountIdentification1Converter))]
public record PlLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required PlLocalAccountIdentification1Properties PlLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out PlLocalAccountIdentification1Properties plLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        plLocalAccountIdentification1Properties = PlLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(PlLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator PlLocalAccountIdentification1Properties(PlLocalAccountIdentification1 value) =>
        value.PlLocalAccountIdentification1Properties;
}

file class PlLocalAccountIdentification1Converter : JsonConverter<PlLocalAccountIdentification1>
{
    public override PlLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var plLocalAccountIdentification1Properties = root.Deserialize<PlLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize PlLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                plLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        plLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new PlLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            PlLocalAccountIdentification1Properties = plLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        PlLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.PlLocalAccountIdentification1Properties,
                options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
