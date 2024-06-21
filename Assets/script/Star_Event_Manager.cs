using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Event_Manager : MonoBehaviour
{

    public float cooldown_max = 1;
    public float cooldown_min = 0.5f;
    private Star_Creat shower;
    private Crowd_Creates crowdy;
    public int Events = 2; // Events�̏����l��K�؂ɐݒ�

    void Start()
    {
        crowdy = GetComponent<Crowd_Creates>(); // crowdy�R���|�[�l���g���L���b�V��
        shower = GetComponent<Star_Creat>(); // shower�R���|�[�l���g���L���b�V��
        StartCoroutine(Timer());
    }

    void RandomEvents()
    {
        int eventIndex = Random.Range(0, Events); // 0����Events-1�܂ł̗����𐶐�

        switch (eventIndex)
        {
            case 0:
                Debug.Log("MeteorShower");
                shower.StartMeteorShower();
                break;

            case 1:
                Debug.Log("Crowdy");
                crowdy.CloudyWeather();
                break;

            default:
                Debug.LogError("Unexpected event index: " + eventIndex);
                break;
        }
    }

    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(cooldown_min, cooldown_max));
            RandomEvents();
        }
    }
}
