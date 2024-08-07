//using UnityEngine;

//public class seiza : MonoBehaviour
//{
//    public GameObject objectToSpawn; // 生成するオブジェクト
//    private int collisionCount = 0; // 衝突カウンター

//    void OnTriggerEnter2D(Collider2D other)
//    {
//        // 衝突したオブジェクトが特定のタグを持つか確認
//        if (other.CompareTag("Stella0") || other.CompareTag("Stella1") || other.CompareTag("Stella2")
//            || other.CompareTag("Stella3") || other.CompareTag("Stella4") || other.CompareTag("Stella5")
//            || other.CompareTag("Stella6"))
//        {
//            collisionCount++;

//            if (collisionCount == 5)
//            {
//                // 新しいオブジェクトを生成
//                Instantiate(objectToSpawn, transform.position, Quaternion.identity);

//                Destroy(gameObject);
//                // カウンターをリセット

//            }
//        }
//    }
//}

using UnityEngine;

public class seiza : MonoBehaviour
{
    public GameObject objectToSpawn; // 生成するオブジェクト
    private int collisionCount = 0; // 衝突カウンター

    void OnTriggerEnter2D(Collider2D other)
    {
        // 衝突したオブジェクトが特定のタグを持つか確認
        if (other.CompareTag("Stella0") || other.CompareTag("Stella1") || other.CompareTag("Stella2")
            || other.CompareTag("Stella3") || other.CompareTag("Stella4") || other.CompareTag("Stella5")
            || other.CompareTag("Stella6"))
        {
            collisionCount++;

            // 衝突したオブジェクトを削除
            Destroy(other.gameObject);

            if (collisionCount == 5)
            {
                // 新しいオブジェクトを生成
                Instantiate(objectToSpawn, transform.position, Quaternion.identity);

                // このオブジェクトを削除
                Destroy(gameObject);
            }
        }
    }
}
