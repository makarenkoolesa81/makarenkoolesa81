using TMPro;
using UnityEngine;
using static _0xfc6e4613;

public class _0x2ec05818 : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0x13a213c1()
    {
        this.MoneyCountText.text = _0xa4ebc6f7._0xa37f5e02.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x41db6a69;
            if (this.gameObject.TryGetComponent(out _0x41db6a69))
                this.MoneyCountText = _0x41db6a69;
        }

        this._0x13a213c1();
    }
}