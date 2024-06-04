using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    bool isCameraOnRightSide = true; // �J�������E���ɂ��邩�ǂ����������ϐ�

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
                // �J�������E���ɂ���ꍇ
                if (isCameraOnRightSide)
                {
                    // �J�����������Ɉړ�
                    transform.position = new Vector3(100, 0,-1);
                    // �J�����̈ʒu���X�V
                    isCameraOnRightSide = false;
                }
                else // �J�����������ɂ���ꍇ
                {
                    // �J�������E���Ɉړ�
                    transform.position = new Vector3(0, 0,-1);
                    // �J�����̈ʒu���X�V
                    isCameraOnRightSide = true;
                }
            }
        }
    }
}
