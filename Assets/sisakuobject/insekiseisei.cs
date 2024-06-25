using UnityEngine;
using System.Collections;

public class insekiseisei : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float spawnInterval = 20f;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;

    void Start()
    {
        StartCoroutine(SpawnMeteor());
    }

    IEnumerator SpawnMeteor()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void Spawn()
    {
        float xPosition = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float yPosition = spawnAreaMax.y;
        Vector2 spawnPosition = new Vector2(xPosition, yPosition);

        Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
    }
}
