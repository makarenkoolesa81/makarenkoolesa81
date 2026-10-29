using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x32ce491f : MonoBehaviour
{
    private Vector3 _0xff2ac1d4 { get; set; }

    private new Camera _0xb0eb3249;
    //public bool executeInUpdate;
    private float _0x61fcccc3 { get; set; }

    private void Awake()
    {
        this._0xb0eb3249 = this.GetComponent<Camera>();
        _0x0fa0677d = this;
        this._0xe9fb8ba9();
    }

    private Vector3 _0xc56377ca { get; set; }
    private Vector3 _0xcac91fa4 { get; set; }
    private Vector3 _0x4ba5f174 { get; set; }
    private Vector3 _0x3287116f { get; set; }
    private Vector3 _0x3d18c42f { get; set; }
    private Vector3 _0x8063a851 { get; set; }

    public enum _0x86a005e5
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x7e7dfe26 { get; set; }

    private Color _0x6137b9ae = Color.white;
    private static _0x32ce491f _0x0fa0677d;
    private _0x86a005e5 _0x03038531 = _0x86a005e5.Portrait;
    private float _0x5da8f48c = 1;
    private void _0xe9fb8ba9()
    {
        float _0x59984e7b, _0x7cbafcc8, _0x66c06bdf, _0xe953b4ca;
        if (this._0x03038531 == _0x86a005e5.Landscape)
            this._0xb0eb3249.orthographicSize = 1f / this._0xb0eb3249.aspect * this._0x5da8f48c / 2f;
        else
            this._0xb0eb3249.orthographicSize = this._0x5da8f48c / 2f;
        this._0xba5610c2 = 2f * this._0xb0eb3249.orthographicSize;
        this._0x61fcccc3 = this._0xba5610c2 * this._0xb0eb3249.aspect;
        float _0x333cba3a = this._0xb0eb3249.transform.position.x;
        float _0xc6ff457b = this._0xb0eb3249.transform.position.y;
        _0x59984e7b = _0x333cba3a - this._0x61fcccc3 / 2;
        _0x7cbafcc8 = _0x333cba3a + this._0x61fcccc3 / 2;
        _0x66c06bdf = _0xc6ff457b + this._0xba5610c2 / 2;
        _0xe953b4ca = _0xc6ff457b - this._0xba5610c2 / 2;
        this._0xc56377ca = new Vector3(_0x59984e7b, _0xe953b4ca, 0);
        this._0x4ba5f174 = new Vector3(_0x333cba3a, _0xe953b4ca, 0);
        this._0x3287116f = new Vector3(_0x7cbafcc8, _0xe953b4ca, 0);
        this._0x7e7dfe26 = new Vector3(_0x59984e7b, _0xc6ff457b, 0);
        this._0xe1fccd69 = new Vector3(_0x333cba3a, _0xc6ff457b, 0);
        this._0xff2ac1d4 = new Vector3(_0x7cbafcc8, _0xc6ff457b, 0);
        this._0xcac91fa4 = new Vector3(_0x59984e7b, _0x66c06bdf, 0);
        this._0x8063a851 = new Vector3(_0x333cba3a, _0x66c06bdf, 0);
        this._0x3d18c42f = new Vector3(_0x7cbafcc8, _0x66c06bdf, 0);
    }

    private Vector3 _0xe1fccd69 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x6137b9ae;
        Matrix4x4 _0xb9c9315a = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xb0eb3249.orthographic)
        {
            float _0xc43fca9d = this._0xb0eb3249.farClipPlane - this._0xb0eb3249.nearClipPlane;
            float _0xea8c165e = (this._0xb0eb3249.farClipPlane + this._0xb0eb3249.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xea8c165e), new Vector3(this._0xb0eb3249.orthographicSize * 2 * this._0xb0eb3249.aspect, this._0xb0eb3249.orthographicSize * 2, _0xc43fca9d));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xb0eb3249.fieldOfView, this._0xb0eb3249.farClipPlane, this._0xb0eb3249.nearClipPlane, this._0xb0eb3249.aspect);
        }

        Gizmos.matrix = _0xb9c9315a;
    }

    private float _0xba5610c2 { get; set; }
}