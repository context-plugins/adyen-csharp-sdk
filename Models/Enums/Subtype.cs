using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of flow to initiate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Subtype>))]
public sealed record Subtype : StringEnum<Subtype>
{
    private Subtype(string value) : base(value)
    {
    }

    public static readonly Subtype Express = new("express");

    public static readonly Subtype Redirect = new("redirect");

    public static readonly Subtype Sdk = new("sdk");

    public static Subtype FromValue(string value) => FromValueCore(value);
}
