using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MeteorBreak : MonoBehaviour
{
    public int wantclick = 15;
    public AudioSource audioSource; // �C���X�y�N�^�[�Őݒ肷��

    [SerializeField] GameObject Effect1;
    [SerializeField] GameObject Effect2;

    RaycastHit2D[] hits = new RaycastHit2D[1]; // ��x�����쐬����

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // �R���|�[�l���g�𐳂����擾����
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // RaycastNonAlloc ���g���ăq�b�g���������擾����
            int numHits = Physics2D.RaycastNonAlloc(ray.origin, ray.direction, hits);

            if (numHits > 0 && hits[0].collider != null)
            {
                GameObject hitObject = hits[0].collider.gameObject;

                if (hitObject.CompareTag("Meteor")) // tag �̔�r�� CompareTag ���g�����������I
                {
                    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    mousePosition.z = 0;

                    audioSource.Play(); // ���ʉ����Đ�

                    if (wantclick <= 0)
                    {
                        GameObject effect = Instantiate(Effect2, mousePosition, Quaternion.identity);
                        Destroy(effect, 3);

                        Destroy(this.gameObject); // �������g��j������
                    }
                    else
                    {
                        GameObject effect1 = Instantiate(Effect1, mousePosition, Quaternion.identity);
                        Destroy(effect1, 2.5f);
                    }

                    wantclick--; // �N���b�N�񐔂����炷
                }
            }
        }
    }
}
