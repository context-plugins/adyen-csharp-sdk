using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, UKLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(UklocalAccountIdentification1Converter))]
public record UklocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required UklocalAccountIdentification1Properties UklocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out UklocalAccountIdentification1Properties uklocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        uklocalAccountIdentification1Properties = UklocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(UklocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator UklocalAccountIdentification1Properties(UklocalAccountIdentification1 value) =>
        value.UklocalAccountIdentification1Properties;
}

file class UklocalAccountIdentification1Converter : JsonConverter<UklocalAccountIdentification1>
{
    public override UklocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var uklocalAccountIdentification1Properties = root.Deserialize<UklocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize UklocalAccountIdentification1Properties");
        return new UklocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            UklocalAccountIdentification1Properties = uklocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        UklocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var uklocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.UklocalAccountIdentification1Properties, options);
        foreach (var property in uklocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
