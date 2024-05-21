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

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Timer");
    }

    void SpawnRandomStar()
    {
        int randomIndex = Random.Range(0, star_prefabs.Length); // ランダムなインデックスの取得
        GameObject star = Instantiate(star_prefabs[randomIndex], new Vector3(Random.Range(x_min, x_max), y, 1), Quaternion.identity);
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
