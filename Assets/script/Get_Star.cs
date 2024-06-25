using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Get_Star : MonoBehaviour
{
    [SerializeField]
    private Star_bag manager;//Star_bag���������I�u�W�F�N�g���A�^�b�`
    [SerializeField]
    private AudioSource audioSource;//�炵�������ʉ����������I�u�W�F�N�g���A�^�b�`

    public string[] targetTags = { };
    [SerializeField] GameObject[] Effect;

    private void Update()
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
                    audioSource.Play();
                    GameObject effect = Instantiate(Effect[index], mousePosition, Quaternion.identity);
                    Destroy(effect, 1.0f);
                }
            }
        
    }

}
