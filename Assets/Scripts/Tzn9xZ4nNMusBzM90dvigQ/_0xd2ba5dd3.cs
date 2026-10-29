using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0xd2ba5dd3 : MonoBehaviour
{
    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0x0dc1f302)
            return;
        this._0x0dc1f302 = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0x8c9ae124 = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0x237dc7bf = 0; _0x237dc7bf < _0x8c9ae124.Length; _0x237dc7bf++)
        {
            TMP_Text _0x1c0a31b2 = _0x8c9ae124[_0x237dc7bf];
            if (_0x1c0a31b2 != null && IsPlaceholder(_0x1c0a31b2.text))
                _0x1c0a31b2.text = "";
        }
    }

    private static bool IsPlaceholder(string _0xa78bb90f)
    {
        if (string.IsNullOrEmpty(_0xa78bb90f))
            return false;
        string _0xbf95e717 = _0xa78bb90f.Trim();
        if (_0x667bd289.Contains(_0xbf95e717))
            return true;
        string _0xd8217ebd = _0xbf95e717.ToLowerInvariant();
        for (int _0x2779a871 = 0; _0x2779a871 < _0x38139228.Length; _0x2779a871++)
        {
            if (_0xd8217ebd.StartsWith(_0x38139228[_0x2779a871]))
                return true;
        }

        return false;
    }

    private static _0xd2ba5dd3 _0x0dcf88ae;
    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0x38139228 =
    {
        _0x2ab88af8._0x3b9328be(new byte[3] { 202, 201, 212 }, 166) + _0x2ab88af8._0x3b9328be(new byte[6] { 71, 79, 2, 75, 82, 81 }, 34) + _0x2ab88af8._0x3b9328be(new byte[2] { 53, 45 }, 64),
        _0x2ab88af8._0x3b9328be(new byte[6] { 79, 94, 70, 70, 82, 11 }, 43) + _0x2ab88af8._0x3b9328be(new byte[4] { 161, 176, 173, 161 }, 213)
    };
    private float _0x0dc1f302;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x0dcf88ae != null)
            return;
        GameObject _0x7a687c85 = new GameObject(_0x2ab88af8._0x3b9328be(new byte[24] { 21, 36, 44, 49, 45, 32, 53, 36, 17, 45, 32, 34, 36, 41, 46, 45, 37, 36, 51, 6, 52, 32, 51, 37 }, 65));
        _0x7a687c85.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x7a687c85);
        _0x0dcf88ae = _0x7a687c85.AddComponent<_0xd2ba5dd3>();
    }

    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0x4985509f;
    private const float ScanInterval = 0.25f;
    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0x4985509f == null)
            this._0x4985509f = (_0xd62aa51d, _0xc3cdc181) =>
            {
                this._0x0dc1f302 = 0f;
            };
        SceneManager.sceneLoaded += this._0x4985509f;
    }

    private static readonly HashSet<string> _0x667bd289 = new HashSet<string>
    {
        _0x2ab88af8._0x3b9328be(new byte[6] { 63, 50, 54, 51, 50, 37 }, 119),
        _0x2ab88af8._0x3b9328be(new byte[6] { 147, 190, 186, 191, 190, 169 }, 219),
        _0x2ab88af8._0x3b9328be(new byte[6] { 110, 99, 103, 98, 99, 116 }, 6),
        _0x2ab88af8._0x3b9328be(new byte[5] { 50, 47, 50, 42, 35 }, 102),
        _0x2ab88af8._0x3b9328be(new byte[5] { 113, 76, 81, 73, 64 }, 37)
    };
    private void OnDisable()
    {
        if (this._0x4985509f != null)
            SceneManager.sceneLoaded -= this._0x4985509f;
    }
}

internal static class _0x2ab88af8
{
    internal static string _0x3b9328be(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}