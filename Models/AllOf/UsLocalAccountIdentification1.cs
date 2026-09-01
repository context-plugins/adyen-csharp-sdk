using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, USLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(UsLocalAccountIdentification1Converter))]
public record UsLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required UsLocalAccountIdentification1Properties UsLocalAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out UsLocalAccountIdentification1Properties usLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        usLocalAccountIdentification1Properties = UsLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(UsLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator UsLocalAccountIdentification1Properties(UsLocalAccountIdentification1 value) =>
        value.UsLocalAccountIdentification1Properties;
}

file class UsLocalAccountIdentification1Converter : JsonConverter<UsLocalAccountIdentification1>
{
    public override UsLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var usLocalAccountIdentification1Properties = root.Deserialize<UsLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize UsLocalAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                usLocalAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        usLocalAccountIdentification1Properties.AdditionalProperties.Clear();
        return new UsLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            UsLocalAccountIdentification1Properties = usLocalAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        UsLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.UsLocalAccountIdentification1Properties,
                options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
