using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas_GameStart : MonoBehaviour
{
    public GamePlayManager GamePlayEvent;

    void Start()
    {
        GamePlayEvent = GameObject.Find("EventSystem").GetComponent<GamePlayManager>();

        if (GamePlayEvent.GameStart == false)
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
            GamePlayEvent.GameStart = true;
            SceneManager.LoadScene("ImMario");
        }
        if (ARAVRInput.GetDown(ARAVRInput.Button.Thumbstick))
        {
            Application.Quit();
        }
    }
}
