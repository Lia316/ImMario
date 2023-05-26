using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStep : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            AudioManager.Instance.PlaySFX("stomp");
            Destroy(collision.gameObject);
            print("foot collide with Enemy");
        }
    }
}