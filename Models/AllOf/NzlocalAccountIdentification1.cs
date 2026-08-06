using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, NZLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(NzlocalAccountIdentification1Converter))]
public record NzlocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required NzlocalAccountIdentification1Properties NzlocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out NzlocalAccountIdentification1Properties nzlocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        nzlocalAccountIdentification1Properties = NzlocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(NzlocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator NzlocalAccountIdentification1Properties(NzlocalAccountIdentification1 value) =>
        value.NzlocalAccountIdentification1Properties;
}

file class NzlocalAccountIdentification1Converter : JsonConverter<NzlocalAccountIdentification1>
{
    public override NzlocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var nzlocalAccountIdentification1Properties = root.Deserialize<NzlocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize NzlocalAccountIdentification1Properties");
        return new NzlocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            NzlocalAccountIdentification1Properties = nzlocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        NzlocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var nzlocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.NzlocalAccountIdentification1Properties, options);
        foreach (var property in nzlocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
