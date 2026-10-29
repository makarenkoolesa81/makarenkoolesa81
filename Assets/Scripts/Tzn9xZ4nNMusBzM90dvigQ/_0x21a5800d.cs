using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// MISSIONS. Three daily rows, deterministic from the calendar day index.
///
/// Row geometry obeys C.25 exactly: the state badge owns a 72-wide gutter centred 96
/// from the row's left edge, and the text column starts at 96 + 36 + 46 = 178, so the
/// glyphs and the indicator never share an x-band. Left alignment only aligns text
/// INSIDE its rectangle - the rectangle itself has to be placed clear of the gutter,
/// which is exactly the mistake this layout avoids.
/// </summary>
public sealed class _0x21a5800d : MonoBehaviour
{
    private readonly Image[] _0x2f88fd27 = new Image[_0x3a1c44b1.SlotCount];
    private readonly TextMeshProUGUI[] _0x39d6d6ff = new TextMeshProUGUI[_0x3a1c44b1.SlotCount];
    private readonly Image[] _0xc4dc2c4b = new Image[_0x3a1c44b1.SlotCount];
    private const float TextWidth = 700f;
    private const float RowHeight = 180f;
    public void _0xcdf56a57()
    {
        this._0x2cdc3d51 = _0x3a1c44b1.EnsureToday();
        for (int _0xfbda039c = 0; _0xfbda039c < _0x3a1c44b1.SlotCount; _0xfbda039c++)
        {
            int _0xe7c1aec8 = this._0x2cdc3d51._0x0cef9fa2(_0xfbda039c);
            int _0x0736195d = Mathf.Min(_0xfd5cbc90.MissionProgress(_0xfbda039c), _0xe7c1aec8);
            bool _0xf7ad942c = _0x0736195d >= _0xe7c1aec8;
            _0xa09f3022.SetText(this._0xf04997e8[_0xfbda039c], this._0x2cdc3d51._0xe9820e3f(_0xfbda039c));
            _0xa09f3022.SetText(this._0x39d6d6ff[_0xfbda039c], _0x0736195d + _0xf7da0088._0x728a8d52(new byte[3] { 206, 193, 206 }, 238) + _0xe7c1aec8);
            _0xeec56d36.SetBar(this._0xc4dc2c4b[_0xfbda039c], _0xe7c1aec8 <= 0 ? 0f : Mathf.Clamp01((float)_0x0736195d / _0xe7c1aec8));
            if (this._0x2f88fd27[_0xfbda039c] != null)
            {
                this._0x2f88fd27[_0xfbda039c].color = _0xf7ad942c ? _0x38306f56.Sprout : (_0x0736195d > 0 ? _0x38306f56.Fade(_0x38306f56.Sprout, 0.45f) : _0x38306f56.Shade);
            }
        }

        int _0xa29f25b0 = this._0x2cdc3d51._0xc2fb5612();
        _0xa09f3022.SetText(this._0x390aa215, _0xa29f25b0 > 0 ? _0xa29f25b0 + _0xf7da0088._0x728a8d52(new byte[35] { 123, 20, 29, 123, 104, 123, 31, 20, 21, 30, 123, 118, 123, 24, 9, 26, 15, 30, 8, 123, 12, 26, 18, 15, 123, 18, 21, 123, 9, 30, 12, 26, 9, 31, 8 }, 91) : _0xf7da0088._0x728a8d52(new byte[43] { 189, 188, 167, 187, 186, 189, 180, 211, 183, 188, 189, 182, 211, 170, 182, 167, 211, 222, 211, 163, 191, 178, 170, 211, 178, 211, 161, 188, 178, 183, 211, 167, 188, 211, 181, 186, 191, 191, 211, 167, 187, 186, 160 }, 243));
    }

    private readonly TextMeshProUGUI[] _0xf04997e8 = new TextMeshProUGUI[_0x3a1c44b1.SlotCount];
    private _0x3a1c44b1 _0x2cdc3d51;
    public void _0x075fe2df(_0xbe7aadff _0x76aae1d0, _0x8e9e461f _0x447b8b49)
    {
        Button _0x98c13062;
        RectTransform _0x14cfc122 = _0xeec56d36.Sheet(this.transform, _0x76aae1d0._0x556c658e, _0x76aae1d0._0x696c8fb6, _0xf7da0088._0x728a8d52(new byte[8] { 82, 86, 76, 76, 86, 80, 81, 76 }, 31), out _0x98c13062);
        _0xeec56d36.OnTap(_0x98c13062, () => _0x447b8b49._0xd40a8cf9());
        float _0x5cd3db2b = _0xeec56d36.TextColumnX(RowWidth, TextWidth);
        float _0xe3ae2d0f = _0xeec56d36.GutterX(RowWidth);
        for (int _0xc50f0661 = 0; _0xc50f0661 < _0x3a1c44b1.SlotCount; _0xc50f0661++)
        {
            RectTransform _0xa233f9de = _0xeec56d36.Row(_0x14cfc122, _0xf7da0088._0x728a8d52(new byte[10] { 166, 130, 152, 152, 130, 132, 133, 185, 132, 156 }, 235) + _0xc50f0661, _0x76aae1d0._0x556c658e, _0xeec56d36.Centre, new Vector2(0f, 300f - _0xc50f0661 * (RowHeight + 24f)), new Vector2(RowWidth, RowHeight));
            this._0x2f88fd27[_0xc50f0661] = _0xeec56d36.Plate(_0xa233f9de, _0xf7da0088._0x728a8d52(new byte[5] { 135, 164, 161, 162, 160 }, 197), _0x76aae1d0._0x556c658e, _0x38306f56.Shade, _0xeec56d36.Centre, new Vector2(_0xe3ae2d0f, 0f), new Vector2(64f, 64f), 1.0f);
            this._0xf04997e8[_0xc50f0661] = _0xeec56d36.Label(_0xa233f9de, _0xf7da0088._0x728a8d52(new byte[4] { 1, 46, 34, 42 }, 79), _0xf7da0088._0x728a8d52(new byte[1] { 87 }, 122), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Cream, TextAlignmentOptions.Left, _0xeec56d36.Centre, new Vector2(_0x5cd3db2b, 42f), new Vector2(TextWidth, 62f));
            this._0xc4dc2c4b[_0xc50f0661] = _0xeec56d36.Bar(_0xa233f9de, _0xf7da0088._0x728a8d52(new byte[3] { 155, 184, 171 }, 217), _0x76aae1d0._0x37c91518, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.95f), _0x38306f56.Sprout, _0xeec56d36.Centre, new Vector2(_0x5cd3db2b - 110f, -40f), new Vector2(480f, 28f), 1.6f);
            this._0x39d6d6ff[_0xc50f0661] = _0xeec56d36.Label(_0xa233f9de, _0xf7da0088._0x728a8d52(new byte[5] { 253, 209, 203, 208, 202 }, 190), _0xf7da0088._0x728a8d52(new byte[5] { 189, 173, 162, 173, 189 }, 141), _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Moss, TextAlignmentOptions.Right, _0xeec56d36.Centre, new Vector2(_0x5cd3db2b + 180f, -40f), new Vector2(180f, 44f));
        }

        this._0x390aa215 = _0xeec56d36.Label(_0x14cfc122, _0xf7da0088._0x728a8d52(new byte[7] { 250, 220, 196, 196, 200, 219, 208 }, 169), _0xf7da0088._0x728a8d52(new byte[1] { 41 }, 4), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Moss, TextAlignmentOptions.Center, _0xeec56d36.BottomCentre, new Vector2(0f, 230f), new Vector2(900f, 70f));
        this._0xcdf56a57();
    }

    private const float RowWidth = 980f;
    private TextMeshProUGUI _0x390aa215;
}

internal static class _0xf7da0088
{
    internal static string _0x728a8d52(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}