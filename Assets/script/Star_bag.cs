using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_bag : MonoBehaviour
{
    int[] star_count = new int[] { 0, 0, 0, 0, 0 };
    

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Starget(int startype, int howstar)
    {
        star_count[startype] =+ howstar;
    }
   
}
