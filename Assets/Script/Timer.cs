using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public bool active = true;
    public TextMeshPro timerTextBox;
    [HideInInspector]
    public float sec;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(timerTextBox.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(active) sec += 1 * Time.deltaTime;

        var min = sec / 60;
        var seconds = sec % 60;
        var mili = (sec * 1000) % 1000;

        timerTextBox.text = $"{min.ToString("00")}:{seconds.ToString("00")}:{mili.ToString("000")}";


    }
}
