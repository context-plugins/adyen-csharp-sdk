using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, DKLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(DkLocalAccountIdentification1Converter))]
public record DkLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required DkLocalAccountIdentification1Properties DkLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out DkLocalAccountIdentification1Properties dkLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        dkLocalAccountIdentification1Properties = DkLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(DkLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator DkLocalAccountIdentification1Properties(DkLocalAccountIdentification1 value) =>
        value.DkLocalAccountIdentification1Properties;
}

file class DkLocalAccountIdentification1Converter : JsonConverter<DkLocalAccountIdentification1>
{
    public override DkLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var dkLocalAccountIdentification1Properties = root.Deserialize<DkLocalAccountIdentification1Properties>(
            options) ??
            throw new JsonException("Failed to deserialize DkLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(
                bankAccountIdentification.AdditionalProperties,
                dkLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        dkLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new DkLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            DkLocalAccountIdentification1Properties = dkLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        DkLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.DkLocalAccountIdentification1Properties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
