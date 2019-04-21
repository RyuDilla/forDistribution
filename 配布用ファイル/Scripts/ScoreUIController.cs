using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUIController : MonoBehaviour
{

    Text uiText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = ScoreManager.Instance.GetScore();
        uiText.text = string.Format("Score: {0}", score);
    }
}
