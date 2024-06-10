using UnityEngine;

public class DisappearAfterTime : MonoBehaviour
{
    public float disappearTime = 5f; // Á‚¦‚é‚Ü‚Å‚ÌŠÔi•bj

    void Start()
    {
        // disappearTime•bŒã‚ÉDestroyŠÖ”‚ğŒÄ‚Ño‚·
        Destroy(gameObject, disappearTime);
    }
}