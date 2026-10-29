using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xfc6e4613;

public class _0x45a945dd : MonoBehaviour
{
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x63941f6f()
    {
        this._0xc7a93832(_0xb58be4ea.SPLASH);
        if (_0xf2da7f44.Instance._0xe8d59afe == _0xef8a6460.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x59a05dda.Instance.DefaultAnimationTime);
        }
    }

    public static _0x45a945dd Instance;
    public List<_0x3afaca58> Panels;
    public float ScaleDuration = 0.4f;
    private void _0x1991bfff(int _0x930fc33e)
    {
        this.LastPanelIndexes.Add(_0x930fc33e);
        this.CurrentPanelIndex = _0x930fc33e;
        for (int _0x985c2e56 = 0; _0x985c2e56 < this.Panels.Count; _0x985c2e56++)
            if (_0x985c2e56 != _0x930fc33e && this.Panels[_0x985c2e56] != null)
                this.Panels[_0x985c2e56]._0x0d77e59e();
    }

    public void _0x30748692(int _0xa5f8bb15)
    {
        if (_0xa5f8bb15 == _0xb58be4ea.SPLASH && _0xf2da7f44.Instance._0xe8d59afe != _0xef8a6460.SCENE_0)
            _0x59a05dda.Instance._0xcff66648();
        if (_0xf2da7f44.Instance._0xe8d59afe != _0xef8a6460.SCENE_0)
        {
            if (_0xa5f8bb15 == _0xb58be4ea.SPLASH || _0xa5f8bb15 == _0xb58be4ea.TUTORIAL0)
                _0xf2da7f44.Instance._0xcf9b15ef(false);
            else if (_0xa5f8bb15 == _0xb58be4ea.DEFAULT)
                _0xf2da7f44.Instance._0xcf9b15ef(true);
        }
    }

    public int CurrentPanelIndex;
    private void _0xde6a415c(int _0xe1ca39e6)
    {
        this.LastPanelIndexes.Add(_0xe1ca39e6);
        this.CurrentPanelIndex = _0xe1ca39e6;
        for (int _0xc5293eba = 0; _0xc5293eba < this.Panels.Count; _0xc5293eba++)
            if (_0xc5293eba != _0xe1ca39e6 && this.Panels[_0xc5293eba] != null)
                this.Panels[_0xc5293eba]._0x0d77e59e();
    }

    public void _0xfe15666b(int _0xc6241da8)
    {
        this._0x1991bfff(_0xc6241da8);
        this._0xddfdccb2(_0xc6241da8);
        this.CurrentPanelIndex = _0xc6241da8;
        this.Panels[_0xc6241da8].Show();
    }

    private void _0xc7a93832(int _0xcfa4181e)
    {
        this._0x1991bfff(_0xcfa4181e);
        this._0xddfdccb2(_0xcfa4181e);
        this.CurrentPanelIndex = _0xcfa4181e;
        this.Panels[_0xcfa4181e]._0x28639d48();
    }

    public float StaticBlurMaterialInitialValue;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x45a945dd>();
    }

    private void Start()
    {
        this._0x63941f6f();
    }

    public bool IsShowSplashOnStart = true;
    public void _0xdec8743e()
    {
        this.LastPanelIndexes.RemoveAll(_0x9bfc47f2 => _0x9bfc47f2 == this.CurrentPanelIndex);
        int _0x6de0b854 = this.LastPanelIndexes.Last();
        this._0xddfdccb2(_0x6de0b854);
        this._0xde6a415c(_0x6de0b854);
        this.CurrentPanelIndex = _0x6de0b854;
        this.Panels[_0x6de0b854].Show();
    }

    private void _0xddfdccb2(int _0xd6ed5e1d)
    {
        if (_0xd6ed5e1d == _0xb58be4ea.SPLASH)
            _0x59a05dda.Instance._0xba9fcc6f();
        if (_0xf2da7f44.Instance._0xe8d59afe == _0xef8a6460.SCENE_0)
        {
        }
    }

    private _0x3afaca58 _0x77a5e5e1(int _0x39215b3e)
    {
        return this.Panels[_0x39215b3e];
    }

    private void SwitchSplash()
    {
        if (_0x1a907722.Instance.IsTutorialEnabled && !_0xf2da7f44._0x8a6de4c1._0xf6a2dee2)
            this._0xfe15666b(_0xb58be4ea.TUTORIAL0);
        else
            this._0xfe15666b(_0xb58be4ea.DEFAULT);
    }
}