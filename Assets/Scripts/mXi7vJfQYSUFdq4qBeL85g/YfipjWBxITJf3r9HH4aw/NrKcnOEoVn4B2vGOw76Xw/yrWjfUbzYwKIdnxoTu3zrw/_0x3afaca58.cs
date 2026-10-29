using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x3afaca58 : MonoBehaviour
{
    public float ScaleDuration = 0.4f;
    private bool _0x2a79da9a => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0xa4652054()
    {
        if (this.OuterBackground != null)
        {
            Image _0x5f41e965 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x5f41e965, true);
            _0x5f41e965.DOFade(1f, 0f);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xc3fcc7af();
    }

    public void _0x0d77e59e()
    {
        this._0x36e2fb96();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public bool IsScaledDownOnAwake = true;
    public void Show()
    {
        this._0xd8eb26de();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x45a945dd.Instance._0x30748692(_0x45a945dd.Instance.CurrentPanelIndex);
            });
        }
    }

    public Ease Ease = Ease.OutSine;
    private void _0x36e2fb96()
    {
        if (this.OuterBackground != null)
        {
            Image _0x5b51f5d4 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x5b51f5d4, true);
            _0x5b51f5d4.DOFade(0f, this.ScaleDuration);
        }
    }

    public void _0x28639d48()
    {
        this._0xa4652054();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x45a945dd.Instance._0x30748692(_0x45a945dd.Instance.CurrentPanelIndex);
    }

    public GameObject Content;
    private void _0xc3fcc7af()
    {
        if (this.OuterBackground != null)
        {
            Image _0x98062e38 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x98062e38, true);
            _0x98062e38.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void _0xd8eb26de()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd54a3659 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd54a3659, true);
            _0xd54a3659.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public TMP_Text HeaderText;
    public TMP_Text MainText;
    public GameObject OuterBackground;
}