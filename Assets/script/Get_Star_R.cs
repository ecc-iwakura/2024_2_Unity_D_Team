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
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;


            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit.collider != null)
            {
                GameObject hitObject = hit.collider.gameObject;
                int index = System.Array.IndexOf(targetTags, hitObject.tag);
                if (index != -1)
                {


                    manager.AddScore(index, 1);

                    Destroy(hitObject);
                   
                   
                }
            }
        }
    }
}
