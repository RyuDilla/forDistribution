using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーの入力を取得して、変数に保持
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        // プレイヤーの入力値をもとに、オブジェクトの角度を変更
        transform.Rotate(new Vector3(0f, 0f, (inputHorizontal * -1.0f)));
        transform.Rotate(new Vector3(inputVertical, 0f, 0f));
    }
}
