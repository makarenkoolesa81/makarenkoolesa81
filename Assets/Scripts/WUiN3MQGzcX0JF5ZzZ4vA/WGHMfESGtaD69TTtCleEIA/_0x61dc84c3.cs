using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x61dc84c3 : MonoBehaviour
{
    private static Vector2 _0x3a651ef3 = Vector2.zero;
    private void OnDestroy()
    {
        if (_0xc4c56670 != null && _0xc4c56670.Contains(this))
            _0xc4c56670.Remove(this);
    }

    private void Update()
    {
        if (_0xc4c56670[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x7b65684c)
            OrientationChanged();
        if (Screen.safeArea != _0x6a8356e3)
            SafeAreaChanged();
        if (Screen.width != _0x3a651ef3.x || Screen.height != _0x3a651ef3.y)
            ResolutionChanged();
    }

    private static Rect _0x6a8356e3 = Rect.zero;
    private void Awake()
    {
        if (!_0xc4c56670.Contains(this))
            _0xc4c56670.Add(this);
        this._0xc1542128 = this.GetComponent<Canvas>();
        this._0xfc75ac37 = this.GetComponent<RectTransform>();
        this._0x47ee63ec = this.transform.Find(_0xf3c8ba7f._0x3f0d672c(new byte[8] { 197, 247, 240, 243, 215, 228, 243, 247 }, 150)) as RectTransform;
        if (!_0x08ae1efa)
        {
            _0x7b65684c = Screen.orientation;
            _0x3a651ef3.x = Screen.width;
            _0x3a651ef3.y = Screen.height;
            _0x6a8356e3 = Screen.safeArea;
            _0x08ae1efa = true;
        }

        this._0x54551d9c();
    }

    private static void SafeAreaChanged()
    {
        _0x6a8356e3 = Screen.safeArea;
        for (int _0x0a10f838 = 0; _0x0a10f838 < _0xc4c56670.Count; _0x0a10f838++)
            _0xc4c56670[_0x0a10f838]._0x54551d9c();
    }

    private static ScreenOrientation _0x7b65684c = ScreenOrientation.LandscapeLeft;
    private static void OrientationChanged()
    {
        _0x7b65684c = Screen.orientation;
        _0x3a651ef3.x = Screen.width;
        _0x3a651ef3.y = Screen.height;
        _0x5fa7d2d5.Invoke();
    }

    private static UnityEvent _0x5fa7d2d5 = new();
    private static bool _0x08ae1efa;
    private RectTransform _0x47ee63ec;
    private Canvas _0xc1542128;
    private void _0x54551d9c()
    {
        if (this._0x47ee63ec == null)
            return;
        Rect _0x9a062a65 = Screen.safeArea;
        Vector2 _0xccea6842 = _0x9a062a65.position;
        Vector2 _0xc47409c9 = _0x9a062a65.position + _0x9a062a65.size;
        _0xccea6842.x /= this._0xc1542128.pixelRect.width;
        _0xccea6842.y /= this._0xc1542128.pixelRect.height;
        _0xc47409c9.x /= this._0xc1542128.pixelRect.width;
        _0xc47409c9.y /= this._0xc1542128.pixelRect.height;
        this._0x47ee63ec.anchorMin = _0xccea6842;
        this._0x47ee63ec.anchorMax = _0xc47409c9;
    }

    private RectTransform _0xfc75ac37;
    private static void ResolutionChanged()
    {
        _0x3a651ef3.x = Screen.width;
        _0x3a651ef3.y = Screen.height;
        _0x5fa7d2d5.Invoke();
    }

    private static readonly List<_0x61dc84c3> _0xc4c56670 = new();
}

internal static class _0xf3c8ba7f
{
    internal static string _0x3f0d672c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}