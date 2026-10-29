using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

/// <summary>
/// The play field itself is the control, so there is no button row to read: this turns
/// a finished tap inside the play band into a hop direction.
///
/// Input is the NEW Input System only - EnhancedTouch, exactly what the template's own
/// InputController uses internally, plus the editor mouse. Legacy UnityEngine.Input is
/// never touched (C). The band is checked arithmetically against normalised screen
/// coordinates, never by looking an EventSystem object up by name.
///
///   y from top 0.00 .. 0.13   HUD band          - ignored
///   y from top 0.13 .. 0.90   play band         - hops
///   y from top 0.90 .. 1.00   control hint band - ignored
///   x < 0 . 3 3 hop  left 0 . 3 3 . . 0 . 6 7 hop  straight  x> 0.67 hop right
/// </summary>
public sealed class _0xa20d578b : MonoBehaviour
{
    public const int HopLeft = -1;
    private const float ZoneLeft = 0.33f;
    private void Start()
    {
        if (!EnhancedTouchSupport.enabled)
        {
            EnhancedTouchSupport.Enable();
        }
    }

    /// <summary>
    /// The hop this frame, or HopNone. Called once per frame by RoadDirector, so a tap
    /// is consumed exactly once.
    /// </summary>
    public int _0x4d582780()
    {
        if (EnhancedTouchSupport.enabled)
        {
            foreach (Touch _0x15c585b5 in Touch.activeTouches)
            {
                if (!_0x15c585b5.ended)
                {
                    continue;
                }

                int _0xcd1de20a = this._0x04c0f38b(_0x15c585b5.screenPosition);
                if (_0xcd1de20a != HopNone)
                {
                    return _0xcd1de20a;
                }
            }
        }

        Mouse _0xb8ef25e9 = Mouse.current;
        if (_0xb8ef25e9 != null)
        {
            bool _0x9d6ea573 = _0xb8ef25e9.leftButton.isPressed;
            bool _0x216f4a6d = this._0xe778259c && !_0x9d6ea573;
            this._0xe778259c = _0x9d6ea573;
            if (_0x216f4a6d)
            {
                return this._0x04c0f38b(_0xb8ef25e9.position.ReadValue());
            }
        }

        return HopNone;
    }

    private bool _0xe778259c;
    public const int HopStraight = 0;
    private int _0x04c0f38b(Vector2 _0x84743386)
    {
        if (Screen.width <= 0 || Screen.height <= 0)
        {
            return HopNone;
        }

        float _0x2e648840 = _0x84743386.x / Screen.width;
        float _0x18655b0a = 1f - _0x84743386.y / Screen.height;
        if (_0x18655b0a < BandTop || _0x18655b0a > BandBottom)
        {
            return HopNone;
        }

        if (_0x2e648840 < ZoneLeft)
        {
            return HopLeft;
        }

        if (_0x2e648840 > ZoneRight)
        {
            return HopRight;
        }

        return HopStraight;
    }

    public const int HopRight = 1;
    private const float ZoneRight = 0.67f;
    private const float BandTop = 0.13f;
    private const float BandBottom = 0.90f;
    public const int HopNone = -99;
}