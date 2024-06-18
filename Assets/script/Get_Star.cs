using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Get_Star : MonoBehaviour
{
    private Star_bag manager;
    private AudioSource audioSource;

    public string[] targetTags = { };

    private void Start()
    {
        manager = GetComponent<Star_bag>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit.collider != null)
            {
                int index = System.Array.IndexOf(targetTags, hit.transform.gameObject.tag);
                if (index != -1)
                {
                  
                    manager.AddScore(index, 1);
                    Destroy(hit.collider.gameObject);
                    audioSource.Play();
                }
            }
        }
    }
}
