using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, NZLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(NzLocalAccountIdentification1Converter))]
public record NzLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required NzLocalAccountIdentification1Properties NzLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out NzLocalAccountIdentification1Properties nzLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        nzLocalAccountIdentification1Properties = NzLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(NzLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator NzLocalAccountIdentification1Properties(NzLocalAccountIdentification1 value) =>
        value.NzLocalAccountIdentification1Properties;
}

file class NzLocalAccountIdentification1Converter : JsonConverter<NzLocalAccountIdentification1>
{
    public override NzLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var nzLocalAccountIdentification1Properties = root.Deserialize<NzLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize NzLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                nzLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        nzLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new NzLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            NzLocalAccountIdentification1Properties = nzLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        NzLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.NzLocalAccountIdentification1Properties,
                options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
