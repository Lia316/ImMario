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
        // �� �Ŵ����� sceneLoaded�� ü���� �Ǵ�.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ü���� �ɾ �� �Լ��� �� ������ ȣ��ȴ�.
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
