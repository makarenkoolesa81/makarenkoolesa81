using UnityEngine;

/// <summary>
/// Every tunable number of the game in one place. Type sizes are canvas pixels on the
/// 1242x2688 reference resolution; the floor is 24 and no autosize minimum here goes
/// below 28 (C.12 - a long line ships at fontSizeMin, not fontSizeMax).
///
/// Nothing in here reads another static field of this type (C.52).
/// </summary>
public static class _0x4e4c58b8
{
    public const int OrderDecor = -14;
    // ---- sorting orders: every world sprite stays inside -19..-1 (C.0.5 / C.21) -----
    public const int OrderVerge = -18;
    public const float RefHeight = 2688f;
    public const float CtaMin = 36f;
    public const int DailyStretchGoal = 5;
    /// <summary>Days since the epoch: the seed every player shares on the same date.</summary>
    public static int DayIndex()
    {
        System.DateTime _0x6ab31ed7 = System.DateTime.UtcNow.Date;
        System.DateTime _0xb6a1ff91 = new System.DateTime(2024, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
        return (int)(_0x6ab31ed7 - _0xb6a1ff91).TotalDays;
    }

    public const float TitleMin = 34f;
    /// <summary>How many lanes fit the camera height; drives laneH, nothing is eyeballed.</summary>
    public const float VisibleLanes = 8.5f;
    public const int Hearts = 3;
    /// <summary>Lane count grows with the stretch so the road reads harder as it goes.</summary>
    public static int RoadLanes(int _0xdd2fd6e3)
    {
        if (_0xdd2fd6e3 >= 6)
        {
            return 5;
        }

        if (_0xdd2fd6e3 >= 3)
        {
            return 4;
        }

        return 3;
    }

    public const float TitleMax = 56f;
    public const float DailySpeedMultiplier = 1.25f;
    /// <summary>A clamped frame step: a long hitch must not teleport a vehicle past the hen.</summary>
    public const float MaxStep = 0.05f;
    public const int OrderChevron = -12;
    // ---- timing ---------------------------------------------------------------------
    public const float HopTime = 0.22f;
    public const float PressScale = 0.96f;
    /// <summary>No generated sprite may leave the corridor, whatever a caller computes.</summary>
    public static int ClampOrder(int _0xabb00fbc)
    {
        return Mathf.Clamp(_0xabb00fbc, OrderFloor, OrderCeil);
    }

    // ---- traffic --------------------------------------------------------------------
    public const float SpeedSlow = 1.1f;
    // ---- canvas geometry ------------------------------------------------------------
    public const float RefWidth = 1242f;
    public const int OrderCeil = -1;
    public const float CountUp = 0.45f;
    // ---- board ----------------------------------------------------------------------
    /// <summary>Hop columns across the road. The hen starts on the middle one.</summary>
    public const int Columns = 5;
    public const int OrderRoad = -17;
    /// <summary>Thousands separator above 999; plain integers below (design doc).</summary>
    public static string Grouped(int _0xd82edc45)
    {
        return _0xd82edc45.ToString(_0x16a2765e._0x50cdc89d(new byte[2] { 169, 215 }, 231), System.Globalization.CultureInfo.InvariantCulture);
    }

    public const int OrderPickup = -9;
    public const float HeroMin = 40f;
    public const int StretchGoal = 8;
    /// <summary>Traffic gets quicker per stretch, but never past the ceiling.</summary>
    public static float SpeedMultiplier(int _0x3dc5ede6)
    {
        return Mathf.Min(1f + _0x3dc5ede6 * SpeedRampPerStretch, SpeedRampCeiling);
    }

    public const float SheetTime = 0.22f;
    public const int OrderEffect = -3;
    // ---- typography (canvas pixels) -------------------------------------------------
    public const float HeroMax = 64f;
    public const float BodyMax = 40f;
    public const int OrderVehicle = -7;
    public const float CaptionMin = 28f;
    public const int OrderHen = -5;
    public const float SpeedRampPerStretch = 0.055f;
    public const float BodyMin = 28f;
    public const float CtaMax = 60f;
    public const float ValueMin = 32f;
    public const float InvulnerableTime = 1.0f;
    public const float HopHeight = 0.34f;
    public const float ValueMax = 54f;
    public const float SpeedFast = 2.6f;
    public const float SpeedRampCeiling = 1.35f;
    public const float CaptionMax = 32f;
    public const float HitEvaluateAt = 0.55f;
    public const float BarTime = 0.4f;
    /// <summary>Lane strips are drawn wider than the screen so their ends never show.</summary>
    public const float StripOverscan = 1.14f;
    public const float ButtonMin = 28f;
    public const float PressTime = 0.08f;
    public const float ButtonMax = 40f;
    public const int OrderFloor = -19;
}

internal static class _0x16a2765e
{
    internal static string _0x50cdc89d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}