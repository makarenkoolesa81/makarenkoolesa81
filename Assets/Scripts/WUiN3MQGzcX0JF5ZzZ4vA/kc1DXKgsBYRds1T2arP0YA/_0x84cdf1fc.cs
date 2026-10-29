using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x84cdf1fc : MonoBehaviour
{
    private float _0x6dedae8d = 0.6f;
    private List<string> _0x4673f61a = new();
    private float _0xbd33feab = 1.5f;
    private float _0x48808c51 = 4;
    private void Update()
    {
        int _0x855db2d8 = 1;
        if (this._0x4673f61a.Count > 0)
        {
            string _0x11f8bbc2 = this._0x5df9f1af.text;
            foreach (string _0xfc953df9 in this._0x4673f61a)
                while (_0x11f8bbc2.Contains(_0xfc953df9))
                    _0x11f8bbc2 = _0x11f8bbc2.Replace(_0xfc953df9, "");
            _0x855db2d8 = _0x11f8bbc2.Length;
        }
        else
        {
            _0x855db2d8 = this._0x5df9f1af.text.Length;
        }

        float _0x70cfb740 = Mathf.Clamp(this._0xd813ca74 + this._0x6dedae8d * _0x855db2d8, this._0xbd33feab, this._0x48808c51);
        if (!Mathf.Approximately(this._0x19f9d5a3.aspectRatio, _0x70cfb740))
            this._0x19f9d5a3.aspectRatio = _0x70cfb740;
    }

    private float _0xd813ca74;
    private AspectRatioFitter _0x19f9d5a3;
    private TMP_Text _0x5df9f1af;
}