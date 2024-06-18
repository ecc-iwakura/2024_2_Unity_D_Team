using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Event_Manager : MonoBehaviour
{

    public float cooldown_max = 1;
    public float cooldown_min = 0.5f;
    private Star_Creat shower;

    // Start is called before the first frame update
    void Start()
    {
        shower = GetComponent<Star_Creat>();
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void RandomEvents()
    {
       
        shower.StartMeteorShower();
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
