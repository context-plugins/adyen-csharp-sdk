using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, NumberAndBicAccountIdentification1.
/// </summary>
[JsonConverter(typeof(NumberAndBicAccountIdentification1Converter))]
public record NumberAndBicAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification)
    {
        bankAccountIdentification = BankAccountIdentification;
    }

    public static implicit operator BankAccountIdentification(NumberAndBicAccountIdentification1 value) =>
        value.BankAccountIdentification;
}

file class NumberAndBicAccountIdentification1Converter : JsonConverter<NumberAndBicAccountIdentification1>
{
    public override NumberAndBicAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        return new NumberAndBicAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        NumberAndBicAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
