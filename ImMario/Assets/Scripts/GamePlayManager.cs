using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{
    public bool GameStart = false; // ���� ����   -> true
    public bool GamePause = false; // �Ͻ�����    -> true
    public bool GameClear = false; // ���� Ŭ���� -> true
    public bool GameOver = false;  // ���� ����   -> true

    public bool MidSave = false;   // Player�� mid flag�� collide -> true

    public Text Coin_text;         // CoinManager
    public int coin = 0;

    public Text Life_text;         // LifeManager
    public int life = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // timeScale ����
        if (GameStart == false || GamePause == true || GameClear == true || GameOver == true)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

        // Coin ����
        Coin_text.text = "Coin : " + coin;

        if (coin >= 10) // 10���� ȹ�� �� life +1
        {
            coin -= 10;
            life_add();
        }

        // Life ����
        if (life > 0)
            Life_text.text = "Life x" + life;
        else
            Life_text.text = "Game Over";
    }

    public void coin_add()
    {
        coin++;
    }

    public void life_add()
    {
        life++;
    }

    public void death()
    {
        life--;
        SceneManager.LoadScene("ImMario");
    }
}
