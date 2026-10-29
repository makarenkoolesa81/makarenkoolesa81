using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Brands the loading screen and makes it read as a DIFFERENT screen from Home: a
/// much darker field, one lit emblem, no chips, no stat row and no PLAY button.
///
/// The brand is an ABSTRACT mark only. The game name appears nowhere - not here, not
/// in the menu, not in the HUD, not in a pop and not baked into any sprite. The store
/// name lives only in ProjectSettings.
///
/// The body it builds into is the PANEL's Content (PanelController.Panels[SPLASH]),
/// not SplashPanel.Content - the latter ships unassigned on this template, and code
/// that brands through it draws nothing at all, silently.
///
/// SplashPanel.cs and MainThreadUtil.cs are NEVER touched (C.64, strict). The loading
/// bar is themed through the Slider the template already wired, from here.
/// </summary>
public sealed class _0xb30c23fd : MonoBehaviour
{
    private void OnDestroy()
    {
        if (this._0x38dd2fbd != null)
        {
            DOTween.Kill(this._0x38dd2fbd.transform);
        }

        if (this._0xe3164c59 != null)
        {
            DOTween.Kill(this._0xe3164c59);
        }
    }

    private Image _0xe3164c59;
    public void _0x6101bb53(_0xbe7aadff _0xf0f5254b, Transform _0x5a90f5a7)
    {
        if (_0x5a90f5a7 == null || _0xf0f5254b == null)
        {
            return;
        }

        RectTransform _0xd185fc6e = _0xeec56d36.Full(_0x5a90f5a7, _0x5bb90499._0x08467804(new byte[10] { 80, 127, 115, 122, 114, 84, 100, 119, 120, 114 }, 22), 0f);
        _0xd185fc6e.SetAsFirstSibling();
        _0xeec56d36.Backdrop(_0xd185fc6e, _0x5bb90499._0x08467804(new byte[5] { 118, 89, 85, 92, 84 }, 48), _0xf0f5254b._0xfbb22ee9, Color.white);
        _0xeec56d36.PlateFull(_0xd185fc6e, _0x5bb90499._0x08467804(new byte[10] { 200, 239, 225, 238, 242, 213, 229, 244, 239, 235 }, 134), _0xf0f5254b._0x556c658e, _0x38306f56.Fade(_0x38306f56.NightField, 0.88f), 0f, 2.0f);
        _0xeec56d36.PlateFull(_0xd185fc6e, _0x5bb90499._0x08467804(new byte[9] { 239, 220, 203, 222, 220, 238, 216, 202, 209 }, 185), _0xf0f5254b._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.35f), 0f, 2.0f);
        this._0xe3164c59 = _0xeec56d36.Plate(_0xd185fc6e, _0x5bb90499._0x08467804(new byte[4] { 254, 215, 218, 217 }, 182), _0xf0f5254b._0x556c658e, _0x38306f56.Fade(_0x38306f56.Sprout, 0.22f), new Vector2(0.5f, 0.58f), Vector2.zero, new Vector2(620f, 620f), 1.1f);
        this._0x38dd2fbd = _0xeec56d36.Picture(_0xd185fc6e, _0x5bb90499._0x08467804(new byte[6] { 32, 8, 7, 9, 0, 8 }, 101), _0xf0f5254b._0xe1f405e4, Color.white, new Vector2(0.5f, 0.58f), Vector2.zero, new Vector2(420f, 420f));
        _0xeec56d36.Label(_0xd185fc6e, _0x5bb90499._0x08467804(new byte[7] { 61, 30, 16, 21, 24, 31, 22 }, 113), _0x5bb90499._0x08467804(new byte[10] { 178, 177, 191, 186, 183, 176, 185, 208, 208, 208 }, 254), _0x4e4c58b8.TitleMax, _0x4e4c58b8.TitleMin, _0x38306f56.Moss, TextAlignmentOptions.Center, new Vector2(0.5f, 0.335f), Vector2.zero, new Vector2(820f, 70f));
        this._0x0db920be();
        this._0x0a29e2bd();
    }

    /// <summary>
    /// The fill takes the accent colour and the track a dark palette colour with REAL
    /// alpha (rule G): the template ships a white fill on a track at alpha 1/255, which
    /// is a bar nobody can see at any size.
    ///
    /// The bar root is left at the size the prefab gives it. The chain inside is
    /// LoadingSlider > SliderContainer > Slider > Fill Area > Fill, and Fill Area
    /// shrinks itself by 30 units: resizing the root to anything at or below 30 would
    /// collapse both track and fill to zero pixels (ANDROID-3578). Only colours are
    /// touched here, so that trap cannot be sprung.
    /// </summary>
    private void _0x0db920be()
    {
        Slider _0xd7ddbf3f = _0x59a05dda.Instance != null ? _0x59a05dda.Instance.AnimationSlider : null;
        if (_0xd7ddbf3f == null)
        {
            return;
        }

        Image _0x9f02398b = _0xd7ddbf3f.GetComponent<Image>();
        if (_0x9f02398b != null)
        {
            _0x9f02398b.color = _0x38306f56.Fade(_0x38306f56.Asphalt, 0.92f);
        }

        RectTransform _0x13c3c9dc = _0xd7ddbf3f.fillRect;
        if (_0x13c3c9dc != null)
        {
            Image _0x4cde342f = _0x13c3c9dc.GetComponent<Image>();
            if (_0x4cde342f != null)
            {
                _0x4cde342f.color = _0x38306f56.Sprout;
            }

            RectTransform _0x86b10559 = _0x13c3c9dc.parent as RectTransform;
            if (_0x86b10559 != null)
            {
                Image _0x836a5e30 = _0x86b10559.GetComponent<Image>();
                if (_0x836a5e30 != null)
                {
                    _0x836a5e30.color = _0x38306f56.Fade(_0x38306f56.Asphalt, 0.92f);
                }
            }
        }

        if (_0xd7ddbf3f.targetGraphic != null)
        {
            _0xd7ddbf3f.targetGraphic.color = _0x38306f56.Fade(_0x38306f56.Asphalt, 0.92f);
        }
    }

    private void _0x0a29e2bd()
    {
        if (this._0x38dd2fbd != null)
        {
            this._0x38dd2fbd.transform.localScale = new Vector3(0.84f, 0.84f, 1f);
            this._0x38dd2fbd.transform.DOScale(1f, 0.45f).SetEase(Ease.OutBack).SetLink(this._0x38dd2fbd.gameObject);
            this._0x38dd2fbd.transform.DOScale(1.03f, 2.4f).SetEase(Ease.InOutSine).SetDelay(0.5f).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x38dd2fbd.gameObject);
        }

        if (this._0xe3164c59 != null)
        {
            this._0xe3164c59.DOFade(0.45f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this._0xe3164c59.gameObject);
        }
    }

    private Image _0x38dd2fbd;
}

internal static class _0x5bb90499
{
    internal static string _0x08467804(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}