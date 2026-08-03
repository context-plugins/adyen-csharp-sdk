using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payout schedule for the account.
/// <para>
/// Possible values: <c>DEFAULT</c>, <c>DAILY</c>, <c>DAILY_US</c>, <c>DAILY_EU</c>, <c>DAILY_AU</c>, <c>DAILY_SG</c>, <c>WEEKLY</c>, <c>WEEKLY_ON_TUE_FRI_MIDNIGHT</c>, <c>BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT</c>, <c>MONTHLY</c>, <c>HOLD</c>.
/// &gt; <c>HOLD</c> prevents scheduled payouts, but you can still initiate payouts manually.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutSchedule>))]
public sealed record PayoutSchedule : StringEnum<PayoutSchedule>
{
    private PayoutSchedule(string value) : base(value)
    {
    }

    public static readonly PayoutSchedule BiweeklyOn1StAnd15ThAtMidnight = new("BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT");

    public static readonly PayoutSchedule Daily = new("DAILY");

    public static readonly PayoutSchedule DailyAu = new("DAILY_AU");

    public static readonly PayoutSchedule DailyEu = new("DAILY_EU");

    public static readonly PayoutSchedule DailySg = new("DAILY_SG");

    public static readonly PayoutSchedule DailyUs = new("DAILY_US");

    public static readonly PayoutSchedule Hold = new("HOLD");

    public static readonly PayoutSchedule Monthly = new("MONTHLY");

    public static readonly PayoutSchedule Weekly = new("WEEKLY");

    public static readonly PayoutSchedule WeeklyMonToFriAu = new("WEEKLY_MON_TO_FRI_AU");

    public static readonly PayoutSchedule WeeklyMonToFriEu = new("WEEKLY_MON_TO_FRI_EU");

    public static readonly PayoutSchedule WeeklyMonToFriUs = new("WEEKLY_MON_TO_FRI_US");

    public static readonly PayoutSchedule WeeklyOnTueFriMidnight = new("WEEKLY_ON_TUE_FRI_MIDNIGHT");

    public static readonly PayoutSchedule WeeklySunToThuAu = new("WEEKLY_SUN_TO_THU_AU");

    public static readonly PayoutSchedule WeeklySunToThuUs = new("WEEKLY_SUN_TO_THU_US");

    public static PayoutSchedule FromValue(string value) => FromValueCore(value);
}
