using DG.Tweening;
using UnityEngine;

/// <summary>
/// The hen. She keeps one world row and only moves across columns; the road scrolls
/// past her, so the composition never drifts off the camera.
///
/// Movement is a DOTween arc on the transform - there is no body on this object, and
/// nothing else writes its position, so there is exactly one mover (C.57).
/// </summary>
public sealed class _0x1f14bf52 : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
        if (this._renderer != null)
        {
            DOTween.Kill(this._renderer);
        }
    }

    public void _0xf6c0e799(_0xaae7a264 _0x84a5b1f9, Sprite _0xf8140948, Color _0xd05bccf3)
    {
        this._0x7120dbcb = _0x84a5b1f9;
        float _0x7d0e0e7f = _0x84a5b1f9._0xcae9c9c5 * 0.80f;
        Vector2 _0x073adf7a = _0x84a5b1f9._0x6a8cf3c8(_0xf8140948, _0x7d0e0e7f);
        SpriteRenderer _0x92fc8bb0 = this._0x289270ff();
        if (_0x92fc8bb0 != null)
        {
            _0x92fc8bb0.sprite = _0xf8140948;
            _0x92fc8bb0.drawMode = SpriteDrawMode.Sliced;
            _0x92fc8bb0.size = _0x073adf7a;
            _0x92fc8bb0.color = _0xd05bccf3;
            _0x92fc8bb0.sortingOrder = _0x4e4c58b8.ClampOrder(_0x4e4c58b8.OrderHen);
        }

        this.transform.localScale = Vector3.one;
        // The hit box is deliberately narrower than the drawing: a near miss at the
        // very edge of the art should read as a near miss, not as a hit.
        this._0x9bdf4c6c = _0x073adf7a.x * 0.5f * 0.72f;
        this._0x916ab75f = _0x4e4c58b8.Columns / 2;
        this.transform.localPosition = new Vector3(_0x84a5b1f9._0x88ec2a6b(this._0x916ab75f), _0x84a5b1f9._0x864140ec, 0f);
        this._0x090b9712();
    }

    private SpriteRenderer _0x289270ff()
    {
        if (this._renderer == null)
        {
            this._renderer = this.GetComponent<SpriteRenderer>();
        }

        return this._renderer;
    }

    /// <summary>Pushes the hen back to a column without a hop, after a hit.</summary>
    public void _0x84be0974(int _0xe99ab138)
    {
        if (this._0x7120dbcb == null)
        {
            return;
        }

        this._0x916ab75f = Mathf.Clamp(_0xe99ab138, 0, _0x4e4c58b8.Columns - 1);
        this._0x4d9f815a();
        this._0x0072e3cb = false;
        this._0x1d4f6ce8 = 1f;
        this.transform.localPosition = new Vector3(this._0x7120dbcb._0x88ec2a6b(this._0x916ab75f), this._0x7120dbcb._0x864140ec, 0f);
        this._0x090b9712();
    }

    /// <summary>Hop progress 0..1; the hit test starts at HitEvaluateAt.</summary>
    public float _0x8f33add4
    {
        get
        {
            return this._0x1d4f6ce8;
        }
    }

    public int _0xf5c741b6
    {
        get
        {
            return this._0x916ab75f;
        }
    }

    /// <summary>
    /// A hop from the current column to the target column, one lane forward. The arc
    /// is the hen rising and falling on the spot while the road slides down under her,
    /// which reads exactly like a jump forward and keeps her inside the frame.
    /// </summary>
    public void _0x24b37c55(int _0xcabca9d1, System.Action _0xb7670a97)
    {
        if (this._0x7120dbcb == null)
        {
            return;
        }

        this._0x916ab75f = Mathf.Clamp(_0xcabca9d1, 0, _0x4e4c58b8.Columns - 1);
        this._0x0072e3cb = true;
        this._0x1d4f6ce8 = 0f;
        this._0xa3c89bf3();
        float _0xaeb673a1 = this._0x7120dbcb._0x88ec2a6b(this._0x916ab75f);
        float _0x4ed16c8b = this._0x7120dbcb._0x864140ec;
        float _0x5c4aa0ab = _0x4e4c58b8.HopTime * 0.5f;
        this._0x660b10b3 = DOTween.Sequence().SetLink(this.gameObject);
        this._0x660b10b3.Join(this.transform.DOLocalMoveX(_0xaeb673a1, _0x4e4c58b8.HopTime).SetEase(Ease.OutQuad));
        this._0x660b10b3.Join(this.transform.DOLocalMoveY(_0x4ed16c8b + _0x4e4c58b8.HopHeight, _0x5c4aa0ab).SetEase(Ease.OutQuad));
        this._0x660b10b3.Insert(_0x5c4aa0ab, this.transform.DOLocalMoveY(_0x4ed16c8b, _0x5c4aa0ab).SetEase(Ease.InQuad));
        this._0x660b10b3.Join(DOTween.To(() => this._0x1d4f6ce8, _0x76127522 => this._0x1d4f6ce8 = _0x76127522, 1f, _0x4e4c58b8.HopTime).SetEase(Ease.Linear));
        this._0x660b10b3.OnComplete(() => this._0x4e33b883(_0xb7670a97));
    }

    /// <summary>Six blinks over the invulnerable second, so the state is readable.</summary>
    public void _0x46633fa7()
    {
        SpriteRenderer _0xdaaf8e0a = this._0x289270ff();
        if (_0xdaaf8e0a == null)
        {
            return;
        }

        _0xdaaf8e0a.DOKill(false);
        Color _0xb33c3fb5 = _0xdaaf8e0a.color;
        _0xdaaf8e0a.DOFade(0.25f, _0x4e4c58b8.InvulnerableTime / 12f).SetLoops(12, LoopType.Yoyo).SetLink(this.gameObject).OnComplete(() => _0xdaaf8e0a.color = _0xb33c3fb5);
    }

    private void _0x4d9f815a()
    {
        if (this._0x660b10b3 != null)
        {
            this._0x660b10b3.Kill(false);
            this._0x660b10b3 = null;
        }
    }

    public void _0xbdc7b866(Color _0xd086ac2b)
    {
        SpriteRenderer _0xbbd20439 = this._0x289270ff();
        if (_0xbbd20439 != null)
        {
            _0xbbd20439.color = _0xd086ac2b;
        }
    }

    private float _0x1d4f6ce8;
    [SerializeField]
    private SpriteRenderer _renderer;
    public bool _0x3b64b94f
    {
        get
        {
            return this._0x0072e3cb;
        }
    }

    /// <summary>
    /// The idle breath is written from the authored base scale of 1 - the real size is
    /// the camera-derived m_Size - never from a world-unit literal (C.0 point 3).
    /// </summary>
    private void _0x090b9712()
    {
        this._0xa3c89bf3();
        this.transform.localScale = Vector3.one;
        this._0xbe6c6cda = this.transform.DOScale(1.07f, 0.55f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this.gameObject);
    }

    private void _0x4e33b883(System.Action _0xa4174648)
    {
        this._0x0072e3cb = false;
        this._0x1d4f6ce8 = 1f;
        this._0x090b9712();
        if (_0xa4174648 != null)
        {
            _0xa4174648();
        }
    }

    private Tween _0xbe6c6cda;
    public float _0x638e6989
    {
        get
        {
            return this._0x9bdf4c6c;
        }
    }

    private bool _0x0072e3cb;
    private int _0x916ab75f;
    private void _0xa3c89bf3()
    {
        if (this._0xbe6c6cda != null)
        {
            this._0xbe6c6cda.Kill(false);
            this._0xbe6c6cda = null;
        }
    }

    private float _0x9bdf4c6c = 0.2f;
    private _0xaae7a264 _0x7120dbcb;
    private Sequence _0x660b10b3;
}