using UnityEngine;

public class tuitekurutagu1 : MonoBehaviour
{
    public string followTag = "FollowTag"; // 追従対象のタグ
    private Transform originalParent; // 元の親オブジェクトのTransform

    void OnTriggerEnter2D(Collider2D other)
    {
        // 衝突したオブジェクトが指定のタグを持っている場合
        if (other.gameObject.CompareTag(followTag))
        {
            // 元の親オブジェクトを保存
            originalParent = other.transform.parent;

            // このオブジェクトを衝突したオブジェクトの子オブジェクトにする
            other.transform.parent = this.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // 指定のタグを持つオブジェクトが領域から離れた場合
        if (other.gameObject.CompareTag(followTag))
        {
            // 親オブジェクトを元に戻す
            other.transform.parent = originalParent;
        }
    }
}

