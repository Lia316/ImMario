using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay3s : MonoBehaviour
{
    public GamePlayManager GamePlayEvent;
    float Timer;
    int WaitTime;
    
    // Start is called before the first frame update
    void Start()
    {
        GamePlayEvent = GameObject.Find("EventSystem").GetComponent<GamePlayManager>();

        if (GamePlayEvent.GameStart == false)
            gameObject.SetActive(false);
        else
        {
            gameObject.SetActive(true);
            Timer = 0.0f;
        }
        WaitTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= WaitTime)
        {
            gameObject.SetActive(false);
        }
    }
}
