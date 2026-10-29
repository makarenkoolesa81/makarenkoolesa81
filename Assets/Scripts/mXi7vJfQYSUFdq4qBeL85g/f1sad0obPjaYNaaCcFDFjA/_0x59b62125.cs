using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xfc6e4613;

public class _0x59b62125 : MonoBehaviour
{
    public void _0x7c18637c()
    {
        this.LastPopIndexes.RemoveAll(_0x9bfc47f2 => _0x9bfc47f2 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x1d7fd9f2();
        else
            this._0x3315eb73(this.LastPopIndexes.Last());
    }

    private void _0x34d34f34()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public static _0x59b62125 Instance;
    public List<GameObject> GameObjectsToHide;
    public List<int> LastPopIndexes = new();
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public int CurrentPopIndex;
    public void _0x1d7fd9f2()
    {
        this.LastPopIndexes.Clear();
        this._0xd235b55c();
        foreach (GameObject _0xf7d07e0c in this.GameObjectsToHide)
            if (_0xf7d07e0c != null)
                _0xf7d07e0c.SetActive(true);
        this._0xf48a3962();
    }

    private void _0xf48a3962()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x59b62125>();
    }

    private void _0xd235b55c(bool _0x7c8fd2ab = false)
    {
        for (int _0x9807dc15 = 0; _0x9807dc15 < this.Pops.Count; ++_0x9807dc15)
            if (this.Pops[_0x9807dc15] != null && !(_0x9807dc15 == this.CurrentPopIndex && _0x7c8fd2ab))
                this.Pops[_0x9807dc15]._0xc5dd7810();
    }

    public GameObject BlurBackground;
    public _0xc01143a0 _0xb8b1da85(int _0xdde90969)
    {
        return this.Pops[_0xdde90969];
    }

    public List<_0xc01143a0> Pops;
    public void _0x3315eb73(int _0xbfcad9f6)
    {
        this.CurrentPopIndex = _0xbfcad9f6;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xd235b55c(true);
        this._0x34d34f34();
        this.Pops[_0xbfcad9f6].Show();
        foreach (GameObject _0x251bb9e6 in this.GameObjectsToHide)
            _0x251bb9e6.SetActive(false);
    }

    public float ScaleDuration = 0.4f;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xc01143a0 _0x62112850 in this.Pops)
            if (_0x62112850 != null)
                _0x62112850.gameObject.SetActive(true);
    }
}