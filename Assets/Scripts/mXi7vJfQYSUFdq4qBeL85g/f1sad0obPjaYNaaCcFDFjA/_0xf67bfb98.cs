using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xf67bfb98 : MonoBehaviour
{
    public List<Button> PauseButtons = new();
    public List<TMP_Text> ScoreText = new();
    public void _0xf90c02a3(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x1a2ea140();
            this._0x4593da5d();
        }
    }

    private void Awake()
    {
        _0x9a020f3e = this.gameObject.GetComponent<_0xf67bfb98>();
    }

    public void _0xd94d7eb9()
    {
        if (_0x1a907722.Instance.IsOnlyWinGameEndEnabled)
            this._0xecc42c74();
        if (!this.IsGameEnd)
        {
            this._0xdb2ed114();
            _0xf2da7f44.IsAfterLevelComplete = false;
            _0xf2da7f44.IsAfterLevelFailed = true;
            _0xc01143a0 _0x272f2bbf = _0x59b62125.Instance._0xb8b1da85(_0xfc6e4613._0xba356ec3.LOSE).GetComponent<_0xc01143a0>();
            if (_0x1a907722.Instance.IsCheckScoreEnabled)
                _0x272f2bbf.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb4bebd85}";
            else
                _0x272f2bbf.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x272f2bbf.ContentAdditionalText.text = $"{0}";
            _0xfc6e4613._0xa4ebc6f7._0xa37f5e02 += 0;
            _0x59b62125.Instance._0x3315eb73(_0xfc6e4613._0xba356ec3.LOSE);
        }
    }

    public int CustomTimeInitial = 30;
    public List<TMP_Text> SubtitleText = new();
    [HideInInspector]
    public int TimeLeft;
    [HideInInspector]
    public int ScoreCurrent;
    private void _0x4593da5d()
    {
        if (this.ScoreCurrent > _0xf2da7f44._0x8a6de4c1._0x0087184c)
            _0xf2da7f44._0x8a6de4c1._0x0087184c = this.ScoreCurrent;
        if (_0x1a907722.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xb4bebd85)
                this._0xecc42c74();
    }

    private int _0x31e5f749 => this.ScoreCurrent;
    private int _0xb4bebd85 => this.CustomTargetScore + _0xf2da7f44._0x8a6de4c1._0x43d8e806 * 10;

    private IEnumerator _0xf928e547()
    {
        this._0xcd30b0c8();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xf2da7f44.Instance._0xe8d59afe == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xf2da7f44.Instance._0x5d7fe3e2)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xcd30b0c8();
            }
        }

        if (!this.IsGameEnd)
            this._0xd94d7eb9();
    }

    public List<TMP_Text> LevelNumberText = new();
    private void _0xefdff105()
    {
        if (this.ScoreCurrent >= this._0xb4bebd85)
            this._0xecc42c74();
        else
            this._0xd94d7eb9();
    }

    [HideInInspector]
    public int CurrentGameIndex;
    [HideInInspector]
    public bool IsGameEnd;
    private void _0xcd30b0c8()
    {
        this.TimerText.ForEach(_0x5c418de0 => _0x5c418de0.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x6e3bef48._0x6dd5064f(new byte[6] { 245, 245, 196, 162, 235, 235 }, 152)));
    }

    public int CustomTargetScore = 10;
    public void _0xecc42c74()
    {
        if (!this.IsGameEnd)
        {
            this._0xdb2ed114();
            _0xf2da7f44.IsAfterLevelComplete = true;
            _0xf2da7f44.IsAfterLevelFailed = false;
            _0xc01143a0 _0x15469d0c = _0x59b62125.Instance._0xb8b1da85(_0xfc6e4613._0xba356ec3.WIN).GetComponent<_0xc01143a0>();
            if (_0x1a907722.Instance.IsCheckScoreEnabled)
                _0x15469d0c.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb4bebd85}";
            else
                _0x15469d0c.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x1a907722.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xfc6e4613._0xa4ebc6f7._0xa37f5e02)
                    _0xfc6e4613._0xa4ebc6f7._0xa37f5e02 = this.ScoreCurrent;
                _0x15469d0c.ContentAdditionalText.text = $"{_0xfc6e4613._0xa4ebc6f7._0xa37f5e02}";
            }
            else
            {
                _0x15469d0c.ContentAdditionalText.text = $"{this._0x31e5f749}";
                _0xfc6e4613._0xa4ebc6f7._0xa37f5e02 += this._0x31e5f749;
            }

            if (_0x1a907722.Instance.IsLevelIncrementOnWin)
                ++_0xf2da7f44._0x8a6de4c1._0x43d8e806;
            _0x59b62125.Instance._0x3315eb73(_0xfc6e4613._0xba356ec3.WIN);
        }
    }

    public void _0x95a76af7()
    {
        _0xf2da7f44.Instance._0xcf9b15ef(true);
        _0xf2da7f44.Instance._0xa80559a1(_0xfc6e4613._0xef8a6460.SCENE_0);
    }

    private void _0xdb2ed114()
    {
        this.IsGameEnd = true;
        _0xf2da7f44.IsAfterLevelComplete = true;
    }

    private void _0x1a2ea140()
    {
        if (_0x1a907722.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x5c418de0 => _0x5c418de0.text = $"{this.ScoreCurrent}/{this._0xb4bebd85}");
        else
            this.ScoreText.ForEach(_0x5c418de0 => _0x5c418de0.text = $"{this.ScoreCurrent}");
    }

    private static _0xf67bfb98 _0x9a020f3e;
    private int _0xf65d4460 => this.CustomTimeInitial + _0xf2da7f44._0x8a6de4c1._0x43d8e806 * 10;

    public List<Button> HomeButtons = new();
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xf65d4460;
        this.CurrentGameIndex = _0xf2da7f44.Instance._0xe8d59afe;
        foreach (Button _0x89e88005 in this.HomeButtons)
            _0x89e88005.onClick.AddListener(() =>
            {
                this._0x95a76af7();
            });
        foreach (Button _0x0d2c7807 in this.PauseButtons)
            _0x0d2c7807.onClick.AddListener(() =>
            {
                _0xf2da7f44.Instance._0xcf9b15ef(false);
                _0x59b62125.Instance._0x3315eb73(_0xfc6e4613._0xba356ec3.PAUSE);
            });
        this._0x1a2ea140();
        this.LevelNumberText.ForEach(_0x5c418de0 => _0x5c418de0.text = $"LVL {_0xf2da7f44._0x8a6de4c1._0x43d8e806 + 1}");
        if (_0x1a907722.Instance.IsTimerEnabled)
        {
            this._0xcd30b0c8();
            this.StartCoroutine(this._0xf928e547());
        }
    }

    public List<TMP_Text> TimerText = new();
}

internal static class _0x6e3bef48
{
    internal static string _0x6dd5064f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}