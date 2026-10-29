using UnityEngine;

/// <summary>
/// Preset TROPICAL, exactly as the design document fixes it. Every field is an
/// INDEPENDENT literal: no static field here reads another static field, so Plana's
/// string encryption plus declaration reordering cannot build one before the other
/// (C.52 - that is how a whole type goes dead with a TypeInitializationException).
///
/// Text colours are the light four only (Cream, Moss, Sprout, Hazard). Ink, NightField,
/// Asphalt, Verge and Shade are BACKING colours and are never passed into a text
/// parameter: the single shared font material carries one dark Ink outline, and a dark
/// face on a dark outline reads as a blot (C.14).
/// </summary>
public static class _0x38306f56
{
    public static Color Trail(int _0xfa60e660)
    {
        if (_0xfa60e660 < 0 || _0xfa60e660 >= Trails.Length)
        {
            return Trails[0];
        }

        return Trails[_0xfa60e660];
    }

    public static readonly Color FieldShade = new Color(0.0745098f, 0.1764706f, 0.1176471f, 1f);
    public static readonly Color Moss = new Color(0.6627451f, 0.7882353f, 0.7098039f, 1f);
    public static readonly Color Locked = new Color(0.2274510f, 0.3529412f, 0.2784314f, 1f);
    public static Color Plume(int _0xad30e508)
    {
        if (_0xad30e508 < 0 || _0xad30e508 >= Plumes.Length)
        {
            return Plumes[0];
        }

        return Plumes[_0xad30e508];
    }

    public static readonly Color Cream = new Color(0.9176471f, 0.9843137f, 0.9411765f, 1f);
    public static readonly Color Ink = new Color(0.0235294f, 0.0901961f, 0.0549020f, 1f);
    public static readonly Color Asphalt = new Color(0.0588235f, 0.1882353f, 0.1411765f, 1f);
    public static readonly Color NightField = new Color(0.0509804f, 0.1568628f, 0.0941176f, 1f);
    public static readonly Color HazardLight = new Color(1f, 0.5411765f, 0.1686275f, 1f);
    public static readonly Color Shade = new Color(0.4941176f, 0.6078431f, 0.5333334f, 1f);
    /// <summary>Six unlockable hen tints. Index 0 is the default plumage.</summary>
    public static readonly Color[] Plumes =
    {
        new Color(0.9176471f, 0.9843137f, 0.9411765f, 1f),
        new Color(0f, 0.9019608f, 0.4627451f, 1f),
        new Color(1f, 0.4274510f, 0f, 1f),
        new Color(0.9490196f, 0.7568628f, 0.3058824f, 1f),
        new Color(0.4980392f, 0.6431373f, 0.4196078f, 1f),
        new Color(0.9098040f, 0.4156863f, 0.3607843f, 1f)
    };
    public static readonly Color Sprout = new Color(0f, 0.9019608f, 0.4627451f, 1f);
    public static readonly Color Hazard = new Color(1f, 0.4274510f, 0f, 1f);
    public static Color Fade(Color _0x7fcc7581, float _0x581dbae0)
    {
        return new Color(_0x7fcc7581.r, _0x7fcc7581.g, _0x7fcc7581.b, _0x581dbae0);
    }

    /// <summary>Three unlockable dust-puff tints, same unlock track as the plumes.</summary>
    public static readonly Color[] Trails =
    {
        new Color(0.9176471f, 0.9843137f, 0.9411765f, 1f),
        new Color(0f, 0.9019608f, 0.4627451f, 1f),
        new Color(0.9490196f, 0.7568628f, 0.3058824f, 1f)
    };
    public static readonly Color Verge = new Color(0.1019608f, 0.2274510f, 0.1568628f, 1f);
}