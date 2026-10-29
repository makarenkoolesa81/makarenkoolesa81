using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three pops the template guarantees - PAUSE 6, WIN 7, LOSE 8 - in this
/// game's own words and colours (C.3). Pops are addressed by SETTINGS.POPS index,
/// never by name.
///
/// WHY THIS DOES NOT USE THE TEMPLATE'S OWN LABELS. The game scene switches
/// MainText off on WIN and LOSE and TOP_BTNS off on both of them, so which of
/// Pop.ContentHeaderText / ContentMainText / ContentAdditionalText is actually visible
/// differs per pop. Every template label is therefore BLANKED and this game draws its
/// own three lines inside its own card - one layout, visible on all three pops.
///
/// WHY BUTTONS ARE CAPTIONED BY DRIVER. A traversal returns the close cross FIRST, so
/// captioning in a loop gives a pause screen three identical buttons (C.17). Each
/// button is identified by the TEMPLATE DRIVER COMPONENT it carries - a type
/// reference, which obfuscation renames consistently, unlike a name:
///   LoadSceneButton + IsLoadCurrentScene -> this scene again -> RETRY / NEXT ROAD
///   LoadSceneButton                      -> scene 0          -> MENU
///   ShowPopButton / SetPhysicsRunButton  -> dismiss + resume  -> RESUME, or the cross
/// No listener is ever added on top of a driver: that would fire the action twice.
///
/// The close cross ships with an Image and NO sprite, which Unity draws as a solid
/// WHITE RECTANGLE (B.1). It gets the serialized close icon and no caption at all.
/// </summary>
public sealed class _0xa06b42c3 : MonoBehaviour
{
    private void _0xf7d002da(int _0xcd67b62b)
    {
        this._0xb2e6d682(_0xcd67b62b, this._0xc0da3ffa(_0xcd67b62b));
    }

    public void _0x0d467fe1(int _0x31233ca5, int _0x93b6bb14, int _0x453a01b2, int _0xd602ad1c)
    {
        if (_0x59b62125.Instance == null)
        {
            return;
        }

        this._0xac25be7c(_0xfc6e4613._0xba356ec3.LOSE, _0xc4b32db9._0xa3edee88(new byte[9] { 87, 80, 75, 37, 64, 75, 65, 64, 65 }, 5), _0xc4b32db9._0xa3edee88(new byte[5] { 16, 13, 3, 6, 98 }, 66) + _0x31233ca5 + _0xc4b32db9._0xa3edee88(new byte[3] { 144, 159, 144 }, 176) + _0x93b6bb14, _0x453a01b2 + _0xc4b32db9._0xa3edee88(new byte[24] { 172, 202, 201, 205, 216, 196, 201, 222, 223, 172, 161, 172, 206, 201, 223, 216, 172, 223, 216, 222, 201, 205, 199, 172 }, 140) + _0xd602ad1c);
        _0x59b62125.Instance._0x3315eb73(_0xfc6e4613._0xba356ec3.LOSE);
    }

    /// <summary>The caption this button has earned, read from the driver it carries.</summary>
    private string _0xd6c0bf2e(int _0x599d5d5c, Button _0xc690a93e)
    {
        _0xd1b3b7bf _0x4d4ee674 = _0xc690a93e.GetComponent<_0xd1b3b7bf>();
        if (_0x4d4ee674 != null)
        {
            if (_0x4d4ee674.IsLoadCurrentScene)
            {
                return _0x599d5d5c == _0xfc6e4613._0xba356ec3.WIN ? _0xc4b32db9._0xa3edee88(new byte[9] { 25, 18, 15, 3, 119, 5, 24, 22, 19 }, 87) : _0xc4b32db9._0xa3edee88(new byte[5] { 115, 100, 117, 115, 120 }, 33);
            }

            return _0xc4b32db9._0xa3edee88(new byte[4] { 74, 66, 73, 82 }, 7);
        }

        if (_0xc690a93e.GetComponent<_0xdb5b34de>() != null || _0xc690a93e.GetComponent<_0x241fafb5>() != null)
        {
            return _0xc4b32db9._0xa3edee88(new byte[6] { 73, 94, 72, 78, 86, 94 }, 27);
        }

        // A caption we cannot justify is worse than none: an empty string, never
        // somebody else's label (C.17).
        return string.Empty;
    }

    private void _0xa224d909(Button _0xfdaf067e)
    {
        RectTransform _0x5491972f = (RectTransform)_0xfdaf067e.transform;
        Image[] _0xc38ccc2b = _0xfdaf067e.GetComponentsInChildren<Image>(true);
        for (int _0x72881267 = 0; _0x72881267 < _0xc38ccc2b.Length; _0x72881267++)
        {
            Image _0x617c67f5 = _0xc38ccc2b[_0x72881267];
            if (_0x617c67f5 == null || _0x617c67f5.sprite != null)
            {
                continue;
            }

            _0x617c67f5.sprite = this._0x4f88af54._0x556c658e;
            _0x617c67f5.type = Image.Type.Sliced;
            _0x617c67f5.pixelsPerUnitMultiplier = 1.4f;
            _0x617c67f5.color = _0x38306f56.Fade(_0x38306f56.Asphalt, 0.92f);
        }

        float _0xa27685fc = Mathf.Min(Mathf.Max(_0x5491972f.rect.width, 40f), 96f) * 0.5f;
        _0xeec56d36.Picture(_0x5491972f, _0xc4b32db9._0xa3edee88(new byte[10] { 53, 26, 25, 5, 19, 49, 26, 15, 6, 30 }, 118), this._0x4f88af54._0x696c8fb6, _0x38306f56.Cream, _0xeec56d36.Centre, new Vector2(0f, 0f), new Vector2(_0xa27685fc, _0xa27685fc));
    }

    private _0xc01143a0 _0xc0da3ffa(int _0xd2a3c60b)
    {
        if (_0x59b62125.Instance == null || _0x59b62125.Instance.Pops == null || _0xd2a3c60b < 0 || _0xd2a3c60b >= _0x59b62125.Instance.Pops.Count)
        {
            return null;
        }

        return _0x59b62125.Instance._0xb8b1da85(_0xd2a3c60b);
    }

    public void _0x3e07be89(int _0x514ca1c7, int _0x0b8d9597, int _0x0a8370a0)
    {
        if (_0x59b62125.Instance == null)
        {
            return;
        }

        this._0xac25be7c(_0xfc6e4613._0xba356ec3.PAUSE, _0xc4b32db9._0xa3edee88(new byte[6] { 29, 12, 24, 30, 8, 9 }, 77), _0xc4b32db9._0xa3edee88(new byte[5] { 49, 44, 34, 39, 67 }, 99) + _0x514ca1c7 + _0xc4b32db9._0xa3edee88(new byte[3] { 132, 139, 132 }, 164) + _0x0b8d9597, _0x0a8370a0 + _0xc4b32db9._0xa3edee88(new byte[16] { 232, 142, 141, 137, 156, 128, 141, 154, 155, 232, 155, 135, 232, 142, 137, 154 }, 200));
        _0x59b62125.Instance._0x3315eb73(_0xfc6e4613._0xba356ec3.PAUSE);
    }

    private void _0xac25be7c(int _0x5828896c, string _0x8c52902d, string _0xdec4d6cb, string _0xe58daa63)
    {
        _0xc01143a0 _0x3407d17b = this._0xc0da3ffa(_0x5828896c);
        if (_0x3407d17b == null)
        {
            return;
        }

        this._0xf7d002da(_0x5828896c);
        TextMeshProUGUI _0x5486a7c4;
        if (this._0xbee302f7.TryGetValue(_0x5828896c, out _0x5486a7c4))
        {
            _0xa09f3022.SetText(_0x5486a7c4, _0x8c52902d);
        }

        if (this._0x44427f31.TryGetValue(_0x5828896c, out _0x5486a7c4))
        {
            _0xa09f3022.SetText(_0x5486a7c4, _0xdec4d6cb);
        }

        if (this._0x987fe666.TryGetValue(_0x5828896c, out _0x5486a7c4))
        {
            _0xa09f3022.SetText(_0x5486a7c4, _0xe58daa63);
        }

        // Pop.Show kills the body's tweens with complete:true, which finishes a
        // half-done Hide and switches the body straight back off. Kill WITHOUT
        // completing and reset the scale before the pop is raised.
        if (_0x3407d17b.Content != null)
        {
            DOTween.Kill(_0x3407d17b.Content.transform);
            _0x3407d17b.Content.SetActive(true);
            _0x3407d17b.Content.transform.localScale = Vector3.zero;
        }
    }

    private void _0xa18fa35d(int _0x393a8550, _0xc01143a0 _0x653c2dec)
    {
        Button[] _0xe41050d4 = _0x653c2dec.Content.GetComponentsInChildren<Button>(true);
        for (int _0xa3a04337 = 0; _0xa3a04337 < _0xe41050d4.Length; _0xa3a04337++)
        {
            Button _0xecde3a9c = _0xe41050d4[_0xa3a04337];
            if (_0xecde3a9c == null)
            {
                continue;
            }

            TMP_Text _0x52e26035 = _0xecde3a9c.GetComponentInChildren<TMP_Text>(true);
            if (_0x52e26035 == null)
            {
                this._0xa224d909(_0xecde3a9c);
                continue;
            }

            this._0x9dc81c58(_0xecde3a9c, _0x52e26035, this._0xd6c0bf2e(_0x393a8550, _0xecde3a9c));
        }
    }

    private _0xbe7aadff _0x4f88af54;
    private readonly Dictionary<int, TextMeshProUGUI> _0xbee302f7 = new Dictionary<int, TextMeshProUGUI>();
    private readonly Dictionary<int, TextMeshProUGUI> _0x44427f31 = new Dictionary<int, TextMeshProUGUI>();
    public void _0x2d463820(int _0x60b764ad, int _0x2af99848, int _0xe31addbf)
    {
        if (_0x59b62125.Instance == null)
        {
            return;
        }

        this._0xac25be7c(_0xfc6e4613._0xba356ec3.WIN, _0xc4b32db9._0xa3edee88(new byte[12] { 68, 89, 87, 82, 54, 85, 90, 83, 87, 68, 83, 82 }, 22), _0x60b764ad + _0xc4b32db9._0xa3edee88(new byte[3] { 143, 128, 143 }, 175) + _0x60b764ad + _0xc4b32db9._0xa3edee88(new byte[10] { 46, 93, 90, 92, 75, 90, 77, 70, 75, 93 }, 14), _0xc4b32db9._0xa3edee88(new byte[1] { 185 }, 146) + _0x2af99848 + _0xc4b32db9._0xa3edee88(new byte[13] { 182, 208, 211, 215, 194, 222, 211, 196, 197, 182, 187, 182, 189 }, 150) + _0xe31addbf + _0xc4b32db9._0xa3edee88(new byte[6] { 122, 29, 8, 27, 19, 20 }, 90));
        _0x59b62125.Instance._0x3315eb73(_0xfc6e4613._0xba356ec3.WIN);
    }

    public void _0x5cfc67ec(_0xbe7aadff _0x92db59bd)
    {
        this._0x4f88af54 = _0x92db59bd;
        if (_0x59b62125.Instance == null || _0x59b62125.Instance.Pops == null)
        {
            return;
        }

        // Fetched by index, exactly as they will be shown: PAUSE 6, WIN 7, LOSE 8.
        _0xc01143a0 _0xbaffc361 = _0x59b62125.Instance._0xb8b1da85(_0xfc6e4613._0xba356ec3.PAUSE);
        _0xc01143a0 _0x700578fa = _0x59b62125.Instance._0xb8b1da85(_0xfc6e4613._0xba356ec3.WIN);
        _0xc01143a0 _0xf77f5997 = _0x59b62125.Instance._0xb8b1da85(_0xfc6e4613._0xba356ec3.LOSE);
        this._0xb2e6d682(_0xfc6e4613._0xba356ec3.PAUSE, _0xbaffc361);
        this._0xb2e6d682(_0xfc6e4613._0xba356ec3.WIN, _0x700578fa);
        this._0xb2e6d682(_0xfc6e4613._0xba356ec3.LOSE, _0xf77f5997);
    }

    private readonly Dictionary<int, TextMeshProUGUI> _0x987fe666 = new Dictionary<int, TextMeshProUGUI>();
    private void _0xb2e6d682(int _0xaf0f7573, _0xc01143a0 _0x05985314)
    {
        if (_0x05985314 == null || _0x05985314.Content == null || this._0x129599e8.Contains(_0xaf0f7573))
        {
            return;
        }

        this._0x129599e8.Add(_0xaf0f7573);
        // Pop.Awake leaves Content inactive, and a TMP label built into a dead
        // hierarchy has never run Awake - it has no font and no shared material, and
        // touching its material would throw (C.65). Wake the body first.
        _0x05985314.Content.SetActive(true);
        Transform _0xbe8f2191 = _0x05985314.Content.transform;
        this._0x95fab9e0(_0x05985314);
        // Card: shadow -> body -> wash -> rim -> illustration -> text. Decorative trim
        // is created BEFORE the content it surrounds, so nothing covers its own
        // caption (C.13 / C.63).
        RectTransform _0x99243363 = _0xeec56d36.Node(_0xbe8f2191, _0xc4b32db9._0xa3edee88(new byte[8] { 170, 151, 153, 156, 187, 153, 138, 156 }, 248), _0xeec56d36.Centre, new Vector2(0f, 60f), new Vector2(1020f, 1000f));
        _0x99243363.SetSiblingIndex(1);
        _0xeec56d36.Plate(_0x99243363, _0xc4b32db9._0xa3edee88(new byte[10] { 232, 202, 217, 207, 248, 195, 202, 207, 196, 220 }, 171), this._0x4f88af54._0x556c658e, _0x38306f56.Fade(_0x38306f56.Ink, 0.45f), _0xeec56d36.Centre, new Vector2(0f, -14f), new Vector2(1036f, 1014f), 2.2f);
        _0xeec56d36.Plate(_0x99243363, _0xc4b32db9._0xa3edee88(new byte[8] { 141, 175, 188, 170, 140, 161, 170, 183 }, 206), this._0x4f88af54._0x556c658e, _0x38306f56.Verge, _0xeec56d36.Centre, Vector2.zero, new Vector2(1020f, 1000f), 2.2f);
        _0xeec56d36.Plate(_0x99243363, _0xc4b32db9._0xa3edee88(new byte[8] { 52, 22, 5, 19, 32, 22, 4, 31 }, 119), this._0x4f88af54._0x556c658e, _0x38306f56.Fade(_0x38306f56.FieldShade, 0.80f), _0xeec56d36.Centre, new Vector2(0f, -250f), new Vector2(996f, 470f), 2.4f);
        _0xeec56d36.Plate(_0x99243363, _0xc4b32db9._0xa3edee88(new byte[7] { 98, 64, 83, 69, 115, 72, 76 }, 33), this._0x4f88af54._0x556c658e, _0x38306f56.Fade(_0x38306f56.Sprout, 0.45f), _0xeec56d36.Centre, Vector2.zero, new Vector2(1020f, 1000f), 2.6f);
        _0xeec56d36.Picture(_0x99243363, _0xc4b32db9._0xa3edee88(new byte[7] { 125, 95, 76, 90, 118, 91, 80 }, 62), this._0x4f88af54._0x36dc6826, _0x38306f56.Plume(_0xfd5cbc90._0x5c438be4), _0xeec56d36.Centre, new Vector2(0f, 250f), new Vector2(280f, 280f));
        this._0xbee302f7[_0xaf0f7573] = _0xeec56d36.Label(_0x99243363, _0xc4b32db9._0xa3edee88(new byte[10] { 216, 250, 233, 255, 211, 254, 250, 255, 254, 233 }, 155), _0xc4b32db9._0xa3edee88(new byte[1] { 110 }, 67), _0x4e4c58b8.TitleMax, _0x4e4c58b8.TitleMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, 40f), new Vector2(900f, 110f));
        this._0x44427f31[_0xaf0f7573] = _0xeec56d36.Label(_0x99243363, _0xc4b32db9._0xa3edee88(new byte[12] { 113, 83, 64, 86, 112, 93, 86, 75, 102, 87, 74, 70 }, 50), _0xc4b32db9._0xa3edee88(new byte[1] { 28 }, 49), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Sprout, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -80f), new Vector2(900f, 70f));
        this._0x987fe666[_0xaf0f7573] = _0xeec56d36.Label(_0x99243363, _0xc4b32db9._0xa3edee88(new byte[9] { 236, 206, 221, 203, 234, 215, 219, 221, 206 }, 175), _0xc4b32db9._0xa3edee88(new byte[1] { 198 }, 235), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Moss, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, -190f), new Vector2(900f, 70f));
        this._0xa18fa35d(_0xaf0f7573, _0x05985314);
    }

    private readonly List<int> _0x129599e8 = new List<int>();
    /// <summary>
    /// A themed face drawn as the button's OWN children with raycastTarget off, so the
    /// tap still reaches the template Button underneath. The template tints its one
    /// surviving graphic to nothing in the normal state, so without this a pop button
    /// is an invisible tap target.
    /// </summary>
    private void _0x9dc81c58(Button _0x3b24a411, TMP_Text _0x6afa0e5d, string _0xc8574fa9)
    {
        RectTransform _0xcff1b75a = (RectTransform)_0x3b24a411.transform;
        Vector2 _0xaa6819ea = _0xcff1b75a.rect.size;
        if (_0xaa6819ea.x < 1f || _0xaa6819ea.y < 1f)
        {
            _0xaa6819ea = new Vector2(620f, 150f);
        }

        Image _0x7e0c16e5 = _0xeec56d36.Plate(_0xcff1b75a, _0xc4b32db9._0xa3edee88(new byte[10] { 211, 241, 230, 251, 253, 252, 212, 243, 241, 247 }, 146), this._0x4f88af54._0x32adc7bd, _0x38306f56.Hazard, _0xeec56d36.Centre, Vector2.zero, new Vector2(_0xaa6819ea.x * 0.62f, Mathf.Min(_0xaa6819ea.y, 160f)), 1.8f);
        _0x7e0c16e5.transform.SetAsFirstSibling();
        Image _0x285218ed = _0xeec56d36.Plate(_0xcff1b75a, _0xc4b32db9._0xa3edee88(new byte[9] { 241, 211, 196, 217, 223, 222, 226, 217, 221 }, 176), this._0x4f88af54._0x556c658e, _0x38306f56.Fade(_0x38306f56.Sprout, 0.45f), _0xeec56d36.Centre, Vector2.zero, new Vector2(_0xaa6819ea.x * 0.62f, Mathf.Min(_0xaa6819ea.y, 160f)), 2.2f);
        _0x285218ed.transform.SetSiblingIndex(1);
        _0xa09f3022.Apply(_0x6afa0e5d, _0x38306f56.Cream, _0x4e4c58b8.ButtonMax, _0x4e4c58b8.ButtonMin);
        _0x6afa0e5d.alignment = TextAlignmentOptions.Center;
        _0xa09f3022.SetText(_0x6afa0e5d, _0xc8574fa9);
        _0x6afa0e5d.transform.SetAsLastSibling();
    }

    /// <summary>
    /// Clears every template string in the pop so no caption from the template's own
    /// game ("You Win!", "The game is currently suspended...", Score:, Reward:, Time:)
    /// can reach the screen beside ours (C.15). Button captions are dressed separately
    /// and are skipped here.
    /// </summary>
    private void _0x95fab9e0(_0xc01143a0 _0x0e1064f2)
    {
        TMP_Text[] _0xa25b8393 = _0x0e1064f2.Content.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x0808eea7 = 0; _0x0808eea7 < _0xa25b8393.Length; _0x0808eea7++)
        {
            TMP_Text _0x8089e02c = _0xa25b8393[_0x0808eea7];
            if (_0x8089e02c == null || _0x8089e02c.GetComponentInParent<Button>() != null)
            {
                continue;
            }

            _0xa09f3022.SetText(_0x8089e02c, string.Empty);
        }

        _0xa09f3022.SetText(_0x0e1064f2.ContentHeaderText, string.Empty);
        _0xa09f3022.SetText(_0x0e1064f2.ContentMainText, string.Empty);
        _0xa09f3022.SetText(_0x0e1064f2.ContentAdditionalText, string.Empty);
    }
}

internal static class _0xc4b32db9
{
    internal static string _0xa3edee88(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}