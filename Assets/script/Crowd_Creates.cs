using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd_Creates : MonoBehaviour
{
    public GameObject[] crowd_prefabs;
    public int x = 0;
    public int y_max = 0;
    public int y_min = 0;
    public float cooldown_max = 1f; // float^ΙC³
    public float cooldown_min = 1f; // float^ΙC³
    public int crowd_max = 5; // ½ΌK₯πC³
    public int crowd_min = 1; // ½ΌK₯πC³

    public void CloudyWeather() // \bhΌπC³
    {
        StartCoroutine(SpawnCrowds());
    }

    void SpawnRandomCrowd()
    {
        int randomIndex = Random.Range(0, crowd_prefabs.Length);
        Vector3 spawnPosition = new Vector3(x, Random.Range(y_min, y_max), 0);
        Instantiate(crowd_prefabs[randomIndex], spawnPosition, Quaternion.identity);
    }

    IEnumerator SpawnCrowds() // \bhΌπC³
    {
        int count = Random.Range(crowd_min, crowd_max); // \bhΌΖΟΌπC³
        for (int i = 0; i < count; i++)
        {
            SpawnRandomCrowd();
            yield return new WaitForSeconds(Random.Range(cooldown_min, cooldown_max));
        }
    }
}
