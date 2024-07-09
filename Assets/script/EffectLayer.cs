using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLayer : MonoBehaviour
{
    private string EFFECT_SORTING_LAYER_NAME = "Effect";
    private Renderer objectRenderer;

    private void Awake()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.sortingLayerName = EFFECT_SORTING_LAYER_NAME;
        }

        SetSortingLayer(transform);
    }

    private void SetSortingLayer(Transform parent)
    {
        foreach (Transform child in parent)
        {
            Renderer childRenderer = child.GetComponent<Renderer>();
            if (childRenderer != null)
            {

                childRenderer.sortingLayerName = EFFECT_SORTING_LAYER_NAME;
            }

            // 再帰的に子オブジェクトに対して同じ処理を行う
            SetSortingLayer(child);
        }
    }
}
