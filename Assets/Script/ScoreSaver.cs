using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSaver : MonoBehaviour
{

    public TextMeshPro finalScoreTextBox;
    private float bestScore = 1000;

    // Start is called before the first frame update
    void Start()
    {
        Timer timer = FindObjectOfType<Timer>();
        timer.active = false;
        //deactive timer by name
        GameObject.Find("Timer").SetActive(false);

        


        if(PlayerPrefs.HasKey("bestScore")){
                bestScore = PlayerPrefs.GetFloat("bestScore");


        }
        if(timer.sec < bestScore){

            bestScore = timer.sec;
            PlayerPrefs.SetFloat("bestScore", bestScore);
            PlayerPrefs.Save();

        }

        finalScoreTextBox.text = $"Your time is: {timer.timerTextBox.text}";
     var min = bestScore / 60;
        var seconds = bestScore % 60;
        var mili = (bestScore * 1000) % 1000;

        finalScoreTextBox.text += $"\nBest time is: {min.ToString("00")}:{seconds.ToString("00")}:{mili.ToString("000")}!";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
