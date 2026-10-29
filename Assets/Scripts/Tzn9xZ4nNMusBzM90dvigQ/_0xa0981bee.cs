using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// DAILY ROAD. One shared road per calendar day: the seed is the day index, so every
/// player gets the same layout on the same date without anything being fetched from a
/// server. One heart, faster traffic, five stretches.
/// </summary>
public sealed class _0xa0981bee : MonoBehaviour
{
    private _0x3a1c44b1 _0x5a10644d;
    private void _0xa8283d12()
    {
        _0xfd5cbc90._0xc633c5a1 = true;
        _0xfd5cbc90.Flush();
        if (_0xf2da7f44.Instance != null)
        {
            _0xf2da7f44.Instance._0xa80559a1(_0xfc6e4613._0xef8a6460.SCENE_1);
        }
    }

    private void _0x66775129(Transform _0x137e1ad0, _0xbe7aadff _0xcfb99d5a, float _0x6046d196, string _0x6d03f578)
    {
        RectTransform _0x1982370e = _0xeec56d36.Node(_0x137e1ad0, _0x5a3ad441._0xabad7496(new byte[4] { 17, 54, 47, 38 }, 67) + _0x6d03f578, _0xeec56d36.Centre, new Vector2(_0x6046d196, -200f), new Vector2(260f, 84f));
        _0xeec56d36.Plate(_0x1982370e, _0x5a3ad441._0xabad7496(new byte[9] { 184, 147, 146, 139, 171, 151, 154, 143, 158 }, 251), _0xcfb99d5a._0x556c658e, _0x38306f56.Fade(_0x38306f56.Verge, 0.95f), _0xeec56d36.Centre, Vector2.zero, new Vector2(260f, 84f), 2.0f);
        _0xeec56d36.Label(_0x1982370e, _0x5a3ad441._0xabad7496(new byte[8] { 54, 29, 28, 5, 33, 16, 13, 1 }, 117), _0x6d03f578, _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.Centre, Vector2.zero, new Vector2(230f, 48f));
    }

    private TextMeshProUGUI _0xa2435419;
    public void _0xd14d49f3(_0xbe7aadff _0x347fece4, _0x8e9e461f _0x36819747)
    {
        Button _0x06d8b3ce;
        RectTransform _0x2a5c0e32 = _0xeec56d36.Sheet(this.transform, _0x347fece4._0x556c658e, _0x347fece4._0x696c8fb6, _0x5a3ad441._0xabad7496(new byte[10] { 250, 255, 247, 242, 231, 158, 236, 241, 255, 250 }, 190), out _0x06d8b3ce);
        _0xeec56d36.OnTap(_0x06d8b3ce, () => _0x36819747._0xd40a8cf9());
        RectTransform _0xfa80b0a7 = _0xeec56d36.Node(_0x2a5c0e32, _0x5a3ad441._0xabad7496(new byte[9] { 249, 220, 212, 209, 196, 254, 220, 207, 217 }, 189), _0xeec56d36.Centre, new Vector2(0f, 140f), new Vector2(920f, 880f));
        _0xeec56d36.Plate(_0xfa80b0a7, _0x5a3ad441._0xabad7496(new byte[9] { 118, 84, 71, 81, 101, 89, 84, 65, 80 }, 53), _0x347fece4._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.9f), _0xeec56d36.Centre, Vector2.zero, new Vector2(920f, 880f), 2.2f);
        _0xeec56d36.Plate(_0xfa80b0a7, _0x5a3ad441._0xabad7496(new byte[9] { 50, 16, 3, 21, 34, 5, 16, 22, 20 }, 113), _0x347fece4._0x6be52309, Color.white, _0xeec56d36.Centre, new Vector2(0f, 190f), new Vector2(860f, 300f), 1.0f);
        _0xeec56d36.Picture(_0xfa80b0a7, _0x5a3ad441._0xabad7496(new byte[7] { 200, 234, 249, 239, 195, 238, 229 }, 139), _0x347fece4._0x36dc6826, _0x38306f56.Plume(_0xfd5cbc90._0x5c438be4), _0xeec56d36.Centre, new Vector2(-180f, 200f), new Vector2(240f, 240f));
        _0xeec56d36.Picture(_0xfa80b0a7, _0x5a3ad441._0xabad7496(new byte[9] { 68, 102, 117, 99, 83, 117, 114, 100, 108 }, 7), _0x347fece4._0xfeaf8c24(0), Color.white, _0xeec56d36.Centre, new Vector2(170f, 190f), new Vector2(240f, 240f));
        _0xeec56d36.Label(_0xfa80b0a7, _0x5a3ad441._0xabad7496(new byte[9] { 133, 167, 180, 162, 146, 175, 178, 170, 163 }, 198), _0x5a3ad441._0xabad7496(new byte[12] { 12, 23, 28, 25, 1, 127, 11, 120, 10, 23, 25, 28 }, 88), _0x4e4c58b8.TitleMax, _0x4e4c58b8.TitleMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -10f), new Vector2(860f, 80f));
        this._0xa2435419 = _0xeec56d36.Label(_0xfa80b0a7, _0x5a3ad441._0xabad7496(new byte[8] { 40, 10, 25, 15, 57, 4, 10, 15 }, 107), _0x5a3ad441._0xabad7496(new byte[4] { 53, 40, 38, 35 }, 103), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Sprout, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -90f), new Vector2(860f, 60f));
        this._0x66775129(_0xfa80b0a7, _0x347fece4, -280f, _0x5a3ad441._0xabad7496(new byte[7] { 72, 89, 49, 60, 56, 43, 45 }, 121));
        this._0x66775129(_0xfa80b0a7, _0x347fece4, 0f, _0x5a3ad441._0xabad7496(new byte[6] { 218, 221, 207, 200, 217, 206 }, 156));
        this._0x66775129(_0xfa80b0a7, _0x347fece4, 280f, _0x5a3ad441._0xabad7496(new byte[7] { 214, 195, 177, 172, 162, 167, 176 }, 227));
        this._0x32e569d3 = _0xeec56d36.Label(_0xfa80b0a7, _0x5a3ad441._0xabad7496(new byte[8] { 148, 182, 165, 179, 149, 178, 164, 163 }, 215), _0x5a3ad441._0xabad7496(new byte[14] { 66, 89, 82, 87, 79, 49, 69, 54, 84, 83, 69, 66, 54, 38 }, 22), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Moss, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -330f), new Vector2(860f, 60f));
        Button _0xedf5e5d0 = _0xeec56d36.Cta(_0x2a5c0e32, _0x5a3ad441._0xabad7496(new byte[11] { 117, 82, 71, 84, 82, 100, 83, 82, 82, 73, 72 }, 38), _0x5a3ad441._0xabad7496(new byte[5] { 0, 7, 18, 1, 7 }, 83), _0x347fece4._0x32adc7bd, _0x38306f56.Hazard, _0x38306f56.Cream, _0xeec56d36.BottomCentre, new Vector2(0f, 220f), new Vector2(620f, 150f), 2.0f);
        _0xeec56d36.OnTap(_0xedf5e5d0, () => this._0xa8283d12());
        this._0xa7bd6559();
    }

    public void _0xa7bd6559()
    {
        this._0x5a10644d = _0x3a1c44b1.EnsureToday();
        _0xa09f3022.SetText(this._0xa2435419, _0x5a3ad441._0xabad7496(new byte[12] { 55, 42, 36, 33, 69, 43, 48, 40, 39, 32, 55, 69 }, 101) + this._0x5a10644d._0x69389be2);
        _0xa09f3022.SetText(this._0x32e569d3, _0xfd5cbc90._0xcc507d7e > 0 ? _0x5a3ad441._0xabad7496(new byte[13] { 168, 179, 184, 189, 165, 219, 175, 220, 190, 185, 175, 168, 220 }, 252) + _0xfd5cbc90._0xcc507d7e + _0x5a3ad441._0xabad7496(new byte[3] { 194, 205, 194 }, 226) + _0x4e4c58b8.DailyStretchGoal : _0x5a3ad441._0xabad7496(new byte[17] { 215, 214, 205, 185, 203, 204, 215, 185, 205, 214, 221, 216, 192, 185, 192, 220, 205 }, 153));
    }

    private TextMeshProUGUI _0x32e569d3;
}

internal static class _0x5a3ad441
{
    internal static string _0xabad7496(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}