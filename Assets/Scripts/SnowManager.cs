using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManager : MonoBehaviour
{
    public List<Material> snowMaterials = new List<Material>();
    [Range(0f, 1f)] public float snowAmount;

    private void OnValidate()
    {
        for (int i = 0; i < snowMaterials.Count; i++)
        {
            snowMaterials[i].SetFloat("_SnowAmount", snowAmount);
        }
    }
}
