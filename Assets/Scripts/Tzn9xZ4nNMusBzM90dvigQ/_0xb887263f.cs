using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// The template defines more panels than this game dresses - seven tutorial panels it
/// never shows, each carrying "Lorem Ipsum" and "HEADER". Those panels are NOT
/// switched off (controllers address panels by index and a missing one breaks
/// navigation); their text is blanked instead, at runtime, from generated code (C.15).
///
/// Panels this game really fills are skipped: the splash body and PANELS.DEFAULT.
/// </summary>
public sealed class _0xb887263f : MonoBehaviour
{
    public void _0xf4ff8e99()
    {
        if (_0x45a945dd.Instance == null || _0x45a945dd.Instance.Panels == null)
        {
            return;
        }

        List<_0x3afaca58> _0x3a60dc02 = _0x45a945dd.Instance.Panels;
        int _0x96917c06 = 0;
        // Every panel except the two this game dresses is swept, not only the ones
        // listed above: the list documents the known set, the loop catches the rest.
        for (int _0xd7254ae6 = 0; _0xd7254ae6 < _0x3a60dc02.Count; _0xd7254ae6++)
        {
            if (_0xd7254ae6 == _0xfc6e4613._0xb58be4ea.SPLASH || _0xd7254ae6 == _0xfc6e4613._0xb58be4ea.DEFAULT)
            {
                continue;
            }

            _0x3afaca58 _0x30de3d1e = _0x3a60dc02[_0xd7254ae6];
            if (_0x30de3d1e == null || _0x30de3d1e.Content == null)
            {
                continue;
            }

            TMP_Text[] _0x86c4d958 = _0x30de3d1e.Content.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x20757c2c = 0; _0x20757c2c < _0x86c4d958.Length; _0x20757c2c++)
            {
                if (_0x86c4d958[_0x20757c2c] == null)
                {
                    continue;
                }

                _0x86c4d958[_0x20757c2c].text = string.Empty;
                _0x96917c06++;
            }

            if (_0x30de3d1e.HeaderText != null)
            {
                _0x30de3d1e.HeaderText.text = string.Empty;
            }

            if (_0x30de3d1e.MainText != null)
            {
                _0x30de3d1e.MainText.text = string.Empty;
            }
        }

        {
#if B_LOGS
            {
                Debug.Log($"[cleaner] blanked={_0x96917c06} panels={_0x3a60dc02.Count} undressed={_0x6678fcdd.Length}");
            }
#endif
        }
    }

    /// <summary>
    /// The seven tutorial panels this game never shows. They are named explicitly so
    /// it is visible in the code which placeholder set is being cleared - and so that
    /// adding a panel to the template cannot quietly slip past this sweep.
    /// </summary>
    private static readonly int[] _0x6678fcdd =
    {
        _0xfc6e4613._0xb58be4ea.EMPTY,
        _0xfc6e4613._0xb58be4ea.TUTORIAL0,
        _0xfc6e4613._0xb58be4ea.TUTORIAL1,
        _0xfc6e4613._0xb58be4ea.TUTORIAL2,
        _0xfc6e4613._0xb58be4ea.TUTORIAL3,
        _0xfc6e4613._0xb58be4ea.TUTORIAL4,
        _0xfc6e4613._0xb58be4ea.TUTORIAL5,
        _0xfc6e4613._0xb58be4ea.TUTORIAL6
    };
}