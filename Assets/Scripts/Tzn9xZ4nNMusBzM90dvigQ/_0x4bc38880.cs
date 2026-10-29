using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Home. Everything above the PLAY button is ours; PLAY itself is the template's own
/// LoadSceneButton instance, found by its DRIVER and resized explicitly (G.3).
///
/// Layout is in canvas units on the 1242 x 2688 reference resolution, so the review
/// tap coordinates are computed, not guessed.
/// </summary>
public sealed class _0x4bc38880 : MonoBehaviour
{
    /// <summary>
    /// A value of zero reads as an em dash rather than a bare 0, so an untouched save
    /// looks deliberate instead of broken, and the row still renders all three chips.
    /// </summary>
    public void _0x6b3271b4()
    {
        _0xa09f3022.SetText(this._0x6e97e47f, _0xc528dff5._0x5ee70fda(new byte[3] { 184, 162, 212 }, 244) + _0xfd5cbc90._0xb3b99d41);
        _0xa09f3022.SetText(this._0x8c8021f6, _0x4e4c58b8.Grouped(_0xfd5cbc90._0x1ec9c5ae));
        _0xa09f3022.SetText(this._0xd8dd0379, _0xfd5cbc90._0x8066d3d8 > 0 ? _0x4e4c58b8.Grouped(_0xfd5cbc90._0x8066d3d8) : _0xc528dff5._0x5ee70fda(new byte[1] { 96 }, 77));
        _0xa09f3022.SetText(this._0xfe1a6add, _0xfd5cbc90._0x62e1ffc6 > 0 ? _0x4e4c58b8.Grouped(_0xfd5cbc90._0x62e1ffc6) : _0xc528dff5._0x5ee70fda(new byte[1] { 130 }, 175));
        _0xa09f3022.SetText(this._0xa433ef4b, _0xfd5cbc90._0x94b0bd4a > 0 ? _0x4e4c58b8.Grouped(_0xfd5cbc90._0x94b0bd4a) : _0xc528dff5._0x5ee70fda(new byte[1] { 235 }, 198));
        if (this._0x8bcd25b3 != null)
        {
            this._0x8bcd25b3.color = _0x38306f56.Plume(_0xfd5cbc90._0x5c438be4);
        }
    }

    private void OnDestroy()
    {
        if (this._0x8bcd25b3 != null)
        {
            DOTween.Kill(this._0x8bcd25b3.rectTransform);
        }
    }

    private TextMeshProUGUI _0x6e97e47f;
    private void _0x70aaf2e4(Transform _0xd5e59552, _0xbe7aadff _0x1202d5c3, float _0x1d720f9b, float _0xc17d1641, string _0x3657c1e3, System.Action _0x5cef980c)
    {
        Button _0xd13b54d8 = _0xeec56d36.Cta(_0xd5e59552, _0xc528dff5._0x5ee70fda(new byte[3] { 1, 46, 57 }, 79) + _0x3657c1e3, _0x3657c1e3, _0x1202d5c3._0x32adc7bd, _0x38306f56.Verge, _0x38306f56.Cream, new Vector2(0.5f, _0x1d720f9b), new Vector2(_0xc17d1641, 0f), new Vector2(360f, 118f), 2.0f);
        _0xeec56d36.OnTap(_0xd13b54d8, _0x5cef980c);
    }

    private TextMeshProUGUI _0xf6978066(Transform _0x03c9575d, _0xbe7aadff _0x7d34fb11, float _0xbd20f555, string _0x851caca7, Color _0x13c5527a)
    {
        RectTransform _0xa7092fee = _0xeec56d36.Node(_0x03c9575d, _0xc528dff5._0x5ee70fda(new byte[8] { 232, 207, 218, 207, 248, 211, 210, 203 }, 187) + _0x851caca7, new Vector2(0.5f, 0.455f), new Vector2(_0xbd20f555, 0f), new Vector2(300f, 110f));
        _0xeec56d36.Plate(_0xa7092fee, _0xc528dff5._0x5ee70fda(new byte[9] { 118, 93, 92, 69, 101, 89, 84, 65, 80 }, 53), _0x7d34fb11._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.88f), _0xeec56d36.Centre, Vector2.zero, new Vector2(300f, 110f), 2.0f);
        _0xeec56d36.Plate(_0xa7092fee, _0xc528dff5._0x5ee70fda(new byte[7] { 185, 146, 147, 138, 190, 149, 142 }, 250), _0x7d34fb11._0x556c658e, _0x13c5527a, _0xeec56d36.TopLeft, new Vector2(26f, -22f), new Vector2(16f, 16f), 1.0f);
        TextMeshProUGUI _0xf1548f15 = _0xeec56d36.Label(_0xa7092fee, _0xc528dff5._0x5ee70fda(new byte[9] { 35, 8, 9, 16, 54, 1, 12, 21, 5 }, 96), _0xc528dff5._0x5ee70fda(new byte[1] { 169 }, 153), _0x4e4c58b8.ValueMax, _0x4e4c58b8.ValueMin, _0x13c5527a, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, 16f), new Vector2(260f, 56f));
        _0xeec56d36.Label(_0xa7092fee, _0xc528dff5._0x5ee70fda(new byte[11] { 111, 68, 69, 92, 111, 77, 92, 88, 69, 67, 66 }, 44), _0x851caca7, _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Shade, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -32f), new Vector2(260f, 36f));
        return _0xf1548f15;
    }

    private TextMeshProUGUI _0xfe1a6add;
    private TextMeshProUGUI _0x8c8021f6;
    private Image _0x8bcd25b3;
    private void _0x7892af09()
    {
        if (this._0x8bcd25b3 == null)
        {
            return;
        }

        RectTransform _0xae6ec3ce = this._0x8bcd25b3.rectTransform;
        float _0xa5aac358 = _0xae6ec3ce.anchoredPosition.y;
        _0xae6ec3ce.DOAnchorPosY(_0xa5aac358 + 14f, 1.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0xae6ec3ce.gameObject);
    }

    public void _0x22ffa2a9(_0xbe7aadff _0xda2f0568, _0x8e9e461f _0xe03a8943)
    {
        RectTransform _0xe6e89546 = (RectTransform)this.transform;
        // --- top band: level on the left, grain on the right ------------------------
        RectTransform _0xf270c09a = _0xeec56d36.Node(_0xe6e89546, _0xc528dff5._0x5ee70fda(new byte[9] { 156, 181, 166, 181, 188, 147, 184, 185, 160 }, 208), _0xeec56d36.TopLeft, new Vector2(170f, -120f), new Vector2(280f, 104f));
        _0xeec56d36.Plate(_0xf270c09a, _0xc528dff5._0x5ee70fda(new byte[9] { 77, 102, 103, 126, 94, 98, 111, 122, 107 }, 14), _0xda2f0568._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.88f), _0xeec56d36.Centre, Vector2.zero, new Vector2(280f, 104f), 2.0f);
        this._0x6e97e47f = _0xeec56d36.Label(_0xf270c09a, _0xc528dff5._0x5ee70fda(new byte[9] { 23, 60, 61, 36, 2, 53, 56, 33, 49 }, 84), _0xc528dff5._0x5ee70fda(new byte[4] { 145, 139, 253, 236 }, 221), _0x4e4c58b8.ButtonMax, _0x4e4c58b8.ButtonMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, 14f), new Vector2(240f, 50f));
        _0xeec56d36.Label(_0xf270c09a, _0xc528dff5._0x5ee70fda(new byte[11] { 87, 124, 125, 100, 87, 117, 100, 96, 125, 123, 122 }, 20), _0xc528dff5._0x5ee70fda(new byte[5] { 62, 52, 55, 59, 51 }, 120), _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Shade, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -28f), new Vector2(240f, 36f));
        // The grain icon owns a 72-wide gutter centred 94 left of the chip centre, and
        // the value column starts clear of it, so glyph and text never overlap (C.25).
        RectTransform _0x79e78998 = _0xeec56d36.Node(_0xe6e89546, _0xc528dff5._0x5ee70fda(new byte[9] { 178, 135, 148, 156, 155, 182, 157, 156, 133 }, 245), _0xeec56d36.TopRight, new Vector2(-170f, -120f), new Vector2(300f, 104f));
        _0xeec56d36.Plate(_0x79e78998, _0xc528dff5._0x5ee70fda(new byte[9] { 137, 162, 163, 186, 154, 166, 171, 190, 175 }, 202), _0xda2f0568._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.88f), _0xeec56d36.Centre, Vector2.zero, new Vector2(300f, 104f), 2.0f);
        _0xeec56d36.Picture(_0x79e78998, _0xc528dff5._0x5ee70fda(new byte[9] { 121, 76, 95, 87, 80, 119, 93, 81, 80 }, 62), _0xda2f0568._0x239249ee, _0x38306f56.Cream, _0xeec56d36.Centre, new Vector2(-94f, 0f), new Vector2(56f, 56f));
        this._0x8c8021f6 = _0xeec56d36.Label(_0x79e78998, _0xc528dff5._0x5ee70fda(new byte[10] { 238, 219, 200, 192, 199, 255, 200, 197, 220, 204 }, 169), _0xc528dff5._0x5ee70fda(new byte[1] { 229 }, 213), _0x4e4c58b8.ButtonMax, _0x4e4c58b8.ButtonMin, _0x38306f56.Sprout, TextAlignmentOptions.Left, _0xeec56d36.Centre, new Vector2(34f, 0f), new Vector2(180f, 58f));
        // --- hero plate: plate -> road ribbon -> hen -> headline (C.13 order) -------
        RectTransform _0xdd02f812 = _0xeec56d36.Node(_0xe6e89546, _0xc528dff5._0x5ee70fda(new byte[9] { 19, 62, 41, 52, 11, 55, 58, 47, 62 }, 91), new Vector2(0.5f, 0.655f), Vector2.zero, new Vector2(980f, 820f));
        _0xeec56d36.Plate(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[10] { 217, 244, 227, 254, 194, 249, 240, 245, 254, 230 }, 145), _0xda2f0568._0x556c658e, _0x38306f56.Fade(_0x38306f56.Ink, 0.40f), _0xeec56d36.Centre, new Vector2(0f, -14f), new Vector2(996f, 834f), 2.2f);
        _0xeec56d36.Plate(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[8] { 221, 240, 231, 250, 215, 250, 241, 236 }, 149), _0xda2f0568._0x556c658e, _0x38306f56.Verge, _0xeec56d36.Centre, Vector2.zero, new Vector2(980f, 820f), 2.2f);
        _0xeec56d36.Plate(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[8] { 195, 238, 249, 228, 220, 234, 248, 227 }, 139), _0xda2f0568._0x556c658e, _0x38306f56.Fade(_0x38306f56.FieldShade, 0.70f), _0xeec56d36.Centre, new Vector2(0f, -210f), new Vector2(956f, 380f), 2.4f);
        _0xeec56d36.Plate(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[7] { 200, 229, 242, 239, 210, 233, 237 }, 128), _0xda2f0568._0x556c658e, _0x38306f56.Fade(_0x38306f56.Sprout, 0.38f), _0xeec56d36.Centre, Vector2.zero, new Vector2(980f, 820f), 2.6f);
        _0xeec56d36.Plate(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[10] { 192, 253, 243, 246, 192, 251, 240, 240, 253, 252 }, 146), _0xda2f0568._0x6be52309, Color.white, _0xeec56d36.Centre, new Vector2(0f, -230f), new Vector2(880f, 240f), 1.0f);
        this._0x8bcd25b3 = _0xeec56d36.Picture(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[7] { 27, 54, 33, 60, 27, 54, 61 }, 83), _0xda2f0568._0x36dc6826, _0x38306f56.Plume(_0xfd5cbc90._0x5c438be4), _0xeec56d36.Centre, new Vector2(-150f, -200f), new Vector2(300f, 300f));
        for (int _0x75bedca2 = 0; _0x75bedca2 < 3; _0x75bedca2++)
        {
            _0xeec56d36.Picture(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[11] { 53, 24, 15, 18, 62, 21, 24, 11, 15, 18, 19 }, 125) + _0x75bedca2, _0xda2f0568._0x6cc93da1, _0x38306f56.Fade(_0x38306f56.Sprout, 0.75f), _0xeec56d36.Centre, new Vector2(150f + _0x75bedca2 * 86f, -200f), new Vector2(64f, 64f));
        }

        _0xeec56d36.Label(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[12] { 6, 43, 60, 33, 6, 43, 47, 42, 34, 39, 32, 43 }, 78), _0xc528dff5._0x5ee70fda(new byte[14] { 203, 218, 199, 219, 219, 168, 220, 192, 205, 168, 218, 199, 201, 204 }, 136), _0x4e4c58b8.HeroMax, _0x4e4c58b8.HeroMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, 240f), new Vector2(900f, 90f));
        _0xeec56d36.Label(_0xdd02f812, _0xc528dff5._0x5ee70fda(new byte[7] { 199, 234, 253, 224, 220, 250, 237 }, 143), _0xc528dff5._0x5ee70fda(new byte[15] { 170, 171, 160, 197, 177, 164, 181, 197, 181, 160, 183, 197, 173, 170, 181 }, 229), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Moss, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, 160f), new Vector2(900f, 60f));
        // --- stat row: three chips, always three, so none ever looks orphaned -------
        this._0xd8dd0379 = this._0xf6978066(_0xe6e89546, _0xda2f0568, -320f, _0xc528dff5._0x5ee70fda(new byte[4] { 146, 149, 131, 132 }, 208), _0x38306f56.Sprout);
        this._0xfe1a6add = this._0xf6978066(_0xe6e89546, _0xda2f0568, 0f, _0xc528dff5._0x5ee70fda(new byte[8] { 82, 81, 85, 64, 92, 81, 70, 71 }, 20), _0x38306f56.Cream);
        this._0xa433ef4b = this._0xf6978066(_0xe6e89546, _0xda2f0568, 320f, _0xc528dff5._0x5ee70fda(new byte[5] { 115, 110, 96, 101, 114 }, 33), _0x38306f56.Hazard);
        // --- secondary and tertiary navigation ---------------------------------------
        this._0x70aaf2e4(_0xe6e89546, _0xda2f0568, 0.255f, -196f, _0xc528dff5._0x5ee70fda(new byte[10] { 105, 108, 100, 97, 116, 13, 127, 98, 108, 105 }, 45), () => _0xe03a8943.Show(_0x8e9e461f.PageDaily));
        this._0x70aaf2e4(_0xe6e89546, _0xda2f0568, 0.255f, 196f, _0xc528dff5._0x5ee70fda(new byte[8] { 164, 160, 186, 186, 160, 166, 167, 186 }, 233), () => _0xe03a8943.Show(_0x8e9e461f.PageMissions));
        this._0x70aaf2e4(_0xe6e89546, _0xda2f0568, 0.175f, -196f, _0xc528dff5._0x5ee70fda(new byte[7] { 53, 34, 48, 38, 53, 35, 52 }, 103), () => _0xe03a8943.Show(_0x8e9e461f.PageRewards));
        this._0x70aaf2e4(_0xe6e89546, _0xda2f0568, 0.175f, 196f, _0xc528dff5._0x5ee70fda(new byte[7] { 43, 41, 52, 61, 50, 55, 62 }, 123), () => _0xe03a8943.Show(_0x8e9e461f.PageProfile));
        this._0x70aaf2e4(_0xe6e89546, _0xda2f0568, 0.095f, -196f, _0xc528dff5._0x5ee70fda(new byte[11] { 207, 200, 208, 167, 211, 200, 167, 215, 203, 198, 222 }, 135), () => _0xe03a8943.Show(_0x8e9e461f.PageHowTo));
        this._0x70aaf2e4(_0xe6e89546, _0xda2f0568, 0.095f, 196f, _0xc528dff5._0x5ee70fda(new byte[8] { 215, 193, 208, 208, 205, 202, 195, 215 }, 132), () => _0xe03a8943.Show(_0x8e9e461f.PageSettings));
        this._0x6b3271b4();
        this._0x7892af09();
    }

    private TextMeshProUGUI _0xd8dd0379;
    private TextMeshProUGUI _0xa433ef4b;
}

internal static class _0xc528dff5
{
    internal static string _0x5ee70fda(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}