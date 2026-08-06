using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, HKLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(HklocalAccountIdentification1Converter))]
public record HklocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required HklocalAccountIdentification1Properties HklocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out HklocalAccountIdentification1Properties hklocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        hklocalAccountIdentification1Properties = HklocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(HklocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator HklocalAccountIdentification1Properties(HklocalAccountIdentification1 value) =>
        value.HklocalAccountIdentification1Properties;
}

file class HklocalAccountIdentification1Converter : JsonConverter<HklocalAccountIdentification1>
{
    public override HklocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var hklocalAccountIdentification1Properties = root.Deserialize<HklocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize HklocalAccountIdentification1Properties");
        return new HklocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            HklocalAccountIdentification1Properties = hklocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        HklocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var hklocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.HklocalAccountIdentification1Properties, options);
        foreach (var property in hklocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
