using UnityEngine;

public class _0x1a907722 : MonoBehaviour
{
    public bool IsLevelSelectorEnabled;
    public bool IsLevelIncrementOnWin;
    private void _0x66666d07()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsCheckScoreEnabled;
    public bool IsBestScoreEnabled;
    private void _0xf2fcdd15()
    {
    }

    public bool IsOnlyWinGameEndEnabled;
    public bool IsTutorialEnabled;
    public bool IsStoryEnabled;
    public bool IsSkipSplashEnabled;
    public static _0x1a907722 Instance;
    public bool IsTimerEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x1a907722>();
            DontDestroyOnLoad(this.gameObject);
            this._0x66666d07();
        }
        else
        {
            this._0xf2fcdd15();
            Destroy(this.gameObject);
        }
    }
}