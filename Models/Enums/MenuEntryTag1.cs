using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Characteristics related to the selection of a menu entry.
/// Possible values:
/// * <b>NonSelectable</b>
/// * <b>NonSelectableSubMenu</b>
/// * <b>Selectable</b>
/// * <b>SubMenu</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MenuEntryTag1>))]
public sealed record MenuEntryTag1 : StringEnum<MenuEntryTag1>
{
    private MenuEntryTag1(string value) : base(value)
    {
    }

    public static readonly MenuEntryTag1 Selectable = new("Selectable");

    public static readonly MenuEntryTag1 NonSelectable = new("NonSelectable");

    public static readonly MenuEntryTag1 SubMenu = new("SubMenu");

    public static readonly MenuEntryTag1 NonSelectableSubMenu = new("NonSelectableSubMenu");

    public static MenuEntryTag1 FromValue(string value) => FromValueCore(value);
}
