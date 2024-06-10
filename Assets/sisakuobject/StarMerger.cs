using UnityEngine;

public class StarMerger : MonoBehaviour
{
    public GameObject star1; // ���̂����鐯1
    public GameObject star2; // ���̂����鐯2
    public Sprite newStarSprite; // ���̌�̐V�������̃X�v���C�g

    void Update()
    {
        // ��Ƃ��āA�X�y�[�X�L�[���������獇�̂���悤�ɂ��܂�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MergeStars();
        }
    }

    void MergeStars()
    {
        // ��1�Ɛ�2�̈ʒu�̕��ς�V�������̈ʒu�Ƃ���
        Vector3 newPosition = (star1.transform.position + star2.transform.position) / 2;

        // �V�������̃I�u�W�F�N�g���쐬
        GameObject newStar = new GameObject("NewStar");
        newStar.transform.position = newPosition;

        // �V��������SpriteRenderer�R���|�[�l���g��ǉ����A�V�����X�v���C�g��ݒ�
        SpriteRenderer sr = newStar.AddComponent<SpriteRenderer>();
        sr.sprite = newStarSprite;

        // �K�v�ɉ����āA�V�������ɑ��̃R���|�[�l���g�i��FCollider, Rigidbody�j��ǉ�

        // ���̐����폜
        Destroy(star1);
        Destroy(star2);
    }
}