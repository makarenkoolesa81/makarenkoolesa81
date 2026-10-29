using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xfc6e4613
{
    public static class _0xba356ec3
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0x41ebf98d
    {
        private static readonly _0x41ebf98d _0xb9e017c0 = new();
        public static readonly _0x41ebf98d[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xb9e017c0,
            _0xb9e017c0,
            _0xb9e017c0,
        };
        private int _0x57e0d42b => 0;
        private int _0xed60dec0 => 10;
        private string _0x08528220 => _0xe00e18c9._0x8ba15c85(new byte[4] { 115, 91, 80, 75 }, 62);
        private string _0x05ff75b7 => _0xe00e18c9._0x8ba15c85(new byte[8] { 219, 210, 193, 210, 219, 236, 167, 234 }, 151);

        private int _0xc2ebbee0
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xe00e18c9._0x8ba15c85(new byte[25] { 160, 150, 145, 145, 134, 141, 151, 164, 143, 140, 129, 130, 143, 160, 139, 130, 147, 151, 134, 145, 170, 141, 135, 134, 155 }, 227)))
                    PlayerPrefs.SetInt(_0xe00e18c9._0x8ba15c85(new byte[25] { 225, 215, 208, 208, 199, 204, 214, 229, 206, 205, 192, 195, 206, 225, 202, 195, 210, 214, 199, 208, 235, 204, 198, 199, 218 }, 162), 0);
                return PlayerPrefs.GetInt(_0xe00e18c9._0x8ba15c85(new byte[25] { 202, 252, 251, 251, 236, 231, 253, 206, 229, 230, 235, 232, 229, 202, 225, 232, 249, 253, 236, 251, 192, 231, 237, 236, 241 }, 137));
            }

            set => PlayerPrefs.SetInt(_0xe00e18c9._0x8ba15c85(new byte[25] { 154, 172, 171, 171, 188, 183, 173, 158, 181, 182, 187, 184, 181, 154, 177, 184, 169, 173, 188, 171, 144, 183, 189, 188, 161 }, 217), value);
        }

        public int _0x43d8e806
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x08528220}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x08528220}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x08528220}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x08528220}CurrentLevelIndex", value);
        }

        public int _0x0087184c
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x08528220}BestScore"))
                    this._0x0087184c = 0;
                return PlayerPrefs.GetInt($"{this._0x08528220}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x08528220}BestScore", value);
        }

        public bool _0xf6a2dee2
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x08528220}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x08528220}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x08528220}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x08528220}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xa4ebc6f7
    {
        public static int _0xa37f5e02
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xe00e18c9._0x8ba15c85(new byte[5] { 221, 241, 247, 240, 237 }, 158)))
                    PlayerPrefs.SetInt(_0xe00e18c9._0x8ba15c85(new byte[5] { 130, 174, 168, 175, 178 }, 193), 0);
                return PlayerPrefs.GetInt(_0xe00e18c9._0x8ba15c85(new byte[5] { 162, 142, 136, 143, 146 }, 225));
            }

            set
            {
                PlayerPrefs.SetInt(_0xe00e18c9._0x8ba15c85(new byte[5] { 163, 143, 137, 142, 147 }, 224), value);
                _0xf2da7f44.Instance._0x29264a2e();
            }
        }
    }

    public static class _0xb58be4ea
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xef8a6460
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0xe00e18c9
{
    internal static string _0x8ba15c85(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}