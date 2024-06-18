using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Star_Creat : MonoBehaviour
{
    public GameObject[] star_prefabs;
    public int y = 0;
    public float x_max = 0;
    public float x_min = 0;
    public float cooldown_max = 1;
    public float cooldown_min = 0.5f;
    public int ShowerTime = 5;


    void Start()
    {
        StartCoroutine(Timer());
        
    }

    void SpawnRandomStar()
    {
        int randomIndex = Random.Range(0, star_prefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(x_min, x_max), y, 0);
        Instantiate(star_prefabs[randomIndex], spawnPosition, Quaternion.identity);
    }

    public void StartMeteorShower()
    {
        StartCoroutine(MeteorShower(cooldown_max, cooldown_min));
    }

    IEnumerator MeteorShower(float originalmaxCooldown, float originalminCooldown)
    {

        Debug.Log("MeteorShower");
        cooldown_max /= 2.00f;
        cooldown_min /= 2.00f;
        yield return new WaitForSeconds(ShowerTime);
        cooldown_max = originalmaxCooldown;
        cooldown_min = originalminCooldown;
        Debug.Log("Cooldown reset");
    }






    IEnumerator Timer()
    {
       

        while (true)
        {
            SpawnRandomStar();
            yield return new WaitForSeconds(Random.Range(cooldown_min, cooldown_max));
        }
    }
}
