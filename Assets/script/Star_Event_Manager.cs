using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Event_Manager : MonoBehaviour
{

    public float cooldown_max = 1;
    public float cooldown_min = 0.5f;
    [SerializeField]
    private Star_Creat shower; // Star_Create���������I�u�W�F�N�g�����A�^�b�`

    [SerializeField]
    private Crowd_Creates crowdy; //Crowd_Create���������I�u�W�F�N�g���A�^�b�`
    public int Events = 2; // Events�̏����l��K�؂ɐݒ�

    void Start()
    {
       
        StartCoroutine(Timer());
    }

    void RandomEvents()
    {
        int eventIndex = Random.Range(0, Events); // 0����Events-1�܂ł̗����𐶐�

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
