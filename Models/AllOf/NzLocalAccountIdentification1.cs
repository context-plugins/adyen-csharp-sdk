using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, NZLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(NzLocalAccountIdentification1Converter))]
public record NzLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required NzLocalAccountIdentification1Properties NzLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out NzLocalAccountIdentification1Properties nzLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        nzLocalAccountIdentification1Properties = NzLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(NzLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator NzLocalAccountIdentification1Properties(NzLocalAccountIdentification1 value) =>
        value.NzLocalAccountIdentification1Properties;
}

file class NzLocalAccountIdentification1Converter : JsonConverter<NzLocalAccountIdentification1>
{
    public override NzLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var nzLocalAccountIdentification1Properties = root.Deserialize<NzLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize NzLocalAccountIdentification1Properties");
        return new NzLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            NzLocalAccountIdentification1Properties = nzLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        NzLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var nzLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.NzLocalAccountIdentification1Properties, options);
        foreach (var property in nzLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
