using UnityEngine;

public class seiza : MonoBehaviour
{
    public GameObject objectToGenerate; // ��������I�u�W�F�N�g
    public Transform generationPoint;   // ��������ʒu

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("stella0"))
        {
            Instantiate(objectToGenerate, generationPoint.position, generationPoint.rotation);
        }
    }
}
