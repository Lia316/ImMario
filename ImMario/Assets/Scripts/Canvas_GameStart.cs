using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas_GameStart : MonoBehaviour
{
    public GameStartManager GameStartEvent;

    void Start()
    {
        GameStartEvent = GameObject.Find("EventSystem").GetComponent<GameStartManager>();

        if (GameStartEvent.GameStart == false)
        {
            gameObject.SetActive(true);
        }
        else
            GameObject.Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger))
        {
            GameStartEvent.GameStart = true;
            Time.timeScale = 1;

            SceneManager.LoadScene("ImMario");
        }
        if (ARAVRInput.GetDown(ARAVRInput.Button.Thumbstick))
        {
            Application.Quit();
        }
    }
}
