using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metor : MonoBehaviour
{
    public GameObject  star_prefabs;
    public int y = 0;
    public int x = 0;

   

    void SpawnRandomStar()
    {
      
        Vector3 spawnPosition = new Vector3(x, y, 0);
        Instantiate(star_prefabs, spawnPosition, Quaternion.identity);
    }
}
