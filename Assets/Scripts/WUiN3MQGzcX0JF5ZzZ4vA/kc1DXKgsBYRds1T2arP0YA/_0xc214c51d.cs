using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xc214c51d : MonoBehaviour
{
    private void _0x61007a56()
    {
        if (this._0xe98fcddf.canvasRenderer.GetColor() != this._0xdc4bd20c.canvasRenderer.GetColor())
            this._0xdc4bd20c.canvasRenderer.SetColor(this._0xe98fcddf.canvasRenderer.GetColor());
    }

    private TMP_Text _0xdc4bd20c;
    private Image _0xe98fcddf;
    private void Update()
    {
        this._0x61007a56();
    }
}