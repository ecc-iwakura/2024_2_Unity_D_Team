using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Get_Star : MonoBehaviour
{
    [SerializeField]
    private Star_bag manager;//Star_bagが入ったオブジェクトをアタッチ
    [SerializeField]
    private AudioSource audioSource;//鳴らしたい効果音が入ったオブジェクトをアタッチ

    public string[] targetTags = { };

    private void Start()
    {
        
       
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // レイキャストの結果を格納する変数
            RaycastHit2D[] hits = new RaycastHit2D[1];
            int numHits = Physics2D.RaycastNonAlloc(ray.origin, ray.direction, hits);

            if (numHits > 0 && hits[0].collider != null)
            {
                GameObject hitObject = hits[0].collider.gameObject;
                int index = System.Array.IndexOf(targetTags, hitObject.tag);
                if (index != -1)
                {
                  
                    manager.AddScore(index, 1);
                    Destroy(hitObject);
                    audioSource.Play();
                }
            }
        }
    }
}
