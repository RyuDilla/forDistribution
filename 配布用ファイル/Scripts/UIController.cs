using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    float timeElapsed;
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

        int minutes = Mathf.FloorToInt(timeElapsed / 60F);
        int seconds = Mathf.FloorToInt(timeElapsed - minutes * 60);
        int mseconds = Mathf.FloorToInt((timeElapsed - minutes * 60 - seconds) * 1000);
        uiText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, mseconds);
    }
}
