using UnityEngine;

public class DisappearAfterTime : MonoBehaviour
{
    public float disappearTime = 5f; // ������܂ł̎��ԁi�b�j

    void Start()
    {
        // disappearTime�b���Destroy�֐����Ăяo��
        Destroy(gameObject, disappearTime);
    }
}