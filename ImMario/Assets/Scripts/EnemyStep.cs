using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStep : MonoBehaviour
{
//    public CoinManager CoinEvent;

    // Start is called before the first frame update
    void Start()
    {
//        CoinEvent = GameObject.Find("EventSystem").GetComponent<CoinManager>();
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
 //           CoinEvent.coin_add();
            print("foot collide with Enemy");
        }
    }
}