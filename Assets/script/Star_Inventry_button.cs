
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;
public class Star_Inventry_button : MonoBehaviour
{
    [SerializeField]
    private Star_bag manager;

    // ボタンを配列として定義
    [SerializeField] private Button[] _starButton;
    public GameObject[] star_prefabs;
    public float x_max = 0;
    public float x_min = 0;
    public float y_max = 0;
    public float y_min = 0;

 

    public void StarSelect(int stars)
    {
        int i = manager.GetScore(stars);
        if (i >= 1)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(x_min, x_max), Random.Range(y_min, y_max), 0);
            Instantiate(star_prefabs[stars],  spawnPosition, Quaternion.identity);
            manager.AddScore(stars,-1);
        }
       
    }
}
