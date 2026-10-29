using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// SETTINGS. Four rows, every one of which does real work.
///
/// There is NO sound row, no volume slider and no speaker icon: this game ships
/// without audio (C.20), so a sound toggle would be a dead button - the player taps,
/// the icon changes and nothing else does. An empty row would be better than that;
/// four working rows are better still.
///
///   VIBRATION      buzzes the device the moment it is switched on
///   HOP GUIDE      switches the landing chevrons in the game scene
///   HIGH CONTRAST  repaints every plate and body line on this sheet instantly
///   RESET PROGRESS opens a confirm row with RESET and KEEP
/// </summary>
public sealed class _0xcfb390b8 : MonoBehaviour
{
    private const float RowWidth = 980f;
    private readonly List<Image> _0xa7966a81 = new List<Image>();
    private void _0xb7775bc9()
    {
        _0xfd5cbc90.ResetAll();
        this._0xc0345965(false);
        _0xa09f3022.SetText(this._0x202eccab, _0x48d8d50b._0x55a0a350(new byte[39] { 86, 84, 73, 65, 84, 67, 85, 85, 38, 69, 74, 67, 71, 84, 67, 66, 38, 43, 38, 82, 78, 67, 38, 84, 73, 71, 66, 38, 85, 82, 71, 84, 82, 85, 38, 73, 80, 67, 84 }, 6));
        this._0x9314b354();
    }

    private readonly List<TextMeshProUGUI> _0x35150f91 = new List<TextMeshProUGUI>();
    /// <summary>
    /// HIGH CONTRAST repaints this sheet the instant it is tapped - the plates go
    /// fully opaque and the body lines go from Moss to Cream - so the toggle confirms
    /// itself on screen rather than only in a saved value.
    /// </summary>
    public void _0x9314b354()
    {
        bool[] _0x8fa6ef32 = new bool[]
        {
            _0xfd5cbc90._0x5db89fcc,
            _0xfd5cbc90._0x4b0763a5,
            _0xfd5cbc90._0x051084a6
        };
        for (int _0xe5505575 = 0; _0xe5505575 < RowCount; _0xe5505575++)
        {
            bool _0xbcc564ba = _0x8fa6ef32[_0xe5505575];
            if (this._0xfbab2b8c[_0xe5505575] != null)
            {
                this._0xfbab2b8c[_0xe5505575].color = _0xbcc564ba ? _0x38306f56.Sprout : _0x38306f56.Asphalt;
            }

            if (this._0xfd596c83[_0xe5505575] != null)
            {
                this._0xfd596c83[_0xe5505575].DOKill(false);
                this._0xfd596c83[_0xe5505575].DOAnchorPosX(_0xbcc564ba ? 38f : -38f, 0.16f).SetEase(Ease.OutQuad).SetLink(this._0xfd596c83[_0xe5505575].gameObject);
            }
        }

        float _0xd34b1b4b = _0xfd5cbc90._0x051084a6 ? 1f : 0.85f;
        for (int _0xa3edf7f5 = 0; _0xa3edf7f5 < this._0xa7966a81.Count; _0xa3edf7f5++)
        {
            if (this._0xa7966a81[_0xa3edf7f5] != null)
            {
                this._0xa7966a81[_0xa3edf7f5].color = _0x38306f56.Fade(_0x38306f56.Asphalt, _0xd34b1b4b);
            }
        }

        Color _0xdf3af5dd = _0xfd5cbc90._0x051084a6 ? _0x38306f56.Cream : _0x38306f56.Moss;
        for (int _0x6638197e = 0; _0x6638197e < this._0x35150f91.Count; _0x6638197e++)
        {
            if (this._0x35150f91[_0x6638197e] != null)
            {
                this._0x35150f91[_0x6638197e].color = _0xdf3af5dd;
            }
        }
    }

    private RectTransform _0xfd8d245b;
    private const float RowHeight = 150f;
    private readonly RectTransform[] _0xfd596c83 = new RectTransform[RowCount];
    private void OnDestroy()
    {
        for (int _0xd91451ab = 0; _0xd91451ab < this._0xfd596c83.Length; _0xd91451ab++)
        {
            if (this._0xfd596c83[_0xd91451ab] != null)
            {
                DOTween.Kill(this._0xfd596c83[_0xd91451ab]);
            }
        }

        if (this._0xfd8d245b != null)
        {
            DOTween.Kill(this._0xfd8d245b);
        }
    }

    private TextMeshProUGUI _0x202eccab;
    private void _0x1910c861(int _0xb46d3417)
    {
        if (_0xb46d3417 == 0)
        {
            _0xfd5cbc90._0x5db89fcc = !_0xfd5cbc90._0x5db89fcc;
            if (_0xfd5cbc90._0x5db89fcc)
            {
                _0xfd5cbc90.Buzz();
            }
        }
        else if (_0xb46d3417 == 1)
        {
            _0xfd5cbc90._0x4b0763a5 = !_0xfd5cbc90._0x4b0763a5;
        }
        else
        {
            _0xfd5cbc90._0x051084a6 = !_0xfd5cbc90._0x051084a6;
        }

        _0xfd5cbc90.Flush();
        this._0x9314b354();
    }

    public void _0x7411c22a(_0xbe7aadff _0xd98f9f80, _0x8e9e461f _0xe16b9711)
    {
        Button _0xbeb39ca5;
        RectTransform _0x484acba1 = _0xeec56d36.Sheet(this.transform, _0xd98f9f80._0x556c658e, _0xd98f9f80._0x696c8fb6, _0x48d8d50b._0x55a0a350(new byte[8] { 122, 108, 125, 125, 96, 103, 110, 122 }, 41), out _0xbeb39ca5);
        _0xeec56d36.OnTap(_0xbeb39ca5, () => _0xe16b9711._0xd40a8cf9());
        this._0x0d7c98ae(_0x484acba1, _0xd98f9f80, 0, 420f, _0x48d8d50b._0x55a0a350(new byte[9] { 99, 124, 119, 103, 116, 97, 124, 122, 123 }, 53), _0x48d8d50b._0x55a0a350(new byte[33] { 173, 204, 191, 164, 163, 190, 184, 204, 174, 185, 182, 182, 204, 187, 164, 169, 162, 204, 173, 204, 164, 169, 173, 190, 184, 204, 165, 191, 204, 160, 163, 191, 184 }, 236));
        this._0x0d7c98ae(_0x484acba1, _0xd98f9f80, 1, 250f, _0x48d8d50b._0x55a0a350(new byte[9] { 33, 38, 57, 73, 46, 60, 32, 45, 44 }, 105), _0x48d8d50b._0x55a0a350(new byte[25] { 173, 182, 177, 169, 222, 170, 182, 187, 222, 178, 191, 176, 186, 183, 176, 185, 222, 189, 182, 187, 168, 172, 177, 176, 173 }, 254));
        this._0x0d7c98ae(_0x484acba1, _0xd98f9f80, 2, 80f, _0x48d8d50b._0x55a0a350(new byte[13] { 104, 105, 103, 104, 0, 99, 111, 110, 116, 114, 97, 115, 116 }, 32), _0x48d8d50b._0x55a0a350(new byte[24] { 55, 39, 60, 50, 61, 33, 48, 39, 85, 37, 57, 52, 33, 48, 38, 85, 52, 59, 49, 85, 33, 48, 45, 33 }, 117));
        RectTransform _0xe67208a7 = _0xeec56d36.Row(_0x484acba1, _0x48d8d50b._0x55a0a350(new byte[8] { 84, 99, 117, 99, 114, 84, 105, 113 }, 6), _0xd98f9f80._0x556c658e, _0xeec56d36.Centre, new Vector2(0f, -110f), new Vector2(RowWidth, RowHeight));
        this._0xa7966a81.Add(_0xe67208a7.GetComponentInChildren<Image>(true));
        _0xeec56d36.Label(_0xe67208a7, _0x48d8d50b._0x55a0a350(new byte[10] { 179, 132, 146, 132, 149, 181, 136, 149, 141, 132 }, 225), _0x48d8d50b._0x55a0a350(new byte[14] { 95, 72, 94, 72, 89, 45, 93, 95, 66, 74, 95, 72, 94, 94 }, 13), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Cream, TextAlignmentOptions.Left, _0xeec56d36.Centre, new Vector2(_0xeec56d36.TextColumnX(RowWidth, 520f), 0f), new Vector2(520f, 62f));
        Button _0x05014a9a = _0xeec56d36.Cta(_0xe67208a7, _0x48d8d50b._0x55a0a350(new byte[11] { 7, 48, 38, 48, 33, 23, 32, 33, 33, 58, 59 }, 85), _0x48d8d50b._0x55a0a350(new byte[5] { 187, 172, 186, 172, 189 }, 233), _0xd98f9f80._0x32adc7bd, _0x38306f56.Hazard, _0x38306f56.Cream, _0xeec56d36.Centre, new Vector2(330f, 0f), new Vector2(260f, 104f), 2.0f);
        _0xeec56d36.OnTap(_0x05014a9a, () => this._0xc0345965(true));
        this._0xfd8d245b = _0xeec56d36.Node(_0x484acba1, _0x48d8d50b._0x55a0a350(new byte[10] { 105, 69, 68, 76, 67, 88, 71, 120, 69, 93 }, 42), _0xeec56d36.Centre, new Vector2(0f, -300f), new Vector2(RowWidth, 220f));
        _0xeec56d36.Plate(this._0xfd8d245b, _0x48d8d50b._0x55a0a350(new byte[12] { 184, 148, 149, 157, 146, 137, 150, 171, 151, 154, 143, 158 }, 251), _0xd98f9f80._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.95f), _0xeec56d36.Centre, Vector2.zero, new Vector2(RowWidth, 220f), 2.2f);
        _0xeec56d36.Label(this._0xfd8d245b, _0x48d8d50b._0x55a0a350(new byte[11] { 20, 56, 57, 49, 62, 37, 58, 3, 50, 47, 35 }, 87), _0x48d8d50b._0x55a0a350(new byte[36] { 190, 169, 186, 168, 190, 219, 190, 173, 190, 169, 162, 219, 189, 190, 186, 175, 179, 190, 169, 215, 219, 171, 183, 174, 182, 190, 219, 186, 181, 191, 219, 169, 180, 186, 191, 196 }, 251), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, 56f), new Vector2(900f, 60f));
        Button _0xca0808bb = _0xeec56d36.Cta(this._0xfd8d245b, _0x48d8d50b._0x55a0a350(new byte[10] { 210, 254, 255, 247, 248, 227, 252, 200, 244, 226 }, 145), _0x48d8d50b._0x55a0a350(new byte[5] { 207, 216, 206, 216, 201 }, 157), _0xd98f9f80._0x32adc7bd, _0x38306f56.Hazard, _0x38306f56.Cream, _0xeec56d36.Centre, new Vector2(-190f, -44f), new Vector2(320f, 104f), 2.0f);
        Button _0x9c4b48db = _0xeec56d36.Cta(this._0xfd8d245b, _0x48d8d50b._0x55a0a350(new byte[9] { 119, 91, 90, 82, 93, 70, 89, 122, 91 }, 52), _0x48d8d50b._0x55a0a350(new byte[4] { 60, 50, 50, 39 }, 119), _0xd98f9f80._0x32adc7bd, _0x38306f56.Verge, _0x38306f56.Cream, _0xeec56d36.Centre, new Vector2(190f, -44f), new Vector2(320f, 104f), 2.0f);
        _0xeec56d36.OnTap(_0xca0808bb, () => this._0xb7775bc9());
        _0xeec56d36.OnTap(_0x9c4b48db, () => this._0xc0345965(false));
        this._0xfd8d245b.gameObject.SetActive(false);
        this._0x202eccab = _0xeec56d36.Label(_0x484acba1, _0x48d8d50b._0x55a0a350(new byte[9] { 193, 246, 224, 246, 231, 221, 252, 231, 246 }, 147), _0x48d8d50b._0x55a0a350(new byte[53] { 8, 9, 18, 14, 15, 8, 1, 102, 14, 3, 20, 3, 102, 5, 9, 21, 18, 21, 102, 11, 9, 8, 3, 31, 102, 107, 102, 1, 20, 7, 15, 8, 102, 15, 21, 102, 3, 7, 20, 8, 3, 2, 102, 4, 31, 102, 22, 10, 7, 31, 15, 8, 1 }, 70), _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Shade, TextAlignmentOptions.Center, _0xeec56d36.BottomCentre, new Vector2(0f, 180f), new Vector2(920f, 60f));
        this._0x35150f91.Add(this._0x202eccab);
        this._0x9314b354();
    }

    private readonly Image[] _0xfbab2b8c = new Image[RowCount];
    private void _0x0d7c98ae(Transform _0xeece62b4, _0xbe7aadff _0x947b5cad, int _0x463ed8e2, float _0x1dbfc7ae, string _0xae4e68f1, string _0xb9baae0d)
    {
        RectTransform _0xd31ef68d = _0xeec56d36.Row(_0xeece62b4, _0x48d8d50b._0x55a0a350(new byte[3] { 81, 108, 116 }, 3) + _0xae4e68f1, _0x947b5cad._0x556c658e, _0xeec56d36.Centre, new Vector2(0f, _0x1dbfc7ae), new Vector2(RowWidth, RowHeight));
        this._0xa7966a81.Add(_0xd31ef68d.GetComponentInChildren<Image>(true));
        float _0xa451162c = _0xeec56d36.TextColumnX(RowWidth, 520f);
        _0xeec56d36.Label(_0xd31ef68d, _0x48d8d50b._0x55a0a350(new byte[8] { 161, 156, 132, 167, 154, 135, 159, 150 }, 243), _0xae4e68f1, _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Cream, TextAlignmentOptions.Left, _0xeec56d36.Centre, new Vector2(_0xa451162c, 28f), new Vector2(520f, 56f));
        this._0x35150f91.Add(_0xeec56d36.Label(_0xd31ef68d, _0x48d8d50b._0x55a0a350(new byte[7] { 76, 113, 105, 80, 113, 106, 123 }, 30), _0xb9baae0d, _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Moss, TextAlignmentOptions.Left, _0xeec56d36.Centre, new Vector2(_0xa451162c, -30f), new Vector2(520f, 44f)));
        RectTransform _0x33a11726 = _0xeec56d36.Node(_0xd31ef68d, _0x48d8d50b._0x55a0a350(new byte[6] { 225, 197, 219, 198, 209, 218 }, 178), _0xeec56d36.Centre, new Vector2(350f, 0f), new Vector2(170f, 86f));
        this._0xfbab2b8c[_0x463ed8e2] = _0xeec56d36.Plate(_0x33a11726, _0x48d8d50b._0x55a0a350(new byte[5] { 17, 55, 36, 38, 46 }, 69), _0x947b5cad._0x556c658e, _0x38306f56.Asphalt, _0xeec56d36.Centre, Vector2.zero, new Vector2(170f, 86f), 1.2f);
        this._0xfd596c83[_0x463ed8e2] = _0xeec56d36.Plate(_0x33a11726, _0x48d8d50b._0x55a0a350(new byte[4] { 25, 60, 61, 48 }, 82), _0x947b5cad._0x556c658e, _0x38306f56.Cream, _0xeec56d36.Centre, new Vector2(-38f, 0f), new Vector2(66f, 66f), 1.0f).rectTransform;
        Image _0x1bcd6e2d = _0x33a11726.gameObject.AddComponent<Image>();
        _0x1bcd6e2d.color = new Color(1f, 1f, 1f, 0f);
        _0x1bcd6e2d.raycastTarget = true;
        Button _0x86a2f78d = _0x33a11726.gameObject.AddComponent<Button>();
        _0x86a2f78d.targetGraphic = _0x1bcd6e2d;
        _0x86a2f78d.transition = Selectable.Transition.None;
        int _0xd0ece7ad = _0x463ed8e2;
        _0xeec56d36.OnTap(_0x86a2f78d, () => this._0x1910c861(_0xd0ece7ad));
    }

    private const int RowCount = 3;
    private void _0xc0345965(bool _0x55eb3f33)
    {
        if (this._0xfd8d245b == null)
        {
            return;
        }

        this._0xfd8d245b.gameObject.SetActive(_0x55eb3f33);
        if (_0x55eb3f33)
        {
            this._0xfd8d245b.localScale = new Vector3(0.92f, 0.92f, 1f);
            this._0xfd8d245b.DOScale(1f, _0x4e4c58b8.SheetTime).SetEase(Ease.OutBack).SetLink(this._0xfd8d245b.gameObject);
        }
    }
}

internal static class _0x48d8d50b
{
    internal static string _0x55a0a350(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}