using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer.
/// <para>
///  Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>bank</b>: Transfer to a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see> or a bank account.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category2>))]
public sealed record Category2 : OpenStringEnum<Category2>
{
    private Category2(string value) : base(value)
    {
    }

    public static readonly Category2 Bank = new("bank");

    public static readonly Category2 Card = new("card");

    public static readonly Category2 Grants = new("grants");

    public static readonly Category2 Interest = new("interest");

    public static readonly Category2 Internal = new("internal");

    public static readonly Category2 IssuedCard = new("issuedCard");

    public static readonly Category2 Migration = new("migration");

    public static readonly Category2 PlatformPayment = new("platformPayment");

    public static readonly Category2 TopUp = new("topUp");

    public static readonly Category2 Upgrade = new("upgrade");

    public TResult Match<TResult>(Func<TResult> onBank,
        Func<TResult> onCard,
        Func<TResult> onGrants,
        Func<TResult> onInterest,
        Func<TResult> onInternal,
        Func<TResult> onIssuedCard,
        Func<TResult> onMigration,
        Func<TResult> onPlatformPayment,
        Func<TResult> onTopUp,
        Func<TResult> onUpgrade,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bank => onBank(),
            _ when this == Card => onCard(),
            _ when this == Grants => onGrants(),
            _ when this == Interest => onInterest(),
            _ when this == Internal => onInternal(),
            _ when this == IssuedCard => onIssuedCard(),
            _ when this == Migration => onMigration(),
            _ when this == PlatformPayment => onPlatformPayment(),
            _ when this == TopUp => onTopUp(),
            _ when this == Upgrade => onUpgrade(),
            _ => otherwise(Value)
        };

    public void Match(Action onBank,
        Action onCard,
        Action onGrants,
        Action onInterest,
        Action onInternal,
        Action onIssuedCard,
        Action onMigration,
        Action onPlatformPayment,
        Action onTopUp,
        Action onUpgrade,
        Action<string> otherwise)
    {
        if (this == Bank) onBank();
        else if (this == Card) onCard();
        else if (this == Grants) onGrants();
        else if (this == Interest) onInterest();
        else if (this == Internal) onInternal();
        else if (this == IssuedCard) onIssuedCard();
        else if (this == Migration) onMigration();
        else if (this == PlatformPayment) onPlatformPayment();
        else if (this == TopUp) onTopUp();
        else if (this == Upgrade) onUpgrade();
        else otherwise(Value);
    }
}
