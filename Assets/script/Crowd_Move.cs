using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd_Move : MonoBehaviour
{
    public int speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Time.deltaTime,0,0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Crowd_Delete")
        {
            Destroy(gameObject);
        }
    }
}
