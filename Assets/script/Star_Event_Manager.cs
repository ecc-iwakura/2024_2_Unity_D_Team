using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Event_Manager : MonoBehaviour
{

    public float cooldown_max = 1;
    public float cooldown_min = 0.5f;
    [SerializeField]
    private Star_Creat shower; // Star_Createが入ったオブジェクトををアタッチ

    [SerializeField]
    private Crowd_Creates crowdy; //Crowd_Createが入ったオブジェクトをアタッチ
    public int Events = 2; // Eventsの初期値を適切に設定

    void Start()
    {
       
        StartCoroutine(Timer());
    }

    void RandomEvents()
    {
        int eventIndex = Random.Range(0, Events); // 0からEvents-1までの乱数を生成

        switch (eventIndex)
        {
            case 0:
               
                shower.StartMeteorShower();
                break;

            case 1:
              
                crowdy.CloudyWeather();
                break;

            default:
             
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
