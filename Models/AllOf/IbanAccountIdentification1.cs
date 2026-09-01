using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, IbanAccountIdentification1.
/// </summary>
[JsonConverter(typeof(IbanAccountIdentification1Converter))]
public record IbanAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required IbanAccountIdentification1Properties IbanAccountIdentification1Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out IbanAccountIdentification1Properties ibanAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        ibanAccountIdentification1Properties = IbanAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(IbanAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator IbanAccountIdentification1Properties(IbanAccountIdentification1 value) =>
        value.IbanAccountIdentification1Properties;
}

file class IbanAccountIdentification1Converter : JsonConverter<IbanAccountIdentification1>
{
    public override IbanAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var ibanAccountIdentification1Properties = root.Deserialize<IbanAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize IbanAccountIdentification1Properties");
        var extras =
            AdditionalProperties.SharedBy(bankAccountIdentification.AdditionalProperties,
                ibanAccountIdentification1Properties.AdditionalProperties);
        bankAccountIdentification.AdditionalProperties.Clear();
        ibanAccountIdentification1Properties.AdditionalProperties.Clear();
        return new IbanAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            IbanAccountIdentification1Properties = ibanAccountIdentification1Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        IbanAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BankAccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.IbanAccountIdentification1Properties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
