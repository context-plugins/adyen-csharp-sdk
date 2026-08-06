using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, NOLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(NolocalAccountIdentification1Converter))]
public record NolocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required NolocalAccountIdentification1Properties NolocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out NolocalAccountIdentification1Properties nolocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        nolocalAccountIdentification1Properties = NolocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(NolocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator NolocalAccountIdentification1Properties(NolocalAccountIdentification1 value) =>
        value.NolocalAccountIdentification1Properties;
}

file class NolocalAccountIdentification1Converter : JsonConverter<NolocalAccountIdentification1>
{
    public override NolocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var nolocalAccountIdentification1Properties = root.Deserialize<NolocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize NolocalAccountIdentification1Properties");
        return new NolocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            NolocalAccountIdentification1Properties = nolocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        NolocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var nolocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.NolocalAccountIdentification1Properties, options);
        foreach (var property in nolocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
