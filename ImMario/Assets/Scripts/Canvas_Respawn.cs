using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Respawn : MonoBehaviour
{
    private void Awake()
    {
        var canvas = FindObjectsOfType<Canvas_Respawn>();
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
