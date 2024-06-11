using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    bool isCameraOnRightSide = true; // カメラが右側にあるかどうかを示す変数
    public int cleartime = 180;
    bool clear = false;
    bool escapekey =false;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(cleartime);
        clear = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
        if (escapekey) 
            {
                if (isCameraOnRightSide)
                {
                    transform.position = new Vector3(0, 0, -1);
                }
                else 
                {
                    transform.position = new Vector3(100, 0, -1);
                }
                escapekey = false;
            }
            else
            {
                transform.position = new Vector3(-100, 0, -1);
                escapekey = true;
            }
        
        }

        if (clear)
        {
            if(isCameraOnRightSide)
            {
                transform.position = new Vector3(100, 0, -1);
                isCameraOnRightSide = false;
            }

        }

        else { 
            if (Input.GetMouseButton(0)) { }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    // カメラが左側にある場合
                    if (isCameraOnRightSide)
                    {
                        // カメラを右側に移動
                        transform.position = new Vector3(100, 0, -1);
                        // カメラの位置を更新
                        isCameraOnRightSide = false;
                    }

                    else // カメラが右側にある場合
                    {
                        // カメラを左側に移動
                        transform.position = new Vector3(0, 0, -1);
                        // カメラの位置を更新
                        isCameraOnRightSide = true;
                    }
                }
            }
        }
    }
}
