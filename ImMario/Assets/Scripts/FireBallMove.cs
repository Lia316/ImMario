using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMove : MonoBehaviour
{
    public float thrust = 2000.0f;
    public float gravityScale = 1.0f; 
    public static float globalGravity = -9.81f;

    private Rigidbody rb;
    private Transform trans;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();

        rb.AddRelativeForce(trans.forward * 2000.0f);
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {        
        Fire();
    }

    void Fire() {
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        rb.AddForce(gravity, ForceMode.Acceleration);
        rb.AddForce(trans.forward * thrust);
    }
}
