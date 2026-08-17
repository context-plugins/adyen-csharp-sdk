using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, UKLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(UkLocalAccountIdentification1Converter))]
public record UkLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required UkLocalAccountIdentification1Properties UkLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out UkLocalAccountIdentification1Properties ukLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        ukLocalAccountIdentification1Properties = UkLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(UkLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator UkLocalAccountIdentification1Properties(UkLocalAccountIdentification1 value) =>
        value.UkLocalAccountIdentification1Properties;
}

file class UkLocalAccountIdentification1Converter : JsonConverter<UkLocalAccountIdentification1>
{
    public override UkLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var ukLocalAccountIdentification1Properties = root.Deserialize<UkLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize UkLocalAccountIdentification1Properties");
        return new UkLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            UkLocalAccountIdentification1Properties = ukLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        UkLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var ukLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.UkLocalAccountIdentification1Properties, options);
        foreach (var property in ukLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
