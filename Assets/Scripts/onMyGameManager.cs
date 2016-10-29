using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class onMyGameManager : MonoBehaviour {
    public Text myRoomCount_text;
    public int myRoomCount;

    public Text myScoreNow_text;
    public Text myScoreBest_text;

    public int myScoreNow;
    public int myScoreBest;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        myUITextUpdate();

    }
    public void myUITextUpdate() {
        myRoomCount_text.text = "這是第"+myRoomCount.ToString()+"個房間";
        myScoreNow_text.text = myScoreNow.ToString()+"分了好棒棒";
        if (myScoreNow < PlayerPrefs.GetInt("myBestScore")) {
            myScoreBest_text.text = "嫩～比" + PlayerPrefs.GetInt("myBestScore").ToString() + "分低";
        }
        else {
            myScoreBest = myScoreNow;
            PlayerPrefs.SetInt("myBestScore", myScoreBest);
            myScoreBest_text.text = "太神拉！！" + myScoreBest.ToString() + "是新紀錄！";
        }
        

    }
}
