using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public static SceneController Instance
    {
        get; private set;
    }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
        ScoreManager.Instance.CountStart();
        SoundManager.Instance.PlayBgm(0);
    }

    public void GoTitle()
    {
        SceneManager.LoadScene("StartScene");
        ScoreManager.Instance.CountStop();
        SoundManager.Instance.StopBgm();

    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
        ScoreManager.Instance.CountStop();
        SoundManager.Instance.StopBgm();
    }

    public void GameClear()
    {
        SceneManager.LoadScene("GameClearScene");
        ScoreManager.Instance.CountStop();
        SoundManager.Instance.StopBgm();
    }

}
