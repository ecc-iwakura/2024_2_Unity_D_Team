using UnityEngine;

public class gattai : MonoBehaviour
{
    public GameObject star1; // ���̂����鐯1
    public GameObject star2; // ���̂����鐯2
    public GameObject newStarPrefab; // ���̌�̐V�������̃v���n�u

    void Update()
    {
        // ��Ƃ��āA�X�y�[�X�L�[���������獇�̂���悤�ɂ��܂�
        if (Input.GetKeyDown(KeyCode.G))
        {
            Merge();
        }
    }

    void Merge()
    {
        // ��1�Ɛ�2�̈ʒu�̕��ς�V�������̈ʒu�Ƃ���
        Vector3 newPosition = (star1.transform.position + star2.transform.position) / 2;

        // �V�������̃I�u�W�F�N�g���v���n�u���琶��
        GameObject newStar = Instantiate(newStarPrefab, newPosition, Quaternion.identity);

        // �K�v�ɉ����āA�V�������ɒǉ��̐ݒ���s�����Ƃ��ł��܂�

        // ���̐����폜
        Destroy(star1);
        Destroy(star2);
    }
}
