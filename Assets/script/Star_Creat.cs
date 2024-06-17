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

    void Start()
    {
        StartCoroutine(Timer());
    }

    void SpawnRandomStar()
    {
        int randomIndex = Random.Range(0, star_prefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(x_min, x_max), y, 0); // Z����0�ɂ��邩�A�s�v�ȏꍇ�͏ȗ��ł���
        Instantiate(star_prefabs[randomIndex], spawnPosition, Quaternion.identity);
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
