using System;
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
public sealed record PayoutSchedule : OpenStringEnum<PayoutSchedule>
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

    public TResult Match<TResult>(Func<TResult> onBiweeklyOn1StAnd15ThAtMidnight,
        Func<TResult> onDaily,
        Func<TResult> onDailyAu,
        Func<TResult> onDailyEu,
        Func<TResult> onDailySg,
        Func<TResult> onDailyUs,
        Func<TResult> onHold,
        Func<TResult> onMonthly,
        Func<TResult> onWeekly,
        Func<TResult> onWeeklyMonToFriAu,
        Func<TResult> onWeeklyMonToFriEu,
        Func<TResult> onWeeklyMonToFriUs,
        Func<TResult> onWeeklyOnTueFriMidnight,
        Func<TResult> onWeeklySunToThuAu,
        Func<TResult> onWeeklySunToThuUs,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BiweeklyOn1StAnd15ThAtMidnight => onBiweeklyOn1StAnd15ThAtMidnight(),
            _ when this == Daily => onDaily(),
            _ when this == DailyAu => onDailyAu(),
            _ when this == DailyEu => onDailyEu(),
            _ when this == DailySg => onDailySg(),
            _ when this == DailyUs => onDailyUs(),
            _ when this == Hold => onHold(),
            _ when this == Monthly => onMonthly(),
            _ when this == Weekly => onWeekly(),
            _ when this == WeeklyMonToFriAu => onWeeklyMonToFriAu(),
            _ when this == WeeklyMonToFriEu => onWeeklyMonToFriEu(),
            _ when this == WeeklyMonToFriUs => onWeeklyMonToFriUs(),
            _ when this == WeeklyOnTueFriMidnight => onWeeklyOnTueFriMidnight(),
            _ when this == WeeklySunToThuAu => onWeeklySunToThuAu(),
            _ when this == WeeklySunToThuUs => onWeeklySunToThuUs(),
            _ => otherwise(Value)
        };

    public void Match(Action onBiweeklyOn1StAnd15ThAtMidnight,
        Action onDaily,
        Action onDailyAu,
        Action onDailyEu,
        Action onDailySg,
        Action onDailyUs,
        Action onHold,
        Action onMonthly,
        Action onWeekly,
        Action onWeeklyMonToFriAu,
        Action onWeeklyMonToFriEu,
        Action onWeeklyMonToFriUs,
        Action onWeeklyOnTueFriMidnight,
        Action onWeeklySunToThuAu,
        Action onWeeklySunToThuUs,
        Action<string> otherwise)
    {
        if (this == BiweeklyOn1StAnd15ThAtMidnight) onBiweeklyOn1StAnd15ThAtMidnight();
        else if (this == Daily) onDaily();
        else if (this == DailyAu) onDailyAu();
        else if (this == DailyEu) onDailyEu();
        else if (this == DailySg) onDailySg();
        else if (this == DailyUs) onDailyUs();
        else if (this == Hold) onHold();
        else if (this == Monthly) onMonthly();
        else if (this == Weekly) onWeekly();
        else if (this == WeeklyMonToFriAu) onWeeklyMonToFriAu();
        else if (this == WeeklyMonToFriEu) onWeeklyMonToFriEu();
        else if (this == WeeklyMonToFriUs) onWeeklyMonToFriUs();
        else if (this == WeeklyOnTueFriMidnight) onWeeklyOnTueFriMidnight();
        else if (this == WeeklySunToThuAu) onWeeklySunToThuAu();
        else if (this == WeeklySunToThuUs) onWeeklySunToThuUs();
        else otherwise(Value);
    }
}
