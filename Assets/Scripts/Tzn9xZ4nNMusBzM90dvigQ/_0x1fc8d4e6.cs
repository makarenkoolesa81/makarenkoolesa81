using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// REWARDS. A three-slot crate track filled by completed missions, and a CLAIM button
/// that unlocks the next plume.
///
/// Claiming is VISIBLY confirmed (C.7), never by a label change alone: the crate slot
/// punches, its tint flips to the accent, the newly unlocked plume swatch lights up in
/// the row below and the grain total counts up.
/// </summary>
public sealed class _0x1fc8d4e6 : MonoBehaviour
{
    private void OnDestroy()
    {
        for (int _0x758ac17c = 0; _0x758ac17c < this._0x77c57fbb.Length; _0x758ac17c++)
        {
            if (this._0x77c57fbb[_0x758ac17c] != null)
            {
                DOTween.Kill(this._0x77c57fbb[_0x758ac17c].transform);
            }
        }

        for (int _0xf1796281 = 0; _0xf1796281 < this._0x1e58b1c0.Length; _0xf1796281++)
        {
            if (this._0x1e58b1c0[_0xf1796281] != null)
            {
                DOTween.Kill(this._0x1e58b1c0[_0xf1796281].transform);
            }
        }
    }

    private void _0x319f8bd4()
    {
        if (_0xfd5cbc90._0x9d9233c1 <= 0)
        {
            return;
        }

        int _0x6ea9fea2 = _0xfd5cbc90._0x9d9233c1 - 1;
        int _0xd35aedca = _0xfd5cbc90.NextLockedPlume();
        _0xfd5cbc90._0x9d9233c1 = _0xfd5cbc90._0x9d9233c1 - 1;
        int _0x6a278352 = _0xfd5cbc90._0x1ec9c5ae;
        _0xfd5cbc90._0x1ec9c5ae = _0x6a278352 + 40;
        if (_0xd35aedca >= 0)
        {
            _0xfd5cbc90.UnlockPlume(_0xd35aedca);
        }

        _0xfd5cbc90.Flush();
        if (_0x6ea9fea2 >= 0 && _0x6ea9fea2 < this._0x77c57fbb.Length && this._0x77c57fbb[_0x6ea9fea2] != null)
        {
            Transform _0xd6e95f9a = this._0x77c57fbb[_0x6ea9fea2].transform;
            _0xd6e95f9a.DOKill(false);
            _0xd6e95f9a.localScale = Vector3.one;
            _0xd6e95f9a.DOPunchScale(Vector3.one * 0.12f, 0.35f, 8, 0.8f).SetLink(_0xd6e95f9a.gameObject);
        }

        if (_0xd35aedca >= 0 && _0xd35aedca < this._0x1e58b1c0.Length && this._0x1e58b1c0[_0xd35aedca] != null)
        {
            Transform _0x938028a7 = this._0x1e58b1c0[_0xd35aedca].transform;
            _0x938028a7.DOKill(false);
            _0x938028a7.localScale = Vector3.one;
            _0x938028a7.DOPunchScale(Vector3.one * 0.18f, 0.4f, 8, 0.8f).SetLink(_0x938028a7.gameObject);
        }

        _0xeec56d36.CountTo(this._0xa8f84f31, _0x6a278352, _0xfd5cbc90._0x1ec9c5ae, _0x8696a319._0xe7b49aac(new byte[6] { 41, 78, 91, 72, 64, 71 }, 9));
        _0xfd5cbc90.Buzz();
        this._0xebf256cd();
    }

    public void _0xe6214539(_0xbe7aadff _0x8b5733fb, _0x8e9e461f _0x62e2af4d)
    {
        Button _0xeabbb191;
        RectTransform _0xc917d196 = _0xeec56d36.Sheet(this.transform, _0x8b5733fb._0x556c658e, _0x8b5733fb._0x696c8fb6, _0x8696a319._0xe7b49aac(new byte[7] { 2, 21, 7, 17, 2, 20, 3 }, 80), out _0xeabbb191);
        _0xeec56d36.OnTap(_0xeabbb191, () => _0x62e2af4d._0xd40a8cf9());
        for (int _0x3413a2e8 = 0; _0x3413a2e8 < SlotCount; _0x3413a2e8++)
        {
            RectTransform _0xabc61457 = _0xeec56d36.Node(_0xc917d196, _0x8696a319._0xe7b49aac(new byte[9] { 48, 1, 18, 7, 22, 32, 31, 28, 7 }, 115) + _0x3413a2e8, _0xeec56d36.Centre, new Vector2((_0x3413a2e8 - 1) * 290f, 380f), new Vector2(240f, 240f));
            _0xeec56d36.Plate(_0xabc61457, _0x8696a319._0xe7b49aac(new byte[9] { 34, 29, 30, 5, 33, 29, 16, 5, 20 }, 113), _0x8b5733fb._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.9f), _0xeec56d36.Centre, Vector2.zero, new Vector2(240f, 240f), 2.0f);
            this._0x77c57fbb[_0x3413a2e8] = _0xeec56d36.Picture(_0xabc61457, _0x8696a319._0xe7b49aac(new byte[5] { 151, 166, 181, 160, 177 }, 212), _0x8b5733fb._0xf5e937fc, _0x38306f56.Locked, _0xeec56d36.Centre, Vector2.zero, new Vector2(170f, 170f));
        }

        _0xeec56d36.Label(_0xc917d196, _0x8696a319._0xe7b49aac(new byte[10] { 212, 232, 241, 233, 225, 208, 237, 240, 232, 225 }, 132), _0x8696a319._0xe7b49aac(new byte[6] { 130, 158, 135, 159, 151, 129 }, 210), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Cream, TextAlignmentOptions.Center, _0xeec56d36.Centre, new Vector2(0f, 150f), new Vector2(880f, 60f));
        for (int _0xbed43280 = 0; _0xbed43280 < this._0x1e58b1c0.Length; _0xbed43280++)
        {
            RectTransform _0xbe43c16f = _0xeec56d36.Node(_0xc917d196, _0x8696a319._0xe7b49aac(new byte[11] { 194, 254, 231, 255, 247, 193, 229, 243, 230, 241, 250 }, 146) + _0xbed43280, _0xeec56d36.Centre, new Vector2((_0xbed43280 % 3 - 1) * 290f, 20f - (_0xbed43280 / 3) * 190f), new Vector2(170f, 170f));
            _0xeec56d36.Plate(_0xbe43c16f, _0x8696a319._0xe7b49aac(new byte[11] { 230, 194, 212, 193, 214, 221, 229, 217, 212, 193, 208 }, 181), _0x8b5733fb._0x556c658e, _0x38306f56.Fade(_0x38306f56.Asphalt, 0.9f), _0xeec56d36.Centre, Vector2.zero, new Vector2(170f, 170f), 2.0f);
            this._0x1e58b1c0[_0xbed43280] = _0xeec56d36.Picture(_0xbe43c16f, _0x8696a319._0xe7b49aac(new byte[9] { 190, 154, 140, 153, 142, 133, 165, 136, 131 }, 237), _0x8b5733fb._0x36dc6826, _0x38306f56.Plume(_0xbed43280), _0xeec56d36.Centre, Vector2.zero, new Vector2(120f, 120f));
        }

        this._0xa8f84f31 = _0xeec56d36.Label(_0xc917d196, _0x8696a319._0xe7b49aac(new byte[10] { 163, 150, 133, 141, 138, 176, 139, 144, 133, 136 }, 228), _0x8696a319._0xe7b49aac(new byte[7] { 253, 237, 138, 159, 140, 132, 131 }, 205), _0x4e4c58b8.BodyMax, _0x4e4c58b8.BodyMin, _0x38306f56.Sprout, TextAlignmentOptions.Center, _0xeec56d36.BottomCentre, new Vector2(0f, 400f), new Vector2(880f, 60f));
        this._0x97ceee24 = _0xeec56d36.EmptyState(_0xc917d196, _0x8696a319._0xe7b49aac(new byte[45] { 99, 98, 121, 101, 100, 99, 106, 13, 120, 99, 97, 98, 110, 102, 104, 105, 13, 116, 104, 121, 39, 125, 97, 108, 116, 13, 108, 13, 127, 98, 108, 105, 13, 121, 98, 13, 107, 100, 97, 97, 13, 121, 101, 100, 126 }, 45));
        this._0x97ceee24.rectTransform.anchoredPosition = new Vector2(0f, -620f);
        this._0xd3155c0f = _0xeec56d36.Cta(_0xc917d196, _0x8696a319._0xe7b49aac(new byte[11] { 203, 228, 233, 225, 229, 202, 253, 252, 252, 231, 230 }, 136), _0x8696a319._0xe7b49aac(new byte[5] { 255, 240, 253, 245, 241 }, 188), _0x8b5733fb._0x32adc7bd, _0x38306f56.Hazard, _0x38306f56.Cream, _0xeec56d36.BottomCentre, new Vector2(0f, 220f), new Vector2(620f, 150f), 2.0f);
        this._0x114a469b = this._0xd3155c0f.GetComponent<Image>();
        this._0x91fcfa9d = this._0xd3155c0f.GetComponentInChildren<TMP_Text>(true);
        _0xeec56d36.OnTap(this._0xd3155c0f, () => this._0x319f8bd4());
        this._0xebf256cd();
    }

    private TMP_Text _0x91fcfa9d;
    private readonly Image[] _0x77c57fbb = new Image[SlotCount];
    private TextMeshProUGUI _0x97ceee24;
    private Image _0x114a469b;
    private Button _0xd3155c0f;
    public void _0xebf256cd()
    {
        int _0xd837316e = _0xfd5cbc90._0x9d9233c1;
        for (int _0x1153aa68 = 0; _0x1153aa68 < SlotCount; _0x1153aa68++)
        {
            if (this._0x77c57fbb[_0x1153aa68] != null)
            {
                this._0x77c57fbb[_0x1153aa68].color = _0x1153aa68 < _0xd837316e ? _0x38306f56.Hazard : _0x38306f56.Locked;
            }
        }

        for (int _0x45a30628 = 0; _0x45a30628 < this._0x1e58b1c0.Length; _0x45a30628++)
        {
            if (this._0x1e58b1c0[_0x45a30628] == null)
            {
                continue;
            }

            bool _0xa436de71 = _0xfd5cbc90.PlumeUnlocked(_0x45a30628);
            this._0x1e58b1c0[_0x45a30628].color = _0xa436de71 ? _0x38306f56.Plume(_0x45a30628) : _0x38306f56.Fade(_0x38306f56.Plume(_0x45a30628), 0.25f);
        }

        _0xa09f3022.SetText(this._0xa8f84f31, _0x4e4c58b8.Grouped(_0xfd5cbc90._0x1ec9c5ae) + _0x8696a319._0xe7b49aac(new byte[6] { 205, 170, 191, 172, 164, 163 }, 237));
        bool _0x48576b12 = _0xd837316e > 0;
        _0xeec56d36.SetEnabled(this._0xd3155c0f, this._0x114a469b, this._0x91fcfa9d, _0x48576b12, _0x38306f56.Hazard, _0x38306f56.Locked, _0x38306f56.Cream, _0x38306f56.Moss);
        _0xa09f3022.SetText(this._0x91fcfa9d, _0x48576b12 ? _0x8696a319._0xe7b49aac(new byte[5] { 14, 1, 12, 4, 0 }, 77) : _0x8696a319._0xe7b49aac(new byte[13] { 238, 239, 128, 227, 242, 225, 244, 229, 243, 128, 249, 229, 244 }, 160));
        if (this._0x97ceee24 != null)
        {
            this._0x97ceee24.gameObject.SetActive(_0xfd5cbc90.UnlockedPlumeCount() <= 1 && _0xd837316e <= 0);
        }
    }

    private const int SlotCount = 3;
    private readonly Image[] _0x1e58b1c0 = new Image[6];
    private TextMeshProUGUI _0xa8f84f31;
}

internal static class _0x8696a319
{
    internal static string _0xe7b49aac(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}