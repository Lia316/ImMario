using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Respawn : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

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
