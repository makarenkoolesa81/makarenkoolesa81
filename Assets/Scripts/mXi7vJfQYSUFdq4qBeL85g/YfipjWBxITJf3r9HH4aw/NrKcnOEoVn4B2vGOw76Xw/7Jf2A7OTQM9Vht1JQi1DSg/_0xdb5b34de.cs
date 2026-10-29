using UnityEngine;
using UnityEngine.UI;

public class _0xdb5b34de : MonoBehaviour
{
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x59b62125.Instance._0x7c18637c();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x59b62125.Instance._0x1d7fd9f2());
        else
            this.Button.onClick.AddListener(() => _0x59b62125.Instance._0x3315eb73(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    public bool IsHideAllPops;
    public bool IsShowLastPop;
}