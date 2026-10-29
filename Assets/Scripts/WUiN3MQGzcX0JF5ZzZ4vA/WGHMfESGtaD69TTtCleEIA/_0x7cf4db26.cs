using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x7cf4db26 : MonoBehaviour
{
    private void OnDestroy()
    {
        if (_0xe3cbaa24 != null && _0xe3cbaa24.Contains(this))
            _0xe3cbaa24.Remove(this);
    }

    private CanvasScaler _0x75af5228;
    private static UnityEvent _0x66673e44 = new();
    private Canvas _0xec58d867;
    private static void SafeAreaChanged()
    {
        _0x27fff434 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private RectTransform _0xd42376bc;
    private static readonly List<_0x7cf4db26> _0xe3cbaa24 = new();
    private static ScreenOrientation _0x2101f5fb = ScreenOrientation.LandscapeLeft;
    private static Vector2 _0x0a972963 = Vector2.zero;
    private Vector2 _0x0d30e8df;
    private static void OrientationChanged()
    {
        _0x2101f5fb = Screen.orientation;
        _0x0a972963.x = Screen.width;
        _0x0a972963.y = Screen.height;
        _0x27fff434 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x66673e44.Invoke();
    }

    private void Update()
    {
        if (_0xe3cbaa24.Count == 0 || _0xe3cbaa24[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x2101f5fb)
            OrientationChanged();
        if (Screen.safeArea != _0x27fff434)
            SafeAreaChanged();
        if (Screen.width != _0x0a972963.x || Screen.height != _0x0a972963.y)
            ResolutionChanged();
    }

    private static void ResolutionChanged()
    {
        _0x0a972963.x = Screen.width;
        _0x0a972963.y = Screen.height;
        _0x27fff434 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x66673e44.Invoke();
    }

    private void _0x42960c76()
    {
        if (this._0xd42376bc == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x2fc33adb = Screen.safeArea;
        Vector2 _0xcb97af3d = _0x2fc33adb.position;
        Vector2 _0xc41ef611 = _0x2fc33adb.position + _0x2fc33adb.size;
        _0xcb97af3d.x /= screenWidth;
        _0xcb97af3d.y /= screenHeight;
        _0xc41ef611.x /= screenWidth;
        _0xc41ef611.y /= screenHeight;
        this._0xd42376bc.anchorMin = _0xcb97af3d;
        this._0xd42376bc.anchorMax = _0xc41ef611;
        this._0xd42376bc.offsetMin = Vector2.zero;
        this._0xd42376bc.offsetMax = Vector2.zero;
        if (this._0x75af5228 == null)
            return;
        Vector2 _0x0f5769cd = _0xc41ef611 - _0xcb97af3d;
        float _0xc5ea9dc9 = 2f - _0x0f5769cd.x;
        float _0x714ff893 = 2f - _0x0f5769cd.y;
        this._0x75af5228.referenceResolution = this._0x0d30e8df * new Vector2(_0xc5ea9dc9, _0x714ff893);
    }

    private static Rect _0x27fff434 = Rect.zero;
    private void Start()
    {
    }

    private void Awake()
    {
        if (!_0xe3cbaa24.Contains(this))
            _0xe3cbaa24.Add(this);
        this._0xec58d867 = this.GetComponent<Canvas>();
        this._0x75af5228 = this.GetComponent<CanvasScaler>();
        if (this._0x75af5228 != null)
            this._0x0d30e8df = this._0x75af5228.referenceResolution;
        this._0x09b373a1 = this.GetComponent<RectTransform>();
        this._0xd42376bc = this.transform.Find(_0x1554b04f._0x260484c3(new byte[8] { 95, 109, 106, 105, 77, 126, 105, 109 }, 12)) as RectTransform;
        if (!_0x8c2fe94b)
        {
            _0x2101f5fb = Screen.orientation;
            _0x0a972963.x = Screen.width;
            _0x0a972963.y = Screen.height;
            _0x27fff434 = Screen.safeArea;
            _0x8c2fe94b = true;
        }

        this._0x42960c76();
    }

    private RectTransform _0x09b373a1;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x7a088c86 = 0; _0x7a088c86 < _0xe3cbaa24.Count; _0x7a088c86++)
            _0xe3cbaa24[_0x7a088c86]._0x42960c76();
    }

    private static bool _0x8c2fe94b;
}

internal static class _0x1554b04f
{
    internal static string _0x260484c3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}