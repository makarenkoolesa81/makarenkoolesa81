using DG.Tweening;
using UnityEngine;

/// <summary>
/// Owns the game scene. Builds the splash branding and the HUD inside the template's
/// OWN panels, raises the road in world space, and starts the run.
///
/// Set-up happens in Start, never Awake (C.59): the template fills BasicController,
/// PanelController and PopsController in Awake, and a generated Awake would race them.
/// </summary>
public sealed class _0x77f10bfb : MonoBehaviour
{
    [SerializeField]
    private GameObject _lanePrefabRoad;
    [SerializeField]
    private GameObject _vehicleTruckPrefab;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    [SerializeField]
    private GameObject _lanePrefabVerge;
    private void _0xc89e59d2()
    {
        if (_0xfc6e4613._0xb58be4ea.DEFAULT >= _0x45a945dd.Instance.Panels.Count)
        {
            return;
        }

        _0x3afaca58 _0x01141009 = _0x45a945dd.Instance.Panels[_0xfc6e4613._0xb58be4ea.DEFAULT];
        if (_0x01141009 == null || _0x01141009.Content == null)
        {
            return;
        }

        Camera _0x2b5acf04 = Camera.main;
        _0xaae7a264 _0x6ec062fa = new _0xaae7a264()._0x808b11fb(_0x2b5acf04);
        // --- world: the road scrolls under a hen that keeps her row ------------------
        GameObject _0xaf2efa37 = new GameObject(_0x29924fa4._0x9be80c88(new byte[9] { 127, 66, 76, 73, 122, 66, 95, 65, 73 }, 45));
        _0xaf2efa37.transform.SetParent(this.transform, false);
        GameObject _0x425d5048 = new GameObject(_0x29924fa4._0x9be80c88(new byte[8] { 235, 214, 216, 221, 235, 214, 206, 202 }, 185));
        _0x425d5048.transform.SetParent(_0xaf2efa37.transform, false);
        _0x1f14bf52 _0x3dd37427 = null;
        if (this._henPrefab != null)
        {
            GameObject _0x2f027867 = Instantiate(this._henPrefab, _0xaf2efa37.transform);
            _0x3dd37427 = _0x2f027867.GetComponent<_0x1f14bf52>();
            if (_0x3dd37427 == null)
            {
                _0x3dd37427 = _0x2f027867.AddComponent<_0x1f14bf52>();
            }

            _0x3dd37427._0xf6c0e799(_0x6ec062fa, this._art._0x36dc6826, _0x38306f56.Plume(_0xfd5cbc90._0x5c438be4));
        }

        // --- UI: our own HUD as the FIRST sibling of the panel body, so it never sits
        //     on top of the template chrome, and none of it is slipped into a template
        //     placeholder (C.2) -------------------------------------------------------
        RectTransform _0xb04c8c41 = _0xeec56d36.Full(_0x01141009.Content.transform, _0x29924fa4._0x9be80c88(new byte[9] { 204, 241, 255, 250, 205, 234, 255, 249, 251 }, 158), 0f);
        _0xb04c8c41.SetAsFirstSibling();
        _0xe0ca158f _0x28f34c80 = _0xb04c8c41.gameObject.AddComponent<_0xe0ca158f>();
        _0xa06b42c3 _0x3e71d6ef = this.gameObject.AddComponent<_0xa06b42c3>();
        _0x3e71d6ef._0x5cfc67ec(this._art);
        _0x21f276c9 _0x75594a96 = this.gameObject.AddComponent<_0x21f276c9>();
        _0xa20d578b _0x68cf52a0 = this.gameObject.AddComponent<_0xa20d578b>();
        int _0x46b8d8ef = _0xfd5cbc90._0xc633c5a1 ? _0x4e4c58b8.DailyStretchGoal : _0x4e4c58b8.StretchGoal;
        _0x28f34c80._0x550266a1(this._art, _0x46b8d8ef, () => this._0x8375a24a(), () => this._0xc0724da8());
        _0x75594a96._0xc1f908ff(_0x28f34c80._0x31031ac5(), _0x2b5acf04, this._dustPrefab, _0xaf2efa37.transform, _0x38306f56.Trail(_0xfd5cbc90._0xb769a538), _0x6ec062fa._0xcae9c9c5 * 0.5f);
        GameObject[] _0x1994ad2f = new GameObject[]
        {
            this._vehicleTruckPrefab,
            this._vehicleCartPrefab,
            this._vehicleHayPrefab
        };
        this._0x68f643ef = _0xaf2efa37.AddComponent<_0xf578798d>();
        this._0x68f643ef._0x4d8cf9b2(this._art, _0x6ec062fa, _0x425d5048.transform, _0x3dd37427, _0x28f34c80, _0x3e71d6ef, _0x75594a96, _0x68cf52a0, this._lanePrefabRoad, this._lanePrefabVerge, _0x1994ad2f, this._featherPrefab, this._signpostPrefab, this._chevronPrefab);
        _0xb887263f _0xedde1471 = this.gameObject.AddComponent<_0xb887263f>();
        _0xedde1471._0xf4ff8e99();
        {
#if B_LOGS
            {
                Debug.Log($"[game] built laneH={_0x6ec062fa._0xcae9c9c5} colW={_0x6ec062fa._0x8d061558} goal={_0x46b8d8ef}");
            }
#endif
        }
    }

    [SerializeField]
    private GameObject _featherPrefab;
    private void _0x35a5cfdf()
    {
        if (_0xfc6e4613._0xb58be4ea.SPLASH >= _0x45a945dd.Instance.Panels.Count)
        {
            return;
        }

        _0x3afaca58 _0x69bb6ebb = _0x45a945dd.Instance.Panels[_0xfc6e4613._0xb58be4ea.SPLASH];
        if (_0x69bb6ebb == null || _0x69bb6ebb.Content == null)
        {
            return;
        }

        _0xb30c23fd _0xf9d65255 = _0x69bb6ebb.gameObject.AddComponent<_0xb30c23fd>();
        _0xf9d65255._0x6101bb53(this._art, _0x69bb6ebb.Content.transform);
    }

    [SerializeField]
    private GameObject _vehicleHayPrefab;
    [SerializeField]
    private GameObject _henPrefab;
    private _0xf578798d _0x68f643ef;
    private void Start()
    {
        if (this._art == null || _0x45a945dd.Instance == null)
        {
            return;
        }

        this._0x35a5cfdf();
        this._0xc89e59d2();
    }

    [SerializeField]
    private GameObject _vehicleCartPrefab;
    [SerializeField]
    private GameObject _dustPrefab;
    private void _0xc0724da8()
    {
        if (this._0x68f643ef != null)
        {
            this._0x68f643ef._0x4f838dff();
        }
    }

    [SerializeField]
    private GameObject _signpostPrefab;
    [SerializeField]
    private _0xbe7aadff _art;
    [SerializeField]
    private GameObject _chevronPrefab;
    private void _0x8375a24a()
    {
        if (_0xf2da7f44.Instance != null)
        {
            _0xf2da7f44.Instance._0xa80559a1(_0xfc6e4613._0xef8a6460.SCENE_0);
        }
    }
}

internal static class _0x29924fa4
{
    internal static string _0x9be80c88(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}