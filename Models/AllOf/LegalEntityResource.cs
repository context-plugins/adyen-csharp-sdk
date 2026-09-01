using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of Resource, LegalEntityResource.
/// </summary>
[JsonConverter(typeof(LegalEntityResourceConverter))]
public record LegalEntityResource
{
    public required Resource Resource { get; init; }

    public required LegalEntityResourceProperties LegalEntityResourceProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

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
        var extras =
            AdditionalProperties.SharedBy(resource.AdditionalProperties, legalEntityResourceProperties.AdditionalProperties);
        resource.AdditionalProperties.Clear();
        legalEntityResourceProperties.AdditionalProperties.Clear();
        return new LegalEntityResource
        {
            Resource = resource,
            LegalEntityResourceProperties = legalEntityResourceProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer, LegalEntityResource value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.Resource, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.LegalEntityResourceProperties, options), written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
