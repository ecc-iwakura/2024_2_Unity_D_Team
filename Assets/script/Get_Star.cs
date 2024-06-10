using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Get_Star : MonoBehaviour
{
    private AudioSource audioSource;
    public string[] targetTags = { "Star0", "Star1", "Star2", "Star3" };

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

            if (hit.collider != null) // Ray�������ɓ����������`�F�b�N
            {
                for (int i = 0; i < targetTags.Length; i++)
                {
                    if (hit.transform.gameObject.tag == targetTags[i]) // �^�O���r
                    {
                        Debug.Log("Clicked on object with tag: " + targetTags[i]);
                        manager.AddScore(i, 1);
                        Destroy(hit.collider.gameObject);
                        audioSource.Play();
                        break; // �^�O����v�����烋�[�v�𔲂���
                    }
                }
            }
        }
    }
}
