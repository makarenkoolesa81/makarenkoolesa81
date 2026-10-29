using UnityEngine;

/// <summary>
/// Every world size in this game comes from here, and every number here comes from the
/// scene camera (C.0 - not one eyeballed size and not one native sprite size).
///
///   halfH = cam.orthographicSize              (5)
///   halfW = halfH * cam.aspect                (~2.31 at 19.5:9)
///   laneH = 2*halfH / VisibleLanes
///   colW  = 2*halfW / Columns
///
/// A plain sealed class with Init() rather than a constructor (C.59).
/// </summary>
public sealed class _0xaae7a264
{
    public float _0xcae9c9c5
    {
        get
        {
            return this._0x91cd035e;
        }
    }

    private float _0x91cd035e = 1.1765f;
    public _0xaae7a264 _0x808b11fb(Camera _0xfdc1d5de)
    {
        if (_0xfdc1d5de != null && _0xfdc1d5de.orthographic)
        {
            this._0xe6bcef90 = _0xfdc1d5de.orthographicSize;
            this._0xf525e85b = _0xfdc1d5de.orthographicSize * _0xfdc1d5de.aspect;
        }

        this._0x91cd035e = 2f * this._0xe6bcef90 / _0x4e4c58b8.VisibleLanes;
        this._0xc02818c6 = 2f * this._0xf525e85b / _0x4e4c58b8.Columns;
        this._0xd12fb2c8 = -this._0xe6bcef90 + this._0x91cd035e * 1.5f;
        return this;
    }

    public float _0x8d061558
    {
        get
        {
            return this._0xc02818c6;
        }
    }

    /// <summary>
    /// The Sliced size for a content sprite: the height comes from the camera, the
    /// width from the PNG's OWN aspect. Every generated SpriteRenderer is Sliced with
    /// an explicit size (C.0 point 1) - Simple would draw at the native pixel size,
    /// and a 640 px sprite at 100 pixels-per-unit is 6.4 units, wider than the whole
    /// 4.6-unit screen. The width is never typed by hand, so a square sprite can never
    /// arrive as an egg (F.2a), and localScale stays 1,1,1 so the two sizing
    /// mechanisms never fight.
    /// </summary>
    public Vector2 _0x6a8cf3c8(Sprite _0x474d7f61, float _0xba9ab673)
    {
        if (_0x474d7f61 == null || _0x474d7f61.rect.height <= 0.0001f)
        {
            return new Vector2(_0xba9ab673, _0xba9ab673);
        }

        float _0xa6457699 = _0x474d7f61.rect.width / _0x474d7f61.rect.height;
        return new Vector2(_0xba9ab673 * _0xa6457699, _0xba9ab673);
    }

    /// <summary>Half the world width a sprite occupies at that size - the overlap test.</summary>
    public float _0x6fed8a69(Sprite _0xc662433c, float _0x957b2fe9)
    {
        return this._0x6a8cf3c8(_0xc662433c, _0x957b2fe9).x * 0.5f;
    }

    private float _0xd12fb2c8 = -3.2353f;
    public float _0x2d5e910e
    {
        get
        {
            return this._0xf525e85b;
        }
    }

    public float _0xe67a37a0
    {
        get
        {
            return this._0xe6bcef90;
        }
    }

    /// <summary>Centre x of a hop column, 0 .. Columns-1.</summary>
    public float _0x88ec2a6b(int _0x1c49d7eb)
    {
        return (_0x1c49d7eb - (_0x4e4c58b8.Columns - 1) * 0.5f) * this._0xc02818c6;
    }

    /// <summary>The hen keeps this world row; the road scrolls down past her.</summary>
    public float _0x864140ec
    {
        get
        {
            return this._0xd12fb2c8;
        }
    }

    /// <summary>Half the travel width a vehicle covers before it is recycled.</summary>
    public float _0x26e9c10d()
    {
        return this._0xf525e85b * _0x4e4c58b8.StripOverscan + this._0xc02818c6;
    }

    private float _0xf525e85b = 2.3077f;
    private float _0xc02818c6 = 0.9231f;
    private float _0xe6bcef90 = 5f;
    /// <summary>Lane strips run wider than the screen so their cut ends never show.</summary>
    public Vector2 _0x2d41fd80()
    {
        return new Vector2(2f * this._0xf525e85b * _0x4e4c58b8.StripOverscan, this._0x91cd035e);
    }
}