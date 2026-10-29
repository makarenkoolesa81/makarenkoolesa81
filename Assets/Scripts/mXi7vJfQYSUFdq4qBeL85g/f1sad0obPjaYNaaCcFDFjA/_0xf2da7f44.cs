using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xfc6e4613;

public class _0xf2da7f44 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf2da7f44>();
        this.RootGameObject = GameObject.FindWithTag(_0xd4a4e30b._0x661e2603(new byte[4] { 131, 190, 190, 165 }, 209));
        if (this._0xe8d59afe == _0xef8a6460.SCENE_0)
            this._0xcf9b15ef(true);
        else
            this._0xcf9b15ef(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x2ec05818>(true).ToList();
    }

    public static _0xf2da7f44 Instance;
    private static _0x41ebf98d GAME_INDEX_SETTINGS(int _0x8b243e34)
    {
        return _0x41ebf98d.ALL_SCENES_SETTING_SINGLETONS[_0x8b243e34];
    }

    private void _0x2a8b2ea9()
    {
        IsAfterLevelComplete = true;
        Instance._0xa80559a1(_0xef8a6460.SCENE_0);
    }

    public static bool IsAfterLevelComplete;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0xcf9b15ef(bool _0xfa061b4b)
    {
        this._0x5d7fe3e2 = _0xfa061b4b;
        this._0xca1802ca(!this._0x5d7fe3e2);
        Physics2D.simulationMode = this._0x5d7fe3e2 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xcdfd8c65(this.EnvironmentWithTweensToToggle);
    }

    public Transform Environment;
    public void _0x29264a2e()
    {
        foreach (_0x2ec05818 _0x2292e6a8 in this.MoneyCountContainers)
            _0x2292e6a8._0x13a213c1();
    }

    private static _0x41ebf98d _0xf3807dfe => _0x41ebf98d.ALL_SCENES_SETTING_SINGLETONS[0];

    private IEnumerator _0x182e3ed5(string _0xbafdd131)
    {
        _0x45a945dd.Instance._0xfe15666b(_0xb58be4ea.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x515f31f2 = SceneManager.LoadSceneAsync(_0xbafdd131);
        while (!_0x515f31f2.isDone)
            yield return null;
    }

    public Transform EnvironmentWithTweensToToggle;
    private void Start()
    {
        if (this._0xe8d59afe != _0xef8a6460.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0xa80559a1(_0xef8a6460.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x8a6de4c1._0xf6a2dee2 = false;
            _0x59b62125.Instance._0x1d7fd9f2();
            _0x45a945dd.Instance._0xfe15666b(_0xb58be4ea.TUTORIAL0);
        });
    }

    private static void MakeGrid(List<RectTransform> _0x3529c3af, AspectRatioFitter _0x3c5e80eb, float _0x6ed1dbf6, int _0xcad9f4d5, int _0x99174a79)
    {
        _0x3c5e80eb.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x3c5e80eb.aspectRatio = _0x6ed1dbf6;
        foreach (RectTransform _0x8ce1fffb in _0x3529c3af)
        {
            int _0xd8692342 = _0x8ce1fffb.transform.GetSiblingIndex();
            _0x8ce1fffb.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xd8692342 % _0xcad9f4d5) * (1f / _0xcad9f4d5), (_0x99174a79 - (Mathf.FloorToInt((float)_0xd8692342 / _0xcad9f4d5) % _0x99174a79 + 1f)) * (1f / _0x99174a79));
            _0x8ce1fffb.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xd8692342 % _0xcad9f4d5 + 1f) * (1f / _0xcad9f4d5), (_0x99174a79 - Mathf.FloorToInt((float)_0xd8692342 / _0xcad9f4d5) % _0x99174a79) * (1f / _0x99174a79));
            _0x8ce1fffb.offsetMin = Vector2.zero;
            _0x8ce1fffb.offsetMax = Vector2.zero;
        }
    }

    public bool _0x5d7fe3e2 { get; private set; }

    private IEnumerator _0x563ee726(int _0xd6e70689)
    {
        _0x45a945dd.Instance._0xfe15666b(_0xb58be4ea.SPLASH);
        AsyncOperation _0x74d62fe1 = SceneManager.LoadSceneAsync(_0xd6e70689);
        while (!_0x74d62fe1.isDone)
            yield return null;
    }

    [HideInInspector]
    public List<_0x2ec05818> MoneyCountContainers = new();
    public int _0xe8d59afe => SceneManager.GetActiveScene().buildIndex;

    public Canvas MainCanvas;
    public static _0x41ebf98d _0x8a6de4c1 => _0x41ebf98d.ALL_SCENES_SETTING_SINGLETONS[Instance._0xe8d59afe];

    private void _0xcdfd8c65(Transform _0xa2c03648)
    {
        Transform[] _0x4c899673 = _0xa2c03648.GetComponentsInChildren<Transform>();
        foreach (Transform _0xd94688c6 in _0x4c899673)
            if (_0xd94688c6 != null && DOTween.IsTweening(_0xd94688c6))
            {
                if (this._0x5d7fe3e2)
                    DOTween.Play(_0xd94688c6);
                else
                    DOTween.Pause(_0xd94688c6);
            }
    }

    private void _0xca1802ca(bool _0x3da83753)
    {
        Rigidbody2D[] _0x02bfc4cf = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x0698197c in _0x02bfc4cf)
            if (_0x3da83753)
                _0x0698197c.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x0698197c.constraints = RigidbodyConstraints2D.None;
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static bool IsAfterLevelFailed = false;
    public void _0x86c3e67a()
    {
        _0x8a6de4c1._0xf6a2dee2 = true;
    }

    public void _0x0fe2f51b()
    {
        this._0xa80559a1(SceneManager.GetActiveScene().buildIndex);
    }

    public void _0xa80559a1(int _0xebff6741)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x563ee726(_0xebff6741));
    }

    public Button ShowResetTutorialButton;
    public Button DeleteProgressDataButton;
}

internal static class _0xd4a4e30b
{
    internal static string _0x661e2603(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}