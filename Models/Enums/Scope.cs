using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The scope to which the transfer limit applies. Possible values:
/// * <b>perTransaction</b>: you set a maximum amount for each transfer made from the balance account or balance platform.
/// * <b>perDay</b>: you set a maximum total amount for all transfers made from the balance account or balance platform in a day.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Scope>))]
public sealed record Scope : StringEnum<Scope>
{
    private Scope(string value) : base(value)
    {
    }

    public static readonly Scope PerDay = new("perDay");

    public static readonly Scope PerTransaction = new("perTransaction");

    public static Scope FromValue(string value) => FromValueCore(value);
}
