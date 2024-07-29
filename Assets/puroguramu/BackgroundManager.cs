using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField]
    private GameObject normalBackground;
    [SerializeField]
    private GameObject beautifulBackground;
    [SerializeField]
    private Score score;

    private void Start()
    {
        UpdateBackground();
    }

    private void Update()
    {
        UpdateBackground();
    }

    private void UpdateBackground()
    {
        int currentScore = score.GetScore();

        if (currentScore < 14000)
        {
            normalBackground.SetActive(true);
            beautifulBackground.SetActive(false);
        }
        else if (currentScore >= 14001)
        {
            normalBackground.SetActive(false);
            beautifulBackground.SetActive(true);
        }
    }
}
