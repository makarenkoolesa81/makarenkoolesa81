using TMPro;
using UnityEngine;

/// <summary>
/// One place that decides how every label in this game behaves.
///
/// C.10: word wrapping OFF, line breaks only as an explicit \n in the string, autosize
/// ALWAYS on, fontSizeMin never below the readability floor. C.65: a label built under
/// an inactive parent has not run Awake, so it has no font and no shared material -
/// reading fontMaterial there THROWS. It is handed a font first, and the shared font
/// SDF material already carries the themed dark Ink outline, which is what makes the
/// light text read on both backgrounds.
/// </summary>
public static class _0xa09f3022
{
    /// <summary>
    /// Sets a string whose line breaks are placed by hand. The engine must never decide
    /// where a line ends, so the layout is identical on every device.
    /// </summary>
    public static void SetText(TMP_Text _0x5ed1bc2f, string _0x5c397d04)
    {
        if (_0x5ed1bc2f == null)
        {
            return;
        }

        Prepare(_0x5ed1bc2f);
        _0x5ed1bc2f.text = _0x5c397d04;
    }

    public static void Apply(TMP_Text _0x43658457, Color _0x633dc1de, float _0x12577cd7, float _0xf9ffad1c)
    {
        if (_0x43658457 == null)
        {
            return;
        }

        Prepare(_0x43658457);
        _0x43658457.textWrappingMode = TextWrappingModes.NoWrap;
        _0x43658457.overflowMode = TextOverflowModes.Overflow;
        _0x43658457.enableAutoSizing = true;
        _0x43658457.fontSizeMin = _0xf9ffad1c < _0x4e4c58b8.CaptionMin ? _0x4e4c58b8.CaptionMin : _0xf9ffad1c;
        _0x43658457.fontSizeMax = _0x12577cd7;
        _0x43658457.fontSize = _0x12577cd7;
        _0x43658457.color = _0x633dc1de;
        _0x43658457.raycastTarget = false;
    }

    public static void Prepare(TMP_Text _0xc2c77fb3)
    {
        if (_0xc2c77fb3 == null)
        {
            return;
        }

        if (_0xc2c77fb3.font == null)
        {
            _0xc2c77fb3.font = TMP_Settings.defaultFontAsset;
        }

        if (_0xc2c77fb3.fontSharedMaterial == null && _0xc2c77fb3.font != null)
        {
            _0xc2c77fb3.fontSharedMaterial = _0xc2c77fb3.font.material;
        }
    }
}