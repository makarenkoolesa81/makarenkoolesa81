/// <summary>
/// One generated stretch of road: an opening verge, some road lanes, a closing verge.
/// Pure data, built by StretchGenerator and read by RoadDirector.
///
/// No constructor anywhere (C.59): Init() fills the fields and returns the object.
/// </summary>
public sealed class _0xf440145c
{
    public int _0xc8393f8d(int _0xaf5ff0fe)
    {
        return _0xaf5ff0fe >= 0 && _0xaf5ff0fe < this._0x4397227a.Length ? this._0x4397227a[_0xaf5ff0fe] : 1;
    }

    private int _0x59ef9868 = 0;
    private int[] _0xe3b9c910 = new int[5];
    private float[] _0x78c4c562 = new float[5];
    private float[] _0xdbadae83 = new float[5];
    private int _0x635b8c01 = -1;
    public void _0xd3238ff0(int _0x12de756f, int _0x9cc7b064, int _0xe1736ba6)
    {
        this._0x1b4c3e72 = _0x12de756f;
        this._0x635b8c01 = _0x9cc7b064;
        this._0x5f19ee26 = _0xe1736ba6;
    }

    public float _0x07f7cb73(int _0x1031acdf)
    {
        return _0x1031acdf >= 0 && _0x1031acdf < this._0x78c4c562.Length ? this._0x78c4c562[_0x1031acdf] : 1f;
    }

    private int[] _0x4397227a = new int[5];
    /// <summary>
    /// Which column of this row carries a feather, or -1. Feathers sit on the road
    /// lanes only, one per lane at most, so a lane is never a free pickup row.
    /// </summary>
    public int _0x873e88a8(int _0x6701264f)
    {
        if (this._0x65863c0e(_0x6701264f) != LaneRoad)
        {
            return -1;
        }

        int _0x118db765 = _0x6701264f - 1;
        if (_0x118db765 == 0)
        {
            return this._0x1b4c3e72;
        }

        if (_0x118db765 == 1)
        {
            return this._0x635b8c01;
        }

        if (_0x118db765 == 2)
        {
            return this._0x5f19ee26;
        }

        return -1;
    }

    private int[] _0x0758507e = new int[5];
    private int[] _0x03d41bee = new int[5];
    public int _0xbf03d0c3(int _0xc8a203c0)
    {
        return _0xc8a203c0 >= 0 && _0xc8a203c0 < this._0x0758507e.Length ? this._0x0758507e[_0xc8a203c0] : 0;
    }

    public int _0x65863c0e(int _0xe9b1bfc3)
    {
        if (_0xe9b1bfc3 < 0 || _0xe9b1bfc3 >= this._0xe3b9c910.Length)
        {
            return LaneVerge;
        }

        return this._0xe3b9c910[_0xe9b1bfc3];
    }

    private int _0x5fc2b589 = 3;
    public const int LaneVerge = 0;
    public const int LaneRoad = 1;
    public int _0x47be9f0a(int _0xa92c50d8)
    {
        return _0xa92c50d8 >= 0 && _0xa92c50d8 < this._0x03d41bee.Length ? this._0x03d41bee[_0xa92c50d8] : 0;
    }

    public void _0x267eaa03(int _0xfc9bd24f, int _0x07eb4f2e, float _0x41bad840, float _0x7b493b7a, int _0x96ec1ad4, int _0xe4c2fa6c)
    {
        if (_0xfc9bd24f < 0 || _0xfc9bd24f >= this._0xe3b9c910.Length)
        {
            return;
        }

        this._0x4397227a[_0xfc9bd24f] = _0x07eb4f2e;
        this._0x78c4c562[_0xfc9bd24f] = _0x41bad840;
        this._0xdbadae83[_0xfc9bd24f] = _0x7b493b7a;
        this._0x03d41bee[_0xfc9bd24f] = _0x96ec1ad4;
        this._0x0758507e[_0xfc9bd24f] = _0xe4c2fa6c;
    }

    private int _0x5f19ee26 = -1;
    public _0xf440145c _0x9ebb2b71(int _0x68461b4f)
    {
        this._0x5fc2b589 = _0x68461b4f;
        this._0xe3b9c910 = new int[_0x68461b4f + 2];
        this._0x4397227a = new int[_0x68461b4f + 2];
        this._0x78c4c562 = new float[_0x68461b4f + 2];
        this._0xdbadae83 = new float[_0x68461b4f + 2];
        this._0x03d41bee = new int[_0x68461b4f + 2];
        this._0x0758507e = new int[_0x68461b4f + 2];
        for (int _0x4bfd756d = 0; _0x4bfd756d < this._0xe3b9c910.Length; _0x4bfd756d++)
        {
            this._0xe3b9c910[_0x4bfd756d] = _0x4bfd756d == 0 || _0x4bfd756d == this._0xe3b9c910.Length - 1 ? LaneVerge : LaneRoad;
        }

        return this;
    }

    private int _0x1b4c3e72 = -1;
    /// <summary>Total rows including the two verges.</summary>
    public int _0x6103f9c9
    {
        get
        {
            return this._0x5fc2b589 + 2;
        }
    }

    public int _0xc782490e
    {
        get
        {
            return this._0x5fc2b589;
        }
    }

    public int _0x4cbd0e87
    {
        get
        {
            return this._0x59ef9868;
        }
    }

    public void _0xf2493dc3(int _0x16496b72)
    {
        this._0x59ef9868 = _0x16496b72;
    }

    public float _0x86c9b740(int _0x645d1b86)
    {
        return _0x645d1b86 >= 0 && _0x645d1b86 < this._0xdbadae83.Length ? this._0xdbadae83[_0x645d1b86] : 0f;
    }
}