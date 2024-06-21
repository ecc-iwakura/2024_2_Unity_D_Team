using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Get_Star : MonoBehaviour
{
    [SerializeField]
    private Star_bag manager;
    [SerializeField]
    private AudioSource audioSource;

    public string[] targetTags = { };

    private void Start()
    {
        
       
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // ƒŒƒCƒLƒƒƒXƒg‚ÌŒ‹‰Ê‚ðŠi”[‚·‚é•Ï”
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
