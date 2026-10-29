using UnityEngine;

/// <summary>
/// One vehicle on one lane. It holds no behaviour of its own: the lane moves it, so
/// there is exactly ONE mover per object (C.57). Nothing here is driven by the
/// engine's simulation; a hit is an arithmetic overlap of two half-widths.
/// </summary>
public sealed class _0xd65b75aa : MonoBehaviour
{
    public void _0xfb41edb4(float _0xda527437)
    {
        Vector3 _0xd132e9a9 = this.transform.localPosition;
        _0xd132e9a9.x = _0xda527437;
        _0xd132e9a9.z = 0f;
        this.transform.localPosition = _0xd132e9a9;
    }

    private float _0x71d4ed5a = 0.3f;
    public float _0x3ca01d94()
    {
        return this.transform.localPosition.x;
    }

    public float _0xbe42e9d5
    {
        get
        {
            return this._0x71d4ed5a;
        }
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    private SpriteRenderer _0x9c805508()
    {
        if (this._renderer == null)
        {
            this._renderer = this.GetComponent<SpriteRenderer>();
        }

        return this._renderer;
    }

    /// <summary>
    /// Dresses the vehicle for its lane. The art is drawn facing RIGHT (declared in
    /// assets.json), so a lane running left flips on X; the symmetric hay bale never
    /// flips, because flipping a symmetric sprite is a no-op that only costs a batch.
    /// </summary>
    public void _0xdc7f42bc(Sprite _0xa0f9043f, bool _0xd615598a, int _0xe1b59aad, Vector2 _0xf80fe311, int _0xaece1fc4, Color _0xc07bdfdd)
    {
        SpriteRenderer _0xd6ce1fea = this._0x9c805508();
        if (_0xd6ce1fea == null)
        {
            return;
        }

        _0xd6ce1fea.sprite = _0xa0f9043f;
        _0xd6ce1fea.color = _0xc07bdfdd;
        _0xd6ce1fea.sortingOrder = _0x4e4c58b8.ClampOrder(_0xaece1fc4);
        _0xd6ce1fea.flipX = _0xd615598a && _0xe1b59aad < 0;
        _0xd6ce1fea.drawMode = SpriteDrawMode.Sliced;
        _0xd6ce1fea.size = _0xf80fe311;
        this.transform.localScale = Vector3.one;
        this._0x71d4ed5a = _0xf80fe311.x * 0.5f;
    }
}