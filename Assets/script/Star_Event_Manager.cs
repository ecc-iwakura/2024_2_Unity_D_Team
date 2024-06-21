using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Event_Manager : MonoBehaviour
{

    public float cooldown_max = 1;
    public float cooldown_min = 0.5f;
    private Star_Creat shower;
    private Crowd_Creates crowdy;
    public int Events = 0;

    // Start is called before the first frame update
    void Start()
    {
        crowdy = GetComponent<Crowd_Creates>();
        shower = GetComponent<Star_Creat>();
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void RandomEvents()
    {

        int eventIndex = Random.Range(0, Events); // Eventsは上限を含まないため、0からEvents-1までの値が生成される

        switch (eventIndex)
        {
            case 0:
                Debug.Log("MeteorShower");
                shower.StartMeteorShower(); // showerオブジェクトがあると仮定
                break;

            case 1:
                Debug.Log("Crowdy");
                crowdy.Cloudy_Weather(); // crowdyオブジェクトがあると仮定
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
            Debug.Log("Event");
            RandomEvents();
            
        }
    }
}
