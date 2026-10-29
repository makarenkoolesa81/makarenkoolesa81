using UnityEngine;
using UnityEngine.UI;

public class _0x241fafb5 : MonoBehaviour
{
    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xf2da7f44.Instance._0xcf9b15ef(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}