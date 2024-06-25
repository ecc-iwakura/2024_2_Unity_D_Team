using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Get_Star_R : MonoBehaviour
{
    public string[] targetTags = { "Star0", "Star1", "Star2", "Star3" };

    private Star_bag manager;
    private void Start()
    {
        manager = GetComponent<Star_bag>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // レイキャストの結果を格納する変数
            RaycastHit2D[] hits = new RaycastHit2D[1];
            int numHits = Physics2D.RaycastNonAlloc(ray.origin, ray.direction, hits);

            if (numHits > 0 && hits[0].collider != null)
            {
                GameObject hitObject = hits[0].collider.gameObject;
                int index = System.Array.IndexOf(targetTags, hitObject.tag);
                for (int i = 0; i < targetTags.Length; i++)
                {
                    if (index != -1)
                    {


                        manager.AddScore(i, 1);
                        Destroy(hitObject);
                        break; // タグが一致したらループを抜ける
                    }
                }
            }
        }
    }
}
