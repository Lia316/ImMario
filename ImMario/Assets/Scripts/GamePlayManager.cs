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

    // CoinManager
    public Text Coin_text;
    public int coin = 0;

    // LifeManager
//    public GameObject Respawn;
//    public GameObject Pause;
//    public Text Life_text1;
    public Text Life_text;
    public int life = 3;

    // Start is called before the first frame update
    void Start()
    {
/*        Respawn = GameObject.Find("Canvas_Respawn");
        Pause = GameObject.Find("Canvas_Pause");
        Coin_text = Pause.GetComponent<Text>();
        Life_text1 = Respawn.GetComponent<Text>();
        Life_text2 = Pause.GetComponent<Text>();*/
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
        {
/*            if (GameStart == false)
                Life_text1.text = "";
            else
                Life_text1.text = "Life x" + life;*/

            Life_text.text = "Life : " + life;
        }
        else
        {
/*            Life_text1.text = "Game Over";
            Life_text.text = "Life : 0";*/

//            Life_text1.text = "";
            Life_text.text = "";
            GameOver = true;
        }
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
/*    void OnEnable()
    {
        // 씬 매니저의 sceneLoaded에 체인을 건다.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 체인을 걸어서 이 함수는 매 씬마다 호출된다.
        print("GamePlayManager");
        Respawn = GameObject.Find("Canvas_Respawn");
        Pause = GameObject.Find("Canvas_Pause");
        Coin_text = Pause.GetComponent<Text>();
        Life_text1 = Respawn.GetComponent<Text>();
        Life_text = Pause.GetComponent<Text>();
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }*/
}
