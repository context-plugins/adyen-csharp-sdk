using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of Resource, LegalEntityResource.
/// </summary>
[JsonConverter(typeof(LegalEntityResourceConverter))]
public record LegalEntityResource
{
    public required Resource Resource { get; init; }

    public required LegalEntityResourceProperties LegalEntityResourceProperties { get; init; }

    public void Deconstruct(out Resource resource, out LegalEntityResourceProperties legalEntityResourceProperties)
    {
        resource = Resource;
        legalEntityResourceProperties = LegalEntityResourceProperties;
    }

    public static implicit operator Resource(LegalEntityResource value) => value.Resource;

    public static implicit operator LegalEntityResourceProperties(LegalEntityResource value) =>
        value.LegalEntityResourceProperties;
}

file class LegalEntityResourceConverter : JsonConverter<LegalEntityResource>
{
    public override LegalEntityResource Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var resource = root.Deserialize<Resource>(options) ??
            throw new JsonException("Failed to deserialize Resource");
        var legalEntityResourceProperties = root.Deserialize<LegalEntityResourceProperties>(options) ??
            throw new JsonException("Failed to deserialize LegalEntityResourceProperties");
        return new LegalEntityResource
        {
            Resource = resource,
            LegalEntityResourceProperties = legalEntityResourceProperties,
        };
    }

    public override void Write(Utf8JsonWriter writer, LegalEntityResource value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var resourceJson = JsonSerializer.SerializeToElement(value.Resource, options);
        foreach (var property in resourceJson.EnumerateObject())
            property.WriteTo(writer);
        var legalEntityResourcePropertiesJson =
            JsonSerializer.SerializeToElement(value.LegalEntityResourceProperties, options);
        foreach (var property in legalEntityResourcePropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
