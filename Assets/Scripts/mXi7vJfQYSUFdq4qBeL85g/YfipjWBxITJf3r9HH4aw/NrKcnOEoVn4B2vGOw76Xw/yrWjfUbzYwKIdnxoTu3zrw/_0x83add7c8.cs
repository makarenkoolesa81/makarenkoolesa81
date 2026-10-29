using UnityEngine;
using UnityEngine.UI;

public class _0x83add7c8 : MonoBehaviour
{
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x45a945dd.Instance._0xfe15666b(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xf2da7f44.Instance._0x86c3e67a());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x45a945dd.Instance._0xfe15666b(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x45a945dd.Instance._0xfe15666b(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xf2da7f44.Instance._0x86c3e67a());
        }
    }

    public Button TutorialEndButton;
}