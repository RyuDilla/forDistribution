using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("You pushed B");
            SoundManager.Instance.PlayBgm(0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("You pushed S");
            SoundManager.Instance.StopBgm();
        }
    }
}
