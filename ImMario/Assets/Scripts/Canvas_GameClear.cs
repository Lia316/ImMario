using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_GameClear : MonoBehaviour
{
    public static Canvas_GameClear Instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.Thumbstick))
        {
            Application.Quit();
        }
    }

    private void Awake()
    {
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
