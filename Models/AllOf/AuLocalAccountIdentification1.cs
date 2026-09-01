using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, AULocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(AuLocalAccountIdentification1Converter))]
public record AuLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required AuLocalAccountIdentification1Properties AuLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out AuLocalAccountIdentification1Properties auLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        auLocalAccountIdentification1Properties = AuLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(AuLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator AuLocalAccountIdentification1Properties(AuLocalAccountIdentification1 value) =>
        value.AuLocalAccountIdentification1Properties;
}

file class AuLocalAccountIdentification1Converter : JsonConverter<AuLocalAccountIdentification1>
{
    public override AuLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var auLocalAccountIdentification1Properties = root.Deserialize<AuLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize AuLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                auLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        auLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new AuLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            AuLocalAccountIdentification1Properties = auLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        AuLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.AuLocalAccountIdentification1Properties,
                options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
