using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Star_Inventry_button : MonoBehaviour
{
    private Star_bag manager;

    // �{�^����z��Ƃ��Ē�`
    [SerializeField] private Button[] _starButton;
    public GameObject[] star_prefabs;

    public Transform spawnPoint;    // Empty�I�u�W�F�N�g��Transform
    private void Start()
    {
        manager = GetComponent<Star_bag>();
    }

    public void StarSelect(int stars)
    {
        int i = manager.GetScore(stars);
        if (i >= 2)
        {
            Instantiate(star_prefabs[stars], spawnPoint.position, spawnPoint.rotation);
            manager.AddScore(stars,-2);
        }
       
    }
}
