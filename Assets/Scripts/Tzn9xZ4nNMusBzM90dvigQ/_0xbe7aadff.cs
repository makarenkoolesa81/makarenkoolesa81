using UnityEngine;

/// <summary>
/// The project's whole image budget, held as serialized references so obfuscation
/// cannot break them. Nothing here is found by name, by path or by a string key.
///
/// Every field matches one row of the design document's art table, which is also the
/// drawing brief the art stage works from (C.67). A getter never returns null where an
/// Image would be left without a sprite: Unity draws an unassigned Image as a solid
/// WHITE RECTANGLE (B.1), so the 9-slice plate is the fallback everywhere.
/// </summary>
public sealed class _0xbe7aadff : MonoBehaviour
{
    public Sprite _0x239249ee
    {
        get
        {
            return this._grain != null ? this._grain : this._plate;
        }
    }

    [SerializeField]
    private Sprite _hen;
    [SerializeField]
    private Sprite _grain;
    public Sprite _0x37c91518
    {
        get
        {
            return this._barFill != null ? this._barFill : this._plate;
        }
    }

    public Sprite _0x36dc6826
    {
        get
        {
            return this._hen != null ? this._hen : this._plate;
        }
    }

    public Sprite _0x6be52309
    {
        get
        {
            return this._laneRoad != null ? this._laneRoad : this._plate;
        }
    }

    [SerializeField]
    private Sprite _haybale;
    public Sprite _0x6cc93da1
    {
        get
        {
            return this._chevron != null ? this._chevron : this._plate;
        }
    }

    public Sprite _0xe1f405e4
    {
        get
        {
            return this._emblem != null ? this._emblem : this._plate;
        }
    }

    [SerializeField]
    private Sprite _button;
    public Sprite _0xdb52545b
    {
        get
        {
            return this._signpost != null ? this._signpost : this._plate;
        }
    }

    public Sprite _0xcc40e0b4
    {
        get
        {
            return this._iconPause != null ? this._iconPause : this._plate;
        }
    }

    [SerializeField]
    private Sprite _signpost;
    public Sprite _0xf062d852
    {
        get
        {
            return this._feather != null ? this._feather : this._plate;
        }
    }

    [SerializeField]
    private Sprite _emblem;
    public Sprite _0x69fb6aa0
    {
        get
        {
            return this._iconBack != null ? this._iconBack : this._plate;
        }
    }

    [SerializeField]
    private Sprite _iconPause;
    [SerializeField]
    private Sprite _crate;
    [SerializeField]
    private Sprite _heart;
    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _cart;
    [SerializeField]
    private Sprite _iconClose;
    [SerializeField]
    private Sprite _laneVerge;
    public Sprite _0xc0446cd9
    {
        get
        {
            return this._laneVerge != null ? this._laneVerge : this._plate;
        }
    }

    [SerializeField]
    private Sprite _bgGame;
    public Sprite _0x2f70ba28
    {
        get
        {
            return this._heart != null ? this._heart : this._plate;
        }
    }

    /// <summary>
    /// The truck and the cart are drawn facing RIGHT (declared in assets.json and
    /// verified by the sprite-direction stage), so a lane running left flips on X.
    /// The hay bale is symmetric and is never flipped.
    /// </summary>
    public bool _0x279c5335(int _0xee9d073d)
    {
        return _0xee9d073d != 2;
    }

    [SerializeField]
    private Sprite _bgMain;
    public Sprite _0xd7f696de
    {
        get
        {
            return this._bgGame;
        }
    }

    [SerializeField]
    private Sprite _barFill;
    public Sprite _0x556c658e
    {
        get
        {
            return this._plate;
        }
    }

    public Sprite _0x32adc7bd
    {
        get
        {
            return this._button != null ? this._button : this._plate;
        }
    }

    public Sprite _0xf5e937fc
    {
        get
        {
            return this._crate != null ? this._crate : this._plate;
        }
    }

    [SerializeField]
    private Sprite _chevron;
    [SerializeField]
    private Sprite _laneRoad;
    public Sprite _0xfbb22ee9
    {
        get
        {
            return this._bgMain;
        }
    }

    public Sprite _0x696c8fb6
    {
        get
        {
            return this._iconClose != null ? this._iconClose : this._plate;
        }
    }

    [SerializeField]
    private Sprite _feather;
    [SerializeField]
    private Sprite _truck;
    /// <summary>Vehicle art by kind: 0 truck, 1 cart, 2 hay bale.</summary>
    public Sprite _0xfeaf8c24(int _0x473e2898)
    {
        if (_0x473e2898 == 1)
        {
            return this._cart != null ? this._cart : this._truck;
        }

        if (_0x473e2898 == 2)
        {
            return this._haybale != null ? this._haybale : this._truck;
        }

        return this._truck != null ? this._truck : this._plate;
    }
}