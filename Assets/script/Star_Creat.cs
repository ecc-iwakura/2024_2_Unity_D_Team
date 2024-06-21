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
    float originalmaxCooldown;
    float originalminCooldown;
    bool meteorShowerRunning = false; 

    void Start()
    {
        StartCoroutine(Timer());
        originalmaxCooldown= cooldown_max;
        originalminCooldown= cooldown_min;
    }

    void SpawnRandomStar()
    {
        int randomIndex = Random.Range(0, star_prefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(x_min, x_max), y, 0);
        Instantiate(star_prefabs[randomIndex], spawnPosition, Quaternion.identity);
    }

    public void StartMeteorShower()
    {
        StartCoroutine(MeteorShower());
    }

    IEnumerator MeteorShower()
    {
        if (meteorShowerRunning)
        {
            yield break; // すでに実行中なら何もしない
        }

        meteorShowerRunning = true; // 実行中フラグを立てる

        
        cooldown_max = cooldown_max / 2.0f;
        cooldown_min = cooldown_min / 2.0f;
        yield return new WaitForSeconds(ShowerTime);
        cooldown_max = originalmaxCooldown;
        cooldown_min = originalminCooldown;
        Debug.Log("Cooldown reset");

        meteorShowerRunning = false; // 実行中フラグを下げる
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
