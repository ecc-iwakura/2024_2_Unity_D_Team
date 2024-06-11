using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Get_Star : MonoBehaviour
{
    private AudioSource audioSource;
    public string[] targetTags = {};

    private Star_bag manager;
    private void Start()
    {
        manager = GetComponent<Star_bag>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit.collider != null) // Rayが何かに当たったかチェック
            {
                for (int i = 0; i < targetTags.Length; i++)
                {
                    if (hit.transform.gameObject.tag == targetTags[i]) // タグを比較
                    {
                        Debug.Log("Clicked on object with tag: " + targetTags[i]);
                        manager.AddScore(i, 1);
                        Destroy(hit.collider.gameObject);
                        GetComponent<AudioSource>().Play();
                        break; // タグが一致したらループを抜ける
                    }
                }
            }
        }
    }
}
