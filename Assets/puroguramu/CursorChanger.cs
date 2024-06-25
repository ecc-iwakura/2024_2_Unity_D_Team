using UnityEngine;

public class CursorChanger : MonoBehaviour
{
    public Texture2D cursorTexture; // カーソルの画像
    public CursorMode cursorMode = CursorMode.Auto; // カーソルモード（デフォルトはAuto）
    public Vector2 hotSpot = Vector2.zero; // カーソルのホットスポット

    void Start()
    {
        // ゲームの開始時にカーソルを変更する
        ChangeCursor(cursorTexture);
    }

    public void ChangeCursor(Texture2D newCursorTexture)
    {
        // カーソルを新しい画像に変更する
        Cursor.SetCursor(newCursorTexture, hotSpot, cursorMode);
    }

    public void ResetCursor()
    {
        // カーソルをデフォルトに戻す
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}