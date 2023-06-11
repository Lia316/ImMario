using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class CoinManager : MonoBehaviour
{
    public Text Coin_text;
    public int coin = 0;
    public LifeManager LifeEvent;

    void Start()
    {
        LifeEvent = GameObject.Find("EventSystem").GetComponent<LifeManager>();
    }

    void Update()
    {
        Coin_text.text = "Coin : " + coin;

        if (coin >= 10) // if earning 10 coins, get 1 life
        {
            coin -= 10;
            LifeEvent.life_add();
        }
    }

    public void coin_add()
    {
        coin++;
    }
}
