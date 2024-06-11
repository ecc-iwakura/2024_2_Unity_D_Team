using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    bool isCameraOnRightSide = true; // �J�������E���ɂ��邩�ǂ����������ϐ�
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
                    // �J�����������ɂ���ꍇ
                    if (isCameraOnRightSide)
                    {
                        // �J�������E���Ɉړ�
                        transform.position = new Vector3(100, 0, -1);
                        // �J�����̈ʒu���X�V
                        isCameraOnRightSide = false;
                    }

                    else // �J�������E���ɂ���ꍇ
                    {
                        // �J�����������Ɉړ�
                        transform.position = new Vector3(0, 0, -1);
                        // �J�����̈ʒu���X�V
                        isCameraOnRightSide = true;
                    }
                }
            }
        }
    }
}
