using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    bool isCameraOnRightSide = true; // カメラが右側にあるかどうかを示す変数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) { }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // カメラが右側にある場合
                if (isCameraOnRightSide)
                {
                    // カメラを左側に移動
                    transform.position = new Vector3(100, 0,-1);
                    // カメラの位置を更新
                    isCameraOnRightSide = false;
                }
                else // カメラが左側にある場合
                {
                    // カメラを右側に移動
                    transform.position = new Vector3(0, 0,-1);
                    // カメラの位置を更新
                    isCameraOnRightSide = true;
                }
            }
        }
    }
}
