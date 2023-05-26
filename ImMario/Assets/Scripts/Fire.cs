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
        bool isFire = Input.GetMouseButtonDown(0);
        if (isFire) {
            GameObject newFireball = Instantiate(fireball, transform.position, Camera.main.transform.rotation);
        }
    }
}
