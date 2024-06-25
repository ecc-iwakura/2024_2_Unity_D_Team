using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Star_Inventry_button : MonoBehaviour
{
    [SerializeField]
    private Star_bag manager;

    // �{�^����z��Ƃ��Ē�`
    [SerializeField] private Button[] _starButton;
    public GameObject[] star_prefabs;

    public Transform spawnPoint;    // Empty�I�u�W�F�N�g��Transform
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
