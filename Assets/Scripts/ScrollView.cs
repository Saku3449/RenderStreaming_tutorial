using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollView : MonoBehaviour
{
    public GameObject DebugText;
    public GameObject DebugWindow;
    private float timer = 0;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    void Awake()
    {
        Application.logMessageReceived += LoggedCb;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Debug.Log("10sec");
            timer = 0;
        }
    }

    public void LoggedCb(string logstr, string stacktrace, LogType type)
    {
        DebugText.GetComponent<Text>().text += logstr;
        DebugText.GetComponent<Text>().text += "\n";
        // 常にTextの最下部（最新）を表示するように強制スクロール
        DebugWindow.GetComponent<ScrollRect>().verticalNormalizedPosition = 0;
    }
}