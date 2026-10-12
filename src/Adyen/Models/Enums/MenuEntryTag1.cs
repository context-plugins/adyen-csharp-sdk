using System;
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
public sealed record MenuEntryTag1 : OpenStringEnum<MenuEntryTag1>
{
    private MenuEntryTag1(string value) : base(value)
    {
    }

    public static readonly MenuEntryTag1 Selectable = new("Selectable");

    public static readonly MenuEntryTag1 NonSelectable = new("NonSelectable");

    public static readonly MenuEntryTag1 SubMenu = new("SubMenu");

    public static readonly MenuEntryTag1 NonSelectableSubMenu = new("NonSelectableSubMenu");

    public TResult Match<TResult>(Func<TResult> onSelectable,
        Func<TResult> onNonSelectable,
        Func<TResult> onSubMenu,
        Func<TResult> onNonSelectableSubMenu,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Selectable => onSelectable(),
            _ when this == NonSelectable => onNonSelectable(),
            _ when this == SubMenu => onSubMenu(),
            _ when this == NonSelectableSubMenu => onNonSelectableSubMenu(),
            _ => otherwise(Value)
        };

    public void Match(Action onSelectable,
        Action onNonSelectable,
        Action onSubMenu,
        Action onNonSelectableSubMenu,
        Action<string> otherwise)
    {
        if (this == Selectable) onSelectable();
        else if (this == NonSelectable) onNonSelectable();
        else if (this == SubMenu) onSubMenu();
        else if (this == NonSelectableSubMenu) onNonSelectableSubMenu();
        else otherwise(Value);
    }
}
