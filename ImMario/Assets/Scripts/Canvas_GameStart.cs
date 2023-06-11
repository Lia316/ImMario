using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_GameStart : MonoBehaviour
{
    public bool GameStart = false;

    void Start()
    {
        if (GameStart == false)
        {
            Time.timeScale = 0;
            gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger))
        {
            GameStart = true;
            Time.timeScale = 1;
            GameObject.Find("Player").GetComponent<Movement>().transform.position = transform.position = new Vector3(2300, -600, -1200);
            gameObject.SetActive(false);
        }
        if (ARAVRInput.GetDown(ARAVRInput.Button.Thumbstick))
        {
            Application.Quit();
        }
    }
        private void Awake()
    {
        var canvas = FindObjectsOfType<Canvas_GameStart>();
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
