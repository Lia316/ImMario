using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Respawn : MonoBehaviour
{
    public static Canvas_Respawn Instance;

    void Start()
    {

    }

    void Update()
    {
        
    }
    
    private void Awake()
    {
        /*       var canvas = FindObjectsOfType<Canvas_Respawn>();
               if (canvas.Length == 1)
               {
                   DontDestroyOnLoad(gameObject);
               }
               else
               {
                   Destroy(gameObject);
               }*/

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
