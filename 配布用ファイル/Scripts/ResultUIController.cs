using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUIController : MonoBehaviour
{
    float timeElapsed;
    int score;
    Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed = ScoreManager.Instance.timeElapsed;
        score = ScoreManager.Instance.GetScore();
        int minutes = Mathf.FloorToInt(timeElapsed / 60F);
        int seconds = Mathf.FloorToInt(timeElapsed - minutes * 60);
        int mseconds = Mathf.FloorToInt((timeElapsed - minutes * 60 - seconds) * 1000);
        uiText.text = string.Format("Clear Time: {0:00}:{1:00}:{2:000} Score:{3}", minutes, seconds, mseconds, score);
    }
}
