using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    public GamePlayManager GamePlayEvent;

    // 리스폰 화면 나올 동안(3초) Player 움직임 정지?
//    float Timer;    int WaitTime;

    public float speed = 0.0f; // 3초 후 150.0f로 Update?
    public float gravity = -20f;
    public float jumpPower = 8f;    // 점프
    float yVelocity = 0;            // 수직 속도

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        GamePlayEvent = GameObject.Find("EventSystem").GetComponent<GamePlayManager>();
 //               Timer = 0.0f;        WaitTime = 3;

        // Player 위치 초기화
        if (GamePlayEvent.GameStart == false)
            transform.position = new Vector3(2300, 1000, -1200);
        else
        {
            if (GamePlayEvent.MidSave == false)
            {
                print("Respawn Init");
                transform.position = new Vector3(2300, -570, -1200);
            }
            else
            {
                print("Respawn Mid");
                transform.position = new Vector3(-400, -49, -2450);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
 /*       Timer += Time.deltaTime;
        if (Timer >= WaitTime)
        {
            speed = 150.0f;
        }*/

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        // 방향 설정
        Vector3 dir = new Vector3(h, 0, v);

        // 사용자가 바라보는 방향으로 전환
        dir = Camera.main.transform.TransformDirection(dir);

        // 중력 적용 v = v0 + at
        yVelocity += gravity * Time.deltaTime;

        // 바닥일 경우 속도를 0으로 초기화
        if(controller.isGrounded) {
            yVelocity = 0;
        }

        // 점프 구현
        if (ARAVRInput.GetDown(ARAVRInput.Button.Two, ARAVRInput.Controller.RTouch))
        {
            if (yVelocity == 0)
            {
                AudioManager.Instance.PlaySFX("jump");
                yVelocity = jumpPower;
            }
        }

        dir.y = yVelocity;

        // 실제 방향 이동
        controller.Move(dir * speed * Time.deltaTime);

        // 낙사
        if(this.transform.position.y < -900)
        {
            // Life 감소
            GamePlayEvent.death();

            /*
            // Player 위치 초기화
            transform.position = new Vector3(2300, -600, -1200);
            yVelocity = 0;*/
        }
    }
}
