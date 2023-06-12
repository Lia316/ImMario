using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStep : MonoBehaviour
{
    public GamePlayManager GamePlayEvent;

    // Start is called before the first frame update
    void Start()
    {
        GamePlayEvent = GameObject.Find("EventSystem").GetComponent<GamePlayManager>();
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
            GamePlayEvent.coin_add();
            print("foot collide with Enemy");
        }
    }
}