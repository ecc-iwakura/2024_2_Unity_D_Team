using UnityEngine;

public class tuitekuru : MonoBehaviour
{
    public GameObject targetObject; // 追従対象のオブジェクト
    private Transform originalParent; // 元の親オブジェクトのTransform

    void OnTriggerEnter2D(Collider2D other)
    {
        // 衝突したオブジェクトが追従対象の場合
        if (other.gameObject == targetObject)
        {
            // 元の親オブジェクトを保存
            originalParent = other.transform.parent;

            // このオブジェクトをtargetObjectの子オブジェクトにする
            other.transform.parent = this.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // 追従対象が領域から離れた場合
        if (other.gameObject == targetObject)
        {
            // 親オブジェクトを元に戻す
            other.transform.parent = originalParent;
        }
    }
}
