using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// HOW TO PLAY. Three step cards, one at a time, paged by BACK and NEXT with a
/// three-dot progress row; the last card starts a run.
///
/// This is the game's own tutorial. The TEMPLATE tutorial stays OFF
/// (SETUP_OBJECT.IsTutorialEnabled = 0): it only routes from the splash while
/// IsTutorPassed is false, so it would appear on the first launch and never again,
/// and the review album would differ between the first capture and every re-capture.
/// Those undressed template panels are blanked by TemplatePlaceholderCleaner (C.15).
///
/// Direction is shown by the chevron SPRITE, never by an arrow glyph: the Roboto
/// fallback renders those as a colon or tofu.
/// </summary>
public sealed class _0x26ab846d : MonoBehaviour
{
    private readonly Image[] _0x0929c728 = new Image[CardCount];
    private Button _0xecff1213;
    private RectTransform _0x97c2c38b(Transform _0xae987745, _0xbe7aadff _0x24b08cb8, string _0xbf2fb959, string _0xa2d1e2c7, Sprite _0x3a37bff6, int _0x1da8b427)
    {
        RectTransform _0x5e17b2ab = _0xeec56d36.Node(_0xae987745, _0x4c240fcf._0x12afb9be(new byte[4] { 129, 163, 176, 166 }, 194) + _0x1da8b427, _0xeec56d36.Centre, new Vector2(0f, 60f), new Vector2(920f, 1020f));
        _0xeec56d36.Plate(_0x5e17b2ab, _0x4c240fcf._0x12afb9be(new byte[9] { 127, 93, 78, 88, 108, 80, 93, 72, 89 }, 60), _0x24b08cb8._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.9f), _0xeec56d36.Centre, Vector2.zero, new Vector2(920f, 1020f), 2.2f);
        _0xeec56d36.Plate(_0x5e17b2ab, _0x4c240fcf._0x12afb9be(new byte[9] { 226, 192, 211, 197, 242, 213, 192, 198, 196 }, 161), _0x24b08cb8._0xc0446cd9, Color.white, _0xeec56d36.Centre, new Vector2(0f, 140f), new Vector2(860f, 420f), 1.0f);
        _0xeec56d36.Picture(_0x5e17b2ab, _0x4c240fcf._0x12afb9be(new byte[7] { 228, 198, 213, 195, 230, 213, 211 }, 167), _0x3a37bff6, _0x38306f56.Cream, _0xeec56d36.Centre, new Vector2(0f, 150f), new Vector2(300f, 300f));
        _0xeec56d36.Label(_0x5e17b2ab, _0x4c240fcf._0x12afb9be(new byte[9] { 162, 128, 147, 133, 181, 136, 149, 141, 132 }, 225), _0xbf2fb959, _0x4e4c58b8.TitleMax, _0x4e4c58b8.TitleMin, _0x38306f56.Sprout, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -170f), new Vector2(860f, 80f));
        _0xeec56d36.Label(_0x5e17b2ab, _0x4c240fcf._0x12afb9be(new byte[8] { 8, 42, 57, 47, 9, 36, 47, 50 }, 75), _0xa2d1e2c7, _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Moss, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -300f), new Vector2(860f, 130f));
        return _0x5e17b2ab;
    }

    public void _0xa059bf5a()
    {
        for (int _0xa2fb1aed = 0; _0xa2fb1aed < CardCount; _0xa2fb1aed++)
        {
            if (this._0x7988893c[_0xa2fb1aed] != null)
            {
                this._0x7988893c[_0xa2fb1aed].gameObject.SetActive(_0xa2fb1aed == this._0xb0ee649b);
            }

            if (this._0x0929c728[_0xa2fb1aed] != null)
            {
                this._0x0929c728[_0xa2fb1aed].color = _0xa2fb1aed == this._0xb0ee649b ? _0x38306f56.Sprout : _0x38306f56.Shade;
            }
        }

        if (this._0x83078638 != null)
        {
            this._0x83078638.interactable = this._0xb0ee649b > 0;
        }

        _0xa09f3022.SetText(this._0xc7c6cf0a, this._0xb0ee649b >= CardCount - 1 ? _0x4c240fcf._0x12afb9be(new byte[5] { 240, 247, 226, 241, 247 }, 163) : _0x4c240fcf._0x12afb9be(new byte[4] { 12, 7, 26, 22 }, 66));
    }

    private Button _0x83078638;
    private void _0x2a8d2c19(int _0x1d682d65)
    {
        if (this._0xb0ee649b + _0x1d682d65 >= CardCount)
        {
            this._0xa5768770();
            return;
        }

        this._0xb0ee649b = Mathf.Clamp(this._0xb0ee649b + _0x1d682d65, 0, CardCount - 1);
        this._0xa059bf5a();
    }

    private readonly RectTransform[] _0x7988893c = new RectTransform[CardCount];
    private TMP_Text _0xc7c6cf0a;
    public void _0xb22b97b8(_0xbe7aadff _0xa3a28a6c, _0x8e9e461f _0x9f2c0a2d)
    {
        Button _0xcaaddfbf;
        RectTransform _0x12b4badc = _0xeec56d36.Sheet(this.transform, _0xa3a28a6c._0x556c658e, _0xa3a28a6c._0x696c8fb6, _0x4c240fcf._0x12afb9be(new byte[11] { 111, 104, 112, 7, 115, 104, 7, 119, 107, 102, 126 }, 39), out _0xcaaddfbf);
        _0xeec56d36.OnTap(_0xcaaddfbf, () => _0x9f2c0a2d._0xd40a8cf9());
        this._0x7988893c[0] = this._0x97c2c38b(_0x12b4badc, _0xa3a28a6c, _0x4c240fcf._0x12afb9be(new byte[10] { 215, 194, 211, 163, 215, 204, 163, 203, 204, 211 }, 131), _0x4c240fcf._0x12afb9be(new byte[36] { 139, 234, 158, 139, 154, 234, 135, 133, 156, 143, 153, 234, 158, 130, 143, 234, 130, 143, 132, 192, 133, 132, 143, 234, 134, 139, 132, 143, 234, 140, 133, 152, 157, 139, 152, 142 }, 202), _0xa3a28a6c._0x36dc6826, 0);
        this._0x7988893c[1] = this._0x97c2c38b(_0x12b4badc, _0xa3a28a6c, _0x4c240fcf._0x12afb9be(new byte[17] { 165, 176, 161, 209, 189, 180, 183, 165, 209, 190, 163, 209, 163, 184, 182, 185, 165 }, 241), _0x4c240fcf._0x12afb9be(new byte[41] { 31, 3, 14, 107, 24, 2, 15, 14, 107, 18, 4, 30, 107, 31, 10, 27, 107, 27, 2, 8, 0, 24, 65, 31, 3, 14, 107, 7, 10, 5, 15, 2, 5, 12, 107, 8, 4, 7, 30, 6, 5 }, 75), _0xa3a28a6c._0x6cc93da1, 1);
        this._0x7988893c[2] = this._0x97c2c38b(_0x12b4badc, _0xa3a28a6c, _0x4c240fcf._0x12afb9be(new byte[14] { 91, 77, 88, 79, 68, 44, 88, 68, 73, 44, 75, 77, 92, 95 }, 12), _0x4c240fcf._0x12afb9be(new byte[40] { 34, 67, 43, 42, 55, 67, 32, 44, 48, 55, 48, 67, 44, 45, 38, 67, 43, 38, 34, 49, 55, 79, 105, 45, 44, 55, 67, 55, 43, 38, 67, 52, 43, 44, 47, 38, 67, 49, 54, 45 }, 99), _0xa3a28a6c._0xfeaf8c24(0), 2);
        for (int _0x3b922ea1 = 0; _0x3b922ea1 < CardCount; _0x3b922ea1++)
        {
            this._0x0929c728[_0x3b922ea1] = _0xeec56d36.Plate(_0x12b4badc, _0x4c240fcf._0x12afb9be(new byte[3] { 133, 174, 181 }, 193) + _0x3b922ea1, _0xa3a28a6c._0x556c658e, _0x38306f56.Shade, _0xeec56d36.BottomCentre, new Vector2((_0x3b922ea1 - 1) * 46f, 300f), new Vector2(22f, 22f), 1.0f);
        }

        this._0x83078638 = _0xeec56d36.Cta(_0x12b4badc, _0x4c240fcf._0x12afb9be(new byte[10] { 115, 81, 70, 85, 97, 86, 87, 87, 76, 77 }, 35), _0x4c240fcf._0x12afb9be(new byte[4] { 16, 19, 17, 25 }, 82), _0xa3a28a6c._0x32adc7bd, _0x38306f56.Asphalt, _0x38306f56.Cream, _0xeec56d36.BottomCentre, new Vector2(-180f, 190f), new Vector2(280f, 104f), 2.0f);
        this._0xecff1213 = _0xeec56d36.Cta(_0x12b4badc, _0x4c240fcf._0x12afb9be(new byte[10] { 255, 212, 201, 197, 243, 196, 197, 197, 222, 223 }, 177), _0x4c240fcf._0x12afb9be(new byte[4] { 34, 41, 52, 56 }, 108), _0xa3a28a6c._0x32adc7bd, _0x38306f56.Hazard, _0x38306f56.Cream, _0xeec56d36.BottomCentre, new Vector2(180f, 190f), new Vector2(280f, 104f), 2.0f);
        this._0xc7c6cf0a = this._0xecff1213.GetComponentInChildren<TMP_Text>(true);
        _0xeec56d36.OnTap(this._0x83078638, () => this._0x2a8d2c19(-1));
        _0xeec56d36.OnTap(this._0xecff1213, () => this._0x2a8d2c19(1));
        this._0xa059bf5a();
    }

    private int _0xb0ee649b;
    private const int CardCount = 3;
    private void _0xa5768770()
    {
        _0xfd5cbc90._0xc633c5a1 = false;
        _0xfd5cbc90.Flush();
        if (_0xf2da7f44.Instance != null)
        {
            _0xf2da7f44.Instance._0xa80559a1(_0xfc6e4613._0xef8a6460.SCENE_1);
        }
    }
}

internal static class _0x4c240fcf
{
    internal static string _0x12afb9be(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}