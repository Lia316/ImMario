using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;

    public float speed = 150.0f;
    public float gravity = -20f;
    // jump
    public float jumpPower = 8f;
    // 수직 속도
    float yVelocity = 0;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
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
            yVelocity = jumpPower;
        }

        dir.y = yVelocity;

        // 실제 방향 이동
        controller.Move(dir * speed * Time.deltaTime);
    }
}
