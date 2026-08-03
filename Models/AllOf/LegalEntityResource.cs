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

    public void Deconstruct(out Resource resource)
    {
        resource = Resource;
    }

    public static implicit operator Resource(LegalEntityResource value) => value.Resource;
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
        return new LegalEntityResource
        {
            Resource = resource,
        };
    }

    public override void Write(Utf8JsonWriter writer, LegalEntityResource value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var resourceJson = JsonSerializer.SerializeToElement(value.Resource, options);
        foreach (var property in resourceJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
