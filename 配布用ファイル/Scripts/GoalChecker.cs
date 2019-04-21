using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalChecker : MonoBehaviour
{
    public GameObject gameObject;
    SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {
        sceneController = gameObject.GetComponent<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            sceneController.GameClear();
        }
    }
}
