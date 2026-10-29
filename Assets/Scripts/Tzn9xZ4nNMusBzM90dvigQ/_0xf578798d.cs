using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// The run. Owns the camera-derived geometry, the generated stretches, the hen, the
/// traffic, the hearts and the three pops.
///
/// BALANCE (C.5): there is no timer, no fuel and no draining meter of any kind. A run
/// in which the player never taps lasts INDEFINITELY - the hen simply stands on the
/// opening verge while the traffic flows - so the "at least 60 seconds" requirement
/// holds by construction, with no arithmetic to get wrong. Hearts are spent only by
/// the player's own hops. The review window (first gameplay frame around second 15,
/// last around second 30) therefore always lands on live gameplay.
///
/// PHYSICS (C.57): none. Vehicles move by transform.position with a clamped frame
/// step, the hen by DOTween, and a hit is an arithmetic overlap of two half-widths.
/// Nothing in this game is driven by the engine's simulation.
/// </summary>
public sealed class _0xf578798d : MonoBehaviour
{
    /// <summary>
    /// A verge closes a stretch: the bar advances, a bonus of 3 + index feathers is
    /// awarded, and the goal is checked.
    /// </summary>
    private void _0x9a003b33()
    {
        int _0x36840602 = this._0x1240b28d();
        if (_0x36840602 <= 0)
        {
            return;
        }

        int _0xec9b4f6c = 3 + _0x36840602;
        this._0x8309ba00(_0xec9b4f6c, this._0x6b40d20b.transform.position, _0x0b7ba5a5._0x7b2f8db6(new byte[1] { 169 }, 130) + _0xec9b4f6c);
        this._0x4e46614c._0x9ae1cbc5(_0x36840602, this._0xe9dd1946);
        if (_0x36840602 >= this._0xe9dd1946)
        {
            this._0x1fb9af27();
        }
    }

    private void _0x762412ea()
    {
        _0x6a0784f1 _0xb7bf0e52 = this._0x15c7fd6e(this._0xc7f8562d);
        if (_0xb7bf0e52 != null && !_0xb7bf0e52._0x6a07f16d)
        {
            this._0x33d3f618 = this._0xc7f8562d;
            this._0x9a003b33();
        }

        if (_0xb7bf0e52 != null && _0xb7bf0e52._0x6a07f16d)
        {
            this._0xb574fd0a++;
            if (this._0xb574fd0a > this._0xcbdfb598)
            {
                this._0xcbdfb598 = this._0xb574fd0a;
            }
        }

        this._0xbf383104(_0xb7bf0e52);
        this._0x91317b36();
        if (this._0xbaf5091d != _0xa20d578b.HopNone && !this._0xdf1f6a6b)
        {
            int _0x7287a22b = this._0xbaf5091d;
            this._0xbaf5091d = _0xa20d578b.HopNone;
            this._0x73e63432(_0x7287a22b);
        }
    }

    private _0x6a0784f1 _0x15c7fd6e(int _0x4c665cc5)
    {
        if (_0x4c665cc5 < 0 || _0x4c665cc5 >= this._0x6131b581.Count)
        {
            return null;
        }

        return this._0x6131b581[_0x4c665cc5];
    }

    private readonly List<int> _0x40f1fd48 = new List<int>();
    /// <summary>
    /// Three landing-column markers one lane ahead of the hen. They are the HOP GUIDE
    /// setting's subject and are hidden at the board edges, so a marker never points
    /// at a column the hen cannot reach.
    /// </summary>
    private void _0x3fafc89d()
    {
        if (this._0x02374ec7 == null)
        {
            return;
        }

        Sprite _0xcb6e5bdf = this._0x06ef4b04._0x6cc93da1;
        Vector2 _0xd7352722 = this._0xe484b9be._0x6a8cf3c8(_0xcb6e5bdf, this._0xe484b9be._0xcae9c9c5 * 0.30f);
        for (int _0x24e016cf = 0; _0x24e016cf < 3; _0x24e016cf++)
        {
            GameObject _0x07a140d6 = Instantiate(this._0x02374ec7, this.transform);
            SpriteRenderer _0x92c8697a = _0x07a140d6.GetComponent<SpriteRenderer>();
            if (_0x92c8697a != null)
            {
                _0x92c8697a.sprite = _0xcb6e5bdf;
                _0x92c8697a.drawMode = SpriteDrawMode.Sliced;
                _0x92c8697a.size = _0xd7352722;
                _0x92c8697a.color = _0x38306f56.Fade(_0x38306f56.Sprout, 0.55f);
                _0x92c8697a.sortingOrder = _0x4e4c58b8.ClampOrder(_0x4e4c58b8.OrderChevron);
                _0x92c8697a.DOFade(0.9f, 0.9f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0x07a140d6);
                this._0x16d62169.Add(_0x92c8697a);
            }

            _0x07a140d6.transform.localScale = Vector3.one;
        }
    }

    private GameObject _0x02374ec7;
    // -------------------------------------------------------------------------------
    // Rows
    // -------------------------------------------------------------------------------
    private void _0xd5b362c8()
    {
        this._0xb037fec5 = this._0x39d43ee1._0x478da592(this._0x75f78fff, _0x4e4c58b8.SpeedMultiplier(this._0x75f78fff) * this._0xd3713782);
        this._0x28ca14cc = 0;
    }

    private int _0xcbdfb598;
    private void _0x80e5ad46()
    {
        if (this._0xdf1f6a6b)
        {
            return;
        }

        this._0xdf1f6a6b = true;
        this._0xa11d1dcf(false);
        this._0x8eb64686._0x0d467fe1(this._0x1240b28d() + 1, this._0xe9dd1946, this._0xbde4fbdd, _0xfd5cbc90._0x8066d3d8);
    }

    private _0x21f276c9 _0x94527339;
    private void _0x857f9f2c(_0x6a0784f1 _0x4360358a, int _0x4e95c52f)
    {
        int _0x76f9b163 = this._0xb037fec5._0x47be9f0a(_0x4e95c52f);
        int _0x01ab2506 = this._0xb037fec5._0xbf03d0c3(_0x4e95c52f);
        GameObject _0x6e0c3dc5 = this._0x6615cca7 != null && _0x76f9b163 < this._0x6615cca7.Length ? this._0x6615cca7[_0x76f9b163] : null;
        if (_0x6e0c3dc5 != null && _0x01ab2506 > 0)
        {
            _0xd65b75aa[] _0x22023f4e = new _0xd65b75aa[_0x01ab2506];
            for (int _0xc21ca2bc = 0; _0xc21ca2bc < _0x01ab2506; _0xc21ca2bc++)
            {
                GameObject _0x7e9c4728 = Instantiate(_0x6e0c3dc5, _0x4360358a.transform);
                _0xd65b75aa _0x6e99ff52 = _0x7e9c4728.GetComponent<_0xd65b75aa>();
                if (_0x6e99ff52 == null)
                {
                    _0x6e99ff52 = _0x7e9c4728.AddComponent<_0xd65b75aa>();
                }

                _0x22023f4e[_0xc21ca2bc] = _0x6e99ff52;
            }

            Sprite _0x3312aeab = this._0x06ef4b04._0xfeaf8c24(_0x76f9b163);
            Vector2 _0x6789ee6e = this._0xe484b9be._0x6a8cf3c8(_0x3312aeab, this._0xe484b9be._0xcae9c9c5 * 0.64f);
            _0x4360358a._0xcefc6d26(_0x22023f4e, _0x3312aeab, this._0x06ef4b04._0x279c5335(_0x76f9b163), this._0xb037fec5._0xc8393f8d(_0x4e95c52f), this._0xb037fec5._0x07f7cb73(_0x4e95c52f), this._0xb037fec5._0x86c9b740(_0x4e95c52f), _0x6789ee6e, Color.white);
        }

        int _0xbef0d9a4 = this._0xb037fec5._0x873e88a8(_0x4e95c52f);
        if (_0xbef0d9a4 >= 0 && this._0x5dd0d95e != null)
        {
            GameObject _0x916ff576 = Instantiate(this._0x5dd0d95e, _0x4360358a.transform);
            _0xa2545300 _0x6920b3c4 = _0x916ff576.GetComponent<_0xa2545300>();
            if (_0x6920b3c4 == null)
            {
                _0x6920b3c4 = _0x916ff576.AddComponent<_0xa2545300>();
            }

            Sprite _0xc8f79252 = this._0x06ef4b04._0xf062d852;
            Vector2 _0x157cafd3 = this._0xe484b9be._0x6a8cf3c8(_0xc8f79252, this._0xe484b9be._0xcae9c9c5 * 0.38f);
            _0x4360358a._0x55fa0b91(_0x6920b3c4, _0xbef0d9a4, this._0xe484b9be._0x88ec2a6b(_0xbef0d9a4), _0x157cafd3, _0xc8f79252, _0x38306f56.Cream);
        }
    }

    private GameObject _0x35db6348;
    private bool _0xdf1f6a6b;
    private const int RowBuffer = 3;
    private int _0xb574fd0a;
    private Transform _0xbb109490;
    private int _0x448b0d71;
    private void _0x4f210d49()
    {
        _0xfd5cbc90._0xae510bae = _0xfd5cbc90._0xae510bae + 1;
        bool _0xdbac822d = _0xfd5cbc90._0xc633c5a1;
        this._0xe9dd1946 = _0xdbac822d ? _0x4e4c58b8.DailyStretchGoal : _0x4e4c58b8.StretchGoal;
        this._0x7c687f26 = _0xdbac822d ? 1 : _0x4e4c58b8.Hearts;
        this._0xd3713782 = _0xdbac822d ? _0x4e4c58b8.DailySpeedMultiplier : 1f;
        int _0x68214887 = _0xdbac822d ? this._0x68292589._0xe2097338() : (this._0x75f78fff * 7919) ^ (_0xfd5cbc90._0xae510bae * 104729);
        System.Random _0x8dece802 = new System.Random(_0x68214887);
        float _0x3cc86d5b = this._0xe484b9be._0x8d061558 * 0.9f;
        this._0x39d43ee1 = new _0x3b49a06d()._0x6b477146(_0x8dece802, _0x3cc86d5b);
        {
#if B_LOGS
            {
                Debug.Log($"[road] seed={_0x68214887} challenge={_0xdbac822d} goal={this._0xe9dd1946} hearts={this._0x7c687f26}");
            }
#endif
        }

        this._0x3fafc89d();
        this._0xd5b362c8();
        while (this._0x448b0d71 < _0x4e4c58b8.VisibleLanes + RowBuffer)
        {
            this._0x6cb97755();
        }

        this._0xc7f8562d = 0;
        this._0x33d3f618 = 0;
        this._0x559bf3be(false);
        this._0x4e46614c._0x0bf39a5f(this._0x7c687f26);
        this._0x4e46614c._0x0285c771(0);
        this._0x4e46614c._0x9ae1cbc5(0, this._0xe9dd1946);
        this._0x91317b36();
    }

    private int _0x28ca14cc;
    /// <summary>
    /// Banks the run: grain = feathers / 4 + stretches * 5, lifetime totals, the best
    /// streak, the daily best and the three mission counters.
    /// </summary>
    private int _0xa11d1dcf(bool _0x3a277efe)
    {
        int _0x1eeba02a = this._0x1240b28d();
        int _0xf074a24e = this._0xbde4fbdd / 4 + _0x1eeba02a * 5;
        _0xfd5cbc90._0x1ec9c5ae = _0xfd5cbc90._0x1ec9c5ae + _0xf074a24e;
        _0xfd5cbc90._0x62e1ffc6 = _0xfd5cbc90._0x62e1ffc6 + this._0xbde4fbdd;
        if (this._0xcbdfb598 > _0xfd5cbc90._0x8066d3d8)
        {
            _0xfd5cbc90._0x8066d3d8 = this._0xcbdfb598;
        }

        if (_0x3a277efe)
        {
            _0xfd5cbc90._0x94b0bd4a = _0xfd5cbc90._0x94b0bd4a + 1;
        }

        if (_0xfd5cbc90._0xc633c5a1 && _0x1eeba02a > _0xfd5cbc90._0xcc507d7e)
        {
            _0xfd5cbc90._0xcc507d7e = _0x1eeba02a;
        }

        this._0x68292589._0xe289feb8(this._0xbde4fbdd, this._0xcbdfb598, _0x3a277efe && this._0x7c687f26 >= _0x4e4c58b8.Hearts);
        _0xfd5cbc90._0xc633c5a1 = false;
        _0xfd5cbc90.Flush();
        {
#if B_LOGS
            {
                Debug.Log($"[road] settled cleared={_0x3a277efe} stretches={_0x1eeba02a} feathers={this._0xbde4fbdd} grain={_0xf074a24e}");
            }
#endif
        }

        return _0xf074a24e;
    }

    private int _0xe9dd1946 = _0x4e4c58b8.StretchGoal;
    private _0xaae7a264 _0xe484b9be;
    private _0xa06b42c3 _0x8eb64686;
    private float _0xd3713782 = 1f;
    private int _0x75f78fff;
    private int _0xbde4fbdd;
    private void _0xbf383104(_0x6a0784f1 _0xde9a1e2a)
    {
        if (_0xde9a1e2a == null || _0xde9a1e2a._0x96797bcb == null || _0xde9a1e2a._0x96797bcb._0x74c5d04e)
        {
            return;
        }

        if (_0xde9a1e2a._0x77f7d207 != this._0x6b40d20b._0xf5c741b6)
        {
            return;
        }

        _0xde9a1e2a._0x96797bcb._0x8d51cb06();
        this._0x8309ba00(1, this._0x6b40d20b.transform.position, _0x0b7ba5a5._0x7b2f8db6(new byte[2] { 184, 162 }, 147));
    }

    private _0xf440145c _0xb037fec5;
    private _0xe0ca158f _0x4e46614c;
    private GameObject _0x7ca6d8de;
    private void _0x8309ba00(int amount, Vector3 _0x03d59956, string _0x9ab7702a)
    {
        this._0xbde4fbdd += amount;
        this._0x4e46614c._0x0285c771(this._0xbde4fbdd);
        if (this._0x94527339 != null)
        {
            this._0x94527339._0xa4ce5f6b(_0x03d59956, _0x9ab7702a);
        }
    }

    private void _0x84aa833d()
    {
        this._0x7c687f26--;
        this._0xb574fd0a = 0;
        this._0xd9248733 = Time.time + _0x4e4c58b8.InvulnerableTime;
        this._0x4e46614c._0x0bf39a5f(this._0x7c687f26);
        this._0x4e46614c._0xfe6b657f();
        this._0x6b40d20b._0x46633fa7();
        _0xfd5cbc90.Buzz();
        this._0xc7f8562d = this._0x33d3f618;
        this._0x6b40d20b._0x84be0974(this._0x6b40d20b._0xf5c741b6);
        this._0x559bf3be(true);
        this._0x91317b36();
        if (this._0x7c687f26 <= 0)
        {
            this._0x80e5ad46();
        }
    }

    private int _0x7c687f26 = _0x4e4c58b8.Hearts;
    private GameObject _0x5dd0d95e;
    private _0x3b49a06d _0x39d43ee1;
    // -------------------------------------------------------------------------------
    // Run loop
    // -------------------------------------------------------------------------------
    private void Update()
    {
        bool _0x3fd74f09 = _0xf2da7f44.Instance != null && _0xf2da7f44.Instance._0x5d7fe3e2;
        bool _0xefd15094 = _0x3fd74f09 && !this._0xdf1f6a6b && !this._0x1e19de21();
        if (_0xefd15094 != this._0x5555be4f)
        {
            this._0x5555be4f = _0xefd15094;
            for (int _0xc0efd5d7 = 0; _0xc0efd5d7 < this._0x6131b581.Count; _0xc0efd5d7++)
            {
                if (this._0x6131b581[_0xc0efd5d7] != null)
                {
                    this._0x6131b581[_0xc0efd5d7]._0x3c88f758(this._0x5555be4f);
                }
            }
        }

        if (!this._0x5555be4f)
        {
            return;
        }

        int _0x4404db9b = this._0x255a19f9 != null ? this._0x255a19f9._0x4d582780() : _0xa20d578b.HopNone;
        if (_0x4404db9b != _0xa20d578b.HopNone)
        {
            if (this._0x6b40d20b._0x3b64b94f)
            {
                this._0xbaf5091d = _0x4404db9b;
            }
            else
            {
                this._0x73e63432(_0x4404db9b);
            }
        }

        this._0x95644c9b();
    }

    private float _0xd9248733;
    private _0x1f14bf52 _0x6b40d20b;
    private GameObject _0x11f717c1;
    /// <summary>
    /// Rows well behind the hen are switched off rather than destroyed: the list index
    /// IS the row number, so nothing may be removed from it.
    ///
    /// The cutoff is measured from the LAST SAFE VERGE, not from the hen: a hit sends
    /// her back there, and a stretch can be five rows deep, so recycling from her
    /// current row would switch off the row she is about to be returned to and leave
    /// her standing on nothing.
    /// </summary>
    private void _0x982e54bc()
    {
        int _0x4759c8e0 = Mathf.Min(this._0xc7f8562d, this._0x33d3f618) - RowBuffer;
        for (int _0x29b8be7b = 0; _0x29b8be7b < _0x4759c8e0 && _0x29b8be7b < this._0x6131b581.Count; _0x29b8be7b++)
        {
            _0x6a0784f1 _0x61c6ade5 = this._0x6131b581[_0x29b8be7b];
            if (_0x61c6ade5 != null && _0x61c6ade5.gameObject.activeSelf)
            {
                _0x61c6ade5.gameObject.SetActive(false);
            }
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
        if (this._0xbb109490 != null)
        {
            DOTween.Kill(this._0xbb109490);
        }

        for (int _0x7772dd95 = 0; _0x7772dd95 < this._0x16d62169.Count; _0x7772dd95++)
        {
            if (this._0x16d62169[_0x7772dd95] != null)
            {
                DOTween.Kill(this._0x16d62169[_0x7772dd95]);
            }
        }
    }

    // -------------------------------------------------------------------------------
    // Results
    // -------------------------------------------------------------------------------
    private void _0x1fb9af27()
    {
        if (this._0xdf1f6a6b)
        {
            return;
        }

        this._0xdf1f6a6b = true;
        int _0x4ae126b6 = this._0xa11d1dcf(true);
        this._0x8eb64686._0x2d463820(this._0xe9dd1946, this._0xbde4fbdd, _0x4ae126b6);
    }

    /// <summary>Roadside decor on a verge, marking the end of a stretch.</summary>
    private void _0x2622145b(_0x6a0784f1 _0xabed4fc2)
    {
        if (this._0x11f717c1 == null)
        {
            return;
        }

        GameObject _0xb5e04e41 = Instantiate(this._0x11f717c1, _0xabed4fc2.transform);
        SpriteRenderer _0x6e847560 = _0xb5e04e41.GetComponent<SpriteRenderer>();
        if (_0x6e847560 != null)
        {
            Sprite _0x597da3c2 = this._0x06ef4b04._0xdb52545b;
            _0x6e847560.sprite = _0x597da3c2;
            _0x6e847560.drawMode = SpriteDrawMode.Sliced;
            _0x6e847560.size = this._0xe484b9be._0x6a8cf3c8(_0x597da3c2, this._0xe484b9be._0xcae9c9c5 * 0.95f);
            _0x6e847560.sortingOrder = _0x4e4c58b8.ClampOrder(_0x4e4c58b8.OrderDecor);
            _0xb5e04e41.transform.localScale = Vector3.one;
        }

        int _0xce68d07b = this._0xb037fec5 != null ? this._0xb037fec5._0x4cbd0e87 : 0;
        _0xb5e04e41.transform.localPosition = new Vector3(this._0xe484b9be._0x88ec2a6b(_0xce68d07b), this._0xe484b9be._0xcae9c9c5 * 0.25f, 0f);
    }

    private void _0x73e63432(int _0x39560808)
    {
        int _0xb1ca964c = Mathf.Clamp(this._0x6b40d20b._0xf5c741b6 + _0x39560808, 0, _0x4e4c58b8.Columns - 1);
        Vector3 _0xfca19908 = this._0x6b40d20b.transform.position;
        this._0xc7f8562d++;
        this._0x559bf3be(true);
        this._0x6b40d20b._0x24b37c55(_0xb1ca964c, () => this._0x762412ea());
        if (this._0x94527339 != null)
        {
            this._0x94527339._0x412ade2c(_0xfca19908);
        }

        while (this._0x448b0d71 < this._0xc7f8562d + _0x4e4c58b8.VisibleLanes + RowBuffer)
        {
            this._0x6cb97755();
        }

        this._0x982e54bc();
        this._0x91317b36();
    }

    public void _0x4d8cf9b2(_0xbe7aadff _0xd1658152, _0xaae7a264 _0x7116f75b, Transform _0x9e1be257, _0x1f14bf52 _0x6408246f, _0xe0ca158f _0xfd5d5e37, _0xa06b42c3 _0x9fbf2c86, _0x21f276c9 _0x27cb2af6, _0xa20d578b _0x699db69c, GameObject _0x4b1ab1f6, GameObject _0x43b80fd4, GameObject[] _0x5305257f, GameObject _0x9926df6c, GameObject _0xf840575b, GameObject _0x1f1880f0)
    {
        this._0x06ef4b04 = _0xd1658152;
        this._0xe484b9be = _0x7116f75b;
        this._0xbb109490 = _0x9e1be257;
        this._0x6b40d20b = _0x6408246f;
        this._0x4e46614c = _0xfd5d5e37;
        this._0x8eb64686 = _0x9fbf2c86;
        this._0x94527339 = _0x27cb2af6;
        this._0x255a19f9 = _0x699db69c;
        this._0x35db6348 = _0x4b1ab1f6;
        this._0x7ca6d8de = _0x43b80fd4;
        this._0x6615cca7 = _0x5305257f;
        this._0x5dd0d95e = _0x9926df6c;
        this._0x11f717c1 = _0xf840575b;
        this._0x02374ec7 = _0x1f1880f0;
        this._0x68292589 = _0x3a1c44b1.EnsureToday();
        this._0x4f210d49();
    }

    private bool _0x5555be4f;
    private _0xbe7aadff _0x06ef4b04;
    private readonly List<_0x6a0784f1> _0x6131b581 = new List<_0x6a0784f1>();
    /// <summary>
    /// The hit test. Arithmetic only: the hen and each vehicle of her lane are two
    /// intervals on one axis. From HitEvaluateAt of the hop she is judged against the
    /// lane she is landing on, which is what makes a committed hop feel fair.
    /// </summary>
    private void _0x95644c9b()
    {
        if (this._0xdf1f6a6b || Time.time < this._0xd9248733)
        {
            return;
        }

        if (this._0x6b40d20b._0x3b64b94f && this._0x6b40d20b._0x8f33add4 < _0x4e4c58b8.HitEvaluateAt)
        {
            return;
        }

        _0x6a0784f1 _0x9cd34dbe = this._0x15c7fd6e(this._0xc7f8562d);
        if (_0x9cd34dbe == null || !_0x9cd34dbe._0x6a07f16d)
        {
            return;
        }

        float _0xf34796b8 = this._0xe484b9be._0x88ec2a6b(this._0x6b40d20b._0xf5c741b6);
        if (!_0x9cd34dbe._0x3c48f53c(_0xf34796b8, this._0x6b40d20b._0x638e6989))
        {
            return;
        }

        this._0x84aa833d();
    }

    private void _0x91317b36()
    {
        bool _0x7261427f = _0xfd5cbc90._0x4b0763a5 && !this._0xdf1f6a6b;
        float _0x9168b658 = this._0xe484b9be._0x864140ec + this._0xe484b9be._0xcae9c9c5;
        for (int _0x26694352 = 0; _0x26694352 < this._0x16d62169.Count; _0x26694352++)
        {
            SpriteRenderer _0x7e1ae41d = this._0x16d62169[_0x26694352];
            if (_0x7e1ae41d == null)
            {
                continue;
            }

            int _0xde4b37c0 = this._0x6b40d20b._0xf5c741b6 + (_0x26694352 - 1);
            bool _0x479fc89c = _0xde4b37c0 >= 0 && _0xde4b37c0 < _0x4e4c58b8.Columns;
            _0x7e1ae41d.gameObject.SetActive(_0x7261427f && _0x479fc89c);
            if (_0x479fc89c)
            {
                _0x7e1ae41d.transform.localPosition = new Vector3(this._0xe484b9be._0x88ec2a6b(_0xde4b37c0), _0x9168b658, 0f);
            }
        }
    }

    private int _0xbaf5091d = _0xa20d578b.HopNone;
    private _0xa20d578b _0x255a19f9;
    private int _0xc7f8562d;
    /// <summary>The pause button on the HUD. The pop freezes the run by itself.</summary>
    public void _0x4f838dff()
    {
        if (this._0xdf1f6a6b || this._0x8eb64686 == null)
        {
            return;
        }

        this._0x8eb64686._0x3e07be89(this._0x1240b28d() + 1, this._0xe9dd1946, this._0xbde4fbdd);
    }

    /// <summary>
    /// How many stretches are behind the hen. A verge every (roadLanes + 1) rows, so
    /// this is counted from the rows actually walked rather than a second counter that
    /// could drift out of step with the generator.
    /// </summary>
    private int _0x1240b28d()
    {
        int _0xe040b619 = 0;
        for (int _0xd154daca = 1; _0xd154daca <= this._0xc7f8562d && _0xd154daca < this._0x40f1fd48.Count; _0xd154daca++)
        {
            if (this._0x40f1fd48[_0xd154daca] == _0xf440145c.LaneVerge)
            {
                _0xe040b619++;
            }
        }

        return _0xe040b619;
    }

    private _0x3a1c44b1 _0x68292589;
    private int _0x33d3f618;
    private bool _0x1e19de21()
    {
        return _0x59b62125.Instance != null && _0x59b62125.Instance.BlurBackground != null && _0x59b62125.Instance.BlurBackground.activeSelf;
    }

    private readonly List<SpriteRenderer> _0x16d62169 = new List<SpriteRenderer>();
    /// <summary>
    /// Spawns the next row of the current plan, moving to a freshly generated stretch
    /// when the plan runs out. The opening verge of a stretch doubles as the closing
    /// verge of the one before it, so the road never shows two grass rows in a line.
    /// </summary>
    private void _0x6cb97755()
    {
        if (this._0xb037fec5 == null)
        {
            this._0xd5b362c8();
        }

        if (this._0x28ca14cc >= this._0xb037fec5._0x6103f9c9)
        {
            this._0x75f78fff++;
            this._0xd5b362c8();
            this._0x28ca14cc = 1;
        }

        int _0x053ca16f = this._0x28ca14cc;
        bool _0x51260321 = this._0xb037fec5._0x65863c0e(_0x053ca16f) == _0xf440145c.LaneRoad;
        GameObject _0xe1e96fa0 = _0x51260321 ? this._0x35db6348 : this._0x7ca6d8de;
        if (_0xe1e96fa0 == null)
        {
            return;
        }

        GameObject _0xcdfa6046 = Instantiate(_0xe1e96fa0, this._0xbb109490);
        _0xcdfa6046.transform.localPosition = new Vector3(0f, this._0x448b0d71 * this._0xe484b9be._0xcae9c9c5, 0f);
        _0x6a0784f1 _0x102b53a6 = _0xcdfa6046.GetComponent<_0x6a0784f1>();
        if (_0x102b53a6 == null)
        {
            _0x102b53a6 = _0xcdfa6046.AddComponent<_0x6a0784f1>();
        }

        _0x102b53a6._0x167f5ec4(this._0xe484b9be, _0x51260321 ? this._0x06ef4b04._0x6be52309 : this._0x06ef4b04._0xc0446cd9, _0x51260321, Color.white);
        _0x102b53a6._0x3c88f758(this._0x5555be4f);
        if (_0x51260321)
        {
            this._0x857f9f2c(_0x102b53a6, _0x053ca16f);
        }
        else
        {
            this._0x2622145b(_0x102b53a6);
        }

        this._0x6131b581.Add(_0x102b53a6);
        this._0x40f1fd48.Add(_0x51260321 ? _0xf440145c.LaneRoad : _0xf440145c.LaneVerge);
        this._0x448b0d71++;
        this._0x28ca14cc++;
    }

    private GameObject[] _0x6615cca7;
    /// <summary>The road slides down so the hen keeps her row and stays in frame.</summary>
    private void _0x559bf3be(bool _0x7d31b7cd)
    {
        if (this._0xbb109490 == null)
        {
            return;
        }

        float _0x9247c4d5 = this._0xe484b9be._0x864140ec - this._0xc7f8562d * this._0xe484b9be._0xcae9c9c5;
        if (!_0x7d31b7cd)
        {
            this._0xbb109490.localPosition = new Vector3(0f, _0x9247c4d5, 0f);
            return;
        }

        this._0xbb109490.DOKill(false);
        this._0xbb109490.DOLocalMoveY(_0x9247c4d5, _0x4e4c58b8.HopTime).SetEase(Ease.OutQuad).SetLink(this._0xbb109490.gameObject);
    }
}

internal static class _0x0b7ba5a5
{
    internal static string _0x7b2f8db6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}