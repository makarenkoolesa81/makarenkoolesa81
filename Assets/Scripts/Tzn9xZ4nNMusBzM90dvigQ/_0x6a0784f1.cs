using UnityEngine;

/// <summary>
/// One row of the road: the strip itself, its traffic and at most one feather.
///
/// The strip is a 9-sliced SpriteRenderer whose m_Size comes from the camera, never
/// from the PNG's native size - a 640 px sprite at 100 pixels-per-unit is 6.4 units,
/// which is wider than the whole screen (C.0).
///
/// Movement is transform.position with a CLAMPED frame step, so a long frame cannot
/// teleport a vehicle past the hen. This game drives no simulated bodies at all; a hit
/// is Mathf.Abs(henX - vehicleX) against the two half-widths (C.57).
/// </summary>
public sealed class _0x6a0784f1 : MonoBehaviour
{
    /// <summary>
    /// Arithmetic AABB overlap against this lane's traffic only. No engine simulation
    /// and no cast - the hen and the vehicle are two intervals on one axis.
    /// </summary>
    public bool _0x3c48f53c(float _0x3b8feee7, float _0x636fdde7)
    {
        if (!this._0xbb0c4307)
        {
            return false;
        }

        for (int _0x38c25395 = 0; _0x38c25395 < this._0x2e08fe5b.Count; _0x38c25395++)
        {
            _0xd65b75aa _0x2ab598ce = this._0x2e08fe5b[_0x38c25395];
            if (_0x2ab598ce == null)
            {
                continue;
            }

            if (Mathf.Abs(_0x3b8feee7 - _0x2ab598ce._0x3ca01d94()) < _0x636fdde7 + _0x2ab598ce._0xbe42e9d5)
            {
                return true;
            }
        }

        return false;
    }

    private _0xa2545300 _0x09463e47;
    public bool _0x6a07f16d
    {
        get
        {
            return this._0xbb0c4307;
        }
    }

    private void Update()
    {
        if (!this._0x17592d19 || !this._0xbb0c4307 || this._0x2e08fe5b.Count == 0)
        {
            return;
        }

        float _0xd8641f9c = this._0xef5130b3 * this._0x287f4562 * Mathf.Min(Time.deltaTime, _0x4e4c58b8.MaxStep);
        for (int _0x23b50488 = 0; _0x23b50488 < this._0x2e08fe5b.Count; _0x23b50488++)
        {
            _0xd65b75aa _0x41cfdbf5 = this._0x2e08fe5b[_0x23b50488];
            if (_0x41cfdbf5 == null)
            {
                continue;
            }

            _0x41cfdbf5._0xfb41edb4(this._0x6bb58472(_0x41cfdbf5._0x3ca01d94() + _0xd8641f9c));
        }
    }

    private float _0xed7eb2d8 = 3f;
    private bool _0x17592d19;
    private int _0xef5130b3 = 1;
    private bool _0xbb0c4307;
    private float _0x287f4562;
    private float _0x6bb58472(float _0x9a03467e)
    {
        float span = this._0xed7eb2d8 * 2f;
        while (_0x9a03467e > this._0xed7eb2d8)
        {
            _0x9a03467e -= span;
        }

        while (_0x9a03467e < -this._0xed7eb2d8)
        {
            _0x9a03467e += span;
        }

        return _0x9a03467e;
    }

    public _0xa2545300 _0x97d03b19()
    {
        _0xa2545300 _0xcc7ec187 = this._0x09463e47;
        this._0x09463e47 = null;
        this._0x6f587316 = -1;
        return _0xcc7ec187;
    }

    public void _0x55fa0b91(_0xa2545300 _0xeb910be2, int _0xae2fb0ce, float _0xc26b5df0, Vector2 _0xfb651c94, Sprite _0x2197ea9c, Color _0xaa84211d)
    {
        this._0x09463e47 = _0xeb910be2;
        this._0x6f587316 = _0xae2fb0ce;
        if (_0xeb910be2 == null)
        {
            return;
        }

        _0xeb910be2.transform.SetParent(this.transform, false);
        _0xeb910be2._0xc1a5c604(_0x2197ea9c, _0xfb651c94, _0x4e4c58b8.OrderPickup, _0xaa84211d);
        _0xeb910be2._0x0fed72ec(_0xc26b5df0, 0f);
    }

    /// <summary>Hands the vehicles back so the director can reuse them on a new row.</summary>
    public _0xd65b75aa[] _0x1ea381a8()
    {
        _0xd65b75aa[] _0x228cdc7f = this._0x2e08fe5b.ToArray();
        this._0x2e08fe5b.Clear();
        return _0x228cdc7f;
    }

    /// <summary>
    /// The strip renderer, resolved from the serialized reference the prefab carries
    /// and only fetched from this object as a fallback - never looked up by name.
    /// </summary>
    private SpriteRenderer _0x027ad48b()
    {
        if (this._strip == null)
        {
            this._strip = this.GetComponent<SpriteRenderer>();
        }

        return this._strip;
    }

    /// <summary>
    /// Fills the lane with evenly spaced traffic. The phase shifts the whole convoy so
    /// two lanes of the same speed do not march in lockstep.
    /// </summary>
    public void _0xcefc6d26(_0xd65b75aa[] _0x287bcdec, Sprite _0xa89d934b, bool _0xfa4d5dc0, int _0x665e4f26, float _0x45643d4a, float _0x0688c2d3, Vector2 _0x3e764dad, Color _0x51f03a25)
    {
        this._0xef5130b3 = _0x665e4f26 == 0 ? 1 : _0x665e4f26;
        this._0x287f4562 = _0x45643d4a;
        this._0x2e08fe5b.Clear();
        if (_0x287bcdec == null || _0x287bcdec.Length == 0)
        {
            return;
        }

        float span = this._0xed7eb2d8 * 2f;
        float _0x0389fddd = span / _0x287bcdec.Length;
        for (int _0x1c4116c0 = 0; _0x1c4116c0 < _0x287bcdec.Length; _0x1c4116c0++)
        {
            _0xd65b75aa _0x518c8e10 = _0x287bcdec[_0x1c4116c0];
            if (_0x518c8e10 == null)
            {
                continue;
            }

            _0x518c8e10.transform.SetParent(this.transform, false);
            _0x518c8e10._0xdc7f42bc(_0xa89d934b, _0xfa4d5dc0, this._0xef5130b3, _0x3e764dad, _0x4e4c58b8.OrderVehicle, _0x51f03a25);
            float _0xee298a62 = (_0x1c4116c0 + _0x0688c2d3) * _0x0389fddd - this._0xed7eb2d8;
            _0x518c8e10._0xfb41edb4(this._0x6bb58472(_0xee298a62));
            _0x518c8e10.gameObject.SetActive(true);
            this._0x2e08fe5b.Add(_0x518c8e10);
        }
    }

    /// <summary>Sizes the strip from the camera-derived geometry and tints it.</summary>
    public void _0x167f5ec4(_0xaae7a264 _0xc2db128c, Sprite _0x257a84e9, bool _0x23a7191f, Color _0xbe2f20f7)
    {
        this._0xbb0c4307 = _0x23a7191f;
        SpriteRenderer _0xf4996c6d = this._0x027ad48b();
        if (_0xf4996c6d != null)
        {
            _0xf4996c6d.sprite = _0x257a84e9;
            _0xf4996c6d.drawMode = SpriteDrawMode.Sliced;
            _0xf4996c6d.size = _0xc2db128c._0x2d41fd80();
            _0xf4996c6d.color = _0xbe2f20f7;
            _0xf4996c6d.sortingOrder = _0x4e4c58b8.ClampOrder(_0x23a7191f ? _0x4e4c58b8.OrderRoad : _0x4e4c58b8.OrderVerge);
        }

        this.transform.localScale = Vector3.one;
        this._0xed7eb2d8 = _0xc2db128c._0x26e9c10d();
    }

    public int _0x77f7d207
    {
        get
        {
            return this._0x6f587316;
        }
    }

    private readonly System.Collections.Generic.List<_0xd65b75aa> _0x2e08fe5b = new System.Collections.Generic.List<_0xd65b75aa>();
    public _0xa2545300 _0x96797bcb
    {
        get
        {
            return this._0x09463e47;
        }
    }

    private int _0x6f587316 = -1;
    [SerializeField]
    private SpriteRenderer _strip;
    public void _0x3c88f758(bool _0x52bff1b7)
    {
        this._0x17592d19 = _0x52bff1b7;
    }
}