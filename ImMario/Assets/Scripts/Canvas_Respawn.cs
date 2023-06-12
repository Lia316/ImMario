using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Text = TMPro.TextMeshProUGUI;

public class Canvas_Respawn : MonoBehaviour
{
    public GamePlayManager GamePlayEvent;
    public Text Life_text;

    void Start()
    {
        GamePlayEvent = GameObject.Find("EventSystem").GetComponent<GamePlayManager>();
        Life_text = this.GetComponentInChildren<Text>();
    }

    void Update()
    {
        if (GamePlayEvent.life > 0)
        {
            if (GamePlayEvent.GameStart == false)
                Life_text.text = "";
            else
                Life_text.text = "Life x" + GamePlayEvent.life;
        }
        else
            Life_text.text = "";
    }
}
