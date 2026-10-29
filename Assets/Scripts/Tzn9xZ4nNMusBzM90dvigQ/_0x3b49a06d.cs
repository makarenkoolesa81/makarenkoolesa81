using UnityEngine;

/// <summary>
/// Builds a stretch of road from a SEEDED System.Random, checks it is crossable, and
/// only then hands it over (C.11). UnityEngine.Random is deliberately not used: it
/// carries global state, so the traffic generator and the pickup generator would start
/// pulling the same stream and "the same seed" would stop meaning the same thing.
///
/// The hardcoded layout at the bottom is a FALLBACK after twenty failed attempts, never
/// the game.
///
/// No constructor (C.59): Init(System.Random) returns the object.
/// </summary>
public sealed class _0x3b49a06d
{
    private _0xf440145c _0xec64b667(int _0xf8c01b1c, float _0x5346f793)
    {
        int _0x085d220b = _0x4e4c58b8.RoadLanes(_0xf8c01b1c);
        _0xf440145c _0xa86561e8 = new _0xf440145c()._0x9ebb2b71(_0x085d220b);
        for (int _0x1264a567 = 1; _0x1264a567 <= _0x085d220b; _0x1264a567++)
        {
            int _0x7af9597f = this._0xdd31d3a0.Next(0, 2) == 0 ? -1 : 1;
            float _0xccdcb2d7 = (float)this._0xdd31d3a0.NextDouble();
            float _0x1bf2d60d = Mathf.Lerp(_0x4e4c58b8.SpeedSlow, _0x4e4c58b8.SpeedFast, _0xccdcb2d7) * _0x5346f793;
            float _0xf5f6ad24 = (float)this._0xdd31d3a0.NextDouble();
            int _0xc711c00b = this._0xdd31d3a0.Next(0, 3);
            int _0xb023cb68 = this._0xdd31d3a0.Next(2, 4);
            _0xa86561e8._0x267eaa03(_0x1264a567, _0x7af9597f, _0x1bf2d60d, _0xf5f6ad24, _0xc711c00b, _0xb023cb68);
        }

        // One to three feathers per stretch, each on its own road lane and column.
        int _0xd9c9fe2b = 1 + this._0xdd31d3a0.Next(0, Mathf.Min(3, _0x085d220b));
        int _0x4b493af7 = _0xd9c9fe2b > 0 ? this._0xdd31d3a0.Next(0, _0x4e4c58b8.Columns) : -1;
        int _0x349ea74b = _0xd9c9fe2b > 1 ? this._0xdd31d3a0.Next(0, _0x4e4c58b8.Columns) : -1;
        int _0x5d18e6be = _0xd9c9fe2b > 2 ? this._0xdd31d3a0.Next(0, _0x4e4c58b8.Columns) : -1;
        _0xa86561e8._0xd3238ff0(_0x4b493af7, _0x349ea74b, _0x5d18e6be);
        _0xa86561e8._0xf2493dc3(this._0xdd31d3a0.Next(0, 2) == 0 ? 0 : _0x4e4c58b8.Columns - 1);
        return _0xa86561e8;
    }

    public _0x3b49a06d _0x6b477146(System.Random _0x8e43cd10, float _0x3872c2cf)
    {
        this._0xdd31d3a0 = _0x8e43cd10;
        this._0xc8e014d0 = _0x3872c2cf;
        return this;
    }

    /// <summary>
    /// A lane is crossable when its repeating gap is wide enough for the hen to commit
    /// to a hop and land: gap >= vehicleLength + speed * 0.95 + 0.9 world units. The
    /// columns themselves are always connected - the hen may hop straight ahead in any
    /// column - so a stretch is crossable exactly when every road lane is.
    /// </summary>
    public bool _0x902bc3d8(_0xf440145c _0xf06a501b)
    {
        if (_0xf06a501b == null)
        {
            return false;
        }

        for (int _0xb4a1b370 = 0; _0xb4a1b370 < _0xf06a501b._0x6103f9c9; _0xb4a1b370++)
        {
            if (_0xf06a501b._0x65863c0e(_0xb4a1b370) != _0xf440145c.LaneRoad)
            {
                continue;
            }

            int _0xdbdb6478 = _0xf06a501b._0xbf03d0c3(_0xb4a1b370);
            if (_0xdbdb6478 <= 0)
            {
                continue;
            }

            float _0x91ae1e5a = 2f * (_0x4e4c58b8.Columns * 0.5f) * 1.2f + 2f;
            float _0xfb84a3fd = _0x91ae1e5a / _0xdbdb6478;
            float _0x6f6363bf = _0xfb84a3fd - this._0xc8e014d0;
            float _0x2b6adcc4 = this._0xc8e014d0 + _0xf06a501b._0x07f7cb73(_0xb4a1b370) * 0.95f + 0.9f;
            if (_0x6f6363bf < _0x2b6adcc4)
            {
                return false;
            }
        }

        return true;
    }

    private float _0xc8e014d0 = 0.9f;
    private System.Random _0xdd31d3a0;
    /// <summary>
    /// Generates the stretch, regenerating while it is not crossable, and falls back to
    /// a known-good three-lane layout if twenty attempts all fail.
    /// </summary>
    public _0xf440145c _0x478da592(int _0x61e43529, float _0x06ba72bf)
    {
        _0xf440145c _0x4d0b2ebd = this._0xec64b667(_0x61e43529, _0x06ba72bf);
        for (int _0x9dea2f5c = 0; _0x9dea2f5c < 20 && !this._0x902bc3d8(_0x4d0b2ebd); _0x9dea2f5c++)
        {
            _0x4d0b2ebd = this._0xec64b667(_0x61e43529, _0x06ba72bf);
        }

        if (!this._0x902bc3d8(_0x4d0b2ebd))
        {
            _0x4d0b2ebd = this._0x28bd0d37(_0x06ba72bf);
        }

        return _0x4d0b2ebd;
    }

    /// <summary>The guaranteed layout. A guarantee, never the game (C.11).</summary>
    private _0xf440145c _0x28bd0d37(float _0x89ca5e05)
    {
        _0xf440145c _0x59f08dcf = new _0xf440145c()._0x9ebb2b71(3);
        _0x59f08dcf._0x267eaa03(1, 1, _0x4e4c58b8.SpeedSlow * _0x89ca5e05, 0.0f, 0, 2);
        _0x59f08dcf._0x267eaa03(2, -1, _0x4e4c58b8.SpeedSlow * _0x89ca5e05, 0.4f, 1, 2);
        _0x59f08dcf._0x267eaa03(3, 1, _0x4e4c58b8.SpeedSlow * _0x89ca5e05, 0.7f, 2, 2);
        _0x59f08dcf._0xd3238ff0(2, -1, -1);
        _0x59f08dcf._0xf2493dc3(_0x4e4c58b8.Columns - 1);
        return _0x59f08dcf;
    }
}