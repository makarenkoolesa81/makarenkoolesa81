using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xe8fd4d52 : MonoBehaviour
{
    private void OnEnable()
    {
        if (this._0x299a46c0 == null)
            this._0x299a46c0 = _0xc029c7cf => this._0xafc53fab(_0xc029c7cf);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x299a46c0);
    }

    private readonly List<TMP_Text> _0xfe945379 = new List<TMP_Text>();
    private static float Ratio(Color _0x467950f7, Color _0x568a1e83)
    {
        float _0x292906d9 = Luminance(_0x467950f7);
        float _0xa356e924 = Luminance(_0x568a1e83);
        return (Mathf.Max(_0x292906d9, _0xa356e924) + 0.05f) / (Mathf.Min(_0x292906d9, _0xa356e924) + 0.05f);
    }

    private const float TargetRatio = 7f;
    private static float Linear(float _0x831bcb7f)
    {
        _0x831bcb7f = Mathf.Clamp01(_0x831bcb7f);
        return _0x831bcb7f <= 0.03928f ? _0x831bcb7f / 12.92f : Mathf.Pow((_0x831bcb7f + 0.055f) / 1.055f, 2.4f);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x64a5b6ca)
    {
        return 0.2126f * Linear(_0x64a5b6ca.r) + 0.7152f * Linear(_0x64a5b6ca.g) + 0.0722f * Linear(_0x64a5b6ca.b);
    }

    private static void Fix(TMP_Text _0x69dfb999)
    {
        if (_0x69dfb999 == null || !_0x69dfb999.isActiveAndEnabled)
            return;
        Material _0x9ef5d439 = _0x69dfb999.fontSharedMaterial;
        if (_0x9ef5d439 == null || !_0x9ef5d439.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x9ef5d439.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x9ef5d439.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x8b104a21 = _0x69dfb999.color;
        if (_0x8b104a21.a <= 0f)
            return;
        Color _0xf7f2230c = _0x9ef5d439.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x8b104a21, _0xf7f2230c) >= MinRatio)
            return;
        Color _0xb4f88cf1 = Luminance(_0xf7f2230c) < 0.5f ? Color.white : Color.black;
        Color _0x6cc4eda5;
        if (Ratio(_0xb4f88cf1, _0xf7f2230c) < TargetRatio)
        {
            _0x6cc4eda5 = _0xb4f88cf1;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x16239b66 = 0f;
            float _0x16ad401f = 1f;
            for (int _0x6e34f4b5 = 0; _0x6e34f4b5 < 20; _0x6e34f4b5++)
            {
                float _0x593278da = (_0x16239b66 + _0x16ad401f) * 0.5f;
                if (Ratio(Color.Lerp(_0x8b104a21, _0xb4f88cf1, _0x593278da), _0xf7f2230c) >= TargetRatio)
                    _0x16ad401f = _0x593278da;
                else
                    _0x16239b66 = _0x593278da;
            }

            _0x6cc4eda5 = Color.Lerp(_0x8b104a21, _0xb4f88cf1, _0x16ad401f);
        }

        _0x6cc4eda5.a = _0x8b104a21.a;
        _0x69dfb999.color = _0x6cc4eda5;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x63d4dfee != null)
            return;
        GameObject _0xf9f9ff62 = new GameObject(_0x5713057e._0x9b91d3e8(new byte[16] { 46, 23, 10, 57, 21, 20, 14, 8, 27, 9, 14, 61, 15, 27, 8, 30 }, 122));
        _0xf9f9ff62.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xf9f9ff62);
        _0x63d4dfee = _0xf9f9ff62.AddComponent<_0xe8fd4d52>();
    }

    private const float MinOutlineWidth = 0.01f;
    private readonly HashSet<TMP_Text> _0xe9b3fe98 = new HashSet<TMP_Text>();
    private void LateUpdate()
    {
        if (this._0xe9b3fe98.Count == 0)
            return;
        this._0xfe945379.Clear();
        this._0xfe945379.AddRange(this._0xe9b3fe98);
        this._0xe9b3fe98.Clear();
        for (int _0xfb605120 = 0; _0xfb605120 < this._0xfe945379.Count; _0xfb605120++)
            Fix(this._0xfe945379[_0xfb605120]);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x299a46c0;
    private const float MinRatio = 4.5f;
    private static _0xe8fd4d52 _0x63d4dfee;
    private void OnDisable()
    {
        if (this._0x299a46c0 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x299a46c0);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xafc53fab(Object _0x34bb8c21)
    {
        TMP_Text _0x16cb73af = _0x34bb8c21 as TMP_Text;
        if (_0x16cb73af != null)
            this._0xe9b3fe98.Add(_0x16cb73af);
    }
}

internal static class _0x5713057e
{
    internal static string _0x9b91d3e8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}