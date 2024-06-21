using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star_bag : MonoBehaviour
{
    [SerializeField]
    private static Star_bag[] instances; // スコアマネージャーの配列

    public int[] stars; // スコアの配列

    public static Star_bag GetInstance(int index)
    {
        if (instances == null || index < 0 || index >= instances.Length)
        {
            Debug.LogError("Invalid index or instances array not initialized.");
            return null;
        }

        //if (instances[index] == null)
        //{
        //    GameObject obj = new GameObject("Star_bag_" + index);
        //    instances[index] = obj.AddComponent<Star_bag>();
        //    DontDestroyOnLoad(obj);
        //}

        return instances[index];
    }

    public void AddScore(int index, int value)
    {
        if (index < 0 || index >= stars.Length)
        {
            Debug.LogError("Invalid index.");
            return;
        }

        stars[index] += value;
    }

    public int GetScore(int index)
    {
        if (index < 0 || index >= stars.Length)
        {
            Debug.LogError("Invalid index.");
            return 0;
        }

        return stars[index];
    }

    //private void Awake()
    //{
    //    if (instances == null)
    //    {
    //        instances = new Star_bag[SceneManager.sceneCountInBuildSettings];
    //        stars = new int[SceneManager.sceneCountInBuildSettings];
    //    }
    //}
}
