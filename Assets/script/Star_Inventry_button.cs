using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Star_Inventry_button : MonoBehaviour
{
    [SerializeField]
    private Star_bag manager;

    // ボタンを配列として定義
    [SerializeField] private Button[] _starButton;
    public GameObject[] star_prefabs;

    public Transform spawnPoint;    // EmptyオブジェクトのTransform
    private void Start()
    {
       
    }

    public void StarSelect(int stars)
    {
        int i = manager.GetScore(stars);
        if (i >= 1)
        {
            Instantiate(star_prefabs[stars], spawnPoint.position, spawnPoint.rotation);
            manager.AddScore(stars,-1);
        }
       
    }
}
