using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverAction : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("GameScene");

    }

    public void GoTitle()
    {
        SceneManager.LoadScene("StartScene");
    }
}
