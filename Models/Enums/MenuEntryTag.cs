using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Characteristics related to the selection of a menu entry.
/// Possible values:
/// * <b>Selectable</b>
/// * <b>NonSelectable</b>
/// * <b>SubMenu</b>
/// * <b>NonSelectableSubMenu</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MenuEntryTag>))]
public sealed record MenuEntryTag : StringEnum<MenuEntryTag>
{
    private MenuEntryTag(string value) : base(value)
    {
    }

    public static readonly MenuEntryTag Selectable = new("Selectable");

    public static readonly MenuEntryTag NonSelectable = new("NonSelectable");

    public static readonly MenuEntryTag SubMenu = new("SubMenu");

    public static readonly MenuEntryTag NonSelectableSubMenu = new("NonSelectableSubMenu");

    public static MenuEntryTag FromValue(string value) => FromValueCore(value);
}
