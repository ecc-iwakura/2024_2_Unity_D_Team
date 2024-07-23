using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.PlayerSettings;

public class Zodiac_Sign_Score : MonoBehaviour
{
    public int x_min;
    public int x_max;
    public int y_min;
    public int y_max;
    public int[] unlock;
    public GameObject[] obj;

    [SerializeField]
    private Score manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        int i = manager.GetScore();
        for (int j = 0; j < unlock.Length; j++) { 
            if (i< unlock[j])
            {
                Vector3 spawnPosition = new Vector3(Random.Range(x_min, x_max), Random.Range(y_min, y_max), 0);
                Instantiate(obj[j], spawnPosition, Quaternion.identity);
            }
        }
    }
}
