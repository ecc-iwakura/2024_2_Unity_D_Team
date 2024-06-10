using UnityEngine;

public class StarMerger : MonoBehaviour
{
    public GameObject star1; // 合体させる星1
    public GameObject star2; // 合体させる星2
    public Sprite newStarSprite; // 合体後の新しい星のスプライト

    void Update()
    {
        // 例として、スペースキーを押したら合体するようにします
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MergeStars();
        }
    }

    void MergeStars()
    {
        // 星1と星2の位置の平均を新しい星の位置とする
        Vector3 newPosition = (star1.transform.position + star2.transform.position) / 2;

        // 新しい星のオブジェクトを作成
        GameObject newStar = new GameObject("NewStar");
        newStar.transform.position = newPosition;

        // 新しい星にSpriteRendererコンポーネントを追加し、新しいスプライトを設定
        SpriteRenderer sr = newStar.AddComponent<SpriteRenderer>();
        sr.sprite = newStarSprite;

        // 必要に応じて、新しい星に他のコンポーネント（例：Collider, Rigidbody）を追加

        // 元の星を削除
        Destroy(star1);
        Destroy(star2);
    }
}