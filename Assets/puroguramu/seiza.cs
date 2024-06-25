using UnityEngine;

public class seiza : MonoBehaviour
{
    public GameObject objectToGenerate; // 生成するオブジェクト
    public Transform generationPoint;   // 生成する位置

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("stella0"))
        {
            Instantiate(objectToGenerate, generationPoint.position, generationPoint.rotation);
        }
    }
}
