using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollide : MonoBehaviour
{
    public LifeManager LifeEvent;

    // Start is called before the first frame update
    void Start()
    {
        LifeEvent = GameObject.Find("EventSystem").GetComponent<LifeManager>();
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
            LifeEvent.death();
            print("body collide with Enemy");
        }
    }
}