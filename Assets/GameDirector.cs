using UnityEngine;
using TMPro;//text proを使うときは必須！
//制限時間を管理するスクリプト
public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    float time =60.0f;

    void Start()
    {
        this.timerText = GameObject.Find("Time");
    }
    // Update is called once per frame
    void Update()
    {
        this.time -=Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text =
            this.time.ToString("F1");
        
    }
}
