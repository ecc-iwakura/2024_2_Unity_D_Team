using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleScene_gameclear:MonoBehaviour
{
    // ƒQ[ƒ€‚ªŽn‚Ü‚éŽžŠÔ
    private float gameTime;

    // ƒQ[ƒ€‚ªI—¹‚·‚é‚Ü‚Å‚ÌŽžŠÔi•bj
    public float gameDuration = 300f;

    void Start()
    {
        // ƒQ[ƒ€‚ªŽn‚Ü‚éŽžŠÔ‚ð‹L˜^
        gameTime = Time.time;
    }

    void Update()
    {
        // Œ»Ý‚ÌŽžŠÔ‚ªŠJŽnŽžŠÔ‚ÉƒQ[ƒ€I—¹ŽžŠÔ‚ð‰Á‚¦‚½‚à‚Ì‚æ‚è‘å‚«‚¯‚ê‚Î
        // ƒQ[ƒ€ƒNƒŠƒA‰æ–Ê‚É‘JˆÚ
        if (Time.time >= gameTime + gameDuration)
        {
            SceneManager.LoadScene("gameclear");
        }
    }
}
