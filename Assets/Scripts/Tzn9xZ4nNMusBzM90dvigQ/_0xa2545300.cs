using DG.Tweening;
using UnityEngine;

/// <summary>
/// A feather sitting on one cell of one lane. Collecting it scales it out while it
/// rises; PickupField draws the floating +1 on the canvas above it.
/// </summary>
public sealed class _0xa2545300 : MonoBehaviour
{
    public void _0x0fed72ec(float _0x3754d920, float _0x26659b31)
    {
        this.transform.localPosition = new Vector3(_0x3754d920, _0x26659b31, 0f);
    }

    /// <summary>
    /// Scale and rise, then switch off. Both tweens are linked to this object so a
    /// scene change cannot leave DOTween animating a destroyed renderer (C.56).
    /// </summary>
    public void _0x8d51cb06()
    {
        if (this._0x7059d018)
        {
            return;
        }

        this._0x7059d018 = true;
        this.transform.DOKill(false);
        this.transform.DOScale(0f, 0.25f).SetEase(Ease.InQuad).SetLink(this.gameObject);
        this.transform.DOLocalMoveY(this.transform.localPosition.y + 0.4f, 0.25f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        DOVirtual.DelayedCall(0.28f, () => this.gameObject.SetActive(false)).SetLink(this.gameObject);
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    /// <summary>
    /// The idle pulse is written from the authored base scale of 1 (the size itself is
    /// the camera-derived m_Size), never from a literal world distance (C.0 point 3).
    /// </summary>
    private void _0xa4961eea()
    {
        this.transform.DOKill(false);
        this.transform.localScale = Vector3.one;
        this.transform.DOScale(1.12f, 0.9f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this.gameObject);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private bool _0x7059d018;
    public void _0xc1a5c604(Sprite _0xbb7f1ec0, Vector2 _0x1068c97e, int _0xa110c42a, Color _0x35ea6921)
    {
        SpriteRenderer _0xc5756e07 = this._0x1a08d7ec();
        if (_0xc5756e07 != null)
        {
            _0xc5756e07.sprite = _0xbb7f1ec0;
            _0xc5756e07.color = _0x35ea6921;
            _0xc5756e07.sortingOrder = _0x4e4c58b8.ClampOrder(_0xa110c42a);
            _0xc5756e07.drawMode = SpriteDrawMode.Sliced;
            _0xc5756e07.size = _0x1068c97e;
        }

        this._0x7059d018 = false;
        this.transform.localScale = Vector3.one;
        this.gameObject.SetActive(true);
        this._0xa4961eea();
    }

    private SpriteRenderer _0x1a08d7ec()
    {
        if (this._renderer == null)
        {
            this._renderer = this.GetComponent<SpriteRenderer>();
        }

        return this._renderer;
    }

    public bool _0x74c5d04e
    {
        get
        {
            return this._0x7059d018;
        }
    }
}