using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, CALocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(CalocalAccountIdentification1Converter))]
public record CalocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required CalocalAccountIdentification1Properties CalocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out CalocalAccountIdentification1Properties calocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        calocalAccountIdentification1Properties = CalocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(CalocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator CalocalAccountIdentification1Properties(CalocalAccountIdentification1 value) =>
        value.CalocalAccountIdentification1Properties;
}

file class CalocalAccountIdentification1Converter : JsonConverter<CalocalAccountIdentification1>
{
    public override CalocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var calocalAccountIdentification1Properties = root.Deserialize<CalocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize CalocalAccountIdentification1Properties");
        return new CalocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            CalocalAccountIdentification1Properties = calocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        CalocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var calocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.CalocalAccountIdentification1Properties, options);
        foreach (var property in calocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
