using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of AccountIdentification, IbanAccountIdentification2.
/// </summary>
[JsonConverter(typeof(IbanAccountIdentification2Converter))]
public record IbanAccountIdentification2
{
    public required AccountIdentification AccountIdentification { get; init; }

    public required IbanAccountIdentification2Properties IbanAccountIdentification2Properties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out AccountIdentification accountIdentification,
        out IbanAccountIdentification2Properties ibanAccountIdentification2Properties)
    {
        accountIdentification = AccountIdentification;
        ibanAccountIdentification2Properties = IbanAccountIdentification2Properties;
    }

    public static implicit operator AccountIdentification(IbanAccountIdentification2 value) =>
        value.AccountIdentification;

    public static implicit operator IbanAccountIdentification2Properties(IbanAccountIdentification2 value) =>
        value.IbanAccountIdentification2Properties;
}

file class IbanAccountIdentification2Converter : JsonConverter<IbanAccountIdentification2>
{
    public override IbanAccountIdentification2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var accountIdentification = root.Deserialize<AccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize AccountIdentification");
        var ibanAccountIdentification2Properties = root.Deserialize<IbanAccountIdentification2Properties>(options) ??
            throw new JsonException("Failed to deserialize IbanAccountIdentification2Properties");
        var extras =
            AdditionalProperties.SharedBy(accountIdentification.AdditionalProperties,
                ibanAccountIdentification2Properties.AdditionalProperties);
        accountIdentification.AdditionalProperties.Clear();
        ibanAccountIdentification2Properties.AdditionalProperties.Clear();
        return new IbanAccountIdentification2
        {
            AccountIdentification = accountIdentification,
            IbanAccountIdentification2Properties = ibanAccountIdentification2Properties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        IbanAccountIdentification2 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.AccountIdentification, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.IbanAccountIdentification2Properties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
