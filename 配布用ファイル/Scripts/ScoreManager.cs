using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    [SerializeField]
    public float timeElapsed { get; private set; }
    private int score;
    public bool isCoutingTime;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCoutingTime)
        {
            timeElapsed += Time.deltaTime;
        }
    }

    public void AddScore(int point)
    {
        score += point;
    }

    public int GetScore()
    {
        return score;
    }

    public void CountStop()
    {
        isCoutingTime = false;
    }

    public void CountStart()
    {
        timeElapsed = 0;
        isCoutingTime = true;
    }
}
