using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverChecker : MonoBehaviour
{
    [SerializeField]
    int lifeStock;

    public GameObject gameObject;
    private SceneController sceneController;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        sceneController = gameObject.GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        // 落下したら ゲームオーバー
        if(transform.position.y < -30.0f)
        {
            lifeStock -= 1;

            if (lifeStock < 0)
            {
                GameOver();
            }
            else
            {
                this.transform.position = startPosition;
            }
        }
    }

    private void GameOver()
    {
        sceneController.GameOver();
    }

}