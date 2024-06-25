using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetorCreat : MonoBehaviour
{
    [SerializeField]
    private Camera_Control manager;//Star_bagが入ったオブジェクトをアタッチ
    

    public GameObject  star_prefabs;
    public int y = 0;
    public int x = 0;

   

    public void Spawnmeteor()
    {
      
        Vector3 spawnPosition = new Vector3(x, y, 0);
        Instantiate(star_prefabs, spawnPosition, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Meteor")
        {
            Destroy(other.gameObject);
            manager.gameover();
        }
    }
}
