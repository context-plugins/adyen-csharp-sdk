using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, USLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(UslocalAccountIdentification1Converter))]
public record UslocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required UslocalAccountIdentification1Properties UslocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out UslocalAccountIdentification1Properties uslocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        uslocalAccountIdentification1Properties = UslocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(UslocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator UslocalAccountIdentification1Properties(UslocalAccountIdentification1 value) =>
        value.UslocalAccountIdentification1Properties;
}

file class UslocalAccountIdentification1Converter : JsonConverter<UslocalAccountIdentification1>
{
    public override UslocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var uslocalAccountIdentification1Properties = root.Deserialize<UslocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize UslocalAccountIdentification1Properties");
        return new UslocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            UslocalAccountIdentification1Properties = uslocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        UslocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var uslocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.UslocalAccountIdentification1Properties, options);
        foreach (var property in uslocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
