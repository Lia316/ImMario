using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    // 현재 각도
    Vector3 angle;
    // 마우스 감도
    public float sensitivity = 200f;

    // Start is called before the first frame update
    void Start()
    {
        // 카메라 초기 각도
        angle.y = -Camera.main.transform.eulerAngles.x;
        angle.x = Camera.main.transform.eulerAngles.y;
        angle.z = Camera.main.transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 값 입력
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        // 회전 값 누적
        angle.x += x * sensitivity * Time.deltaTime;
        angle.y += y * sensitivity * Time.deltaTime;

        // 회전 값 할당
        transform.eulerAngles = new Vector3(-angle.y, angle.x, transform.eulerAngles.z);
    }
}