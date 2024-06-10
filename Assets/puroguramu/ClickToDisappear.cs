using UnityEngine;

public class ClickToDisappear : MonoBehaviour
{
    void OnMouseDown()
    {
        // オブジェクトを消去
        Destroy(gameObject);
    }
}