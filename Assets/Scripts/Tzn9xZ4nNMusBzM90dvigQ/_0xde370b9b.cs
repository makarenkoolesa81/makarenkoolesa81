using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Owns the menu scene. Everything it builds goes inside the template's OWN panels -
/// the splash body and PANELS.DEFAULT's Content - so there is no second canvas to
/// sort against the pops and the template's panel transitions still reveal it.
///
/// Set-up happens in Start, never Awake (C.59): the template fills its singletons in
/// Awake and a generated Awake would run in the same phase in an undefined order.
/// </summary>
public sealed class _0xde370b9b : MonoBehaviour
{
    private void _0x6590d1ee()
    {
        if (_0xfc6e4613._0xb58be4ea.DEFAULT >= _0x45a945dd.Instance.Panels.Count)
        {
            return;
        }

        _0x3afaca58 _0x5de3dcc2 = _0x45a945dd.Instance.Panels[_0xfc6e4613._0xb58be4ea.DEFAULT];
        if (_0x5de3dcc2 == null || _0x5de3dcc2.Content == null)
        {
            return;
        }

        Transform _0x34b4680c = _0x5de3dcc2.Content.transform;
        // The template's own scene-load button is the only Button in this Content
        // before we add ours, so this finds it WITHOUT relying on a name, and it is
        // the driver that identifies it (G.3 step 1). It stays the LAST sibling,
        // which is what draws it above the page we insert below it.
        Button _0xd8712bbf = _0x34b4680c.GetComponentInChildren<Button>(true);
        this._0x40d3bb1d = this.gameObject.AddComponent<_0x8e9e461f>();
        RectTransform _0xf6fbb66d = _0xeec56d36.Full(_0x34b4680c, _0xe5b7b015._0x1453748f(new byte[5] { 180, 133, 131, 129, 151 }, 228), 0f);
        _0xf6fbb66d.SetAsFirstSibling();
        _0xeec56d36.Backdrop(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[5] { 113, 94, 82, 91, 83 }, 55), this._art._0xfbb22ee9, Color.white);
        _0xeec56d36.PlateFull(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[9] { 174, 129, 141, 132, 140, 191, 137, 155, 128 }, 232), this._art._0x556c658e, _0x38306f56.Fade(_0x38306f56.NightField, 0.42f), 0f, 2.0f);
        RectTransform _0xafec8f07 = _0xeec56d36.Full(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[8] { 19, 34, 36, 38, 11, 44, 46, 38 }, 67), 0f);
        this._0x35d80816 = _0xafec8f07.gameObject.AddComponent<_0x4bc38880>();
        this._0x35d80816._0x22ffa2a9(this._art, this._0x40d3bb1d);
        this._0x40d3bb1d._0x3b65f6af(_0x8e9e461f.PageHome, _0xafec8f07, () => this._0x35d80816._0x6b3271b4());
        RectTransform _0x6aedfdf8 = _0xeec56d36.Full(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[5] { 252, 204, 221, 198, 194 }, 175), 0f);
        Image _0xf6cf4544 = _0x6aedfdf8.gameObject.AddComponent<Image>();
        _0xf6cf4544.sprite = this._art._0x556c658e;
        _0xf6cf4544.type = Image.Type.Sliced;
        _0xf6cf4544.color = _0x38306f56.Fade(_0x38306f56.Ink, 0.72f);
        _0xf6cf4544.raycastTarget = true;
        this._0x40d3bb1d._0xe66b464f(_0x6aedfdf8);
        RectTransform _0xc8d27a07 = _0xeec56d36.Full(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[9] { 4, 53, 51, 49, 28, 59, 35, 0, 59 }, 84), 0f);
        _0x26ab846d _0x87304dd8 = _0xc8d27a07.gameObject.AddComponent<_0x26ab846d>();
        _0x87304dd8._0xb22b97b8(this._art, this._0x40d3bb1d);
        this._0x40d3bb1d._0x3b65f6af(_0x8e9e461f.PageHowTo, _0xc8d27a07, () => _0x87304dd8._0xa059bf5a());
        RectTransform _0x1952779a = _0xeec56d36.Full(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[9] { 186, 139, 141, 143, 174, 139, 131, 134, 147 }, 234), 0f);
        _0xa0981bee _0x016f303f = _0x1952779a.gameObject.AddComponent<_0xa0981bee>();
        _0x016f303f._0xd14d49f3(this._art, this._0x40d3bb1d);
        this._0x40d3bb1d._0x3b65f6af(_0x8e9e461f.PageDaily, _0x1952779a, () => _0x016f303f._0xa7bd6559());
        RectTransform _0x4399b7a5 = _0xeec56d36.Full(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[12] { 159, 174, 168, 170, 130, 166, 188, 188, 166, 160, 161, 188 }, 207), 0f);
        _0x21a5800d _0x400258eb = _0x4399b7a5.gameObject.AddComponent<_0x21a5800d>();
        _0x400258eb._0x075fe2df(this._art, this._0x40d3bb1d);
        this._0x40d3bb1d._0x3b65f6af(_0x8e9e461f.PageMissions, _0x4399b7a5, () => _0x400258eb._0xcdf56a57());
        RectTransform _0x2d75ac6f = _0xeec56d36.Full(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[11] { 52, 5, 3, 1, 54, 1, 19, 5, 22, 0, 23 }, 100), 0f);
        _0x1fc8d4e6 _0x8dcfdbe1 = _0x2d75ac6f.gameObject.AddComponent<_0x1fc8d4e6>();
        _0x8dcfdbe1._0xe6214539(this._art, this._0x40d3bb1d);
        this._0x40d3bb1d._0x3b65f6af(_0x8e9e461f.PageRewards, _0x2d75ac6f, () => _0x8dcfdbe1._0xebf256cd());
        RectTransform _0xed6bdd74 = _0xeec56d36.Full(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[11] { 18, 35, 37, 39, 18, 48, 45, 36, 43, 46, 39 }, 66), 0f);
        _0x08ca6747 _0x9a8101f1 = _0xed6bdd74.gameObject.AddComponent<_0x08ca6747>();
        _0x9a8101f1._0x5801ab42(this._art, this._0x40d3bb1d);
        this._0x40d3bb1d._0x3b65f6af(_0x8e9e461f.PageProfile, _0xed6bdd74, () => _0x9a8101f1._0xcd08efd8());
        RectTransform _0xe56f28d2 = _0xeec56d36.Full(_0xf6fbb66d, _0xe5b7b015._0x1453748f(new byte[12] { 249, 200, 206, 204, 250, 204, 221, 221, 192, 199, 206, 218 }, 169), 0f);
        _0xcfb390b8 _0x64b75402 = _0xe56f28d2.gameObject.AddComponent<_0xcfb390b8>();
        _0x64b75402._0x7411c22a(this._art, this._0x40d3bb1d);
        this._0x40d3bb1d._0x3b65f6af(_0x8e9e461f.PageSettings, _0xe56f28d2, () => _0x64b75402._0x9314b354());
        this._0x94c3d88d(_0xd8712bbf, _0x34b4680c);
        this._0x40d3bb1d.PageChanged += (_0xc8d1cc6e) => this._0xd108b0da(_0xc8d1cc6e);
        _0xb887263f _0x0e5aef80 = this.gameObject.AddComponent<_0xb887263f>();
        _0x0e5aef80._0xf4ff8e99();
        _0x3a1c44b1.EnsureToday();
        this._0x40d3bb1d.Show(_0x8e9e461f.PageHome);
        {
#if B_LOGS
            {
                Debug.Log($"[menu] built pages={_0x8e9e461f.PageCount} grain={_0xfd5cbc90._0x1ec9c5ae} level={_0xfd5cbc90._0xb3b99d41}");
            }
#endif
        }
    }

    private _0x4bc38880 _0x35d80816;
    [SerializeField]
    private _0xbe7aadff _art;
    private void _0x6d7c7bca()
    {
        if (_0xfc6e4613._0xb58be4ea.SPLASH >= _0x45a945dd.Instance.Panels.Count)
        {
            return;
        }

        _0x3afaca58 _0x6d281b94 = _0x45a945dd.Instance.Panels[_0xfc6e4613._0xb58be4ea.SPLASH];
        if (_0x6d281b94 == null || _0x6d281b94.Content == null)
        {
            return;
        }

        _0xb30c23fd _0xa827919b = _0x6d281b94.gameObject.AddComponent<_0xb30c23fd>();
        _0xa827919b._0x6101bb53(this._art, _0x6d281b94.Content.transform);
    }

    private void Start()
    {
        if (this._art == null || _0x45a945dd.Instance == null)
        {
            return;
        }

        this._0x6d7c7bca();
        this._0x6590d1ee();
    }

    private _0x8e9e461f _0x40d3bb1d;
    private Button _0x9ba42dd4;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private TextMeshProUGUI _0xf92f41cd;
    /// <summary>
    /// The PLAY button, sized EXPLICITLY (G.3). The template ships it with stretching
    /// anchors 0 .. 0.93 and sizeDelta 0x0, which is a slab across the whole menu; the
    /// anchors are collapsed to a point and the size written in canvas pixels of the
    /// 1242 x 2688 reference resolution - 760 x 172, i.e. 0.61 of the reference width
    /// and 0.064 of its height, far under the 0.25 ceiling.
    ///
    /// Every layer the EMPTY variant could draw is tinted away first: those Images
    /// ship with no sprite, and a sprite-less Image is a solid rectangle. The face is
    /// then drawn as the button's OWN children with raycastTarget off, so the tap
    /// still reaches the template Button and its LoadSceneButton driver underneath.
    /// </summary>
    private void _0x94c3d88d(Button _0x9ed4ea8d, Transform _0x3fd2c8da)
    {
        if (_0x9ed4ea8d == null)
        {
            return;
        }

        RectTransform _0x838dcdd1 = (RectTransform)_0x9ed4ea8d.transform;
        _0x838dcdd1.anchorMin = new Vector2(0.5f, 0.345f);
        _0x838dcdd1.anchorMax = new Vector2(0.5f, 0.345f);
        _0x838dcdd1.pivot = _0xeec56d36.Centre;
        _0x838dcdd1.anchoredPosition = Vector2.zero;
        _0x838dcdd1.sizeDelta = new Vector2(760f, 172f);
        Image[] _0x547a17dd = _0x9ed4ea8d.GetComponentsInChildren<Image>(true);
        for (int _0x9a198ca0 = 0; _0x9a198ca0 < _0x547a17dd.Length; _0x9a198ca0++)
        {
            if (_0x547a17dd[_0x9a198ca0] != null && _0x547a17dd[_0x9a198ca0].sprite == null)
            {
                _0x547a17dd[_0x9a198ca0].color = new Color(1f, 1f, 1f, 0f);
            }
        }

        _0xeec56d36.Plate(_0x838dcdd1, _0xe5b7b015._0x1453748f(new byte[10] { 160, 156, 145, 137, 163, 152, 145, 148, 159, 135 }, 240), this._art._0x556c658e, _0x38306f56.Fade(_0x38306f56.Ink, 0.45f), _0xeec56d36.Centre, new Vector2(0f, -10f), new Vector2(772f, 178f), 2.0f);
        _0xeec56d36.Plate(_0x838dcdd1, _0xe5b7b015._0x1453748f(new byte[8] { 69, 121, 116, 108, 83, 116, 118, 112 }, 21), this._art._0x32adc7bd, _0x38306f56.Hazard, _0xeec56d36.Centre, Vector2.zero, new Vector2(760f, 172f), 2.2f);
        _0xeec56d36.Plate(_0x838dcdd1, _0xe5b7b015._0x1453748f(new byte[12] { 62, 2, 15, 23, 58, 1, 30, 34, 7, 9, 6, 26 }, 110), this._art._0x556c658e, _0x38306f56.Fade(_0x38306f56.HazardLight, 0.55f), _0xeec56d36.Centre, new Vector2(0f, 46f), new Vector2(716f, 56f), 2.0f);
        _0xeec56d36.Plate(_0x838dcdd1, _0xe5b7b015._0x1453748f(new byte[7] { 135, 187, 182, 174, 133, 190, 186 }, 215), this._art._0x556c658e, _0x38306f56.Fade(_0x38306f56.Sprout, 0.45f), _0xeec56d36.Centre, Vector2.zero, new Vector2(760f, 172f), 2.6f);
        _0xeec56d36.Label(_0x838dcdd1, _0xe5b7b015._0x1453748f(new byte[11] { 20, 40, 37, 61, 7, 37, 52, 48, 45, 43, 42 }, 68), _0xe5b7b015._0x1453748f(new byte[4] { 5, 25, 20, 12 }, 85), _0x4e4c58b8.CtaMax, _0x4e4c58b8.CtaMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.Centre, Vector2.zero, new Vector2(620f, 108f));
        // The hint sits ABOVE the button, never under it: a plate or a shadow would
        // swallow half of a caption placed below (rule 19 of the shared layout rules).
        this._0x9ba42dd4 = _0x9ed4ea8d;
        this._0xf92f41cd = _0xeec56d36.Label(_0x3fd2c8da, _0xe5b7b015._0x1453748f(new byte[8] { 177, 141, 128, 152, 169, 136, 143, 149 }, 225), _0xe5b7b015._0x1453748f(new byte[24] { 174, 175, 164, 193, 181, 160, 177, 193, 178, 164, 175, 165, 178, 193, 169, 164, 179, 193, 160, 162, 179, 174, 178, 178 }, 225), _0x4e4c58b8.CaptionMax, _0x4e4c58b8.CaptionMin, _0x38306f56.Moss, TextAlignmentOptions.Center, new Vector2(0.5f, 0.345f), new Vector2(0f, 122f), new Vector2(900f, 52f));
        _0x9ed4ea8d.onClick.AddListener(() => this._0xba2c0fc6());
    }

    private void _0xba2c0fc6()
    {
        _0xfd5cbc90._0xc633c5a1 = false;
        _0xfd5cbc90.Flush();
        _0xeec56d36.Press(this._0x9ba42dd4 != null ? this._0x9ba42dd4.transform : this.transform);
    }

    /// <summary>PLAY belongs to Home; no sheet shares its slot.</summary>
    private void _0xd108b0da(int _0xfc4593c4)
    {
        bool _0x8782c865 = _0xfc4593c4 == _0x8e9e461f.PageHome;
        if (this._0x9ba42dd4 != null)
        {
            this._0x9ba42dd4.gameObject.SetActive(_0x8782c865);
        }

        if (this._0xf92f41cd != null)
        {
            this._0xf92f41cd.gameObject.SetActive(_0x8782c865);
        }

        if (_0x8782c865 && this._0x35d80816 != null)
        {
            this._0x35d80816._0x6b3271b4();
        }
    }
}

internal static class _0xe5b7b015
{
    internal static string _0x1453748f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}