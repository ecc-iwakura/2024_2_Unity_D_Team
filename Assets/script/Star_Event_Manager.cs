using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Event_Manager : MonoBehaviour
{

    public float cooldown_max = 1;
    public float cooldown_min = 0.5f;
    [SerializeField]
    private Star_Creat shower; // Assign in Unity Editor

    [SerializeField]
    private Crowd_Creates crowdy; // Assign in Unity Editor
    public int Events = 2; // Events‚Ì‰Šú’l‚ğ“KØ‚Éİ’è

    void Start()
    {
       
        StartCoroutine(Timer());
    }

    void RandomEvents()
    {
        int eventIndex = Random.Range(0, Events); // 0‚©‚çEvents-1‚Ü‚Å‚Ì—”‚ğ¶¬

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
