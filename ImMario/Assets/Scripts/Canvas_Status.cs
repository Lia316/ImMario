using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Status : MonoBehaviour
{
    private void Awake()
    {
        var canvas = FindObjectsOfType<Canvas_Status>();
        if (canvas.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}