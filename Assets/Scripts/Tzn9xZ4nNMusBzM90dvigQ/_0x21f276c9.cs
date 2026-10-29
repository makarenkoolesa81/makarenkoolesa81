using DG.Tweening;
using TMPro;
using UnityEngine;

/// <summary>
/// The floating feedback above the hen: a canvas "+1" that rises and fades whenever a
/// feather is collected, and the dust puff she leaves at the take-off cell.
///
/// The label is UGUI on the template's own canvas and is positioned from
/// WorldToScreenPoint, so the world-size-in-points trap (C.16) cannot occur: there is
/// no world-space TextMeshPro in this project at all.
/// </summary>
public sealed class _0x21f276c9 : MonoBehaviour
{
    public void _0xd9c18376(Color _0xb96868d7)
    {
        this._0x9708098e = _0xb96868d7;
    }

    private Transform _0x13eb2e67;
    private float _0x94a1664c = 0.5f;
    /// <summary>
    /// The camera a screen point must be converted against for THIS canvas: the one
    /// the canvas renders with, or null when it is a Screen Space - Overlay canvas.
    /// Resolved through GetComponentInParent, never by looking the canvas up by name.
    /// </summary>
    private Camera _0xcbb2cc6c()
    {
        if (this._0x5454efa5 == null)
        {
            return null;
        }

        Canvas _0xcf412bc7 = this._0x5454efa5.GetComponentInParent<Canvas>();
        if (_0xcf412bc7 == null)
        {
            return null;
        }

        return _0xcf412bc7.renderMode == RenderMode.ScreenSpaceOverlay ? null : _0xcf412bc7.worldCamera;
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private RectTransform _0x5454efa5;
    /// <summary>The puff keeps the PNG's own proportions; only the height is chosen.</summary>
    private Vector2 _0x6996dd0c(Sprite _0xb4b514cf)
    {
        if (_0xb4b514cf == null || _0xb4b514cf.rect.height <= 0.0001f)
        {
            return new Vector2(this._0x94a1664c, this._0x94a1664c);
        }

        return new Vector2(this._0x94a1664c * (_0xb4b514cf.rect.width / _0xb4b514cf.rect.height), this._0x94a1664c);
    }

    private Color _0x9708098e = Color.white;
    /// <summary>A rising +1 at the hen's screen position. Collect feedback (C.7).</summary>
    public void _0xa4ce5f6b(Vector3 _0x3c8144c6, string _0xdff3683d)
    {
        if (this._0x5454efa5 == null || this._0xa264a0fe == null)
        {
            return;
        }

        // The template's main canvas is Screen Space - CAMERA, so the conversion needs
        // THAT camera: passing null is only correct for an Overlay canvas, and with a
        // camera canvas it puts the label somewhere else entirely.
        Vector2 _0xff5694ca;
        Vector2 _0xf5150106 = this._0xa264a0fe.WorldToScreenPoint(_0x3c8144c6);
        if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(this._0x5454efa5, _0xf5150106, this._0xcbb2cc6c(), out _0xff5694ca))
        {
            return;
        }

        TextMeshProUGUI _0x788840e3 = _0xeec56d36.Label(this._0x5454efa5, _0x61d96313._0xc1860ad1(new byte[4] { 127, 89, 81, 86 }, 56), _0xdff3683d, _0x4e4c58b8.ValueMax, _0x4e4c58b8.ValueMin, _0x38306f56.Sprout, TextAlignmentOptions.Center, _0xeec56d36.Centre, _0xff5694ca, new Vector2(240f, 70f));
        _0x788840e3.rectTransform.DOAnchorPosY(_0xff5694ca.y + 90f, 0.5f).SetEase(Ease.OutQuad).SetLink(_0x788840e3.gameObject);
        _0x788840e3.DOFade(0f, 0.5f).SetEase(Ease.InQuad).SetLink(_0x788840e3.gameObject);
        DOVirtual.DelayedCall(0.55f, () => Destroy(_0x788840e3.gameObject)).SetLink(this.gameObject);
    }

    public void _0xc1f908ff(RectTransform _0xfa4225c2, Camera _0xda12e604, GameObject _0x6eea3e12, Transform _0x4bb2f25b, Color _0xc492a277, float _0xd7e6f46f)
    {
        this._0x5454efa5 = _0xfa4225c2;
        this._0xa264a0fe = _0xda12e604;
        this._0x62091c8a = _0x6eea3e12;
        this._0x13eb2e67 = _0x4bb2f25b;
        this._0x9708098e = _0xc492a277;
        this._0x94a1664c = _0xd7e6f46f;
    }

    private GameObject _0x62091c8a;
    /// <summary>The dust puff at the cell the hen just left.</summary>
    public void _0x412ade2c(Vector3 _0xa88f3ab9)
    {
        if (this._0x62091c8a == null || this._0x13eb2e67 == null)
        {
            return;
        }

        GameObject _0x97c8e1f7 = Instantiate(this._0x62091c8a, this._0x13eb2e67);
        _0x97c8e1f7.transform.position = _0xa88f3ab9;
        // The puff is sized by the renderer, not by the transform, so there is only one
        // sizing mechanism and the scale tween can be written from a base of 1 (C.0).
        SpriteRenderer _0x83589548 = _0x97c8e1f7.GetComponent<SpriteRenderer>();
        if (_0x83589548 != null)
        {
            _0x83589548.drawMode = SpriteDrawMode.Sliced;
            _0x83589548.size = this._0x6996dd0c(_0x83589548.sprite);
            _0x83589548.color = _0x38306f56.Fade(this._0x9708098e, 0.8f);
            _0x83589548.sortingOrder = _0x4e4c58b8.ClampOrder(_0x4e4c58b8.OrderEffect);
            _0x83589548.DOFade(0f, 0.35f).SetEase(Ease.OutQuad).SetLink(_0x97c8e1f7);
        }

        _0x97c8e1f7.transform.localScale = Vector3.one * 0.6f;
        _0x97c8e1f7.transform.DOScale(1.3f, 0.35f).SetEase(Ease.OutQuad).SetLink(_0x97c8e1f7);
        DOVirtual.DelayedCall(0.4f, () => Destroy(_0x97c8e1f7)).SetLink(this.gameObject);
    }

    private Camera _0xa264a0fe;
}

internal static class _0x61d96313
{
    internal static string _0xc1860ad1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}