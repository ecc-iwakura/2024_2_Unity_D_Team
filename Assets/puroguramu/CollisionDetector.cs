using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject objectToSpawn; // ��������I�u�W�F�N�g
    private int collisionCount = 0; // �Փ˃J�E���^�[

    void OnTriggerEnter2D(Collider2D other)
    {
        // �Փ˂����I�u�W�F�N�g������̃^�O�������m�F
        if (other.CompareTag("Stella0") || other.CompareTag("Stella1") || other.CompareTag("Stella2")
            || other.CompareTag("Stella3") || other.CompareTag("Stella4") || other.CompareTag("Stella5")
            || other.CompareTag("Stella6"))
        {
            collisionCount++;

            if (collisionCount == 5)
            {
                // �V�����I�u�W�F�N�g�𐶐�
                Instantiate(objectToSpawn, transform.position, Quaternion.identity);

                // �J�E���^�[�����Z�b�g
                collisionCount = 0;
            }
        }
    }
}
