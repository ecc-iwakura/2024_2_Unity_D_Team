using UnityEngine;

public class gattai : MonoBehaviour
{
    public GameObject star1; // 合体させる星1
    public GameObject star2; // 合体させる星2
    public GameObject newStarPrefab; // 合体後の新しい星のプレハブ

    void Update()
    {
        // 例として、スペースキーを押したら合体するようにします
        if (Input.GetKeyDown(KeyCode.G))
        {
            Merge();
        }
    }

    void Merge()
    {
        // 星1と星2の位置の平均を新しい星の位置とする
        Vector3 newPosition = (star1.transform.position + star2.transform.position) / 2;

        // 新しい星のオブジェクトをプレハブから生成
        GameObject newStar = Instantiate(newStarPrefab, newPosition, Quaternion.identity);

        // 必要に応じて、新しい星に追加の設定を行うことができます

        // 元の星を削除
        Destroy(star1);
        Destroy(star2);
    }
}
