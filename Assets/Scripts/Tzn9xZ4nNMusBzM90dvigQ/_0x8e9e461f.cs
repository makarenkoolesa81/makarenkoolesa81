using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Home plus six sheets, exactly one visible at a time. Pages are addressed by the
/// integer ids below - never by object name, which obfuscation renames.
///
/// A sheet is an overlay inside PANELS.DEFAULT, not a template panel: the template's
/// panel pool is addressed by index by its own controllers, and borrowing a slot from
/// it for a sheet of ours would collide with the tutorial indices.
/// </summary>
public sealed class _0x8e9e461f : MonoBehaviour
{
    public void Show(int _0x0933a6a0)
    {
        this._0x7a6d7f07 = _0x0933a6a0;
        foreach (KeyValuePair<int, RectTransform> _0x51c0dde3 in this._0x7b2f0159)
        {
            if (_0x51c0dde3.Value != null)
            {
                _0x51c0dde3.Value.gameObject.SetActive(_0x51c0dde3.Key == _0x0933a6a0);
            }
        }

        Action _0x6bce61f7;
        if (this._0x38e2f473.TryGetValue(_0x0933a6a0, out _0x6bce61f7) && _0x6bce61f7 != null)
        {
            _0x6bce61f7();
        }

        RectTransform _0x7c7637c8;
        if (this._0x7b2f0159.TryGetValue(_0x0933a6a0, out _0x7c7637c8) && _0x7c7637c8 != null && _0x0933a6a0 != PageHome)
        {
            _0x7c7637c8.localScale = new Vector3(0.92f, 0.92f, 1f);
            _0x7c7637c8.DOScale(1f, _0x4e4c58b8.SheetTime).SetEase(Ease.OutBack).SetLink(_0x7c7637c8.gameObject);
        }

        if (this._0x875e5e63 != null)
        {
            bool _0x708c45f8 = _0x0933a6a0 != PageHome;
            this._0x875e5e63.gameObject.SetActive(_0x708c45f8);
            Image _0x033d47f3 = this._0x875e5e63.GetComponent<Image>();
            if (_0x033d47f3 != null && _0x708c45f8)
            {
                _0x033d47f3.DOKill(false);
                _0x033d47f3.color = _0x38306f56.Fade(_0x38306f56.Ink, 0f);
                _0x033d47f3.DOFade(0.72f, 0.18f).SetEase(Ease.OutQuad).SetLink(_0x033d47f3.gameObject);
            }
        }

        if (this.PageChanged != null)
        {
            this.PageChanged(_0x0933a6a0);
        }
    }

    public const int PageDaily = 2;
    public void _0xd40a8cf9()
    {
        this.Show(PageHome);
    }

    public const int PageSettings = 6;
    public int _0x02ab3893
    {
        get
        {
            return this._0x7a6d7f07;
        }
    }

    private readonly Dictionary<int, Action> _0x38e2f473 = new Dictionary<int, Action>();
    private void OnDestroy()
    {
        foreach (KeyValuePair<int, RectTransform> _0x36588d78 in this._0x7b2f0159)
        {
            if (_0x36588d78.Value != null)
            {
                DOTween.Kill(_0x36588d78.Value);
            }
        }

        if (this._0x875e5e63 != null)
        {
            DOTween.Kill(this._0x875e5e63);
        }
    }

    public const int PageHome = 0;
    public const int PageMissions = 3;
    public const int PageCount = 7;
    private int _0x7a6d7f07 = PageHome;
    public const int PageProfile = 5;
    public const int PageHowTo = 1;
    public event Action<int> PageChanged;
    public const int PageRewards = 4;
    private RectTransform _0x875e5e63;
    private readonly Dictionary<int, RectTransform> _0x7b2f0159 = new Dictionary<int, RectTransform>();
    public void _0xe66b464f(RectTransform _0x6b16466a)
    {
        this._0x875e5e63 = _0x6b16466a;
    }

    public void _0x3b65f6af(int _0x9e2fbedf, RectTransform _0x41af56e4, Action _0x82eccb0b)
    {
        if (_0x41af56e4 == null)
        {
            return;
        }

        this._0x7b2f0159[_0x9e2fbedf] = _0x41af56e4;
        if (_0x82eccb0b != null)
        {
            this._0x38e2f473[_0x9e2fbedf] = _0x82eccb0b;
        }

        _0x41af56e4.gameObject.SetActive(false);
    }
}