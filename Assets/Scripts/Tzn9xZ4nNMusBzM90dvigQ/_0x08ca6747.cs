using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// PROFILE. Five stat chips and the six-slot plume grid. Tapping an unlocked plume
/// equips it and VISIBLY recolours the hen in the header the same frame (C.7), so the
/// tap confirms itself instead of only changing a stored number.
///
/// A locked slot is the hen silhouette at a quarter alpha with a LOCKED caption - no
/// padlock sprite and no emoji, which Android renders as the same fallback glyph.
/// </summary>
public sealed class _0x08ca6747 : MonoBehaviour
{
    private TextMeshProUGUI _0x0331f8e8(Transform _0x9309daee, _0xbe7aadff _0xc6470d69, float _0xaad20b13, float _0x500c2448, string _0x304f2a2f, Color _0x06b9d4eb)
    {
        RectTransform _0x630d3518 = _0xeec56d36.Node(_0x9309daee, _0x64f88806._0x9226e57e(new byte[4] { 180, 147, 134, 147 }, 231) + _0x304f2a2f, _0xeec56d36.Centre, new Vector2(_0xaad20b13, _0x500c2448), new Vector2(430f, 120f));
        _0xeec56d36.Plate(_0x630d3518, _0x64f88806._0x9226e57e(new byte[9] { 82, 121, 120, 97, 65, 125, 112, 101, 116 }, 17), _0xc6470d69._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.9f), _0xeec56d36.Centre, Vector2.zero, new Vector2(430f, 120f), 2.0f);
        _0xeec56d36.Plate(_0x630d3518, _0x64f88806._0x9226e57e(new byte[7] { 87, 124, 125, 100, 80, 123, 96 }, 20), _0xc6470d69._0x556c658e, _0x06b9d4eb, _0xeec56d36.TopLeft, new Vector2(28f, -24f), new Vector2(16f, 16f), 1.0f);
        TextMeshProUGUI _0xc6d74b42 = _0xeec56d36.Label(_0x630d3518, _0x64f88806._0x9226e57e(new byte[9] { 227, 200, 201, 208, 246, 193, 204, 213, 197 }, 160), _0x64f88806._0x9226e57e(new byte[1] { 43 }, 27), _0x4e4c58b8.ValueMax, _0x4e4c58b8.ValueMin, _0x06b9d4eb, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, 18f), new Vector2(390f, 58f));
        _0xeec56d36.Label(_0x630d3518, _0x64f88806._0x9226e57e(new byte[11] { 92, 119, 118, 111, 92, 126, 111, 107, 118, 112, 113 }, 31), _0x304f2a2f, _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Shade, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -34f), new Vector2(390f, 38f));
        return _0xc6d74b42;
    }

    private readonly Image[] _0x65c3c8e7 = new Image[PlumeCount];
    public void _0x5801ab42(_0xbe7aadff _0xcfe3848c, _0x8e9e461f _0xcc4d220e)
    {
        Button _0xfdd31c20;
        RectTransform _0xdd69cf6a = _0xeec56d36.Sheet(this.transform, _0xcfe3848c._0x556c658e, _0xcfe3848c._0x696c8fb6, _0x64f88806._0x9226e57e(new byte[7] { 254, 252, 225, 232, 231, 226, 235 }, 174), out _0xfdd31c20);
        _0xeec56d36.OnTap(_0xfdd31c20, () => _0xcc4d220e._0xd40a8cf9());
        RectTransform _0xdd614585 = _0xeec56d36.Node(_0xdd69cf6a, _0x64f88806._0x9226e57e(new byte[11] { 26, 56, 47, 60, 35, 47, 61, 9, 43, 56, 46 }, 74), _0xeec56d36.Centre, new Vector2(0f, 540f), new Vector2(920f, 300f));
        _0xeec56d36.Plate(_0xdd614585, _0x64f88806._0x9226e57e(new byte[9] { 164, 134, 149, 131, 183, 139, 134, 147, 130 }, 231), _0xcfe3848c._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.9f), _0xeec56d36.Centre, Vector2.zero, new Vector2(920f, 300f), 2.2f);
        _0xeec56d36.Plate(_0xdd614585, _0x64f88806._0x9226e57e(new byte[9] { 133, 167, 180, 162, 149, 178, 167, 161, 163 }, 198), _0xcfe3848c._0xc0446cd9, Color.white, _0xeec56d36.Centre, new Vector2(0f, -70f), new Vector2(860f, 120f), 1.0f);
        this._0x3ca6c0e4 = _0xeec56d36.Picture(_0xdd614585, _0x64f88806._0x9226e57e(new byte[10] { 176, 146, 133, 150, 137, 133, 151, 168, 133, 142 }, 224), _0xcfe3848c._0x36dc6826, _0x38306f56.Plume(_0xfd5cbc90._0x5c438be4), _0xeec56d36.Centre, new Vector2(0f, 10f), new Vector2(220f, 220f));
        this._0x7b0b8592[0] = this._0x0331f8e8(_0xdd69cf6a, _0xcfe3848c, -230f, 280f, _0x64f88806._0x9226e57e(new byte[5] { 94, 87, 68, 87, 94 }, 18), _0x38306f56.Sprout);
        this._0x7b0b8592[1] = this._0x0331f8e8(_0xdd69cf6a, _0xcfe3848c, 230f, 280f, _0x64f88806._0x9226e57e(new byte[8] { 23, 20, 16, 5, 25, 20, 3, 2 }, 81), _0x38306f56.Cream);
        this._0x7b0b8592[2] = this._0x0331f8e8(_0xdd69cf6a, _0xcfe3848c, -230f, 140f, _0x64f88806._0x9226e57e(new byte[11] { 198, 193, 215, 208, 164, 215, 208, 214, 193, 197, 207 }, 132), _0x38306f56.Sprout);
        this._0x7b0b8592[3] = this._0x0331f8e8(_0xdd69cf6a, _0xcfe3848c, 230f, 140f, _0x64f88806._0x9226e57e(new byte[5] { 229, 248, 246, 243, 228 }, 183), _0x38306f56.Hazard);
        this._0x7b0b8592[4] = this._0x0331f8e8(_0xdd69cf6a, _0xcfe3848c, 0f, 0f, _0x64f88806._0x9226e57e(new byte[13] { 69, 65, 91, 91, 65, 71, 70, 91, 40, 76, 71, 70, 77 }, 8), _0x38306f56.Cream);
        this._0x8bd0748e = _0xeec56d36.Label(_0xdd69cf6a, _0x64f88806._0x9226e57e(new byte[10] { 170, 150, 143, 151, 159, 174, 147, 142, 150, 159 }, 250), _0x64f88806._0x9226e57e(new byte[12] { 242, 238, 247, 239, 231, 241, 130, 147, 130, 141, 130, 148 }, 162), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Moss, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -120f), new Vector2(880f, 60f));
        for (int _0x9a74c0fe = 0; _0x9a74c0fe < PlumeCount; _0x9a74c0fe++)
        {
            int _0x2eb66bb9 = _0x9a74c0fe;
            RectTransform _0x67d38996 = _0xeec56d36.Node(_0xdd69cf6a, _0x64f88806._0x9226e57e(new byte[9] { 169, 149, 140, 148, 156, 170, 149, 150, 141 }, 249) + _0x9a74c0fe, _0xeec56d36.Centre, new Vector2((_0x9a74c0fe % 3 - 1) * 290f, -260f - (_0x9a74c0fe / 3) * 200f), new Vector2(160f, 160f));
            Button _0xf49d6924 = _0xeec56d36.IconButton(_0x67d38996, _0x64f88806._0x9226e57e(new byte[11] { 180, 136, 145, 137, 129, 166, 145, 144, 144, 139, 138 }, 228) + _0x9a74c0fe, _0xcfe3848c._0x556c658e, _0xcfe3848c._0x36dc6826, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.9f), _0x38306f56.Plume(_0x9a74c0fe), _0xeec56d36.Centre, Vector2.zero, 160f, 2.0f);
            this._0x65c3c8e7[_0x2eb66bb9] = _0xf49d6924.transform.GetChild(_0xf49d6924.transform.childCount - 1).GetComponent<Image>();
            this._0x685e9166[_0x2eb66bb9] = _0xeec56d36.Label(_0x67d38996, _0x64f88806._0x9226e57e(new byte[12] { 4, 56, 33, 57, 49, 23, 53, 36, 32, 61, 59, 58 }, 84), _0x64f88806._0x9226e57e(new byte[6] { 86, 85, 89, 81, 95, 94 }, 26), _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Moss, TextAlignmentOptions.Center, _0xeec56d36.BottomCentre, new Vector2(0f, 16f), new Vector2(150f, 36f));
            _0xeec56d36.OnTap(_0xf49d6924, () => this._0xc5da410a(_0x2eb66bb9));
        }

        this._0xcd08efd8();
    }

    private readonly TextMeshProUGUI[] _0x685e9166 = new TextMeshProUGUI[PlumeCount];
    private const int PlumeCount = 6;
    private void OnDestroy()
    {
        if (this._0x3ca6c0e4 != null)
        {
            DOTween.Kill(this._0x3ca6c0e4.transform);
        }
    }

    private void _0xc5da410a(int _0x28b491da)
    {
        if (!_0xfd5cbc90.PlumeUnlocked(_0x28b491da))
        {
            return;
        }

        _0xfd5cbc90._0x5c438be4 = _0x28b491da;
        _0xfd5cbc90.Flush();
        if (this._0x3ca6c0e4 != null)
        {
            this._0x3ca6c0e4.color = _0x38306f56.Plume(_0x28b491da);
            this._0x3ca6c0e4.transform.DOKill(false);
            this._0x3ca6c0e4.transform.localScale = Vector3.one;
            this._0x3ca6c0e4.transform.DOPunchScale(Vector3.one * 0.14f, 0.35f, 8, 0.8f).SetLink(this._0x3ca6c0e4.gameObject);
        }

        this._0xcd08efd8();
    }

    private Image _0x3ca6c0e4;
    private TextMeshProUGUI _0x8bd0748e;
    public void _0xcd08efd8()
    {
        _0x3a1c44b1 _0x85c6655f = _0x3a1c44b1.EnsureToday();
        _0xa09f3022.SetText(this._0x7b0b8592[0], _0x4e4c58b8.Grouped(_0xfd5cbc90._0xb3b99d41));
        _0xa09f3022.SetText(this._0x7b0b8592[1], _0x4e4c58b8.Grouped(_0xfd5cbc90._0x62e1ffc6));
        _0xa09f3022.SetText(this._0x7b0b8592[2], _0x4e4c58b8.Grouped(_0xfd5cbc90._0x8066d3d8));
        _0xa09f3022.SetText(this._0x7b0b8592[3], _0x4e4c58b8.Grouped(_0xfd5cbc90._0x94b0bd4a));
        _0xa09f3022.SetText(this._0x7b0b8592[4], _0x85c6655f._0xc2fb5612() + _0x64f88806._0x9226e57e(new byte[4] { 195, 204, 195, 208 }, 227));
        int _0xb2630e0d = _0xfd5cbc90.UnlockedPlumeCount();
        _0xa09f3022.SetText(this._0x8bd0748e, _0x64f88806._0x9226e57e(new byte[7] { 219, 199, 222, 198, 206, 216, 171 }, 139) + _0xb2630e0d + _0x64f88806._0x9226e57e(new byte[3] { 195, 204, 195 }, 227) + PlumeCount);
        for (int _0xc0653784 = 0; _0xc0653784 < PlumeCount; _0xc0653784++)
        {
            bool _0x2e4f46f6 = _0xfd5cbc90.PlumeUnlocked(_0xc0653784);
            if (this._0x65c3c8e7[_0xc0653784] != null)
            {
                this._0x65c3c8e7[_0xc0653784].color = _0x2e4f46f6 ? _0x38306f56.Plume(_0xc0653784) : _0x38306f56.Fade(_0x38306f56.Plume(_0xc0653784), 0.25f);
            }

            if (this._0x685e9166[_0xc0653784] != null)
            {
                _0xa09f3022.SetText(this._0x685e9166[_0xc0653784], _0x2e4f46f6 ? (_0xc0653784 == _0xfd5cbc90._0x5c438be4 ? _0x64f88806._0x9226e57e(new byte[4] { 123, 99, 126, 98 }, 44) : _0x64f88806._0x9226e57e(new byte[5] { 130, 149, 145, 148, 137 }, 208)) : _0x64f88806._0x9226e57e(new byte[6] { 66, 65, 77, 69, 75, 74 }, 14));
                this._0x685e9166[_0xc0653784].color = _0xc0653784 == _0xfd5cbc90._0x5c438be4 && _0x2e4f46f6 ? _0x38306f56.Sprout : _0x38306f56.Moss;
            }
        }

        if (this._0x3ca6c0e4 != null)
        {
            this._0x3ca6c0e4.color = _0x38306f56.Plume(_0xfd5cbc90._0x5c438be4);
        }
    }

    private readonly TextMeshProUGUI[] _0x7b0b8592 = new TextMeshProUGUI[5];
}

internal static class _0x64f88806
{
    internal static string _0x9226e57e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}