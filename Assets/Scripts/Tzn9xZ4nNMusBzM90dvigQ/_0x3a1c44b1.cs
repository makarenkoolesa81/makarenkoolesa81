using UnityEngine;

/// <summary>
/// Today's three missions and today's shared road, both derived from the calendar day
/// index alone. Everyone who opens the app on the same date gets the same set; nothing
/// is fetched from a server and nothing can be bought.
///
/// A plain sealed class with Init() instead of a constructor (C.59): a constructor runs
/// whenever the object is made, including by the serializer, before the scene exists.
/// </summary>
public sealed class _0x3a1c44b1
{
    private int _0x76fa2411;
    private readonly int[] _0x36a1f465 = new int[SlotCount];
    private readonly string[] _0x4180ea33 = new string[SlotCount];
    /// <summary>
    /// A new calendar day clears yesterday's progress. Called from both scenes before
    /// anything reads a mission, so the two scenes can never disagree about the day.
    /// </summary>
    public static _0x3a1c44b1 EnsureToday()
    {
        int _0x8719ec7a = _0x4e4c58b8.DayIndex();
        if (_0xfd5cbc90._0x8c6e5386 != _0x8719ec7a)
        {
            _0xfd5cbc90._0x8c6e5386 = _0x8719ec7a;
            for (int _0xcf6c1449 = 0; _0xcf6c1449 < SlotCount; _0xcf6c1449++)
            {
                _0xfd5cbc90.SetMissionProgress(_0xcf6c1449, 0);
            }

            _0xfd5cbc90._0xcc507d7e = 0;
            _0xfd5cbc90.Flush();
        }

        return new _0x3a1c44b1()._0x1e1afe19(_0x8719ec7a);
    }

    public const int SlotCount = 3;
    /// <summary>The shared Daily Road: same seed for every player on the same date.</summary>
    public int _0xe2097338()
    {
        return this._0x76fa2411 * 7919;
    }

    public int _0xc2fb5612()
    {
        int _0x20127a7a = 0;
        for (int _0xe8bf3f2d = 0; _0xe8bf3f2d < SlotCount; _0xe8bf3f2d++)
        {
            if (this._0x55a1f668(_0xe8bf3f2d))
            {
                _0x20127a7a++;
            }
        }

        return _0x20127a7a;
    }

    public string _0xe9820e3f(int _0x7a0061c7)
    {
        if (_0x7a0061c7 < 0 || _0x7a0061c7 >= SlotCount)
        {
            return string.Empty;
        }

        return this._0x4180ea33[_0x7a0061c7];
    }

    public _0x3a1c44b1 _0x1e1afe19(int _0xa16f9be1)
    {
        this._0x76fa2411 = _0xa16f9be1;
        System.Random _0x773133c6 = new System.Random(_0xa16f9be1 * 7919);
        this._0x2a9f77f0[0] = KindFeathers;
        this._0x36a1f465[0] = 15 + _0x773133c6.Next(0, 4) * 5;
        this._0x4180ea33[0] = _0x7ff8b33b._0xcf2fb332(new byte[8] { 214, 218, 217, 217, 208, 214, 193, 181 }, 149) + this._0x36a1f465[0] + _0x7ff8b33b._0xcf2fb332(new byte[9] { 37, 67, 64, 68, 81, 77, 64, 87, 86 }, 5);
        this._0x2a9f77f0[1] = KindCleanLanes;
        this._0x36a1f465[1] = 8 + _0x773133c6.Next(0, 5) * 2;
        this._0x4180ea33[1] = _0x7ff8b33b._0xcf2fb332(new byte[6] { 186, 171, 182, 170, 170, 217 }, 249) + this._0x36a1f465[1] + _0x7ff8b33b._0xcf2fb332(new byte[20] { 91, 55, 58, 53, 62, 40, 113, 44, 50, 47, 51, 52, 46, 47, 91, 58, 91, 51, 50, 47 }, 123);
        this._0x2a9f77f0[2] = KindFullHearts;
        this._0x36a1f465[2] = 1;
        this._0x4180ea33[2] = _0x7ff8b33b._0xcf2fb332(new byte[29] { 13, 2, 5, 2, 24, 3, 107, 10, 107, 25, 4, 10, 15, 65, 28, 2, 31, 3, 107, 10, 7, 7, 107, 3, 14, 10, 25, 31, 24 }, 75);
        return this;
    }

    public bool _0x55a1f668(int _0x905087ee)
    {
        return _0xfd5cbc90.MissionProgress(_0x905087ee) >= this._0x0cef9fa2(_0x905087ee);
    }

    private readonly int[] _0x2a9f77f0 = new int[SlotCount];
    /// <summary>Mission kind 2: finish a road with every heart intact.</summary>
    public const int KindFullHearts = 2;
    public int _0x69389be2
    {
        get
        {
            return this._0x76fa2411;
        }
    }

    /// <summary>
    /// Records a finished run against every mission at once and converts newly
    /// completed missions into crates on the rewards track.
    /// </summary>
    public void _0xe289feb8(int _0x24c96747, int _0xabc7d2d0, bool _0x2001d433)
    {
        int _0xdbca0385 = this._0xc2fb5612();
        _0xfd5cbc90.SetMissionProgress(0, _0xfd5cbc90.MissionProgress(0) + _0x24c96747);
        int _0x630298dd = _0xfd5cbc90.MissionProgress(1);
        if (_0xabc7d2d0 > _0x630298dd)
        {
            _0xfd5cbc90.SetMissionProgress(1, _0xabc7d2d0);
        }

        if (_0x2001d433)
        {
            _0xfd5cbc90.SetMissionProgress(2, 1);
        }

        int _0x49c01745 = this._0xc2fb5612();
        if (_0x49c01745 > _0xdbca0385)
        {
            _0xfd5cbc90._0x9d9233c1 = _0xfd5cbc90._0x9d9233c1 + (_0x49c01745 - _0xdbca0385);
        }

        _0xfd5cbc90.Flush();
    }

    /// <summary>Mission kind 1: cross lanes without taking a hit.</summary>
    public const int KindCleanLanes = 1;
    /// <summary>Mission kind 0: collect feathers across runs.</summary>
    public const int KindFeathers = 0;
    public int _0xb560f836(int _0x70295650)
    {
        if (_0x70295650 < 0 || _0x70295650 >= SlotCount)
        {
            return KindFeathers;
        }

        return this._0x2a9f77f0[_0x70295650];
    }

    public int _0x0cef9fa2(int _0x79d6b378)
    {
        if (_0x79d6b378 < 0 || _0x79d6b378 >= SlotCount)
        {
            return 1;
        }

        return this._0x36a1f465[_0x79d6b378];
    }
}

internal static class _0x7ff8b33b
{
    internal static string _0xcf2fb332(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}