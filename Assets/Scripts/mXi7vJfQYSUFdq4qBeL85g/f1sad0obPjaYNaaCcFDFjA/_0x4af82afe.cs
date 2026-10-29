using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x4af82afe : MonoBehaviour
{
    private Touch? _0x63c846f1(Bounds _0x9125c48d)
    {
        if (!_0xf2da7f44.Instance._0x5d7fe3e2)
            return null;
        foreach (Touch _0x623cfd9e in Touch.activeTouches)
            if (!_0x623cfd9e.ended)
            {
                Vector3 _0xba8702e3 = Camera.main.ScreenToWorldPoint(_0x623cfd9e.screenPosition);
                Vector3 _0xb54879c0 = new(_0xba8702e3.x, _0xba8702e3.y, _0x9125c48d.center.z);
                if (_0x9125c48d.Contains(_0xb54879c0) && this._0xeed76256(_0x623cfd9e))
                    return _0x623cfd9e;
            }

        return null;
    }

    private bool _0xeed76256(Touch? _0x569c54c5)
    {
        if (!_0x569c54c5.HasValue)
            return false;
        Vector3 _0x65d6ab96 = Camera.main.ScreenToWorldPoint(_0x569c54c5.Value.screenPosition);
        Vector3 _0x4695394e = _0x65d6ab96;
        _0x4695394e.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x4695394e))
            return true;
        _0x569c54c5 = null;
        return false;
    }

    private Touch? _0x1fbc66a6()
    {
        if (!_0xf2da7f44.Instance._0x5d7fe3e2)
            return null;
        foreach (Touch _0x50a178c1 in Touch.activeTouches)
            if (_0x50a178c1.ended)
                if (this._0xeed76256(_0x50a178c1))
                    return _0x50a178c1;
        return null;
    }

    private bool _0x8ed6d603(Touch? _0xadf67421, Bounds _0x486482b0, TouchPhase _0xd9419a17)
    {
        if (!_0xf2da7f44.Instance._0x5d7fe3e2)
        {
            _0xadf67421 = null;
            return false;
        }

        if (_0xadf67421 != null)
            if (_0xadf67421.Value.phase == _0xd9419a17)
            {
                Vector3 _0xfeebae8f = Camera.main.ScreenToWorldPoint(_0xadf67421.Value.screenPosition);
                Vector3 _0x4f6ce150 = new(_0xfeebae8f.x, _0xfeebae8f.y, _0x486482b0.center.z);
                if (_0x486482b0.Contains(_0x4f6ce150) && this._0xeed76256(_0xadf67421.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0xf166fd81(Bounds _0xeecf5dcf, TouchPhase _0xbb1c8e0c)
    {
        if (!_0xf2da7f44.Instance._0x5d7fe3e2)
            return null;
        foreach (Touch _0xee0865ee in Touch.activeTouches)
            if (_0xee0865ee.phase == _0xbb1c8e0c)
            {
                Vector3 _0x7f6c2e8c = Camera.main.ScreenToWorldPoint(_0xee0865ee.screenPosition);
                Vector3 _0x149344a1 = new(_0x7f6c2e8c.x, _0x7f6c2e8c.y, _0xeecf5dcf.center.z);
                if (_0xeecf5dcf.Contains(_0x149344a1) && this._0xeed76256(_0xee0865ee))
                    return _0xee0865ee;
            }

        return null;
    }

    private Touch? _0x9e9cd6cb()
    {
        if (!_0xf2da7f44.Instance._0x5d7fe3e2)
            return null;
        foreach (Touch _0xc96c3d9e in Touch.activeTouches)
            if (!_0xc96c3d9e.ended)
                if (this._0xeed76256(_0xc96c3d9e))
                    return _0xc96c3d9e;
        return null;
    }

    private Touch? _0xd4060a2c(Bounds _0xa32b7942)
    {
        if (!_0xf2da7f44.Instance._0x5d7fe3e2)
            return null;
        foreach (Touch _0xa8202977 in Touch.activeTouches)
            if (_0xa8202977.ended)
            {
                Vector3 _0xed5de722 = Camera.main.ScreenToWorldPoint(_0xa8202977.screenPosition);
                Vector3 _0xe93cd067 = new(_0xed5de722.x, _0xed5de722.y, _0xa32b7942.center.z);
                if (_0xa32b7942.Contains(_0xe93cd067) && this._0xeed76256(_0xa8202977))
                    return _0xa8202977;
            }

        return null;
    }

    private void _0xece8c210(Touch? _0xc71dc83a)
    {
        if (!_0xf2da7f44.Instance._0x5d7fe3e2)
        {
            _0xc71dc83a = null;
            return;
        }

        int _0x71041011 = _0xc71dc83a.Value.touchId;
        _0xc71dc83a = Touch.activeTouches.FirstOrDefault(_0x919269e6 => _0x919269e6.touchId == _0x71041011);
        if (!this._0xeed76256(_0xc71dc83a.Value))
            _0xc71dc83a = null;
    }

    public BoxCollider2D CameraTouchBounds;
    private static _0x4af82afe _0x5dcf0c30;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x5dcf0c30 = this.gameObject.GetComponent<_0x4af82afe>();
    }
}