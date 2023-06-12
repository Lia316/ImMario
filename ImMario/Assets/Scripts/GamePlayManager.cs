using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{
    public bool GameStart = false; // 게임 시작   -> true
    public bool GamePause = false; // 일시정지    -> true
    public bool GameClear = false; // 게임 클리어 -> true
    public bool GameOver = false;  // 게임 오버   -> true

    public bool MidSave = false;   // Player와 mid flag가 collide -> true

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
        // timeScale 조절
        if (GameStart == false || GamePause == true || GameClear == true || GameOver == true)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

        // Coin 관리
        Coin_text.text = "Coin : " + coin;

        if (coin >= 10) // 10코인 획득 시 life +1
        {
            coin -= 10;
            life_add();
        }

        // Life 관리
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
