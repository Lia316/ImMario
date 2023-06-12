using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActive : MonoBehaviour
{
    // Start() 시 3초 동안 활성화한 뒤 비활성화
    public GamePlayManager GamePlayEvent;
    float Timer;    int WaitTime;
    public GameObject target_delay1;
    public GameObject target_delay2;

    // 사용자의 입력에 따라 활성화 여부 변경
    private bool state_handtrigger;
    public GameObject target_handtrigger;

    // 게임 종료 화면
    public GameObject target_GameClear;
    public GameObject target_GameOver;

    // Start is called before the first frame update
    void Start()
    {
        GamePlayEvent = GameObject.Find("EventSystem").GetComponent<GamePlayManager>();
        Timer = 0.0f; WaitTime = 3;

        target_delay1 = GameObject.Find("hollow_sphere");
//        target_delay2 = GameObject.Find("Canvas_Repspawn");
//        target_handtrigger = GameObject.Find("Canvas_Pause");

        if (GamePlayEvent.GameStart == false)
        {
            print("GameStart==false");
            target_delay1.SetActive(false);
            target_delay2.SetActive(false);
            target_handtrigger.SetActive(false);
        }
        else
        {
            print("GameStart==true");
            target_delay1.SetActive(true);
            target_delay2.SetActive(true);
            target_handtrigger.SetActive(false);
        }
        state_handtrigger = true;

        target_GameClear.SetActive(false);
        target_GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= WaitTime)
        {
            target_delay1.SetActive(false);
            target_delay2.SetActive(false);
        }

        if (ARAVRInput.GetDown(ARAVRInput.Button.HandTrigger))
        {
            if (state_handtrigger == true)
            {
                GamePlayEvent.GamePause = false;
                target_handtrigger.SetActive(false);
                state_handtrigger = false;
            }
            else
            {
                GamePlayEvent.GamePause = true;
                target_handtrigger.SetActive(true);
                state_handtrigger = true;
            }
        }

        if (ARAVRInput.GetDown(ARAVRInput.Button.IndexTrigger))
        {
            if (state_handtrigger == true)
            {
                GamePlayEvent.GamePause = false;
                target_handtrigger.SetActive(false);
                state_handtrigger = false;
                GamePlayEvent.death();
            }
        }

        if (GamePlayEvent.GameClear)
            target_GameClear.SetActive(true);

        if (GamePlayEvent.GameOver)
            target_GameOver.SetActive(true);
    }

    void OnEnable()
    {
        // 씬 매니저의 sceneLoaded에 체인을 건다.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 체인을 걸어서 이 함수는 매 씬마다 호출된다.
        print("SetActive");
        target_delay1 = GameObject.Find("hollow_sphere");
        target_delay1.SetActive(true);
        target_delay2 = GameObject.Find("Canvas_Respawn");
        Timer = 0.0f; WaitTime = 3;

        //        target_handtrigger = GameObject.Find("Canvas_Pause");
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
