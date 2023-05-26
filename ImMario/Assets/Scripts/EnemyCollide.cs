using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollide : MonoBehaviour
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
            AudioManager.Instance.PlaySFX("mariodie");
            Time.timeScale = 0;
            print("body collide with Enemy"); // TODO: replace with death action
        }
    }
}