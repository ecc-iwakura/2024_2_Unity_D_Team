using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd_Creates : MonoBehaviour
{
    public GameObject[] crowd_prefabs;
    public int x = 0;
    public int y_max = 0;
    public int y_min = 0;
    public int cooldown_max = 1;
    public int cooldown_min = 1;
    public int Crowd_max = 5;
    public int Crowd_min = 1;
    int how;

    public void Cloudy_Weather()
    {
        StartCoroutine(Timer());
       
    }

    void SpawnRandomCrowd()
    {
        int randomIndex = Random.Range(0, crowd_prefabs.Length);
        Vector3 spawnPosition = new Vector3(x,Random.Range(y_min, y_max), 0);
        Instantiate(crowd_prefabs[randomIndex], spawnPosition, Quaternion.identity);
    }


    IEnumerator Timer()
    {

        how = Random.Range(Crowd_min, Crowd_max);
        for (int i=0;i<how;i++)
        {
            SpawnRandomCrowd();
            yield return new WaitForSeconds(Random.Range(cooldown_min, cooldown_max));
        }
    }
}
