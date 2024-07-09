using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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

            if (collisionCount == 10)
            {
                // 新しいオブジェクトを生成
                Instantiate(objectToSpawn, transform.position, Quaternion.identity);

                // カウンターをリセット
                collisionCount = 0;
            }
        }
    }
}