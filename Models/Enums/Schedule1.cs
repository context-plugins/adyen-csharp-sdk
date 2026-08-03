using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The new payout schedule for the account.
/// <para>
/// Possible values: <c>DEFAULT</c>, <c>DAILY</c>, <c>DAILY_US</c>, <c>DAILY_EU</c>, <c>DAILY_AU</c>, <c>DAILY_SG</c>, <c>WEEKLY</c>, <c>WEEKLY_ON_TUE_FRI_MIDNIGHT</c>, <c>BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT</c>, <c>MONTHLY</c>, <c>HOLD</c>.
/// &gt; <c>HOLD</c> prevents scheduled payouts, but you can still initiate payouts manually.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Schedule1>))]
public sealed record Schedule1 : StringEnum<Schedule1>
{
    private Schedule1(string value) : base(value)
    {
    }

    public static readonly Schedule1 BiweeklyOn1StAnd15ThAtMidnight = new("BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT");

    public static readonly Schedule1 Daily = new("DAILY");

    public static readonly Schedule1 DailyAu = new("DAILY_AU");

    public static readonly Schedule1 DailyEu = new("DAILY_EU");

    public static readonly Schedule1 DailySg = new("DAILY_SG");

    public static readonly Schedule1 DailyUs = new("DAILY_US");

    public static readonly Schedule1 Hold = new("HOLD");

    public static readonly Schedule1 Monthly = new("MONTHLY");

    public static readonly Schedule1 Weekly = new("WEEKLY");

    public static readonly Schedule1 WeeklyMonToFriAu = new("WEEKLY_MON_TO_FRI_AU");

    public static readonly Schedule1 WeeklyMonToFriEu = new("WEEKLY_MON_TO_FRI_EU");

    public static readonly Schedule1 WeeklyMonToFriUs = new("WEEKLY_MON_TO_FRI_US");

    public static readonly Schedule1 WeeklyOnTueFriMidnight = new("WEEKLY_ON_TUE_FRI_MIDNIGHT");

    public static readonly Schedule1 WeeklySunToThuAu = new("WEEKLY_SUN_TO_THU_AU");

    public static readonly Schedule1 WeeklySunToThuUs = new("WEEKLY_SUN_TO_THU_US");

    public static Schedule1 FromValue(string value) => FromValueCore(value);
}
