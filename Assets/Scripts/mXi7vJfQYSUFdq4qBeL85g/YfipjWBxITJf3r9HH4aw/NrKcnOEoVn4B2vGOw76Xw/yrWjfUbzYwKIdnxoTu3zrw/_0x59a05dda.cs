using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x59a05dda : MonoBehaviour
{
    private static bool _0x7a99cf38 = false;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x59a05dda>();
    }

    public static _0x59a05dda Instance;
    private Sequence _0x0626bd14;
    private void _0xdcff5753()
    {
        this.AnimationSlider.value = 0.05f;
        _0x7a99cf38 = !_0x7a99cf38;
        this._0x0626bd14 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x76127522 => this.AnimationSlider.value = _0x76127522, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x9cbda3d8._0x737a8a6e?._0x04d52e80();
        });
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xfc6e4613._0xef8a6460.SCENE_0 && !_0x7a99cf38)
        {
            this._0xdcff5753();
        }
        else
        {
            this._0xcff66648();
        }
    }

    public GameObject Error;
    public GameObject Background;
    public float FirstAnimationTime = 10.0f;
    public Slider AnimationSlider;
    public void _0xba9fcc6f()
    {
        this._0x0626bd14?.Kill();
        this.AnimationSlider.value = _0x7a99cf38 ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0xd789eee8()
    {
        this._0x0626bd14?.Pause();
    }

    public void _0xca4c77c8()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x0626bd14?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x7a99cf38 = false;
    }

    public GameObject Content;
    public void _0xcff66648()
    {
        this._0xba9fcc6f();
        bool _0xbf20d2bf = _0x7a99cf38;
        this._0x0626bd14 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x76127522 => this.AnimationSlider.value = _0x76127522, _0xbf20d2bf ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x7a99cf38 = !_0x7a99cf38;
    }

    public void _0xddbb75e6()
    {
        this._0x0626bd14?.Play();
    }

    public float SecondPassSliderValue = 0.5f;
    public float DefaultAnimationTime = 0.4f;
}