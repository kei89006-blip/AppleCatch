using UnityEngine;
using TMPro;//text proを使うときは必須！
//制限時間を管理するスクリプト
public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    float time =60.0f;
    int point =0;

    public void GetApple()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point/= 2;
    }

    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("point");
    }
    // Update is called once per frame
    void Update()
    {
        this.time -=Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text =
            this.time.ToString("F1");
        this.pointText.GetComponent<TextMeshProUGUI>().text =
            this.point.ToString() + " point";
        
    }
}
