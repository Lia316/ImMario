using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    public Canvas_GameStart CanvasGameStart;

    public float speed = 150.0f;
    public float gravity = -20f;
    public float jumpPower = 8f;    // jump
    float yVelocity = 0;            // 수직 속도

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        CanvasGameStart = GameObject.Find("Canvas_GameStart").GetComponent<Canvas_GameStart>();

        // Player 위치 초기화
        if (CanvasGameStart.GameStart == false)
            transform.position = new Vector3(2300, 1000, -1200);
        else
            transform.position = new Vector3(2300, -600, -1200);
    }

    // Update is called once per frame
    void Update()
    {
        if (CanvasGameStart.GameStart == false)
        {

        }

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
        if(ARAVRInput.GetDown(ARAVRInput.Button.Two, ARAVRInput.Controller.RTouch)) {
            AudioManager.Instance.PlaySFX("jump");
            yVelocity = jumpPower;
        }

        dir.y = yVelocity;

        // 실제 방향 이동
        controller.Move(dir * speed * Time.deltaTime);

        // 낙사
        if(this.transform.position.y < -900)
        {
            // Life >= 1이면 Life -= 1, Respawn
            // 리스폰 화면(Canvas_Respawn 수정)
            // Player 위치 초기화
            transform.position = new Vector3(2300, -600, -1200);
            yVelocity = 0;

            // Life == 0이면 Game Over
        }
    }
}
