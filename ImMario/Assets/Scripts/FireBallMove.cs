using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMove : MonoBehaviour
{
    public float thrust = 2000.0f;
    private Rigidbody rb;
    public float gravityScale = 1.0f; 
    public static float globalGravity = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        InitialSetting();
    }

    // Update is called once per frame
    void Update()
    {        
        Fire();
    }

    void InitialSetting() {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.left * 2000.0f);

        Destroy(this.gameObject, 5.0f);
    }

    void Fire() {
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        rb.AddForce(gravity, ForceMode.Acceleration);
        rb.AddForce(Vector3.left * thrust);

        // if ball bounce off backward, destroy it
        if (rb.velocity.x > 0.0f) {
            Destroy(gameObject);
        }
    }
}
