using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Pause : MonoBehaviour
{
    public static Canvas_Pause Instance;
    public GamePlayManager GamePlayEvent;

    void Start()
    {
        GamePlayEvent = GameObject.Find("EventSystem").GetComponent<GamePlayManager>();

    }

    void Update()
    {
/*        if (ARAVRInput.GetDown(ARAVRInput.Button.IndexTrigger))
        {
            GamePlayEvent.death();
        }*/
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