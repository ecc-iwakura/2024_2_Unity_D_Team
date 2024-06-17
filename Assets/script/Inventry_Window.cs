using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventry_Window : MonoBehaviour
{
    public GameObject obj;
    bool c=true;

    void Start()
    {

       
    }



    public void Object()
    {

        c = !c;
        obj.SetActive(c);
    }
}

