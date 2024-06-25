using UnityEngine;

public class CursorChanger : MonoBehaviour
{
    public Texture2D cursorTexture; // �J�[�\���̉摜
    public CursorMode cursorMode = CursorMode.Auto; // �J�[�\�����[�h�i�f�t�H���g��Auto�j
    public Vector2 hotSpot = Vector2.zero; // �J�[�\���̃z�b�g�X�|�b�g

    void Start()
    {
        // �Q�[���̊J�n���ɃJ�[�\����ύX����
        ChangeCursor(cursorTexture);
    }

    public void ChangeCursor(Texture2D newCursorTexture)
    {
        // �J�[�\����V�����摜�ɕύX����
        Cursor.SetCursor(newCursorTexture, hotSpot, cursorMode);
    }

    public void ResetCursor()
    {
        // �J�[�\�����f�t�H���g�ɖ߂�
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}