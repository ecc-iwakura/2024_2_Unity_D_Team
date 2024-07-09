using UnityEngine;

public class CursorChanger : MonoBehaviour
{
    public Texture2D cursorTexture; // カーソルの画像をアサインするための変数
    public CursorMode cursorMode = CursorMode.Auto; // カーソルモード（通常はAutoで問題ありません）
    public Vector2 hotSpot = Vector2.zero; // カーソルのホットスポット（通常は左上の0,0）

    void Start()
    {
        // カーソルをカスタム画像に変更
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseEnter()
    {
        // マウスが特定のオブジェクトに入った時にカーソルを変更
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseExit()
    {
        // マウスが特定のオブジェクトから離れた時にカーソルをデフォルトに戻す
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
