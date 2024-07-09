using UnityEngine;

public class CursorChanger : MonoBehaviour
{
    public Texture2D cursorTexture; // �J�[�\���̉摜���A�T�C�����邽�߂̕ϐ�
    public CursorMode cursorMode = CursorMode.Auto; // �J�[�\�����[�h�i�ʏ��Auto�Ŗ�肠��܂���j
    public Vector2 hotSpot = Vector2.zero; // �J�[�\���̃z�b�g�X�|�b�g�i�ʏ�͍����0,0�j

    void Start()
    {
        // �J�[�\�����J�X�^���摜�ɕύX
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseEnter()
    {
        // �}�E�X������̃I�u�W�F�N�g�ɓ��������ɃJ�[�\����ύX
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseExit()
    {
        // �}�E�X������̃I�u�W�F�N�g���痣�ꂽ���ɃJ�[�\�����f�t�H���g�ɖ߂�
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
