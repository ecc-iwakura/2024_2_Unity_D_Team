using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Event_Manager : MonoBehaviour
{

    public float cooldown_max = 1;
    public float cooldown_min = 0.5f;
    private Star_Creat shower;
    private Crowd_Creates crowdy;
    public int Events = 2; // Eventsの初期値を適切に設定

    void Start()
    {
        crowdy = GetComponent<Crowd_Creates>(); // crowdyコンポーネントをキャッシュ
        shower = GetComponent<Star_Creat>(); // showerコンポーネントをキャッシュ
        StartCoroutine(Timer());
    }

    void RandomEvents()
    {
        int eventIndex = Random.Range(0, Events); // 0からEvents-1までの乱数を生成

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
