using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xd1b3b7bf : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsLoadCurrentScene;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xf2da7f44.Instance._0xa80559a1(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xf2da7f44.Instance._0xa80559a1(this.LoadSceneId));
    }

    public Button Button;
    public int LoadSceneId;
}