using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The only way this game builds UI. Everything is uGUI on the template's OWN canvases,
/// so there is no second canvas to sort against the pops (C.13 draw order) and no world
/// sprite that could climb above them.
///
/// Draw order is sibling order: callers create backdrop -> frame -> content -> label,
/// in that order, so a plate never covers its own caption and a frame never covers what
/// it frames (C.63).
/// </summary>
public static class _0xeec56d36
{
    public static readonly Vector2 BottomCentre = new Vector2(0.5f, 0f);
    /// <summary>
    /// The shared sheet frame: one geometry for all six overlays, so the review tap
    /// coordinates are the same on every one of them. Shadow -> body -> rim -> title
    /// -> close cross, in that order. Returns the body rect the page fills; the close
    /// cross is handed back through the out parameter so the caller wires it.
    /// </summary>
    public static RectTransform Sheet(Transform _0x91f6d83d, Sprite _0xb4fa0fb6, Sprite _0x068c5977, string _0x46b8ed2d, out Button _0xdd245d66)
    {
        RectTransform _0x27e95b2c = Node(_0x91f6d83d, _0x5bcb3532._0xdc22a854(new byte[9] { 139, 176, 189, 189, 172, 138, 183, 183, 172 }, 216), Centre, Vector2.zero, new Vector2(1100f, 1700f));
        Plate(_0x27e95b2c, _0x5bcb3532._0xdc22a854(new byte[11] { 48, 11, 6, 6, 23, 48, 11, 2, 7, 12, 20 }, 99), _0xb4fa0fb6, _0x38306f56.Fade(_0x38306f56.Ink, 0.45f), Centre, new Vector2(0f, -16f), new Vector2(1116f, 1716f), 2.2f);
        Plate(_0x27e95b2c, _0x5bcb3532._0xdc22a854(new byte[9] { 152, 163, 174, 174, 191, 137, 164, 175, 178 }, 203), _0xb4fa0fb6, _0x38306f56.Verge, Centre, Vector2.zero, new Vector2(1100f, 1700f), 2.2f);
        Plate(_0x27e95b2c, _0x5bcb3532._0xdc22a854(new byte[9] { 194, 249, 244, 244, 229, 198, 240, 226, 249 }, 145), _0xb4fa0fb6, _0x38306f56.Fade(_0x38306f56.FieldShade, 0.75f), Centre, new Vector2(0f, -340f), new Vector2(1076f, 1000f), 2.4f);
        Plate(_0x27e95b2c, _0x5bcb3532._0xdc22a854(new byte[8] { 238, 213, 216, 216, 201, 239, 212, 208 }, 189), _0xb4fa0fb6, _0x38306f56.Fade(_0x38306f56.Sprout, 0.40f), Centre, Vector2.zero, new Vector2(1100f, 1700f), 2.6f);
        Label(_0x27e95b2c, _0x5bcb3532._0xdc22a854(new byte[10] { 20, 47, 34, 34, 51, 19, 46, 51, 43, 34 }, 71), _0x46b8ed2d, _0x4e4c58b8.TitleMax, _0x4e4c58b8.TitleMin, _0x38306f56.Cream, TextAlignmentOptions.Left, TopLeft, new Vector2(400f, -118f), new Vector2(700f, 76f));
        _0xdd245d66 = IconButton(_0x27e95b2c, _0x5bcb3532._0xdc22a854(new byte[10] { 50, 9, 4, 4, 21, 34, 13, 14, 18, 4 }, 97), _0xb4fa0fb6, _0x068c5977, _0x38306f56.Asphalt, _0x38306f56.Cream, TopRight, new Vector2(-72f, -72f), 96f, 1.5f);
        return _0x27e95b2c;
    }

    /// <summary>The indicator gutter centre, in a row's own local coordinates.</summary>
    public static float GutterX(float _0x29c94ae6)
    {
        return -_0x29c94ae6 * 0.5f + 96f;
    }

    /// <summary>An empty rect on a POINT anchor - never a stretch (G.3).</summary>
    public static RectTransform Node(Transform _0x17c5603c, string _0x6c0c2e6c, Vector2 _0xbbb7b9f7, Vector2 _0x1f4ba53a, Vector2 _0xe3f9f171)
    {
        GameObject _0x9a7309fa = new GameObject(_0x6c0c2e6c, typeof(RectTransform));
        _0x9a7309fa.layer = _0x17c5603c != null ? _0x17c5603c.gameObject.layer : 5;
        RectTransform _0x1935c541 = _0x9a7309fa.GetComponent<RectTransform>();
        _0x1935c541.SetParent(_0x17c5603c, false);
        _0x1935c541.anchorMin = _0xbbb7b9f7;
        _0x1935c541.anchorMax = _0xbbb7b9f7;
        _0x1935c541.pivot = Centre;
        _0x1935c541.anchoredPosition = _0x1f4ba53a;
        _0x1935c541.sizeDelta = _0xe3f9f171;
        _0x1935c541.localScale = Vector3.one;
        return _0x1935c541;
    }

    public static readonly Vector2 Centre = new Vector2(0.5f, 0.5f);
    /// <summary>Counts a number up so a change is visible on a frame, not instantaneous.</summary>
    public static void CountTo(TMP_Text _0xc1568584, int _0x8cd0fdfb, int _0x0e816bc2, string _0x83af25b7)
    {
        if (_0xc1568584 == null)
        {
            return;
        }

        int _0xaf852b9c = _0x8cd0fdfb;
        DOTween.To(() => _0xaf852b9c, _0x9bfc47f2 =>
        {
            _0xaf852b9c = _0x9bfc47f2;
            _0xa09f3022.SetText(_0xc1568584, _0x4e4c58b8.Grouped(_0xaf852b9c) + _0x83af25b7);
        }, _0x0e816bc2, _0x4e4c58b8.CountUp).SetEase(Ease.OutCubic).SetLink(_0xc1568584.gameObject);
    }

    public static readonly Vector2 TopRight = new Vector2(1f, 1f);
    public static readonly Vector2 Stretch0 = new Vector2(0f, 0f);
    /// <summary>
    /// A themed button: plate -> caption, caption LAST so it draws on top (E.1).
    /// No decorative icon: an ornament that cannot be aligned exactly is worse than a
    /// clean caption, and the primary CTA carries none by design.
    /// </summary>
    public static Button Cta(Transform _0xbc75b558, string _0xd2fd3bea, string _0xff6f2412, Sprite _0x4ebc5c02, Color _0x05d391aa, Color _0x7e43dfdd, Vector2 _0x379831f0, Vector2 _0x5fb733eb, Vector2 _0xb77874a8, float _0xd62f98dd)
    {
        RectTransform _0x8627e288 = Node(_0xbc75b558, _0xd2fd3bea, _0x379831f0, _0x5fb733eb, _0xb77874a8);
        Image _0xf8740e1d = _0x8627e288.gameObject.AddComponent<Image>();
        _0xf8740e1d.sprite = _0x4ebc5c02;
        _0xf8740e1d.type = Image.Type.Sliced;
        _0xf8740e1d.pixelsPerUnitMultiplier = _0xd62f98dd;
        _0xf8740e1d.color = _0x05d391aa;
        _0xf8740e1d.raycastTarget = true;
        Button _0xa3102019 = AttachButton(_0x8627e288.gameObject, _0xf8740e1d);
        Label(_0x8627e288, _0x5bcb3532._0xdc22a854(new byte[7] { 71, 101, 116, 112, 109, 107, 106 }, 4), _0xff6f2412, _0x4e4c58b8.ButtonMax, _0x4e4c58b8.ButtonMin, _0x7e43dfdd, TextAlignmentOptions.Center, Centre, Vector2.zero, new Vector2(_0xb77874a8.x - 48f, _0xb77874a8.y * 0.62f));
        return _0xa3102019;
    }

    /// <summary>A plate stretched over its parent (a backdrop wash or a scrim).</summary>
    public static Image PlateFull(Transform _0x52045b6e, string _0x7f1e88bf, Sprite _0x443530b4, Color _0x23bcb55b, float _0xee886421, float _0x81191830)
    {
        RectTransform _0x6ed1e24d = Full(_0x52045b6e, _0x7f1e88bf, _0xee886421);
        Image _0x16cca4cb = _0x6ed1e24d.gameObject.AddComponent<Image>();
        _0x16cca4cb.sprite = _0x443530b4;
        _0x16cca4cb.type = Image.Type.Sliced;
        _0x16cca4cb.pixelsPerUnitMultiplier = _0x81191830;
        _0x16cca4cb.color = _0x23bcb55b;
        _0x16cca4cb.raycastTarget = false;
        return _0x16cca4cb;
    }

    /// <summary>
    /// Generated art drawn at its OWN proportions (F.2a). The second side is never
    /// typed by hand: preserveAspect keeps whatever the PNG really is, so no sprite
    /// arrives as an egg.
    /// </summary>
    public static Image Picture(Transform _0x40a5ac39, string _0xbb6c8bc3, Sprite _0xa4f71e85, Color _0x3319101d, Vector2 _0xfffb87f3, Vector2 _0x4dfb51f0, Vector2 _0x33cfdd40)
    {
        RectTransform _0x1fc05325 = Node(_0x40a5ac39, _0xbb6c8bc3, _0xfffb87f3, _0x4dfb51f0, _0x33cfdd40);
        Image _0x41736b5c = _0x1fc05325.gameObject.AddComponent<Image>();
        _0x41736b5c.sprite = _0xa4f71e85;
        _0x41736b5c.type = Image.Type.Simple;
        _0x41736b5c.preserveAspect = true;
        _0x41736b5c.color = _0x3319101d;
        _0x41736b5c.raycastTarget = false;
        return _0x41736b5c;
    }

    /// <summary>Sets a bar built by Bar() to a 0..1 amount, immediately.</summary>
    public static void SetBar(Image _0xdbc85c70, float _0xc33a7674)
    {
        if (_0xdbc85c70 == null)
        {
            return;
        }

        RectTransform _0xf8fd6bd4 = _0xdbc85c70.rectTransform;
        RectTransform _0xab8ab646 = _0xf8fd6bd4.parent as RectTransform;
        float _0xdd2e9734 = _0xab8ab646 != null ? _0xab8ab646.rect.width - 8f : _0xf8fd6bd4.rect.width;
        _0xf8fd6bd4.sizeDelta = new Vector2(_0xdd2e9734 * Mathf.Clamp01(_0xc33a7674), _0xf8fd6bd4.sizeDelta.y);
    }

    public static readonly Vector2 TopCentre = new Vector2(0.5f, 1f);
    /// <summary>
    /// A horizontal progress bar: track plate, then the fill. The fill is a 9-SLICED
    /// plate whose width is driven by its right anchor, not a Filled image: stretching
    /// is the whole purpose of a bar, so it is one of the cases where preserveAspect
    /// would be wrong, and 9-slice keeps the rounded ends at every length (F.2a).
    /// Returns the fill; drive it with SetBar / TweenBar.
    /// </summary>
    public static Image Bar(Transform _0xe5f90858, string _0x685321a5, Sprite _0x81a04468, Color _0xb9a9d3c4, Color _0x00732538, Vector2 _0xac8e37cc, Vector2 _0xa1da9b33, Vector2 _0x9170763e, float _0x6aec31cc)
    {
        RectTransform _0x7b0152dd = Node(_0xe5f90858, _0x685321a5, _0xac8e37cc, _0xa1da9b33, _0x9170763e);
        Image _0x7787fb5d = _0x7b0152dd.gameObject.AddComponent<Image>();
        _0x7787fb5d.sprite = _0x81a04468;
        _0x7787fb5d.type = Image.Type.Sliced;
        _0x7787fb5d.pixelsPerUnitMultiplier = _0x6aec31cc;
        _0x7787fb5d.color = _0xb9a9d3c4;
        _0x7787fb5d.raycastTarget = false;
        RectTransform _0x6d4b7cad = Full(_0x7b0152dd, _0x5bcb3532._0xdc22a854(new byte[4] { 120, 87, 82, 82 }, 62), 4f);
        _0x6d4b7cad.anchorMin = new Vector2(0f, 0f);
        _0x6d4b7cad.anchorMax = new Vector2(0f, 1f);
        _0x6d4b7cad.pivot = new Vector2(0f, 0.5f);
        _0x6d4b7cad.offsetMin = new Vector2(4f, 4f);
        _0x6d4b7cad.offsetMax = new Vector2(4f, -4f);
        _0x6d4b7cad.sizeDelta = new Vector2(0f, -8f);
        Image _0x35123a33 = _0x6d4b7cad.gameObject.AddComponent<Image>();
        _0x35123a33.sprite = _0x81a04468;
        _0x35123a33.type = Image.Type.Sliced;
        _0x35123a33.pixelsPerUnitMultiplier = _0x6aec31cc;
        _0x35123a33.color = _0x00732538;
        _0x35123a33.raycastTarget = false;
        return _0x35123a33;
    }

    /// <summary>
    /// A themed row plate with an indicator gutter and a text column that NEVER share
    /// an x-band (C.25). The gutter is centred on x=96 with a width of 72, so the text
    /// column starts at 96 + 36 + 46 = 178 from the row's left edge.
    /// </summary>
    public static RectTransform Row(Transform _0xd4bebd89, string _0x41b165a6, Sprite _0xba5c60bb, Vector2 _0xac4768c3, Vector2 _0xd943efe9, Vector2 _0xf2adeda6)
    {
        RectTransform _0x6074fff7 = Node(_0xd4bebd89, _0x41b165a6, _0xac4768c3, _0xd943efe9, _0xf2adeda6);
        Plate(_0x6074fff7, _0x5bcb3532._0xdc22a854(new byte[8] { 141, 176, 168, 143, 179, 190, 171, 186 }, 223), _0xba5c60bb, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.85f), Centre, Vector2.zero, _0xf2adeda6, 2.2f);
        return _0x6074fff7;
    }

    /// <summary>A rect stretched to its parent, optionally inset on all sides.</summary>
    public static RectTransform Full(Transform _0x2fd061ca, string _0x20997673, float _0xe38bc501)
    {
        GameObject _0x943ab872 = new GameObject(_0x20997673, typeof(RectTransform));
        _0x943ab872.layer = _0x2fd061ca != null ? _0x2fd061ca.gameObject.layer : 5;
        RectTransform _0x971ac151 = _0x943ab872.GetComponent<RectTransform>();
        _0x971ac151.SetParent(_0x2fd061ca, false);
        _0x971ac151.anchorMin = Stretch0;
        _0x971ac151.anchorMax = Stretch1;
        _0x971ac151.pivot = Centre;
        _0x971ac151.anchoredPosition = Vector2.zero;
        _0x971ac151.sizeDelta = new Vector2(-_0xe38bc501 * 2f, -_0xe38bc501 * 2f);
        _0x971ac151.localScale = Vector3.one;
        return _0x971ac151;
    }

    /// <summary>The text column centre for a row, clear of the gutter by 46 px.</summary>
    public static float TextColumnX(float _0xd2c7b135, float _0x756d0785)
    {
        return -_0xd2c7b135 * 0.5f + 178f + _0x756d0785 * 0.5f;
    }

    /// <summary>A full-bleed backdrop. The one place preserveAspect is wrong: it must cover.</summary>
    public static Image Backdrop(Transform _0xd5ce879b, string _0xeb08dbaa, Sprite _0x5833588b, Color _0x630e4631)
    {
        RectTransform _0x8aa2b124 = Full(_0xd5ce879b, _0xeb08dbaa, 0f);
        Image _0xfae4e312 = _0x8aa2b124.gameObject.AddComponent<Image>();
        _0xfae4e312.sprite = _0x5833588b;
        _0xfae4e312.type = Image.Type.Simple;
        _0xfae4e312.preserveAspect = false;
        _0xfae4e312.color = _0x630e4631;
        _0xfae4e312.raycastTarget = false;
        return _0xfae4e312;
    }

    /// <summary>Scale feedback on press, so a tap is visible on a screenshot (C.7).</summary>
    public static void Press(Transform _0xfe94ce5f)
    {
        if (_0xfe94ce5f == null)
        {
            return;
        }

        _0xfe94ce5f.DOKill(false);
        _0xfe94ce5f.localScale = Vector3.one;
        _0xfe94ce5f.DOScale(_0x4e4c58b8.PressScale, _0x4e4c58b8.PressTime).SetEase(Ease.OutQuad).SetLoops(2, LoopType.Yoyo).SetLink(_0xfe94ce5f.gameObject);
    }

    public static TextMeshProUGUI Label(Transform _0x17772b0f, string _0x7b1d0510, string _0x18aeb18e, float _0x09e55d8c, float _0xc8678696, Color _0x355aaee4, TextAlignmentOptions _0x36ed2e19, Vector2 _0x83128532, Vector2 _0xcdc29414, Vector2 _0x8d4f67ec)
    {
        RectTransform _0x52c9b348 = Node(_0x17772b0f, _0x7b1d0510, _0x83128532, _0xcdc29414, _0x8d4f67ec);
        TextMeshProUGUI _0x068fd078 = _0x52c9b348.gameObject.AddComponent<TextMeshProUGUI>();
        _0xa09f3022.Apply(_0x068fd078, _0x355aaee4, _0x09e55d8c, _0xc8678696);
        _0x068fd078.alignment = _0x36ed2e19;
        _0xa09f3022.SetText(_0x068fd078, _0x18aeb18e);
        return _0x068fd078;
    }

    /// <summary>
    /// A 9-sliced tinted surface. The ppu argument is the corner-radius lever: lower is
    /// rounder. Sliced is the whole point of these plates, so they deliberately do NOT
    /// preserve aspect (F.2a lists stretchable plates as the exception).
    /// </summary>
    public static Image Plate(Transform _0x86baa0c4, string _0xb91262d6, Sprite _0x860b7b84, Color _0x2099f716, Vector2 _0x71ef4012, Vector2 _0x299c0d50, Vector2 _0x34b0a437, float _0x80131cfd)
    {
        RectTransform _0x254ff8c2 = Node(_0x86baa0c4, _0xb91262d6, _0x71ef4012, _0x299c0d50, _0x34b0a437);
        Image _0xd738c6ed = _0x254ff8c2.gameObject.AddComponent<Image>();
        _0xd738c6ed.sprite = _0x860b7b84;
        _0xd738c6ed.type = Image.Type.Sliced;
        _0xd738c6ed.pixelsPerUnitMultiplier = _0x80131cfd;
        _0xd738c6ed.color = _0x2099f716;
        _0xd738c6ed.raycastTarget = false;
        return _0xd738c6ed;
    }

    /// <summary>
    /// Wires a button and gives it its press feedback in one place. ALWAYS a lambda,
    /// never a method group: Plana renames the declaration and leaves a bare reference
    /// behind, which fails the cloud build with CS1061 (C.1).
    /// </summary>
    public static void OnTap(Button _0x6c732b05, Action _0xb0779767)
    {
        if (_0x6c732b05 == null)
        {
            return;
        }

        _0x6c732b05.onClick.AddListener(() => Press(_0x6c732b05.transform));
        if (_0xb0779767 != null)
        {
            _0x6c732b05.onClick.AddListener(() => _0xb0779767());
        }
    }

    private static Button AttachButton(GameObject _0xc254a164, Image _0x485bf84a)
    {
        Button _0x75b5cd05 = _0xc254a164.AddComponent<Button>();
        _0x75b5cd05.targetGraphic = _0x485bf84a;
        _0x75b5cd05.transition = Selectable.Transition.ColorTint;
        ColorBlock _0x4bcc191d = _0x75b5cd05.colors;
        _0x4bcc191d.normalColor = Color.white;
        _0x4bcc191d.highlightedColor = Color.white;
        _0x4bcc191d.pressedColor = new Color(0.80f, 0.80f, 0.80f, 1f);
        _0x4bcc191d.selectedColor = Color.white;
        _0x4bcc191d.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.75f);
        _0x4bcc191d.fadeDuration = 0.08f;
        _0x75b5cd05.colors = _0x4bcc191d;
        return _0x75b5cd05;
    }

    /// <summary>Tweens a bar built by Bar() to a 0..1 amount.</summary>
    public static void TweenBar(Image _0x1d8d3a06, float _0x86c45d7e, float _0x7173e7d0)
    {
        if (_0x1d8d3a06 == null)
        {
            return;
        }

        RectTransform _0x8662e352 = _0x1d8d3a06.rectTransform;
        RectTransform _0xf472caba = _0x8662e352.parent as RectTransform;
        float _0x4bcd3ab9 = _0xf472caba != null ? _0xf472caba.rect.width - 8f : _0x8662e352.rect.width;
        float _0x1f019a03 = _0x4bcd3ab9 * Mathf.Clamp01(_0x86c45d7e);
        _0x8662e352.DOKill(false);
        _0x8662e352.DOSizeDelta(new Vector2(_0x1f019a03, _0x8662e352.sizeDelta.y), _0x7173e7d0).SetEase(Ease.OutCubic).SetLink(_0x8662e352.gameObject);
    }

    public static readonly Vector2 TopLeft = new Vector2(0f, 1f);
    /// <summary>
    /// The themed message a list shows when it has no rows. Never an empty area: a
    /// blank page reads as a bug, not as an empty state.
    /// </summary>
    public static TextMeshProUGUI EmptyState(Transform _0xb7afa1e8, string _0x36aeeeff)
    {
        return Label(_0xb7afa1e8, _0x5bcb3532._0xdc22a854(new byte[10] { 56, 16, 13, 9, 4, 46, 9, 28, 9, 24 }, 125), _0x36aeeeff, _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Moss, TextAlignmentOptions.Center, Centre, new Vector2(0f, -60f), new Vector2(880f, 180f));
    }

    /// <summary>Enabled / disabled look for a button whose action is not available yet.</summary>
    public static void SetEnabled(Button _0xfeed1023, Image _0x018e7e38, TMP_Text _0xb5273302, bool _0xfdb602f1, Color _0x1bd8a170, Color _0x3eebce78, Color _0x785ef8e5, Color _0x748cd6e7)
    {
        if (_0xfeed1023 != null)
        {
            _0xfeed1023.interactable = _0xfdb602f1;
        }

        if (_0x018e7e38 != null)
        {
            _0x018e7e38.color = _0xfdb602f1 ? _0x1bd8a170 : _0x3eebce78;
        }

        if (_0xb5273302 != null)
        {
            _0xb5273302.color = _0xfdb602f1 ? _0x785ef8e5 : _0x748cd6e7;
        }
    }

    /// <summary>A round, caption-less button: plate first, glyph on top and centred.</summary>
    public static Button IconButton(Transform _0x7b379a07, string _0xa786af83, Sprite _0x98296f1b, Sprite _0xfdd00851, Color _0xd3ac8a9d, Color _0x1a42d4e4, Vector2 _0x581482e1, Vector2 _0x32255a0b, float _0xb011d558, float _0x9e255974)
    {
        RectTransform _0xa3521b36 = Node(_0x7b379a07, _0xa786af83, _0x581482e1, _0x32255a0b, new Vector2(_0xb011d558, _0xb011d558));
        Image _0xf3301e30 = _0xa3521b36.gameObject.AddComponent<Image>();
        _0xf3301e30.sprite = _0x98296f1b;
        _0xf3301e30.type = Image.Type.Sliced;
        _0xf3301e30.pixelsPerUnitMultiplier = _0x9e255974;
        _0xf3301e30.color = _0xd3ac8a9d;
        _0xf3301e30.raycastTarget = true;
        Button _0x3217c609 = AttachButton(_0xa3521b36.gameObject, _0xf3301e30);
        Picture(_0xa3521b36, _0x5bcb3532._0xdc22a854(new byte[5] { 191, 148, 129, 136, 144 }, 248), _0xfdd00851, _0x1a42d4e4, Centre, Vector2.zero, new Vector2(_0xb011d558 * 0.50f, _0xb011d558 * 0.50f));
        return _0x3217c609;
    }

    public static readonly Vector2 Stretch1 = new Vector2(1f, 1f);
}

internal static class _0x5bcb3532
{
    internal static string _0xdc22a854(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}