using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Star_Creat : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;

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
        originalmaxCooldown = cooldown_max;
        originalminCooldown = cooldown_min;
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
            yield break;
       

        meteorShowerRunning = true;
        particle.Play();
        // メテオシャワー中の間、生成間隔を短縮
        float originalCooldownMax = cooldown_max;
        float originalCooldownMin = cooldown_min;
        cooldown_max /= 4.0f;
        cooldown_min /= 2.0f;

        yield return new WaitForSeconds(ShowerTime);

        // メテオシャワー終了後、生成間隔を元に戻す
        cooldown_max = originalCooldownMax;
        cooldown_min = originalCooldownMin;
        

        meteorShowerRunning = false;
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