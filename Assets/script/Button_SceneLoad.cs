using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_SceneLoad : MonoBehaviour
{

  
    // Update is called once per frame
    public void Load(int i)
    {
        SceneManager.LoadScene(i);
    }
}
