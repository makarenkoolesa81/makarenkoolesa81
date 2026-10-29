using UnityEngine;
using UnityEngine.UI;

public class _0xc578268b : MonoBehaviour
{
    private Button _0x75589f4b;
    private void Awake()
    {
        if (this._0x75589f4b == null)
            if (!this.TryGetComponent(out this._0x75589f4b))
                this._0x75589f4b = this.GetComponentInChildren<Button>();
    }

    private bool _0x62b30391;
    private int _0x29260124;
    private void Start()
    {
        if (this._0x62b30391)
            this._0x75589f4b.onClick.AddListener(() => _0x45a945dd.Instance._0xdec8743e());
        else
            this._0x75589f4b.onClick.AddListener(() => _0x45a945dd.Instance._0xfe15666b(this._0x29260124));
    }
}