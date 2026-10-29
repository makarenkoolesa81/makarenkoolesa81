using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xc01143a0 : MonoBehaviour
{
    public Image ContentImage;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x594b87e1();
    }

    public TMP_Text ContentHeaderText;
    public static void HideAllPops()
    {
        _0x59b62125.Instance._0x1d7fd9f2();
    }

    public bool IsScaledDownOnAwake = true;
    public float scaleDuration = 0.4f;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public void _0xc5dd7810()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private bool _0xc0918884 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public bool IsOnlyYScale;
    public GameObject Content;
    private void _0x594b87e1()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public Ease ease = Ease.OutSine;
    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentMainText;
}