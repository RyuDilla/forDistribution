using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAction : MonoBehaviour
{
    public void StartGame()
    { //自分の好きな関数名でok
        SceneManager.LoadScene("GameScene");

    }
}
