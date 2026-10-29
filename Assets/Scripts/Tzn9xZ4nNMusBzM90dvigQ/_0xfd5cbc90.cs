using UnityEngine;

/// <summary>
/// The whole persistent state of the game: feathers, grain, level, plumes, trails,
/// mission progress and the three settings toggles.
///
/// Keys are LITERAL strings, never nameof: obfuscation renames symbols and a renamed
/// key loses the player's save silently (C.1 "no nameof for persisted identifiers").
/// Nothing here is bought - grain is earned by finishing runs and spent only on plume
/// and dust-trail unlocks. There is no purchase path in the app at all.
/// </summary>
public static class _0xfd5cbc90
{
    private static readonly string KeyRoads = _0x067ef4ce._0x4903b682(new byte[8] { 48, 34, 120, 36, 57, 55, 50, 37 }, 86);
    private static readonly string KeyPlumeMask = _0x067ef4ce._0x4903b682(new byte[12] { 149, 135, 221, 131, 159, 134, 158, 150, 158, 146, 128, 152 }, 243);
    public static bool _0x051084a6
    {
        get
        {
            return PlayerPrefs.GetInt(KeyContrast, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyContrast, value ? 1 : 0);
        }
    }

    private static readonly string KeyHopGuide = _0x067ef4ce._0x4903b682(new byte[11] { 130, 144, 202, 140, 139, 148, 131, 145, 141, 128, 129 }, 228);
    private static readonly string KeyDailyBest = _0x067ef4ce._0x4903b682(new byte[12] { 140, 158, 196, 142, 139, 131, 134, 147, 136, 143, 153, 158 }, 234);
    private static readonly string KeyMissionDay = _0x067ef4ce._0x4903b682(new byte[13] { 220, 206, 148, 215, 211, 201, 201, 211, 213, 212, 222, 219, 195 }, 186);
    public static int _0x5c438be4
    {
        get
        {
            return PlayerPrefs.GetInt(KeyPlume, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyPlume, value);
        }
    }

    private static readonly string KeyPlume = _0x067ef4ce._0x4903b682(new byte[8] { 67, 81, 11, 85, 73, 80, 72, 64 }, 37);
    private static readonly string KeyFeathers = _0x067ef4ce._0x4903b682(new byte[11] { 14, 28, 70, 14, 13, 9, 28, 0, 13, 26, 27 }, 104);
    private static readonly string KeyAttempt = _0x067ef4ce._0x4903b682(new byte[10] { 170, 184, 226, 173, 184, 184, 169, 161, 188, 184 }, 204);
    /// <summary>Bit per plume slot. Slot 0 ships unlocked so the hen is never blank.</summary>
    public static int _0x53839197
    {
        get
        {
            return PlayerPrefs.GetInt(KeyPlumeMask, 1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyPlumeMask, value | 1);
        }
    }

    public static int _0x1ec9c5ae
    {
        get
        {
            return PlayerPrefs.GetInt(KeyGrain, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyGrain, value < 0 ? 0 : value);
        }
    }

    /// <summary>Level is derived, never stored: one level per 150 lifetime feathers.</summary>
    public static int _0xb3b99d41
    {
        get
        {
            return 1 + _0x62e1ffc6 / 150;
        }
    }

    public static void Flush()
    {
        PlayerPrefs.Save();
    }

    public static int _0xcc507d7e
    {
        get
        {
            return PlayerPrefs.GetInt(KeyDailyBest, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyDailyBest, value < 0 ? 0 : value);
        }
    }

    /// <summary>Crates earned from completed missions and not yet claimed.</summary>
    public static int _0x9d9233c1
    {
        get
        {
            return PlayerPrefs.GetInt(KeyCrates, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyCrates, Mathf.Clamp(value, 0, 3));
        }
    }

    /// <summary>RESET PROGRESS on the settings sheet. Only our own keys are removed.</summary>
    public static void ResetAll()
    {
        PlayerPrefs.DeleteKey(KeyGrain);
        PlayerPrefs.DeleteKey(KeyFeathers);
        PlayerPrefs.DeleteKey(KeyBestStreak);
        PlayerPrefs.DeleteKey(KeyRoads);
        PlayerPrefs.DeleteKey(KeyPlume);
        PlayerPrefs.DeleteKey(KeyTrail);
        PlayerPrefs.DeleteKey(KeyPlumeMask);
        PlayerPrefs.DeleteKey(KeyCrates);
        PlayerPrefs.DeleteKey(KeyMissionDay);
        PlayerPrefs.DeleteKey(KeyMission0);
        PlayerPrefs.DeleteKey(KeyMission1);
        PlayerPrefs.DeleteKey(KeyMission2);
        PlayerPrefs.DeleteKey(KeyDailyBest);
        PlayerPrefs.DeleteKey(KeyAttempt);
        PlayerPrefs.DeleteKey(KeyChallenge);
        PlayerPrefs.Save();
    }

    public static bool _0x4b0763a5
    {
        get
        {
            return PlayerPrefs.GetInt(KeyHopGuide, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyHopGuide, value ? 1 : 0);
        }
    }

    /// <summary>1 while the next run is the shared Daily Road, 0 for a normal road.</summary>
    public static bool _0xc633c5a1
    {
        get
        {
            return PlayerPrefs.GetInt(KeyChallenge, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyChallenge, value ? 1 : 0);
        }
    }

    /// <summary>The first still-locked plume, or -1 when the set is complete.</summary>
    public static int NextLockedPlume()
    {
        for (int _0x53d7fc00 = 0; _0x53d7fc00 < _0x38306f56.Plumes.Length; _0x53d7fc00++)
        {
            if (!PlumeUnlocked(_0x53d7fc00))
            {
                return _0x53d7fc00;
            }
        }

        return -1;
    }

    public static int _0xb769a538
    {
        get
        {
            return PlayerPrefs.GetInt(KeyTrail, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyTrail, value);
        }
    }

    public static int _0x62e1ffc6
    {
        get
        {
            return PlayerPrefs.GetInt(KeyFeathers, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyFeathers, value < 0 ? 0 : value);
        }
    }

    public static void SetMissionProgress(int _0x4e026d2b, int _0x8e7791d9)
    {
        int _0xbb87fad8 = _0x8e7791d9 < 0 ? 0 : _0x8e7791d9;
        if (_0x4e026d2b == 1)
        {
            PlayerPrefs.SetInt(KeyMission1, _0xbb87fad8);
            return;
        }

        if (_0x4e026d2b == 2)
        {
            PlayerPrefs.SetInt(KeyMission2, _0xbb87fad8);
            return;
        }

        PlayerPrefs.SetInt(KeyMission0, _0xbb87fad8);
    }

    private static readonly string KeyMission2 = _0x067ef4ce._0x4903b682(new byte[11] { 149, 135, 221, 158, 154, 128, 128, 154, 156, 157, 193 }, 243);
    public static bool PlumeUnlocked(int _0xfe2599a3)
    {
        return (_0x53839197 & (1 << _0xfe2599a3)) != 0;
    }

    public static int _0x8066d3d8
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBestStreak, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBestStreak, value < 0 ? 0 : value);
        }
    }

    private static readonly string KeyCrates = _0x067ef4ce._0x4903b682(new byte[9] { 20, 6, 92, 17, 0, 19, 6, 23, 1 }, 114);
    private static readonly string KeyTrail = _0x067ef4ce._0x4903b682(new byte[8] { 79, 93, 7, 93, 91, 72, 64, 69 }, 41);
    private static readonly string KeyMission1 = _0x067ef4ce._0x4903b682(new byte[11] { 77, 95, 5, 70, 66, 88, 88, 66, 68, 69, 26 }, 43);
    public static int _0x94b0bd4a
    {
        get
        {
            return PlayerPrefs.GetInt(KeyRoads, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyRoads, value < 0 ? 0 : value);
        }
    }

    public static bool _0x5db89fcc
    {
        get
        {
            return PlayerPrefs.GetInt(KeyVibration, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyVibration, value ? 1 : 0);
        }
    }

    public static void UnlockPlume(int _0x4d5a0d3b)
    {
        _0x53839197 = _0x53839197 | (1 << _0x4d5a0d3b);
    }

    /// <summary>Attempt counter: half of every run seed, so no two runs repeat (C.11).</summary>
    public static int _0xae510bae
    {
        get
        {
            return PlayerPrefs.GetInt(KeyAttempt, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyAttempt, value);
        }
    }

    private static readonly string KeyMission0 = _0x067ef4ce._0x4903b682(new byte[11] { 236, 254, 164, 231, 227, 249, 249, 227, 229, 228, 186 }, 138);
    private static readonly string KeyContrast = _0x067ef4ce._0x4903b682(new byte[11] { 111, 125, 39, 106, 102, 103, 125, 123, 104, 122, 125 }, 9);
    private static readonly string KeyBestStreak = _0x067ef4ce._0x4903b682(new byte[13] { 56, 42, 112, 60, 59, 45, 42, 45, 42, 44, 59, 63, 53 }, 94);
    public static int _0x8c6e5386
    {
        get
        {
            return PlayerPrefs.GetInt(KeyMissionDay, -1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyMissionDay, value);
        }
    }

    private static readonly string KeyGrain = _0x067ef4ce._0x4903b682(new byte[8] { 200, 218, 128, 201, 220, 207, 199, 192 }, 174);
    /// <summary>
    /// A short buzz when the player turns vibration on and when a heart is lost. The
    /// game has no sound at all (C.20), so this is the only haptic channel.
    /// </summary>
    public static void Buzz()
    {
        if (!_0x5db89fcc || !Application.isMobilePlatform)
        {
            return;
        }

        Handheld.Vibrate();
    }

    public static int MissionProgress(int _0x826185f2)
    {
        if (_0x826185f2 == 1)
        {
            return PlayerPrefs.GetInt(KeyMission1, 0);
        }

        if (_0x826185f2 == 2)
        {
            return PlayerPrefs.GetInt(KeyMission2, 0);
        }

        return PlayerPrefs.GetInt(KeyMission0, 0);
    }

    private static readonly string KeyChallenge = _0x067ef4ce._0x4903b682(new byte[12] { 204, 222, 132, 201, 194, 203, 198, 198, 207, 196, 205, 207 }, 170);
    private static readonly string KeyVibration = _0x067ef4ce._0x4903b682(new byte[12] { 170, 184, 226, 186, 165, 174, 190, 173, 184, 165, 163, 162 }, 204);
    public static int UnlockedPlumeCount()
    {
        int _0xd60771e3 = 0;
        for (int _0x82c357c8 = 0; _0x82c357c8 < _0x38306f56.Plumes.Length; _0x82c357c8++)
        {
            if (PlumeUnlocked(_0x82c357c8))
            {
                _0xd60771e3++;
            }
        }

        return _0xd60771e3;
    }
}

internal static class _0x067ef4ce
{
    internal static string _0x4903b682(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}