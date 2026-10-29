using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game-scene HUD: feather count, stretch bar, hearts, Back, Pause and the control
/// hint. Every one of these is OUR OWN scene object (C.2) - no content of this game is
/// slipped into a template placeholder, and none of our components references
/// ScoreText, MoneyContainer, TimerContainer, RewardText or BOT_BTNS_LEFT, so stage
/// 5da can switch the template leftovers off without breaking anything here.
///
/// Back and Pause are added rather than restyled in place because this template's game
/// scene has no pause slot at all: its only ShowPopButton hides every pop, and all
/// three LoadSceneButtons are set to scene 0. Per H that is the second allowed path -
/// our own buttons, with none of the template ones touched by us.
///
/// Band layout, in fractions of screen height from the top:
///   0.000 .. 0.115  HUD            0.130 .. 0.900  play band (TapZoneReader)
///   0.912 .. 0.943  control hint
/// </summary>
public sealed class _0xe0ca158f : MonoBehaviour
{
    /// <summary>A lost heart punches and drops to a quarter alpha, so the loss reads.</summary>
    public void _0x0bf39a5f(int _0x0ef5c953)
    {
        for (int _0x995fea5a = 0; _0x995fea5a < this._0xc227d4dc.Length; _0x995fea5a++)
        {
            Image _0xc29bf038 = this._0xc227d4dc[_0x995fea5a];
            if (_0xc29bf038 == null)
            {
                continue;
            }

            bool _0xf3141edf = _0x995fea5a < _0x0ef5c953;
            Color _0x79173b22 = _0xf3141edf ? _0x38306f56.Hazard : _0x38306f56.Fade(_0x38306f56.Hazard, 0.22f);
            if (!_0xf3141edf && _0xc29bf038.color.a > 0.5f)
            {
                _0xc29bf038.transform.DOKill(false);
                _0xc29bf038.transform.localScale = Vector3.one;
                _0xc29bf038.transform.DOPunchScale(Vector3.one * 0.2f, 0.3f, 6, 0.8f).SetLink(_0xc29bf038.gameObject);
            }

            _0xc29bf038.color = _0x79173b22;
        }
    }

    private Image _0xfb034143;
    /// <summary>A hazard-coloured wash over the frame when a heart is lost (C.7).</summary>
    public void _0xfe6b657f()
    {
        if (this._0xfb034143 == null)
        {
            return;
        }

        this._0xfb034143.DOKill(false);
        this._0xfb034143.color = _0x38306f56.Fade(_0x38306f56.Hazard, 0f);
        this._0xfb034143.DOFade(0.5f, 0.12f).SetEase(Ease.OutQuad).SetLink(this._0xfb034143.gameObject).OnComplete(() => this._0xff11b4a9());
    }

    private void _0xff11b4a9()
    {
        if (this._0xfb034143 == null)
        {
            return;
        }

        this._0xfb034143.DOFade(0f, 0.13f).SetEase(Ease.InQuad).SetLink(this._0xfb034143.gameObject);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
        for (int _0x502d271a = 0; _0x502d271a < this._0xc227d4dc.Length; _0x502d271a++)
        {
            if (this._0xc227d4dc[_0x502d271a] != null)
            {
                DOTween.Kill(this._0xc227d4dc[_0x502d271a].transform);
            }
        }

        if (this._0x93124c47 != null)
        {
            DOTween.Kill(this._0x93124c47);
        }

        if (this._0xfb034143 != null)
        {
            DOTween.Kill(this._0xfb034143);
        }
    }

    public void _0x9ae1cbc5(int _0x0158577d, int _0xf3d7b974)
    {
        _0xa09f3022.SetText(this._0x18694e8e, _0x210eeda9._0xd6d2450a(new byte[5] { 58, 39, 41, 44, 72 }, 104) + Mathf.Min(_0x0158577d + 1, _0xf3d7b974) + _0x210eeda9._0xd6d2450a(new byte[3] { 110, 97, 110 }, 78) + _0xf3d7b974);
        if (this._0x93124c47 == null)
        {
            return;
        }

        float _0x2a65b1bb = _0xf3d7b974 <= 0 ? 0f : Mathf.Clamp01((float)_0x0158577d / _0xf3d7b974);
        _0xeec56d36.TweenBar(this._0x93124c47, _0x2a65b1bb, _0x4e4c58b8.BarTime);
    }

    public void _0x550266a1(_0xbe7aadff _0x1944959f, int _0x25d844ea, System.Action _0xa3d580df, System.Action _0x64b674d5)
    {
        RectTransform _0xa81fe3c1 = (RectTransform)this.transform;
        // --- hazard flash: first child, so it sits UNDER every readable element ------
        this._0xfb034143 = _0xeec56d36.PlateFull(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[11] { 220, 245, 238, 245, 230, 240, 210, 248, 245, 231, 252 }, 148), _0x1944959f._0x556c658e, _0x38306f56.Fade(_0x38306f56.Hazard, 0f), 0f, 1.0f);
        // --- top band ----------------------------------------------------------------
        _0xeec56d36.Plate(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[7] { 15, 50, 35, 5, 38, 41, 35 }, 71), _0x1944959f._0x556c658e, _0x38306f56.Fade(_0x38306f56.Ink, 0.46f), _0xeec56d36.TopCentre, new Vector2(0f, -150f), new Vector2(1242f, 320f), 2.4f);
        Button _0x1715094a = _0xeec56d36.IconButton(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[10] { 141, 174, 172, 164, 141, 186, 187, 187, 160, 161 }, 207), _0x1944959f._0x32adc7bd, _0x1944959f._0x69fb6aa0, _0x38306f56.Verge, _0x38306f56.Cream, _0xeec56d36.TopLeft, new Vector2(120f, -120f), 132f, 1.6f);
        Button _0x2f2e2f2a = _0xeec56d36.IconButton(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[11] { 58, 11, 31, 25, 15, 40, 31, 30, 30, 5, 4 }, 106), _0x1944959f._0x32adc7bd, _0x1944959f._0xcc40e0b4, _0x38306f56.Verge, _0x38306f56.Cream, _0xeec56d36.TopRight, new Vector2(-120f, -120f), 132f, 1.6f);
        // Feather counter. The icon owns a 68-wide gutter centred on x=-150 and the
        // value column starts clear of it, so glyphs and icon never share an x-band
        // (C.25): gutter right edge -116, text left edge -92.
        _0xeec56d36.Picture(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[11] { 186, 153, 157, 136, 148, 153, 142, 181, 159, 147, 146 }, 252), _0x1944959f._0xf062d852, _0x38306f56.Cream, _0xeec56d36.TopCentre, new Vector2(-150f, -110f), new Vector2(52f, 52f));
        this._0xa5afb8f4 = _0xeec56d36.Label(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[12] { 103, 68, 64, 85, 73, 68, 83, 119, 64, 77, 84, 68 }, 33), _0x210eeda9._0xd6d2450a(new byte[1] { 224 }, 208), _0x4e4c58b8.ValueMax, _0x4e4c58b8.ValueMin, _0x38306f56.Cream, TextAlignmentOptions.Left, _0xeec56d36.TopCentre, new Vector2(68f, -110f), new Vector2(320f, 64f));
        this._0x93124c47 = _0xeec56d36.Bar(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[10] { 198, 225, 231, 240, 225, 246, 253, 215, 244, 231 }, 149), _0x1944959f._0x37c91518, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.9f), _0x38306f56.Sprout, _0xeec56d36.TopCentre, new Vector2(0f, -196f), new Vector2(900f, 32f), 2.0f);
        this._0x18694e8e = _0xeec56d36.Label(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[9] { 46, 19, 29, 24, 48, 29, 30, 25, 16 }, 124), _0x210eeda9._0xd6d2450a(new byte[9] { 167, 186, 180, 177, 213, 196, 213, 218, 213 }, 245) + _0x25d844ea, _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Moss, TextAlignmentOptions.Center, _0xeec56d36.TopCentre, new Vector2(0f, -248f), new Vector2(620f, 42f));
        for (int _0x4d7f4e18 = 0; _0x4d7f4e18 < _0x4e4c58b8.Hearts; _0x4d7f4e18++)
        {
            this._0xc227d4dc[_0x4d7f4e18] = _0xeec56d36.Picture(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[5] { 10, 39, 35, 48, 54 }, 66) + _0x4d7f4e18, _0x1944959f._0x2f70ba28, _0x38306f56.Hazard, _0xeec56d36.TopCentre, new Vector2((_0x4d7f4e18 - 1) * 76f, -304f), new Vector2(60f, 60f));
        }

        // --- control hint: the control is a tap on an AREA, so it is named on screen
        //     for the whole run (C.6), low enough never to cover the play field -------
        _0xeec56d36.Plate(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[9] { 115, 82, 85, 79, 107, 87, 90, 79, 94 }, 59), _0x1944959f._0x556c658e, _0x38306f56.Fade(_0x38306f56.Ink, 0.55f), _0xeec56d36.BottomCentre, new Vector2(0f, 190f), new Vector2(980f, 84f), 2.2f);
        _0xeec56d36.Label(_0xa81fe3c1, _0x210eeda9._0xd6d2450a(new byte[8] { 115, 82, 85, 79, 111, 94, 67, 79 }, 59), _0x210eeda9._0xd6d2450a(new byte[41] { 254, 235, 250, 138, 230, 239, 236, 254, 138, 135, 138, 233, 239, 228, 254, 248, 239, 138, 135, 138, 248, 227, 237, 226, 254, 138, 254, 229, 138, 226, 229, 250, 138, 254, 226, 235, 254, 138, 253, 235, 243 }, 170), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.BottomCentre, new Vector2(0f, 190f), new Vector2(940f, 56f));
        // The Button objects are held from the calls above, never looked up by name:
        // obfuscation renames scene objects and a name lookup dies silently (C.1).
        _0xeec56d36.OnTap(_0x1715094a, _0xa3d580df);
        _0xeec56d36.OnTap(_0x2f2e2f2a, _0x64b674d5);
    }

    private readonly Image[] _0xc227d4dc = new Image[_0x4e4c58b8.Hearts];
    /// <summary>The canvas rect the floating +1 labels are parented to.</summary>
    public RectTransform _0x31031ac5()
    {
        return (RectTransform)this.transform;
    }

    private Image _0x93124c47;
    public void _0x0285c771(int _0x06db8286)
    {
        _0xa09f3022.SetText(this._0xa5afb8f4, _0x4e4c58b8.Grouped(_0x06db8286));
    }

    private TextMeshProUGUI _0xa5afb8f4;
    private TextMeshProUGUI _0x18694e8e;
}

internal static class _0x210eeda9
{
    internal static string _0xd6d2450a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}