using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject fireball;
    private Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isFire = Input.GetButton("Fire1");
        if (isFire) {
            Vector3 rotate = new Vector3(0,0,0);
            GameObject newFireball = Instantiate(fireball, transform.position, Quaternion.LookRotation(rotate));
        }
    }
}
